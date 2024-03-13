using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parking_System_Application.controller;

namespace Parking_System_Application.view
{
    public partial class PSDashboard : Form
    {
        public event EventHandler LoginButtonClicked;
        public event EventHandler ParkinButtonClicked;
        public event EventHandler SignoutButtonClicked;

        public PSDashboard()
        {
            InitializeComponent();
        }

        public void mnItemLogin_Click(object sender, EventArgs e)
        {
            LoginButtonClicked?.Invoke(this, e);
        }

        public void mnItemParkIn_Click(object sender, EventArgs e)
        {
            ParkinButtonClicked?.Invoke(this, e);
        }

        public void mnItemSignOut_Click(object sender, EventArgs e)
        {
            SignoutButtonClicked?.Invoke(this, e);
        }

        public void PSDashboard_Load(object sender, EventArgs e)
        {
        }
    }
}
