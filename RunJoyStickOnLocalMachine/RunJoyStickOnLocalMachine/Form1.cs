using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Management;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.IO;
using System.IO.Ports;
using Microsoft.DirectX.DirectInput;
using disc1.XML;

namespace RunJoyStickOnLocalMachine
{
    public partial class Form1 : Form
    {
        private Joystick joystick;
        private bool[] joystickButtons;
        private string settingsFilename = "Settings.xml";
        private SettingsData settings;
        private SerialPort comm;
        private Thread rxCommTrd;
        private bool rxCommTrdAlive = true;
        private int lastComportWriteTimestamp = 0;

        private string endLineStr = "\r\n";

        private int topStickX = 0;
        private int topStickY = 0;

        private List<string> controllersList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load settings
            try
            {
                string filename = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                filename = Path.Combine(filename, this.settingsFilename);


                // this code to create xml file initaily. should not be part of application
                /*
                this.settings = new SettingsData();

                this.settings.Comport = "COM27";
                this.settings.Baudrate = 115200;
                this.settings.x1Factor = 1f;
                this.settings.x2Factor = 1f;
                this.settings.x1Offset = 0;
                this.settings.x2Offset = 0;

                this.settings.TopStickMaxX = 1000;
                this.settings.TopStickMinX = -1000;
                this.settings.TopStickStepX = 1;
                this.settings.TopStickMaxY = 1000;
                this.settings.TopStickMinY = -1000;
                this.settings.TopStickStepY = 1;

                this.settings.SMax1 = 100;
                this.settings.SMin1 = -100;
                this.settings.SMax2 = 100;
                this.settings.SMin2 = -100;
                this.settings.SMax3 = 100;
                this.settings.SMin3 = -100;
                this.settings.SMax4 = 100;
                this.settings.SMin4 = -100;
                this.settings.SMax5 = 100;
                this.settings.SMin5 = -100;
                this.settings.SMax6 = 100;
                this.settings.SMin6 = -100;
                this.settings.SMax7 = 100;
                this.settings.SMin7 = -100;
                this.settings.SMax8 = 100;
                this.settings.SMin8 = -100;

                ObjectXMLSerializer<SettingsData>.Save(this.settings, filename);
                // end of xml creation code
                */


                this.settings = ObjectXMLSerializer<SettingsData>.Load(filename);

                this.joystickTimer.Interval = this.settings.ComPortInhibitTime;


                this.track1.Minimum = this.settings.SMin1;
                this.track1.Maximum = this.settings.SMax1;
                this.track2.Minimum = this.settings.SMin2;
                this.track2.Maximum = this.settings.SMax2;
                this.track3.Minimum = this.settings.SMin3;
                this.track3.Maximum = this.settings.SMax3;
                this.track4.Minimum = this.settings.SMin4;
                this.track4.Maximum = this.settings.SMax4;
                this.track5.Minimum = this.settings.SMin5;
                this.track5.Maximum = this.settings.SMax5;
                this.track6.Minimum = this.settings.SMin6;
                this.track6.Maximum = this.settings.SMax6;
                this.track7.Minimum = this.settings.SMin7;
                this.track7.Maximum = this.settings.SMax7;
                this.track8.Minimum = this.settings.SMin8;
                this.track8.Maximum = this.settings.SMax8;

                this.track1.Value = 1500;// this.track1.Minimum;
                this.track2.Value = 500;// this.track2.Minimum;
                this.track3.Value = 500;// this.track3.Minimum;
                this.track4.Value = 1500;// this.track4.Minimum;
                this.track5.Value = 1500;// this.track5.Minimum;
                this.track6.Value = 500;// this.track6.Minimum;
                this.track7.Value = 500;// this.track7.Minimum;
                this.track8.Value = 1500;// this.track8.Minimum;

                // special handling for track4 and track8
                this.HandleVerticalTrackBar(500, 500);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("in Form1_Load: " + ex.Message);
                this.settings = new SettingsData();
                this.joystickTimer.Interval = 100;
            }


            // try to open comport
            try
            {
                this.comm = new SerialPort();

                this.comm.Parity = Parity.Odd;
                this.comm.DataBits = 8;
                this.comm.StopBits = StopBits.One;
                this.comm.PortName = this.settings.Comport;
                this.comm.BaudRate = this.settings.Baudrate;
                this.comm.ReadTimeout = 5000;
                this.comm.WriteTimeout = 5000;
                this.comm.Open();

                this.comm.DiscardInBuffer();
                this.comm.DiscardOutBuffer();

                // open rx thread
                this.rxCommTrd = new Thread(rxCommFunc);
                this.rxCommTrd.Start();
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Failed to open serial port. " + ex1.Message);
            }

            try
            {
                // try to connect to joystick
                joystick = new Joystick(this.Handle);

                if (!connectToJoystick(joystick))
                {
                    joystick = null;
                    MessageBox.Show("Failed to connect to joystick (check that driver is installed and joystick is connected).");
#if DEBUG
                    string str = "";
                    for (int i = 0; i < this.controllersList.Count; i++)
                    {
                        str += this.controllersList[i] + Environment.NewLine;
                    }

                    MessageBox.Show("joystick: " + str);
#endif
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Failed to connect to joystick. " + ex2.Message);
            }
        }

        private void HandleVerticalTrackBar(int val4, int val8)
        {
            // track 4 and 8
            this.track4.Value = this.track4.Maximum - val4;
            this.txtTrack4.Text = (this.track4.Maximum - val4).ToString();

            this.track8.Value = this.track8.Maximum - val8;
            this.txtTrack8.Text = (this.track8.Maximum - val8).ToString();
        }

        private void rxCommFunc()
        {
            char[] buff = new char[2048];

            while (this.rxCommTrdAlive)
            {
                try
                {
                    if (this.comm.BytesToRead > 0)
                    {
                        int receivedLen = this.comm.Read(buff, 0, 2048);
                    }

                    Thread.Sleep(2000);
                }
                catch (Exception ex)
                {
                    // read timeout - do nothing
                }
            }
        }



        //---------------------------------------------------------------------
        private bool connectToJoystick(Joystick joystick)
        {
            while (true)
            {
                string sticks = joystick.FindJoysticks(out this.controllersList);
                if (sticks == null)
                {
                    return false;
                }

                if (joystick.AcquireJoystick(sticks))
                {
                    enableTimer();
                    break;
                }
            }

            return true;
        }

        private void enableTimer()
        {
            if (this.InvokeRequired)
            {
                BeginInvoke(new ThreadStart(delegate()
                {
                    joystickTimer.Enabled = true;
                }));
            }
            else
                joystickTimer.Enabled = true;
        }

        private void joystickTimer_Tick_1(object sender, EventArgs e)
        {
            JoystickState state;

            try
            {
                joystick.UpdateStatus();
                joystickButtons = joystick.buttons;

                //state = joystick.GetJoystickState();

                //System.Diagnostics.Trace.WriteLine("loc: " + joystick.Xaxis + "  " + joystick.Yaxis + " " + state.Rx + " " + state.Ry);
                System.Diagnostics.Trace.WriteLine("loc: " + joystick.Xaxis + "  " + joystick.Yaxis);

                if (joystick.Xaxis == 0)
                    output.Text += "Left\n";

                if (joystick.Xaxis == 65535)
                    output.Text += "Right\n";

                if (joystick.Yaxis == 0)
                    output.Text += "Up\n";

                if (joystick.Yaxis == 65535)
                    output.Text += "Down\n";

                for (int i = 0; i < joystickButtons.Length; i++)
                {
                    if (joystickButtons[i] == true)
                        output.Text += "Button " + i + " Pressed\n";
                }

                this.txtXRaw.Text = joystick.Xaxis.ToString();
                this.txtYRaw.Text = joystick.Yaxis.ToString();
                this.txtRzRaw.Text = joystick.RZaxis.ToString();
                this.txtThRaw.Text = joystick.Throttle.ToString();

                float processedX;
                float processedY;

                float xfactor = (float)(65535 - joystick.Throttle) / 65535f + 1f;
                processedX = (joystick.Xaxis + this.settings.x1Offset) * xfactor * this.settings.x1Factor;
                processedY = (joystick.Yaxis + this.settings.x2Offset) * xfactor * this.settings.x2Factor;

                float processedRZ = (joystick.RZaxis + this.settings.RzOffset) * this.settings.RzFactor;
                this.txtXProcessed.Text = processedX.ToString();
                this.txtYProcessed.Text = processedY.ToString();
                this.txtRzProcessed.Text = processedRZ.ToString();

                // point of view (x,y counters)
                switch (joystick.PointOfView)
                {
                    case -1:
                        // do nothing - top stick is idle
                        break;
                    case 0:
                        // move up
                        if (this.topStickY < this.settings.TopStickMaxY)
                            this.topStickY += this.settings.TopStickStepY;
                        break;
                    case 90:
                        // move right
                        if (this.topStickX < this.settings.TopStickMaxX)
                            this.topStickX += this.settings.TopStickStepX;
                        break;
                    case 180:
                        // move down
                        if (this.topStickY > this.settings.TopStickMinY)
                            this.topStickY -= this.settings.TopStickStepY;
                        break;
                    case 270:
                        // move left
                        if (this.topStickX > this.settings.TopStickMinX)
                            this.topStickX -= this.settings.TopStickStepX;
                        break;
                }


                int track4ActualValue = this.track4.Maximum - this.track4.Value + this.track4.Minimum;
                int track8ActualValue = this.track8.Maximum - this.track8.Value + this.track8.Minimum;

                this.txtTrack1.Text = this.track1.Value.ToString();
                this.txtTrack2.Text = this.track2.Value.ToString();
                this.txtTrack3.Text = this.track3.Value.ToString();
                this.txtTrack4.Text = track4ActualValue.ToString();
                this.txtTrack5.Text = this.track5.Value.ToString();
                this.txtTrack6.Text = this.track6.Value.ToString();
                this.txtTrack7.Text = this.track7.Value.ToString();
                this.txtTrack8.Text = track8ActualValue.ToString();



                WriteComport(processedX, processedY, processedRZ, topStickX, topStickY,
                    this.track1.Value, this.track2.Value, this.track3.Value, track4ActualValue,
                    this.track5.Value, this.track6.Value, this.track7.Value, this.track8.Value);
            }
            catch
            {
                joystickTimer.Enabled = false;
                connectToJoystick(joystick);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            output.Text = "";
        }

        private void WriteComport(float x1, float x2, float rz, int topStickX, int topStickY,
                                  int track1, int track2, int track3, int track4,
                                  int track5, int track6, int track7, int track8)
        {
            string line;

            if (this.comm != null && this.comm.IsOpen)
            {
                try
                {
                    // consider inhibit tme when writing to comport
                    //System.Diagnostics.Trace.WriteLine("tick: " + Environment.TickCount + " last: " + this.lastComportWriteTimestamp + " diff: " + (Environment.TickCount - this.lastComportWriteTimestamp));
                    //if (Environment.TickCount - this.lastComportWriteTimestamp < this.settings.ComPortInhibitTime)
                    //{
                    //    return;
                    //}

                    // print float with 2 digits after decmal point
                    line = "x1 " + x1.ToString("F0") + this.endLineStr;
                    this.comm.Write(line);
                    line = "x2 " + x2.ToString("F0") + this.endLineStr;
                    this.comm.Write(line);
                    line = "rotate " + rz.ToString("F0") + this.endLineStr;
                    this.comm.Write(line);

                    line = "cntX " + topStickX + this.endLineStr;
                    this.comm.Write(line);
                    line = "cntY " + topStickY + this.endLineStr;
                    this.comm.Write(line);

                    // sliders values
                    line = "s1 " + track1 + this.endLineStr;
                    this.comm.Write(line);
                    line = "s2 " + track2 + this.endLineStr;
                    this.comm.Write(line);
                    line = "s3 " + track3 + this.endLineStr;
                    this.comm.Write(line);
                    line = "s4 " + track4 + this.endLineStr;
                    this.comm.Write(line);
                    line = "s5 " + track5 + this.endLineStr;
                    this.comm.Write(line);
                    line = "s6 " + track6 + this.endLineStr;
                    this.comm.Write(line);
                    line = "s7 " + track7 + this.endLineStr;
                    this.comm.Write(line);
                    line = "s8 " + track8 + this.endLineStr;
                    this.comm.Write(line);

                    this.lastComportWriteTimestamp = Environment.TickCount;
                    System.Diagnostics.Trace.WriteLine(line);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Trace.WriteLine("WriteComport" + ex.Message);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.comm.Close();
            this.rxCommTrdAlive = false;
        }

        private void track4_Scroll(object sender, EventArgs e)
        {

        }



    }
}
