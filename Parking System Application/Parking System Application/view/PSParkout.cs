using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parking_System_Application.controller;
using Parking_System_Application.model;

namespace Parking_System_Application.view
{
    public partial class PSParkout : Form
    {
        public event EventHandler Back1ButtonClicked;
        public event EventHandler EnterButtonClicked;
        public event EventHandler Done2ButtonClicked;

        // Park-in Details
        public List<string> platenO = new List<string>();
        public List<string> vtypE = new List<string>();
        public List<string> vbranD = new List<string>();
        public List<string> dtiN = new List<string>();

        // History Details
        public List<string> platenO1 = new List<string>();
        public List<string> vtypE1 = new List<string>();
        public List<string> vbranD1 = new List<string>();
        public List<string> dtiN1 = new List<string>();
        public List<string> dtparkin = new List<string>();
        public List<string> dtparkout = new List<string>();
        public List<string> ttlHours = new List<string>();
        public List<string> ttlAmount = new List<string>();

        public List<string> cmb = new List<string>();
        public List<int> selectIndex = new List<int>();

        private void txtBoxParkoutDT_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Back1ButtonClicked?.Invoke(this, e);
        }

        public PSParkout(List<string> a, List<string> b, List<string> c, List<string> d)
        {
            InitializeComponent();

            for (int x = 0; x < a.Count; x++)
            {
                cmBoxPlateNum.Items.Add(a[x]);
                platenO.Add(a[x]);
                platenO1.Add(a[x]);
                dtparkout.Add(null);
                ttlHours.Add(null);
                ttlAmount.Add(null);
            }

            for (int x = 0; x < b.Count; x++)
            {
                vtypE.Add(b[x]);
                vtypE1.Add(b[x]);
            }

            for (int x = 0; x < c.Count; x++)
            {
                vbranD.Add(c[x]);
                vbranD1.Add(c[x]);
            }

            for (int x = 0; x < d.Count; x++)
            {
                dtiN.Add(d[x]);
                dtparkin.Add(d[x]);
            }

        }


        private void cmBoxPlateNum_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            EnterButtonClicked?.Invoke(this, e);
        }

        private void btnDone2_Click(object sender, EventArgs e)
        {
            Done2ButtonClicked?.Invoke(this, e);
        }
    }
}
