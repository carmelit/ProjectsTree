namespace RunJoyStickOnLocalMachine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.joystickTimer = new System.Windows.Forms.Timer(this.components);
            this.output = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXRaw = new System.Windows.Forms.TextBox();
            this.txtYRaw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYProcessed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXProcessed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRzProcessed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRzRaw = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtThRaw = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.grpCross1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTrack1 = new System.Windows.Forms.TextBox();
            this.txtTrack2 = new System.Windows.Forms.TextBox();
            this.track3 = new System.Windows.Forms.TrackBar();
            this.txtTrack4 = new System.Windows.Forms.TextBox();
            this.track4 = new System.Windows.Forms.TrackBar();
            this.txtTrack3 = new System.Windows.Forms.TextBox();
            this.track2 = new System.Windows.Forms.TrackBar();
            this.track1 = new System.Windows.Forms.TrackBar();
            this.grpCross2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTrack5 = new System.Windows.Forms.TextBox();
            this.txtTrack6 = new System.Windows.Forms.TextBox();
            this.txtTrack8 = new System.Windows.Forms.TextBox();
            this.txtTrack7 = new System.Windows.Forms.TextBox();
            this.track7 = new System.Windows.Forms.TrackBar();
            this.track8 = new System.Windows.Forms.TrackBar();
            this.track6 = new System.Windows.Forms.TrackBar();
            this.track5 = new System.Windows.Forms.TrackBar();
            this.grpCross1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track1)).BeginInit();
            this.grpCross2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cleare Output Window";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // joystickTimer
            // 
            this.joystickTimer.Tick += new System.EventHandler(this.joystickTimer_Tick_1);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(13, 34);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(253, 138);
            this.output.TabIndex = 1;
            this.output.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output Window";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X";
            // 
            // txtXRaw
            // 
            this.txtXRaw.Location = new System.Drawing.Point(316, 79);
            this.txtXRaw.Name = "txtXRaw";
            this.txtXRaw.Size = new System.Drawing.Size(100, 20);
            this.txtXRaw.TabIndex = 4;
            // 
            // txtYRaw
            // 
            this.txtYRaw.Location = new System.Drawing.Point(316, 115);
            this.txtYRaw.Name = "txtYRaw";
            this.txtYRaw.Size = new System.Drawing.Size(100, 20);
            this.txtYRaw.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y";
            // 
            // txtYProcessed
            // 
            this.txtYProcessed.Location = new System.Drawing.Point(521, 115);
            this.txtYProcessed.Name = "txtYProcessed";
            this.txtYProcessed.Size = new System.Drawing.Size(100, 20);
            this.txtYProcessed.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Y";
            // 
            // txtXProcessed
            // 
            this.txtXProcessed.Location = new System.Drawing.Point(521, 79);
            this.txtXProcessed.Name = "txtXProcessed";
            this.txtXProcessed.Size = new System.Drawing.Size(100, 20);
            this.txtXProcessed.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Raw";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Processed";
            // 
            // txtRzProcessed
            // 
            this.txtRzProcessed.Location = new System.Drawing.Point(521, 152);
            this.txtRzProcessed.Name = "txtRzProcessed";
            this.txtRzProcessed.Size = new System.Drawing.Size(100, 20);
            this.txtRzProcessed.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(501, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Rz";
            // 
            // txtRzRaw
            // 
            this.txtRzRaw.Location = new System.Drawing.Point(316, 152);
            this.txtRzRaw.Name = "txtRzRaw";
            this.txtRzRaw.Size = new System.Drawing.Size(100, 20);
            this.txtRzRaw.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Rz";
            // 
            // txtThRaw
            // 
            this.txtThRaw.Location = new System.Drawing.Point(693, 49);
            this.txtThRaw.Name = "txtThRaw";
            this.txtThRaw.Size = new System.Drawing.Size(100, 20);
            this.txtThRaw.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(644, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Throttle";
            // 
            // grpCross1
            // 
            this.grpCross1.Controls.Add(this.label14);
            this.grpCross1.Controls.Add(this.label13);
            this.grpCross1.Controls.Add(this.label12);
            this.grpCross1.Controls.Add(this.label10);
            this.grpCross1.Controls.Add(this.txtTrack1);
            this.grpCross1.Controls.Add(this.txtTrack2);
            this.grpCross1.Controls.Add(this.track3);
            this.grpCross1.Controls.Add(this.txtTrack4);
            this.grpCross1.Controls.Add(this.track4);
            this.grpCross1.Controls.Add(this.txtTrack3);
            this.grpCross1.Controls.Add(this.track2);
            this.grpCross1.Controls.Add(this.track1);
            this.grpCross1.Location = new System.Drawing.Point(13, 178);
            this.grpCross1.Name = "grpCross1";
            this.grpCross1.Size = new System.Drawing.Size(378, 414);
            this.grpCross1.TabIndex = 19;
            this.grpCross1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(130, 384);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "S4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(130, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "S3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(292, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "S2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "S1";
            // 
            // txtTrack1
            // 
            this.txtTrack1.Location = new System.Drawing.Point(12, 177);
            this.txtTrack1.Name = "txtTrack1";
            this.txtTrack1.Size = new System.Drawing.Size(62, 20);
            this.txtTrack1.TabIndex = 11;
            // 
            // txtTrack2
            // 
            this.txtTrack2.Location = new System.Drawing.Point(295, 177);
            this.txtTrack2.Name = "txtTrack2";
            this.txtTrack2.Size = new System.Drawing.Size(62, 20);
            this.txtTrack2.TabIndex = 10;
            // 
            // track3
            // 
            this.track3.LargeChange = 1;
            this.track3.Location = new System.Drawing.Point(166, 60);
            this.track3.Name = "track3";
            this.track3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track3.Size = new System.Drawing.Size(45, 150);
            this.track3.TabIndex = 3;
            this.track3.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // txtTrack4
            // 
            this.txtTrack4.Location = new System.Drawing.Point(156, 381);
            this.txtTrack4.Name = "txtTrack4";
            this.txtTrack4.Size = new System.Drawing.Size(62, 20);
            this.txtTrack4.TabIndex = 9;
            // 
            // track4
            // 
            this.track4.LargeChange = 1;
            this.track4.Location = new System.Drawing.Point(166, 232);
            this.track4.Name = "track4";
            this.track4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track4.Size = new System.Drawing.Size(45, 150);
            this.track4.TabIndex = 2;
            this.track4.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.track4.Scroll += new System.EventHandler(this.track4_Scroll);
            // 
            // txtTrack3
            // 
            this.txtTrack3.Location = new System.Drawing.Point(156, 37);
            this.txtTrack3.Name = "txtTrack3";
            this.txtTrack3.Size = new System.Drawing.Size(62, 20);
            this.txtTrack3.TabIndex = 8;
            // 
            // track2
            // 
            this.track2.LargeChange = 1;
            this.track2.Location = new System.Drawing.Point(208, 203);
            this.track2.Name = "track2";
            this.track2.Size = new System.Drawing.Size(150, 45);
            this.track2.TabIndex = 1;
            this.track2.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // track1
            // 
            this.track1.LargeChange = 1;
            this.track1.Location = new System.Drawing.Point(13, 203);
            this.track1.Name = "track1";
            this.track1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.track1.RightToLeftLayout = true;
            this.track1.Size = new System.Drawing.Size(150, 45);
            this.track1.TabIndex = 0;
            this.track1.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // grpCross2
            // 
            this.grpCross2.Controls.Add(this.label18);
            this.grpCross2.Controls.Add(this.label17);
            this.grpCross2.Controls.Add(this.label16);
            this.grpCross2.Controls.Add(this.label15);
            this.grpCross2.Controls.Add(this.txtTrack5);
            this.grpCross2.Controls.Add(this.txtTrack6);
            this.grpCross2.Controls.Add(this.txtTrack8);
            this.grpCross2.Controls.Add(this.txtTrack7);
            this.grpCross2.Controls.Add(this.track7);
            this.grpCross2.Controls.Add(this.track8);
            this.grpCross2.Controls.Add(this.track6);
            this.grpCross2.Controls.Add(this.track5);
            this.grpCross2.Location = new System.Drawing.Point(439, 178);
            this.grpCross2.Name = "grpCross2";
            this.grpCross2.Size = new System.Drawing.Size(366, 414);
            this.grpCross2.TabIndex = 20;
            this.grpCross2.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(127, 384);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 13);
            this.label18.TabIndex = 25;
            this.label18.Text = "S8";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(127, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "S7";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(289, 161);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "S6";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 161);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "S5";
            // 
            // txtTrack5
            // 
            this.txtTrack5.Location = new System.Drawing.Point(9, 177);
            this.txtTrack5.Name = "txtTrack5";
            this.txtTrack5.Size = new System.Drawing.Size(62, 20);
            this.txtTrack5.TabIndex = 7;
            // 
            // txtTrack6
            // 
            this.txtTrack6.Location = new System.Drawing.Point(292, 177);
            this.txtTrack6.Name = "txtTrack6";
            this.txtTrack6.Size = new System.Drawing.Size(62, 20);
            this.txtTrack6.TabIndex = 6;
            // 
            // txtTrack8
            // 
            this.txtTrack8.Location = new System.Drawing.Point(153, 381);
            this.txtTrack8.Name = "txtTrack8";
            this.txtTrack8.Size = new System.Drawing.Size(62, 20);
            this.txtTrack8.TabIndex = 5;
            // 
            // txtTrack7
            // 
            this.txtTrack7.Location = new System.Drawing.Point(153, 37);
            this.txtTrack7.Name = "txtTrack7";
            this.txtTrack7.Size = new System.Drawing.Size(62, 20);
            this.txtTrack7.TabIndex = 4;
            // 
            // track7
            // 
            this.track7.LargeChange = 1;
            this.track7.Location = new System.Drawing.Point(162, 60);
            this.track7.Name = "track7";
            this.track7.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track7.Size = new System.Drawing.Size(45, 150);
            this.track7.TabIndex = 3;
            this.track7.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // track8
            // 
            this.track8.LargeChange = 1;
            this.track8.Location = new System.Drawing.Point(162, 232);
            this.track8.Name = "track8";
            this.track8.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.track8.Size = new System.Drawing.Size(45, 150);
            this.track8.TabIndex = 2;
            this.track8.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // track6
            // 
            this.track6.LargeChange = 1;
            this.track6.Location = new System.Drawing.Point(204, 203);
            this.track6.Name = "track6";
            this.track6.Size = new System.Drawing.Size(150, 45);
            this.track6.TabIndex = 1;
            this.track6.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // track5
            // 
            this.track5.LargeChange = 1;
            this.track5.Location = new System.Drawing.Point(9, 203);
            this.track5.Name = "track5";
            this.track5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.track5.RightToLeftLayout = true;
            this.track5.Size = new System.Drawing.Size(150, 45);
            this.track5.TabIndex = 0;
            this.track5.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 599);
            this.Controls.Add(this.grpCross2);
            this.Controls.Add(this.grpCross1);
            this.Controls.Add(this.txtThRaw);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRzProcessed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRzRaw);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtYProcessed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtXProcessed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYRaw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtXRaw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Joystick";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCross1.ResumeLayout(false);
            this.grpCross1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track1)).EndInit();
            this.grpCross2.ResumeLayout(false);
            this.grpCross2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer joystickTimer;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXRaw;
        private System.Windows.Forms.TextBox txtYRaw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYProcessed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtXProcessed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRzProcessed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRzRaw;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtThRaw;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grpCross1;
        private System.Windows.Forms.TrackBar track3;
        private System.Windows.Forms.TrackBar track4;
        private System.Windows.Forms.TrackBar track2;
        private System.Windows.Forms.TrackBar track1;
        private System.Windows.Forms.GroupBox grpCross2;
        private System.Windows.Forms.TrackBar track7;
        private System.Windows.Forms.TrackBar track8;
        private System.Windows.Forms.TrackBar track6;
        private System.Windows.Forms.TrackBar track5;
        private System.Windows.Forms.TextBox txtTrack1;
        private System.Windows.Forms.TextBox txtTrack2;
        private System.Windows.Forms.TextBox txtTrack4;
        private System.Windows.Forms.TextBox txtTrack3;
        private System.Windows.Forms.TextBox txtTrack5;
        private System.Windows.Forms.TextBox txtTrack6;
        private System.Windows.Forms.TextBox txtTrack8;
        private System.Windows.Forms.TextBox txtTrack7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}

