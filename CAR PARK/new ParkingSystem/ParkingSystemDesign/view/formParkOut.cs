using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingSystemDesign.controller;

namespace ParkingSystemDesign.view
{
    public partial class formParkOut : Form
    {
        // Park-in Details
        public List<string> platenO = new List<string>();
        public List<string> vtypE = new List<string>();
        public List<string> vbranD = new List<string>();
        public List<string> dtiN = new List<string>();

        // History Details
        public List<string> platenO1 = new List<string>();
        public List<string> vtypE1 = new List<string>();
        public List<string> vbranD1 = new List<string>();
        //public List<string> dtiN1 = new List<string>();
        public List<string> dtparkin = new List<string>();
        public List<string> dtparkout = new List<string>();
        public List<string> ttlHours = new List<string>();
        public List<string> ttlAmount = new List<string>();

        public List<string> plateno1 = new List<string>();
        public List<string> vtype1 = new List<string>();
        public List<string> vbrand1 = new List<string>();
        public List<string> dtparkout1 = new List<string>();

        public List<string> cmb = new List<string>();
        public List<int> selectIndex = new List<int>();

        private DateTimeChecker checkT;
        private string plateno, dtin, dtout, vtype;
        private int count = 0;
        private double hour, amount;
        //private formParkIn parkin;     

        public formParkOut(List<string> a, List<string> b, List<string> c, List<string> d)
        {
            InitializeComponent();

            try
            {
                setVehic1(DatabaseManager.getVPlate1(), DatabaseManager.getVType1(), DatabaseManager.getVBrand1(), DatabaseManager.getVParkoutT1());

                for (int x = 0; x < a.Count; x++)
                {
                    plateNumComboBox.Items.Add(a[x]);
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
                    //dtparkin.Add(d[x]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public formParkOut()
        {
            InitializeComponent();
        }

        private void formParkOut_Load(object sender, EventArgs e)
        {
            try
            {

                for (int x = 0; x < plateno1.Count; x++)
                {
                    dataGridViewParkout.Rows.Add();

                    dataGridViewParkout.Rows[count].Cells[0].Value = plateno1[x];
                    dataGridViewParkout.Rows[count].Cells[1].Value = vtype1[x];
                    dataGridViewParkout.Rows[count].Cells[2].Value = vbrand1[x];
                    dataGridViewParkout.Rows[count].Cells[3].Value = dtparkout1[x];

                    count++;
                }

                parkOutListBox.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void enterParkoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                checkT = new DateTimeChecker();
                plateno = Convert.ToString(plateNumComboBox.SelectedItem);
                int index = plateNumComboBox.SelectedIndex;

                if (index != -1)
                {
                    dtin = dtiN[index];
                }

                if (platenO.Count == 0)
                {
                    MessageBox.Show("No Park-in Customer Left!", "Parkout Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (plateno == "")
                {
                    MessageBox.Show("No Park-in Customer!", "Parkout Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (checkT.invalidInputTime(DateTimeTxtBox.Text, dtin))
                {
                    MessageBox.Show("Empty/Invalid Input!", "Parkout Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dtparkin.Add(dtin);
                    dtout = DateTimeTxtBox.Text;
                    vtype = vtypE[index];

                    ParkHour calc = new ParkHour();
                    hour = calc.calculateParkTime(dtin, dtout);

                    parkOutListBox.Items.Clear();
                    parkOutListBox.Items.Add("Date/Time In:");
                    parkOutListBox.Items.Add("    " + dtin);
                    parkOutListBox.Items.Add("");
                    parkOutListBox.Items.Add("Date/Time Out:");
                    parkOutListBox.Items.Add("    " + dtout);
                    parkOutListBox.Items.Add("");

                    if (1 >= hour)
                    {
                        parkOutListBox.Items.Add("Parking Time:");
                        parkOutListBox.Items.Add("    " + hour.ToString("F") + " hr");
                    }
                    else
                    {
                        parkOutListBox.Items.Add("Parking Time:");
                        parkOutListBox.Items.Add("    " + hour.ToString("F") + " hrs");
                    }

                    TotalAmount total = new TotalAmount();
                    amount = total.totalAmount(hour, vtype);

                    parkOutListBox.Items.Add("");
                    parkOutListBox.Items.Add("Total Amount: ");

                    parkOutListBox.Items.Add("    Php" + amount.ToString("N"));

                    for (int x = 0; x < platenO1.Count; x++)
                    {
                        if (platenO[index] == platenO1[x])
                        {
                            dtparkout[x] = dtout;
                            ttlAmount[x] = "Php" + amount.ToString("N");

                            if (1 >= hour)
                            {
                                ttlHours[x] = hour.ToString("F") + " hr";
                            }
                            else
                            {
                                ttlHours[x] = hour.ToString("F") + " hrs";
                            }

                            DatabaseManager.insertVOutInfo(platenO1[x], dtparkout[x], ttlHours[x], ttlAmount[x]);
                            DatabaseManager.exitSlot(platenO1[x]);
                        }
                    }

                    dataGridViewParkout.Rows.Add();

                    dataGridViewParkout.Rows[count].Cells[0].Value = platenO[index];
                    dataGridViewParkout.Rows[count].Cells[1].Value = vtypE[index];
                    dataGridViewParkout.Rows[count].Cells[2].Value = vbranD[index];
                    dataGridViewParkout.Rows[count].Cells[3].Value = dtparkout[index];

                    dataGridViewParkout.Refresh();

                    DateTimeTxtBox.Text = "";
                    plateNumComboBox.Text = "";
                    plateNumComboBox.Items.RemoveAt(index);
                    platenO.RemoveAt(index);
                    vtypE.RemoveAt(index);
                    vbranD.RemoveAt(index);
                    dtiN.RemoveAt(index);

                    count++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setVehic1(List<string> a, List<string> b, List<string> c, List<string> d)
        {
            for (int x = 0; x < a.Count; x++)
            {
                plateno1.Add(a[x]);
            }

            for (int x = 0; x < b.Count; x++)
            {
                vtype1.Add(b[x]);
            }

            for (int x = 0; x < c.Count; x++)
            {
                vbrand1.Add(c[x]);
            }

            for (int x = 0; x < d.Count; x++)
            {
                dtparkout1.Add(d[x]);
            }

        }
    }
}
