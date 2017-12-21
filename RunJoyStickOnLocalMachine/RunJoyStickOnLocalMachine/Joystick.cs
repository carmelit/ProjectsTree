using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.DirectX.DirectInput;
using System.Windows.Forms;
using System;

namespace RunJoyStickOnLocalMachine
{
    class Joystick
    {
        #region param

        private Device joystickDevice;
        private JoystickState state;
        public int Xaxis; // X-axis movement
        public int Yaxis; //Y-axis movement
        public int RZaxis; //Rz-axis movement
        public int Throttle;  // throttle 
        public int PointOfView;  // point of view (top joystick) in degrees
        private IntPtr hWnd;
        public bool[] buttons;
        private string systemJoysticks;

        #endregion

        public Joystick(IntPtr window_handle)
        {
            hWnd = window_handle;
            Xaxis = -1;
        }

        public string FindJoysticks(out  List<string> gameControllerNames)
        {
            systemJoysticks = null;

            gameControllerNames = new List<string>();

            try
            {
                // Find all the GameControl devices that are attached.
                DeviceList gameControllerList = Manager.GetDevices(DeviceClass.GameControl, EnumDevicesFlags.AttachedOnly);

                // check that we have at least one device.
                if (gameControllerList.Count > 0)
                {
                    foreach (DeviceInstance deviceInstance in gameControllerList)
                    {
                        // create a device from this controller so we can retrieve info.
                        joystickDevice = new Device(deviceInstance.InstanceGuid);
                        joystickDevice.SetCooperativeLevel(hWnd, CooperativeLevelFlags.Background | CooperativeLevelFlags.NonExclusive);

                        systemJoysticks = joystickDevice.DeviceInformation.InstanceName;
                        gameControllerNames.Add(systemJoysticks);
                        if (systemJoysticks.StartsWith( "Logitech Extreme 3D"))
                        {
                            break;
                        }
                        else
                        {
                            systemJoysticks = null;
                        }
                    }
                }
            }
            catch
            {
                return null;
            }

            return systemJoysticks;
        }

        public bool AcquireJoystick(string name)
        {
            try
            {
                DeviceList gameControllerList = Manager.GetDevices(DeviceClass.GameControl, EnumDevicesFlags.AttachedOnly);
                int i = 0;
                bool found = false;

                foreach (DeviceInstance deviceInstance in gameControllerList)
                {
                    if (deviceInstance.InstanceName == name)
                    {
                        found = true;
                        joystickDevice = new Device(deviceInstance.InstanceGuid);
                        joystickDevice.SetCooperativeLevel(hWnd, CooperativeLevelFlags.Background | CooperativeLevelFlags.NonExclusive);
                        break;
                    }
                    i++;
                }

                if (!found)
                    return false;

                joystickDevice.SetDataFormat(DeviceDataFormat.Joystick);

                joystickDevice.Acquire();

                UpdateStatus();
            }
            catch (Exception err)
            {
                return false;
            }

            return true;
        }

        public void ReleaseJoystick()
        {
            joystickDevice.Unacquire();
        }

        public void UpdateStatus()
        {
            Poll();

            int[] extraAxis = state.GetSlider();

            int[] pointOfView = state.GetPointOfView();

            Xaxis = state.X;
            Yaxis = state.Y;
            RZaxis = state.Rz;
            Throttle = extraAxis[0];
            if (pointOfView[0] == -1)
                PointOfView = pointOfView[0];
            else
                PointOfView = pointOfView[0] / 100;


            byte[] jsButtons = state.GetButtons();
            buttons = new bool[jsButtons.Length];

            int i = 0;
            int cnt = 0;
            foreach (byte button in jsButtons)
            {
                buttons[i] = button >= 128;
                i++;
                if (button != 0)
                {
                    int r = 0;
                    cnt++;
                    r++;
                }
            }
        }

        private void Poll()
        {
            try
            {
                // poll the joystick
                joystickDevice.Poll();
                // update the joystick state field
                state = joystickDevice.CurrentJoystickState;
            }
            catch
            {
                throw (null);
            }
        }

        //public JoystickState GetJoystickState()
        //{
        //    return this.state;
        //}

    }
}
