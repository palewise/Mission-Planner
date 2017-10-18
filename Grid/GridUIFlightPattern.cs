using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using com.drew.imaging.jpg;
using com.drew.metadata;
using com.drew.metadata.exif;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using log4net;
using MissionPlanner.GCSViews;
using MissionPlanner.Properties;
using MissionPlanner.Utilities;
using ProjNet.CoordinateSystems;
using ProjNet.CoordinateSystems.Transformations;
using MissionPlanner.Plugin;


namespace MissionPlanner
{
    public partial class GridUIFlightPattern : Form
    {
        
        // GridUI
        public GridUIFlightPattern (GridFlightPattern plugin)
        {
            InitializeComponent();
        }
        

        private void GridUI_Load(object sender, EventArgs e)
        {


        }

        private void GridUI_Resize(object sender, EventArgs e)
        {

        }

        // Load/Save
        public void LoadGrid()
        {

        }

        public void SaveGrid()
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GridSetFlight grid = new GridSetFlight();
            grid.Host = new PluginHost();
            grid.but_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }


    }
}