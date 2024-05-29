using ParkingSystemDesign.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystemDesign.view
{
    public partial class Form1 : Form
    {
        DashboardForm dashboard;
        formParkIn parkin;
        formParkOut parkout;
        formParkHistory parkhistory;
        public List<string> sample = new List<string>();
        public List<string> platenoL = new List<string>(); 
        public List<string> platenO1 = new List<string>();
        public List<string> vtypE1 = new List<string>();
        public List<string> vbranD1 = new List<string>();
        public List<string> dtparkin = new List<string>();
        public List<string> dtparkout = new List<string>();
        public List<string> ttlHours = new List<string>();
        public List<string> ttlAmount = new List<string>();
        public string lastPanel = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            try
            {
                if (sidebarExpand)
                {
                    if (welcomePanel.Visible)
                    {
                        sidebarExpand = false;
                        return;
                    }

                    sidebar.Width -= 10;
                    if (sidebar.Width <= 45)
                    {
                        sidebarExpand = false;
                        sidebarTransition.Stop();
                    }
                }
                else
                {
                    sidebar.Width += 10;
                    if (sidebar.Width >= 164)
                    {
                        sidebarExpand = true;
                        sidebarTransition.Stop();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        //dashboard button
        private void button1_Click(object sender, EventArgs e)
        {
            if (welcomePanel.Visible) { welcomePanel.Hide(); }

            try
            {
                close(lastPanel);
                dashboard = new DashboardForm();
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
                lastPanel = "dashboard";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
        }

        private void parkIn_Click(object sender, EventArgs e)
        {
            if (welcomePanel.Visible) { welcomePanel.Hide(); }

            try
            {
                close(lastPanel);
                MessageBox.Show(DatabaseManager.getVCount().ToString() + " vehicle/s", "Number of Saved Parked in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                parkin = new formParkIn(DatabaseManager.getVPlate(), DatabaseManager.getVType(), DatabaseManager.getVBrand(), DatabaseManager.getVParkinT());
                parkin.MdiParent = this;
                parkin.Dock = DockStyle.Fill;
                parkin.Show();
                lastPanel = "parkin";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Parkin_FormClosed(object? sender, FormClosedEventArgs e)
        {
        }

        private void parkOut_Click(object sender, EventArgs e)
        {
            if (welcomePanel.Visible) { welcomePanel.Hide(); }

            try
            {
                close(lastPanel);
                MessageBox.Show(DatabaseManager.getVCount().ToString() + " vehicle/s", "Number of Parked in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                parkout = new formParkOut(DatabaseManager.getVPlate(), DatabaseManager.getVType(), DatabaseManager.getVBrand(), DatabaseManager.getVParkinT());
                parkout.MdiParent = this;
                parkout.Dock = DockStyle.Fill;
                parkout.Show();
                lastPanel = "parkout";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Parkout_FormClosed(object? sender, FormClosedEventArgs e)
        {
        }

        private void parkHistory_Click(object sender, EventArgs e)
        {
            if (welcomePanel.Visible) { welcomePanel.Hide(); }

            try
            {
                close(lastPanel);
                parkhistory = new formParkHistory(DatabaseManager.getVPlateHist(), DatabaseManager.getVParkinTHist(), DatabaseManager.getVParkoutTHist(), DatabaseManager.getVTtlhrsHist(), DatabaseManager.getVTtlamntHist());
                parkhistory.MdiParent = this;
                parkHistory.Dock = DockStyle.Fill;
                parkhistory.Show();
                lastPanel = "parkhistory";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Parkhistory_FormClosed(object? sender, FormClosedEventArgs e)
        {
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you and come again.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new FormLogin().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void close(string panel)
        {
            switch(panel)
            {
                case "dashboard": dashboard.Close(); break;
                case "parkin": parkin.Close(); break;
                case "parkout": parkout.Close(); break;
                case "parkhistory": parkhistory.Close(); break;
                default: break;
            }
        }
    }
}
