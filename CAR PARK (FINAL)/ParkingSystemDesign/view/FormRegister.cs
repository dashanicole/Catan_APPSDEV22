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
    public partial class FormRegister : Form
    {

        public FormRegister()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textUsername.Text = "";
            textPasswordReg.Text = "";
            textConfirmPass.Text = "";
            textFirstName.Text = "";
            textMiddleName.Text = "";
            textLastName.Text = "";
            textFirstName.Focus();
        }

        private void backToLoginLabel_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string fname = textFirstName.Text, lname = textLastName.Text, mname = textMiddleName.Text
                , user = textUsername.Text, pass = textPasswordReg.Text, cpass = textConfirmPass.Text;

            try
            {
                if (fname == "")
                {
                    MessageBox.Show("Enter first name!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textFirstName.Focus();
                }
                else if (lname == "") {
                    MessageBox.Show("Enter last name!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textLastName.Focus();
                }
                else if (user == "")
                {
                    MessageBox.Show("Enter username!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textUsername.Focus();
                }
                else if (pass == "")
                {
                    MessageBox.Show("Enter password!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textPasswordReg.Focus();
                }
                else if (cpass == "")
                {
                    MessageBox.Show("Confirm password!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textConfirmPass.Focus();
                }
                else if (user.Length < 6 || user.Length > 14) 
                {
                    MessageBox.Show("Username must between 6 and 14 characters!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (pass.Length < 6 || pass.Length > 14)
                {
                    MessageBox.Show("Password must between 6 and 14 characters!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (pass != cpass)
                {
                    MessageBox.Show("Passwords do not match!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textConfirmPass.Text = "";
                    textConfirmPass.Focus();
                }
                else
                {
                    if (mname == "")
                    {
                        DatabaseManager.addReg(lname, fname, mname, user, pass);
                    } 
                    else
                    {
                        DatabaseManager.addReg(lname, fname, Convert.ToString(mname[0]), user, pass);
                    }

                    MessageBox.Show("Registered successfully!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    new FormLogin().Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    textPasswordReg.PasswordChar = '\0';
                    textConfirmPass.PasswordChar = '\0';
                }
                else
                {
                    textPasswordReg.PasswordChar = 'x';
                    textConfirmPass.PasswordChar = 'x';
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
