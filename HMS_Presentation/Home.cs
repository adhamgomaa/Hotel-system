using HMS_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Presentation
{
    public partial class Home : Form
    {
        public bool isLogout = false;
        public Home()
        {
            InitializeComponent();
        }

        private void movePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblUsername.Text = "Welcome: " + clsGlobal.CurrentUser.UserName;
        }

        private void btnBoard_Click(object sender, EventArgs e)
        {
            movePanel(btnBoard);
            ctrlDashboard1.Show();
            ctrlSettings1.Hide();
            ctrlReservation1.Hide();
            ctrlRoom1.Hide();
            ctrlClient1.Hide();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            movePanel(btnClient);
            ctrlClient1.Show();
            ctrlSettings1.Hide();
            ctrlReservation1.Hide();
            ctrlRoom1.Hide();
            ctrlDashboard1.Hide();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            movePanel(btnRoom);
            ctrlRoom1.Show();
            ctrlSettings1.Hide();
            ctrlReservation1.Hide();
            ctrlClient1.Hide();
            ctrlDashboard1.Hide();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            movePanel(btnReserve);
            ctrlReservation1.Show();
            ctrlSettings1.Hide();
            ctrlRoom1.Hide();
            ctrlClient1.Hide();
            ctrlDashboard1.Hide();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            movePanel(btnSetting);
            ctrlSettings1.Show();
            ctrlReservation1.Hide();
            ctrlRoom1.Hide();
            ctrlClient1.Hide();
            ctrlDashboard1.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Stop();
            clsGlobal.CurrentUser = null;
            isLogout = true;
            this.Close();
        }
    }
}
