namespace ParkingSystemDesign.view
{
    partial class FormRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            label1 = new Label();
            label2 = new Label();
            textUsername = new TextBox();
            textPasswordReg = new TextBox();
            label3 = new Label();
            textConfirmPass = new TextBox();
            label4 = new Label();
            checkBoxShowPass = new CheckBox();
            registerButton = new Button();
            clearButton = new Button();
            alreadyHaveLabel = new Label();
            backToLoginLabel = new Label();
            textMiddleName = new TextBox();
            label5 = new Label();
            textLastName = new TextBox();
            label6 = new Label();
            textFirstName = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(309, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 31);
            label1.TabIndex = 0;
            label1.Text = "REGISTER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(549, 66);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.FromArgb(230, 231, 233);
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Font = new Font("Arial", 12F);
            textUsername.Location = new Point(552, 92);
            textUsername.Multiline = true;
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(216, 28);
            textUsername.TabIndex = 3;
            // 
            // textPasswordReg
            // 
            textPasswordReg.BackColor = Color.FromArgb(230, 231, 233);
            textPasswordReg.BorderStyle = BorderStyle.None;
            textPasswordReg.Font = new Font("Arial", 12F);
            textPasswordReg.Location = new Point(552, 156);
            textPasswordReg.Multiline = true;
            textPasswordReg.Name = "textPasswordReg";
            textPasswordReg.PasswordChar = 'x';
            textPasswordReg.Size = new Size(216, 28);
            textPasswordReg.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(549, 130);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // textConfirmPass
            // 
            textConfirmPass.BackColor = Color.FromArgb(230, 231, 233);
            textConfirmPass.BorderStyle = BorderStyle.None;
            textConfirmPass.Font = new Font("Arial", 12F);
            textConfirmPass.Location = new Point(552, 218);
            textConfirmPass.Multiline = true;
            textConfirmPass.Name = "textConfirmPass";
            textConfirmPass.PasswordChar = 'x';
            textConfirmPass.Size = new Size(216, 28);
            textConfirmPass.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(549, 192);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // checkBoxShowPass
            // 
            checkBoxShowPass.Location = new Point(0, 0);
            checkBoxShowPass.Name = "checkBoxShowPass";
            checkBoxShowPass.Size = new Size(104, 24);
            checkBoxShowPass.TabIndex = 21;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.Black;
            registerButton.Cursor = Cursors.Hand;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(432, 291);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(216, 35);
            registerButton.TabIndex = 6;
            registerButton.Text = "REGISTER";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.White;
            clearButton.Cursor = Cursors.Hand;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.ForeColor = Color.Black;
            clearButton.Location = new Point(432, 332);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(216, 35);
            clearButton.TabIndex = 7;
            clearButton.Text = "CLEAR";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // alreadyHaveLabel
            // 
            alreadyHaveLabel.AutoSize = true;
            alreadyHaveLabel.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            alreadyHaveLabel.Location = new Point(455, 379);
            alreadyHaveLabel.Name = "alreadyHaveLabel";
            alreadyHaveLabel.Size = new Size(182, 20);
            alreadyHaveLabel.TabIndex = 10;
            alreadyHaveLabel.Text = "Already Have an Account";
            // 
            // backToLoginLabel
            // 
            backToLoginLabel.AutoSize = true;
            backToLoginLabel.Cursor = Cursors.Hand;
            backToLoginLabel.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            backToLoginLabel.ForeColor = Color.Black;
            backToLoginLabel.Location = new Point(512, 399);
            backToLoginLabel.Name = "backToLoginLabel";
            backToLoginLabel.Size = new Size(58, 20);
            backToLoginLabel.TabIndex = 8;
            backToLoginLabel.Text = "Sign-in\r\n";
            backToLoginLabel.Click += backToLoginLabel_Click;
            // 
            // textMiddleName
            // 
            textMiddleName.BackColor = Color.FromArgb(230, 231, 233);
            textMiddleName.BorderStyle = BorderStyle.None;
            textMiddleName.Font = new Font("Arial", 12F);
            textMiddleName.Location = new Point(312, 156);
            textMiddleName.Multiline = true;
            textMiddleName.Name = "textMiddleName";
            textMiddleName.Size = new Size(216, 28);
            textMiddleName.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(309, 130);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 16;
            label5.Text = "Middle Name";
            // 
            // textLastName
            // 
            textLastName.BackColor = Color.FromArgb(230, 231, 233);
            textLastName.BorderStyle = BorderStyle.None;
            textLastName.Font = new Font("Arial", 12F);
            textLastName.Location = new Point(312, 218);
            textLastName.Multiline = true;
            textLastName.Name = "textLastName";
            textLastName.Size = new Size(216, 28);
            textLastName.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(309, 192);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 14;
            label6.Text = "Last Name";
            // 
            // textFirstName
            // 
            textFirstName.BackColor = Color.FromArgb(230, 231, 233);
            textFirstName.BorderStyle = BorderStyle.None;
            textFirstName.Font = new Font("Arial", 12F);
            textFirstName.Location = new Point(312, 92);
            textFirstName.Multiline = true;
            textFirstName.Name = "textFirstName";
            textFirstName.Size = new Size(216, 28);
            textFirstName.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(309, 66);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 12;
            label7.Text = "First Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(-3, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 460);
            panel1.TabIndex = 17;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.FromArgb(164, 165, 169);
            checkBox1.Location = new Point(635, 252);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(133, 24);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(760, 0);
            button2.Name = "button2";
            button2.Size = new Size(40, 32);
            button2.TabIndex = 22;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(panel1);
            Controls.Add(textMiddleName);
            Controls.Add(label5);
            Controls.Add(textLastName);
            Controls.Add(label6);
            Controls.Add(textFirstName);
            Controls.Add(label7);
            Controls.Add(backToLoginLabel);
            Controls.Add(alreadyHaveLabel);
            Controls.Add(clearButton);
            Controls.Add(registerButton);
            Controls.Add(checkBoxShowPass);
            Controls.Add(textConfirmPass);
            Controls.Add(label4);
            Controls.Add(textPasswordReg);
            Controls.Add(label3);
            Controls.Add(textUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPasswordReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textConfirmPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label alreadyHaveLabel;
        private System.Windows.Forms.Label backToLoginLabel;
        private System.Windows.Forms.TextBox textMiddleName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label label7;
        private Panel panel1;
        private CheckBox checkBox1;
        private Button button2;
    }
}

