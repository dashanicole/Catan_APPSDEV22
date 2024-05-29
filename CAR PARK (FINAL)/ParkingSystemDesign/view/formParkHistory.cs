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
    public partial class formParkHistory : Form
    {
        private List<string> plateno = new List<string>();
        private List<string> vtype = new List<string>();
        private List<string> vbrand = new List<string>();
        private List<string> dtparkin = new List<string>();
        private List<string> dtparkout = new List<string>();
        private List<string> ttlhrs = new List<string>();
        private List<string> ttlamnt = new List<string>();

        public formParkHistory(List<string> a, List<string> b, List<string> c, List<string> d, List<string> e)
        {
            InitializeComponent();

            for (int x = 0; x < a.Count; x++)
            {
                plateno.Add(a[x]);
            }

            for (int x = 0; x < b.Count; x++)
            {
                dtparkin.Add(b[x]);
            }

            for (int x = 0; x < c.Count; x++)
            {
                dtparkout.Add(c[x]);
            }

            for (int x = 0; x < d.Count; x++)
            {
                ttlhrs.Add(d[x]);
            }

            for (int x = 0; x < e.Count; x++)
            {
                ttlamnt.Add(e[x]);
            }

            for (int x = 0; x < plateno.Count; x++)
            {
                gridViewHistory.Rows.Add();
                gridViewHistory.Rows[x].Cells[0].Value = plateno[x];
                gridViewHistory.Rows[x].Cells[1].Value = dtparkin[x];
                gridViewHistory.Rows[x].Cells[2].Value = dtparkout[x];
                gridViewHistory.Rows[x].Cells[3].Value = ttlhrs[x];
                gridViewHistory.Rows[x].Cells[4].Value = ttlamnt[x];
            }

            gridViewHistory.Refresh();
        }

        public formParkHistory()
        {
            InitializeComponent();
        }

        private void formParkHistory_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
