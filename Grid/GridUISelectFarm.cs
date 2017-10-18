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

namespace MissionPlanner
{
    public partial class GridUISelectFarm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        // Variables
        const double rad2deg = (180 / Math.PI);
        const double deg2rad = (1.0 / rad2deg);

        private GridPlugin plugin;
        static public Object thisLock = new Object();

        GMapOverlay routesOverlay;
        GMapOverlay kmlpolygonsoverlay;
        List<PointLatLngAlt> list = new List<PointLatLngAlt>();
        List<PointLatLngAlt> grid;
        bool loadedfromfile = false;
        bool loading = false;

        Dictionary<string, camerainfo> cameras = new Dictionary<string, camerainfo>();

        public string DistUnits = "";
        public string inchpixel = "";
        public string feet_fovH = "";
        public string feet_fovV = "";

        internal PointLatLng MouseDownStart = new PointLatLng();
        internal PointLatLng MouseDownEnd;
        internal PointLatLngAlt CurrentGMapMarkerStartPos;
        PointLatLng currentMousePosition;
        GMapMarker marker;
        GMapMarker CurrentGMapMarker = null;
        GMapMarkerOverlapCount GMapMarkerOverlap = new GMapMarkerOverlapCount(PointLatLng.Empty);
        int CurrentGMapMarkerIndex = 0;
        bool isMouseDown = false;
        bool isMouseDraging = false;

        // Structures
        public struct camerainfo
        {
            public string name;
            public float focallen;
            public float sensorwidth;
            public float sensorheight;
            public float imagewidth;
            public float imageheight;
        }

        public struct GridData
        {
            public List<PointLatLngAlt> poly;
            //simple
            public string camera;
            public decimal alt;
            public decimal angle;
            public bool camdir;
            public decimal speed;
            public bool usespeed;
            public bool autotakeoff;
            public bool autotakeoff_RTL;

            public decimal splitmission;

            public bool internals;
            public bool footprints;
            public bool advanced;

            //options
            public decimal dist;
            public decimal overshoot1;
            public decimal overshoot2;
            public decimal leadin;
            public string startfrom;
            public decimal overlap;
            public decimal sidelap;
            public decimal spacing;
            public bool crossgrid;
            // Copter Settings
            public decimal copter_delay;
            public bool copter_headinghold_chk;
            public decimal copter_headinghold;
            // plane settings
            public bool alternateLanes;
            public decimal minlaneseparation;

            // camera config
            public bool trigdist;
            public bool digicam;
            public bool repeatservo;

            public bool breaktrigdist;

            public decimal repeatservo_no;
            public decimal repeatservo_pwm;
            public decimal repeatservo_cycle;

            // do set servo
            public decimal setservo_no;
            public decimal setservo_low;
            public decimal setservo_high;
        }

        // GridUI
        public GridUISelectFarm(GridNew plugin)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("bao bao");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}