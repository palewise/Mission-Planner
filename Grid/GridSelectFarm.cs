using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using MissionPlanner.Plugin;


namespace MissionPlanner
{
    public class GridSelectFarm : MissionPlanner.Plugin.Plugin
    {
        

        ToolStripMenuItem but;

        public override string Name
        {
            get { return "Grid"; }
        }

        public override string Version
        {
            get { return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(); }
        }

        public override string Author
        {
            get { return "Napat Jintanakosol"; }
        }

        public override bool Init()
        {
            return true;
        }

        public override bool Loaded()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridUIFarm));
            var temp = (string)(resources.GetObject("$this.Text"));

            but = new ToolStripMenuItem(temp);
            but.Click += but_Click;

            bool hit = false;
            ToolStripItemCollection col = Host.FPMenuMap.Items;
            int index = col.Count;
            foreach (ToolStripItem item in col)
            {
                if (item.Text.Equals(Strings.AutoWP))
                {
                    index = col.IndexOf(item);
                    ((ToolStripMenuItem)item).DropDownItems.Add(but);
                    hit = true;
                    break;
                }
            }

            if (hit == false)
                col.Add(but);

            return true;
        }

        public void but_Click(object sender, EventArgs e)
        {
            using (var gridui = new GridUIFarm(this))
            {
                MissionPlanner.Utilities.ThemeManager.ApplyThemeTo(gridui);

                if (Host.FPDrawnPolygon != null && Host.FPDrawnPolygon.Points.Count > 2)
                {
                    gridui.ShowDialog();
                }
                else
                {
                    gridui.LoadGrid();
                    gridui.ShowDialog();
                   
                }
            }
        }

        public override bool Exit()
        {
            return true;
        }

        
    }
}
