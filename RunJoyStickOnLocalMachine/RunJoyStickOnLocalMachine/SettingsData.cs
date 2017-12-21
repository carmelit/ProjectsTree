// -----------------------------------------------------------------------
// <copyright file="SettingsData.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace RunJoyStickOnLocalMachine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    [XmlRootAttribute("SettingsData", Namespace = "", IsNullable = false)]
    public class SettingsData
    {
        // must be first
        public string Comport { get; set; }
        public int Baudrate { get; set; }

        public float x1Factor { get; set; }
        public float x2Factor { get; set; }
        public float RzFactor { get; set; }

        public int x1Offset { get; set; }
        public int x2Offset { get; set; }
        public int RzOffset { get; set; }

        public int TopStickMaxX { get; set; }
        public int TopStickMinX { get; set; }
        public int TopStickMaxY { get; set; }
        public int TopStickMinY { get; set; }

        public int TopStickStepX { get; set; }
        public int TopStickStepY { get; set; }

        // sliders min/max
        public int SMin1 { get; set; }
        public int SMax1 { get; set; }
        public int SMin2 { get; set; }
        public int SMax2 { get; set; }
        public int SMin3 { get; set; }
        public int SMax3 { get; set; }
        public int SMin4 { get; set; }
        public int SMax4 { get; set; }
        public int SMin5 { get; set; }
        public int SMax5 { get; set; }
        public int SMin6 { get; set; }
        public int SMax6 { get; set; }
        public int SMin7 { get; set; }
        public int SMax7 { get; set; }
        public int SMin8 { get; set; }
        public int SMax8 { get; set; }
        public int SMin9 { get; set; }
        public int SMax9 { get; set; }
        public int SMin10 { get; set; }
        public int SMax10 { get; set; }
        public int SMin11 { get; set; }
        public int SMax11 { get; set; }
        public int SMin12 { get; set; }
        public int SMax12 { get; set; }
        public int SMin13 { get; set; }
        public int SMax13 { get; set; }
        public int SMin14 { get; set; }
        public int SMax14 { get; set; }
        public int SMin15 { get; set; }
        public int SMax15 { get; set; }
        public int SMin16 { get; set; }
        public int SMax16 { get; set; }


        public int ComPortInhibitTime { get; set; }


        public SettingsData()
        {
            this.x1Factor = 1f;
            this.x2Factor = 1f;
            this.x1Offset = 0;
            this.x2Offset = 0;
            this.ComPortInhibitTime = 100;
        }



    }
}
