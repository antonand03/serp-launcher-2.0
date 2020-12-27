using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SEREP_Launcher_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Close_Click(object sender, EventArgs eventArgs)
        {
            System.Windows.Forms.Application.ExitThread();
        }
        private void Min_Click(object sender, EventArgs eventArgs)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void FiveM_Click(object sender, EventArgs eventArgs)
        {
            System.Diagnostics.Process.Start("Explorer.exe", "fivem://connect/gta.swedishemergencyroleplay.se:30120");
            System.Windows.Forms.Application.ExitThread();
        }
        private void TS_Click(object sender, EventArgs eventArgs)
        {
            System.Diagnostics.Process.Start("Explorer.exe", "ts3server://ts.swedishemergencyroleplay.se");
            System.Windows.Forms.Application.ExitThread();
        }
        private void Logo_Click(object sender, EventArgs eventArgs)
        {
            System.Diagnostics.Process.Start("Explorer.exe", "https://www.swedishemergencyroleplay.se/");
        }

        private bool mouseDown;
        private Point lastLocation;

        private void Launcher_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Launcher_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void Launcher_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
