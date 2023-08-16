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

namespace Zipperoni
{

    public partial class DashboardMain : Form
    {
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

            //Add apps

        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            //Visual
            pnlNav.Height = dashboardBtn.Height;
            pnlNav.Top = dashboardBtn.Top;
            pnlNav.Left = dashboardBtn.Left;
            dashboardBtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void statsBtn_Click(object sender, EventArgs e)
        {
            //Visual
            pnlNav.Height = statsBtn.Height;
            pnlNav.Top = statsBtn.Top;
            pnlNav.Left = statsBtn.Left;
            statsBtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            //Visual
            pnlNav.Height = settingsBtn.Height;
            pnlNav.Top = settingsBtn.Top;
            pnlNav.Left = settingsBtn.Left;
            settingsBtn.BackColor = Color.FromArgb(46, 51, 73);

            //Code
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

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("rundll32.exe", "dfshim.dll,ShOpenVerbApplication " + "https://raw.githubusercontent.com/OsRaMoSaO/Quantom-Calculator/master/published/Zipperoni.application");
        }
    }


}
