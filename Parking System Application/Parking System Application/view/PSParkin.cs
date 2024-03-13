using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parking_System_Application.model;
using Parking_System_Application.controller;

namespace Parking_System_Application.view
{
    public partial class PSParkin : Form
    {
        public event EventHandler DeleteButtonClicked;
        public event EventHandler CmbBxVBrandSelected;
        public event EventHandler Parkin1ButtonClicked;
        public event EventHandler Done1ButtonClicked;

        public PSParkin() { 
            InitializeComponent();
        }

        private void dtnDelete_Click(object sender, EventArgs e)
        {
            DeleteButtonClicked?.Invoke(this, e);
        }

        private void cmbBxVType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbBxVBrandSelected?.Invoke(this, e);
        }

        private void btnParkIn_Click(object sender, EventArgs e)
        {
            Parkin1ButtonClicked?.Invoke(this, e);
        }

        private void btnDone1_Click(object sender, EventArgs e)
        {
            Done1ButtonClicked?.Invoke(this, e);
        }
    }
}
