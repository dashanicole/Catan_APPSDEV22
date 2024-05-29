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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void motorbikeButton_Click(object sender, EventArgs e)
        {
            motorbikeAddLabel.Show();
            motorbikeFlagdownLabel.Show();
            vanSuvAddLabel.Hide();
            vanSuvFlagdownLabel.Hide();
            sedanAddLabel.Hide();
            sedanFlagdownLabel.Hide();
        }

        private void suvButton_Click(object sender, EventArgs e)
        {
            motorbikeAddLabel.Hide();
            motorbikeFlagdownLabel.Hide();
            vanSuvAddLabel.Show();
            vanSuvFlagdownLabel.Show();
            sedanAddLabel.Hide();
            sedanFlagdownLabel.Hide();
        }

        private void vanButton_Click(object sender, EventArgs e)
        {
            motorbikeAddLabel.Hide();
            motorbikeFlagdownLabel.Hide();
            vanSuvAddLabel.Show();
            vanSuvFlagdownLabel.Show();
            sedanAddLabel.Hide();
            sedanFlagdownLabel.Hide();
        }

        private void sedanButton_Click(object sender, EventArgs e)
        {
            motorbikeAddLabel.Hide();
            motorbikeFlagdownLabel.Hide();
            vanSuvAddLabel.Hide();
            vanSuvFlagdownLabel.Hide();
            sedanAddLabel.Show();
            sedanFlagdownLabel.Show();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            availSlot.Text = DatabaseManager.getAvailSlt().ToString();
            occpdSlot.Text = DatabaseManager.getOccpdSlt().ToString();
        }
    }
}
