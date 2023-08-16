using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Management.Automation;
using Dashboard;



namespace Zipperoni
{

    public partial class DashboardMain : Form
    {

        public bool MouseDown;
        public DashboardMain()
        {
            InitializeComponent();

            //Visual
            pnlNav.Height = dashboardBtn.Height;
            pnlNav.Top = dashboardBtn.Top;
            pnlNav.Left = dashboardBtn.Left;
            dashboardBtn.BackColor = Color.FromArgb(46, 51, 73);

            //Get pc username and apply
            string userName = Environment.UserName;
            userNameText.Text = userName;

            //Load deafult page
            dashBoardLoad();

            //Run appcheck

        }






        private void dashBoardLoad()
        {

            //Open dashboard panel
            lblTitle.Text = "YLF Dashboard";
            this.formLoaderPnl.Controls.Clear();
            frmDashboard FrmDashboard = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.formLoaderPnl.Controls.Add(FrmDashboard);
            FrmDashboard.Show();
        }



        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            //Visual
            pnlNav.Height = dashboardBtn.Height;
            pnlNav.Top = dashboardBtn.Top;
            pnlNav.Left = dashboardBtn.Left;
            dashboardBtn.BackColor = Color.FromArgb(46, 51, 73);

            dashBoardLoad();
        }

        private void statsBtn_Click(object sender, EventArgs e)
        {
            //Visual
            pnlNav.Height = statsBtn.Height;
            pnlNav.Top = statsBtn.Top;
            pnlNav.Left = statsBtn.Left;
            statsBtn.BackColor = Color.FromArgb(46, 51, 73);

            //Open stats form
            lblTitle.Text = "YLF Analytics";
            this.formLoaderPnl.Controls.Clear();
            frmAnalytics FrmDashboard = new frmAnalytics() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.formLoaderPnl.Controls.Add(FrmDashboard);
            FrmDashboard.Show();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            //Visual
            pnlNav.Height = settingsBtn.Height;
            pnlNav.Top = settingsBtn.Top;
            pnlNav.Left = settingsBtn.Left;
            settingsBtn.BackColor = Color.FromArgb(46, 51, 73);

            //Open settings form
            lblTitle.Text = "YLF Settings";
            this.formLoaderPnl.Controls.Clear();
            frmSettings FrmDashboard = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.formLoaderPnl.Controls.Add(FrmDashboard);
            FrmDashboard.Show();
        }



        //Visual reset background after leaving button

        private void dashboardBtn_Leave(object sender, EventArgs e)
        {
            dashboardBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void statsBtn_Leave(object sender, EventArgs e)
        {
            statsBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void settingsBtn_Leave(object sender, EventArgs e)
        {
            settingsBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Make window draggable
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDown)
            {
                int mousex = MousePosition.X - 400;
                int mousey = MousePosition.Y - 20;
                this.SetDesktopLocation(mousex, mousey);
            }


        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }

        //Minimize window button

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}



