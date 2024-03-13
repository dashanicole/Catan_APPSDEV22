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
    public partial class PSLogin : Form
    {
        public event EventHandler Login1ButtonClicked;

        public PSLogin()
        {
            InitializeComponent();
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            Login1ButtonClicked?.Invoke(this, e);
        }

        private void PSLogin_Load(object sender, EventArgs e)
        {
        }
    }
}
