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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string user = textUsername.Text, pass = textPassword.Text;
            DateTime now = DateTime.Now;
            string dateTime = now.ToString("MM/dd/yyyy HH:mm");

            try
            {
                if (user == "") 
                {
                    MessageBox.Show("Enter username!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textUsername.Focus();
                }
                else if (pass == "")
                {
                    MessageBox.Show("Enter password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textPassword.Focus();
                }
                else if (DatabaseManager.fetchLogin(user, pass) == "none")
                {
                    MessageBox.Show("User does not exist!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textUsername.Text = "";
                    textPassword.Text = "";
                    textUsername.Focus();
                }

                else if (DatabaseManager.fetchLogin(user, pass) == "pass")
                {
                    MessageBox.Show("Incorrect password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textPassword.Text = "";
                    textPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Login Successfully!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DatabaseManager.addUsrLog(dateTime);
                    new Form1().Show();
                    this.Hide();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textUsername.Text = "";
            textPassword.Text = "";
            textUsername.Focus();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxShowPass.Checked)
                {
                    textPassword.PasswordChar = '\0';
                }
                else
                {
                    textPassword.PasswordChar = 'x';
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createAccLabel_Click(object sender, EventArgs e)
        {
            new FormRegister().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
