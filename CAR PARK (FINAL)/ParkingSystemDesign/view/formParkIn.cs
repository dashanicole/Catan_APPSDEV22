using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkingSystemDesign.controller;
using ParkingSystemDesign.model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ParkingSystemDesign.view
{
    public partial class formParkIn : Form
    {
        private string plateno, vtype, vbrand, dtin;
        public List<string> platenoL = new List<string>();
        public List<string> vtypeL = new List<string>();
        public List<string> vbrandL = new List<string>();
        public List<string> dtinL = new List<string>();
        private Vehicle v;
        private InputChecker check;
        public DateTime now = DateTime.Now;

        public formParkIn(List<string> a, List<string> b, List<string> c, List<string> d)
        {
            InitializeComponent();

            try
            {
                for (int x = 0; x < a.Count; x++)
                {
                    platenoL.Add(a[x]);
                    vtypeL.Add(b[x]);
                    vbrandL.Add(c[x]);
                    dtinL.Add(d[x]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewParkin.SelectedRows.Count > 0)
                {
                    int index = dataGridViewParkin.SelectedRows[0].Index;

                    // Ensure the index is within bounds
                    if (index >= 0 && index < platenoL.Count)
                    {
                        // Call delete on the database before removing the item from the list
                        DatabaseManager.deleteParkinV(platenoL[index]);

                        // Remove the row from the DataGridView and the corresponding items from the lists
                        dataGridViewParkin.Rows.RemoveAt(index);
                        platenoL.RemoveAt(index);
                        vtypeL.RemoveAt(index);
                        vbrandL.RemoveAt(index);
                        dtinL.RemoveAt(index);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string slctdVType = Convert.ToString(vTypeParkinComboBox.SelectedItem);
            vBrandParkinComboBox.Text = "Choose Vehicle Brand";

            try
            {
                switch (slctdVType)
                {
                    case "Motorbike":
                        vBrandParkinComboBox.Items.Clear();
                        string[] brands1 = { "BMW", "Kawasaki", "Yamaha", "Honda", "Suzuki" };
                        foreach (string b in brands1)
                        {
                            vBrandParkinComboBox.Items.Add(b);
                        }
                        break;

                    case "SUV":
                        vBrandParkinComboBox.Items.Clear();
                        string[] brands2 = { "Kia", "Mazda", "Hyundai", "Toyota", "Chevrolet" };
                        foreach (string b in brands2)
                        {
                            vBrandParkinComboBox.Items.Add(b);
                        }
                        break;

                    case "Van":
                        vBrandParkinComboBox.Items.Clear();
                        string[] brands3 = { "Mercedes-Benz", "Nissan", "Ford", "Isuzu", "Volkswagen" };
                        foreach (string b in brands3)
                        {
                            vBrandParkinComboBox.Items.Add(b);
                        }
                        break;

                    case "Sedan":
                        vBrandParkinComboBox.Items.Clear();
                        string[] brands4 = { "Chrysler", "Mirage", "Changan", "Rolls-Royce", "Skoda" };
                        foreach (string b in brands4)
                        {
                            vBrandParkinComboBox.Items.Add(b);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void confirmParkinButton_Click(object sender, EventArgs e)
        {
            try
            {
                v = new Vehicle();
                plateno = PlateNumTextBox.Text;

                PlateNumTextBox.Text = "";
                vTypeParkinComboBox.Text = "";
                vBrandParkinComboBox.Text = "";

                vtype = Convert.ToString(vTypeParkinComboBox.SelectedItem);
                vbrand = Convert.ToString(vBrandParkinComboBox.SelectedItem);
                dtin = v.DtIn;

                check = new InputChecker();

                if (vtype == "" || vbrand == "")
                {
                    MessageBox.Show("Incomplete input!", "Parkin Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (check.invalidInputStr(plateno))
                {
                    MessageBox.Show("Invalid input!", "Parkin Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (platenoL.Count != 0 && check.checkPltNo(platenoL, plateno) || DatabaseManager.existVPlate(plateno))
                {
                    MessageBox.Show("Plate Number is already parked in!", "Parkin Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DatabaseManager.addParkinV(plateno, vtype, vbrand, dtin);
                    DatabaseManager.parkSlot();
                    DatabaseManager.addTransact(now, plateno);

                    platenoL.Add(plateno);
                    vtypeL.Add(vtype);
                    vbrandL.Add(vbrand);
                    dtinL.Add(dtin);

                    dataGridViewParkin.Rows.Add();

                    for (int x = 0; x < platenoL.Count; x++)
                    {
                        dataGridViewParkin.Rows[x].Cells[0].Value = platenoL[x];
                        dataGridViewParkin.Rows[x].Cells[1].Value = vtypeL[x];
                        dataGridViewParkin.Rows[x].Cells[2].Value = vbrandL[x];
                        dataGridViewParkin.Rows[x].Cells[3].Value = dtinL[x];
                    }

                    dataGridViewParkin.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void vBrandParkinComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void formParkIn_Load(object sender, EventArgs e)
        {
            try
            {
                this.ControlBox = false;

                for (int x = 0; x < DatabaseManager.getVCount(); x++)
                {
                    dataGridViewParkin.Rows.Add();

                    dataGridViewParkin.Rows[x].Cells[0].Value = platenoL[x];
                    dataGridViewParkin.Rows[x].Cells[1].Value = vtypeL[x];
                    dataGridViewParkin.Rows[x].Cells[2].Value = vbrandL[x];
                    dataGridViewParkin.Rows[x].Cells[3].Value = dtinL[x];
                }

                dataGridViewParkin.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
