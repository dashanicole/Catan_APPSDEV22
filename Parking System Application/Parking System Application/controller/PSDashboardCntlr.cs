using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parking_System_Application.model;
using Parking_System_Application.view;

namespace Parking_System_Application.controller
{
    internal class PSDashboardCntlr
    {
        private PSDashboard dash;
        private PSLogin login;
        private PSParkin parkin;
        private PSInputChecker check;
        private string username, password, cpassword;
        private bool success;
        private string plateno, vtype, vbrand, dtin, dtout;
        private List<string> platenoL = new List<string>();
        private List<string> vtypeL = new List<string>();
        private List<string> vbrandL = new List<string>();
        private List<string> dtinL = new List<string>();
        private PSVehicle v;
        private PSParkout parkout;
        private PSDateTimeChecker checkT;
        private int count = 0;
        private double hour, amount;
        private PSParkHistory hist;

        public PSDashboardCntlr()
        {
            dash = new PSDashboard();
            dash.LoginButtonClicked += MyLoginButtonClickHandler;
            dash.ParkinButtonClicked += MyParkinButtonClickHandler;
            dash.SignoutButtonClicked += MySignoutButtonClickHandler;
            dash.ShowDialog();
        }

        private void MyLoginButtonClickHandler(object sender, EventArgs e)
        {
            dash.Visible = false;
            login = new PSLogin();
            login.Login1ButtonClicked += MyLogin1ButtonClickHandler;
            login.ShowDialog();

            if (success)
            {
                dash.mnItemParkIn.Enabled = true;
                dash.mnItemSignOut.Enabled = true;
                dash.mnItemLogin.Enabled = false;
                dash.Visible = true;
            }
        }

        private void MyLogin1ButtonClickHandler(object sender, EventArgs e)
        {
            check = new PSInputChecker();
            username = login.txtBxUsern.Text;
            password = login.txtBxPassw.Text;
            cpassword = login.txtBxCPassw.Text;

            if (check.invalidInputStr(username) || check.invalidInputStr(password)
                || check.invalidInputStr(cpassword))
            {
                MessageBox.Show("Incomplete/Invalid Login Form!");
            }
            else if (username.Length < 6 || username.Length > 14)
            {
                MessageBox.Show("Username must between 6 and 14 characters!");
            }
            else if (password.Length < 6 || password.Length > 14)
            {
                MessageBox.Show("Password must between 6 and 14 characters!");
            }
            else if (password != cpassword)
            {
                MessageBox.Show("Incorrect Password Confirmation!");
            }
            else
            {
                MessageBox.Show("Login Successfully!");
                success = true;
                login.Close();
            }
        }

        private void MySignoutButtonClickHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you, " + username + "!");
            dash.Close();
        }

        private void MyParkinButtonClickHandler(object sender, EventArgs e)
        {
            dash.Visible = false;
            parkin = new PSParkin();
            parkin.DeleteButtonClicked += MyDeleteButtonClickHandler;
            parkin.CmbBxVBrandSelected += MyCmbBxVBrandSelectedkHandler;
            parkin.Parkin1ButtonClicked += MyParkin1ButtonClickHandler;
            parkin.Done1ButtonClicked += MyDone1ButtonClickHandler;
            parkin.ShowDialog();
        }

        private void MyDeleteButtonClickHandler(object sender, EventArgs e)
        {
            if (parkin.dataGridViewParkIn.SelectedRows.Count > 0)
            {
                int index = parkin.dataGridViewParkIn.SelectedRows[0].Index;
                parkin.dataGridViewParkIn.Rows.RemoveAt(index);
                platenoL.RemoveAt(index);
                vtypeL.RemoveAt(index);
                vbrandL.RemoveAt(index);
                dtinL.RemoveAt(index);
            }

            if (platenoL.Count == 0)
            {
                parkin.btnDone1.Enabled = false;
                parkin.btnDelete.Enabled = false;
            }
        }

        private void MyCmbBxVBrandSelectedkHandler(object sender, EventArgs e)
        {
            string slctdVType = Convert.ToString(parkin.cmbBxVType.SelectedItem);
            parkin.cmbBxVBrand.Text = "Choose Vehicle Brand";

            switch (slctdVType)
            {
                case "Motorbike":
                    parkin.cmbBxVBrand.Items.Clear();
                    string[] brands1 = { "BMW", "Kawasaki", "Yamaha", "Honda", "Suzuki" };
                    foreach (string b in brands1)
                    {
                        parkin.cmbBxVBrand.Items.Add(b);
                    }
                    break;

                case "SUV":
                    parkin.cmbBxVBrand.Items.Clear();
                    string[] brands2 = { "Kia", "Mazda", "Hyundai", "Toyota", "Chevrolet" };
                    foreach (string b in brands2)
                    {
                        parkin.cmbBxVBrand.Items.Add(b);
                    }
                    break;

                case "Van":
                    parkin.cmbBxVBrand.Items.Clear();
                    string[] brands3 = { "Mercedes-Benz", "Nissan", "Ford", "Isuzu", "Volkswagen" };
                    foreach (string b in brands3)
                    {
                        parkin.cmbBxVBrand.Items.Add(b);
                    }
                    break;

                case "Sedan":
                    parkin.cmbBxVBrand.Items.Clear();
                    string[] brands4 = { "Chrysler", "Mirage", "Changan", "Rolls-Royce", "Skoda" };
                    foreach (string b in brands4)
                    {
                        parkin.cmbBxVBrand.Items.Add(b);
                    }
                    break;
            }
        }

        private void MyParkin1ButtonClickHandler(object sender, EventArgs e)
        {
            v = new PSVehicle();
            plateno = parkin.txtBxPlateNo.Text;
            vtype = Convert.ToString(parkin.cmbBxVType.SelectedItem);
            vbrand = Convert.ToString(parkin.cmbBxVBrand.SelectedItem);
            dtin = v.DtIn;

            check = new PSInputChecker();
            if (check.invalidInputStr(plateno) || vtype == "" || vbrand == "")
            {
                MessageBox.Show("Incomplete/Invalid Input!");
            }
            else if (platenoL.Count != 0 && check.checkPltNo(platenoL, plateno))
            {
                MessageBox.Show("Plate Number is already parked in!");
            }
            else
            {
                parkin.dataGridViewParkIn.Rows.Add();

                platenoL.Add(plateno);
                vtypeL.Add(vtype);
                vbrandL.Add(vbrand);
                dtinL.Add(dtin);

                for (int x = 0; x < platenoL.Count; x++)
                {
                    parkin.dataGridViewParkIn.Rows[x].Cells[0].Value = platenoL[x];
                    parkin.dataGridViewParkIn.Rows[x].Cells[1].Value = vtypeL[x];
                    parkin.dataGridViewParkIn.Rows[x].Cells[2].Value = vbrandL[x];
                    parkin.dataGridViewParkIn.Rows[x].Cells[3].Value = dtinL[x];
                }

                parkin.dataGridViewParkIn.Refresh();

                if (platenoL.Count != 0)
                {
                    parkin.btnDone1.Enabled = true;
                    parkin.btnDelete.Enabled = true;
                }
            }
        }

        private void MyDone1ButtonClickHandler(object sender, EventArgs e)
        {
            parkout = new PSParkout(platenoL, vtypeL, vbrandL, dtinL);
            parkout.Back1ButtonClicked += MyBack1ButtonClickHandler;
            parkout.EnterButtonClicked += MyEnterButtonClickHandler;
            parkout.Done2ButtonClicked += MyDone2ButtonClickHandler;
            parkin.Visible = false;
            parkout.ShowDialog();
        }

        private void MyBack1ButtonClickHandler(object sender, EventArgs e)
        {
            count = 0;
            parkin.Visible = true;
            parkout.Close();
        }

        private void MyEnterButtonClickHandler(object sender, EventArgs e)
        {
            checkT = new PSDateTimeChecker();
            plateno = Convert.ToString(parkout.cmBoxPlateNum.SelectedItem);
            int index = parkout.cmBoxPlateNum.SelectedIndex;

            if (index != -1)
            {
                dtin = parkout.dtiN[index];
            }

            if (parkout.platenO.Count == 0)
            {
                parkout.cmBoxPlateNum.Text = "No Park-in Customer Left";
            }

            if (plateno == "")
            {
                MessageBox.Show("No Park-in Customer!");
            }
            else if (checkT.invalidInputTime(parkout.txtBoxParkoutDT.Text, dtin))
            {
                MessageBox.Show("Empty/Invalid Input!");
            }
            else
            {
                parkout.dtiN1.Add(dtin);
                dtout = parkout.txtBoxParkoutDT.Text;
                vtype = parkout.vtypE[index];

                parkout.gridViewParkCust.Rows.Add();

                parkout.gridViewParkCust.Rows[count].Cells[0].Value = parkout.platenO[index];
                parkout.gridViewParkCust.Rows[count].Cells[1].Value = parkout.vtypE[index];

                parkout.gridViewParkCust.Rows[count].Cells[2].Value = parkout.vbranD[index];
                parkout.gridViewParkCust.Rows[count].Cells[3].Value = dtout;

                parkout.gridViewParkCust.Refresh();

                PSParkHour calc = new PSParkHour();
                hour = calc.calculateParkTime(dtin, dtout);

                parkout.lstBxParkOut.Items.Clear();
                parkout.lstBxParkOut.Items.Add("Date/Time In:");
                parkout.lstBxParkOut.Items.Add("    " + dtin);
                parkout.lstBxParkOut.Items.Add("");
                parkout.lstBxParkOut.Items.Add("Date/Time Out:");
                parkout.lstBxParkOut.Items.Add("    " + dtout);
                parkout.lstBxParkOut.Items.Add("");

                if (1 >= hour)
                {
                    parkout.lstBxParkOut.Items.Add("Parking Time:");
                    parkout.lstBxParkOut.Items.Add("    " + hour.ToString("F") + " hr");
                }
                else
                {
                    parkout.lstBxParkOut.Items.Add("Parking Time:");
                    parkout.lstBxParkOut.Items.Add("    " + hour.ToString("F") + " hrs");
                }

                PSTotalAmount total = new PSTotalAmount();
                amount = total.totalAmount(hour, vtype);

                parkout.lstBxParkOut.Items.Add("");
                parkout.lstBxParkOut.Items.Add("Total Amount: ");

                parkout.lstBxParkOut.Items.Add("    Php" + amount.ToString("N"));

                for (int x = 0; x < parkout.platenO1.Count; x++)
                {
                    if (parkout.platenO[index] == parkout.platenO1[x])
                    {
                        parkout.dtparkout[x] = dtout;
                        parkout.ttlAmount[x] = "Php" + amount.ToString("N");

                        if (1 >= hour)
                        {
                            parkout.ttlHours[x] = hour.ToString("F") + " hr";
                        }
                        else
                        {
                            parkout.ttlHours[x] = hour.ToString("F") + " hrs";
                        }
                    }
                }

                parkout.cmBoxPlateNum.Items.RemoveAt(index);
                parkout.platenO.RemoveAt(index);
                parkout.vtypE.RemoveAt(index);
                parkout.vbranD.RemoveAt(index);
                parkout.dtiN.RemoveAt(index);
                parkout.btnDone2.Enabled = true;

                count++;
            }
        }

        private void MyDone2ButtonClickHandler(object sender, EventArgs e)
        {
            hist = new PSParkHistory(parkout.platenO1, parkout.vtypE1, parkout.vbranD1, parkout.dtparkin, parkout.dtparkout, parkout.ttlHours, parkout.ttlAmount);
            hist.Done3ButtonClicked += MyDone3ButtonClickHandler;
            hist.Back2ButtonClicked += MyBack2ButtonClickHandler;
            parkout.Visible = false;
            hist.ShowDialog();
        }

        private void MyDone3ButtonClickHandler(object sender, EventArgs e)
        {
            parkin.Close();
            parkout.Close();
            hist.Close();
            dash.Visible = true;
        }

        private void MyBack2ButtonClickHandler(object sender, EventArgs e)
        {
            parkout.Visible = true;
            hist.Close();
        }
    }
}