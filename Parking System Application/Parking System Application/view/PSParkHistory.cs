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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Parking_System_Application.view
{
    public partial class PSParkHistory : Form
    {
        public event EventHandler Done3ButtonClicked;
        public event EventHandler Back2ButtonClicked;

        private List<string> plateno = new List<string>();
        private List<string> vtype = new List<string>();
        private List<string> vbrand = new List<string>();
        private List<string> dtparkin = new List<string>();
        private List<string> dtparkout = new List<string>();
        private List<string> ttlhrs = new List<string>();
        private List<string> ttlamnt = new List<string>();

        public PSParkHistory(List<string> a, List<string> b, List<string> c, List<string> d, List<string> e, List<string> f, List<string> g)
        {
            InitializeComponent();

            for (int x = 0; x < a.Count; x++)
            {
                plateno.Add(a[x]);
            }

            for (int x = 0; x < b.Count; x++)
            {
                vtype.Add(b[x]);
            }

            for (int x = 0; x < c.Count; x++)
            {
                vbrand.Add(c[x]);
            }

            for (int x = 0; x < d.Count; x++)
            {
                dtparkin.Add(d[x]);
            }

            for (int x = 0; x < e.Count; x++)
            {
                dtparkout.Add(e[x]);
            }

            for (int x = 0; x < f.Count; x++)
            {
                ttlhrs.Add(f[x]);
            }

            for (int x = 0; x < g.Count; x++)
            {
                ttlamnt.Add(g[x]);
            }

            for (int x = 0; x < plateno.Count; x++)
            {
                gridViewHistory.Rows.Add();
                gridViewHistory.Rows[x].Cells[0].Value = plateno[x];
                gridViewHistory.Rows[x].Cells[1].Value = vtype[x];
                gridViewHistory.Rows[x].Cells[2].Value = vbrand[x];
                gridViewHistory.Rows[x].Cells[3].Value = dtparkin[x];
                gridViewHistory.Rows[x].Cells[4].Value = dtparkout[x];
                gridViewHistory.Rows[x].Cells[5].Value = ttlhrs[x];
                gridViewHistory.Rows[x].Cells[6].Value = ttlamnt[x];
            }

            gridViewHistory.Refresh();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Done3ButtonClicked?.Invoke(this, e);
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            Back2ButtonClicked?.Invoke(this, e);
        }
    }
}
