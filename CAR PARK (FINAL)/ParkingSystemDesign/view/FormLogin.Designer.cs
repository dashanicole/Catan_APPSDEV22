namespace ParkingSystemDesign.view
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            createAccLabel = new Label();
            dontHaveAccLabel = new Label();
            clearButton = new Button();
            loginButton = new Button();
            checkBoxShowPass = new CheckBox();
            textPassword = new TextBox();
            label3 = new Label();
            textUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // createAccLabel
            // 
            createAccLabel.AutoSize = true;
            createAccLabel.Cursor = Cursors.Hand;
            createAccLabel.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createAccLabel.ForeColor = Color.Black;
            createAccLabel.Location = new Point(144, 391);
            createAccLabel.Name = "createAccLabel";
            createAccLabel.Size = new Size(113, 20);
            createAccLabel.TabIndex = 23;
            createAccLabel.Text = "Create Account";
            createAccLabel.Click += createAccLabel_Click;
            // 
            // dontHaveAccLabel
            // 
            dontHaveAccLabel.AutoSize = true;
            dontHaveAccLabel.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dontHaveAccLabel.Location = new Point(115, 371);
            dontHaveAccLabel.Name = "dontHaveAccLabel";
            dontHaveAccLabel.Size = new Size(167, 20);
            dontHaveAccLabel.TabIndex = 22;
            dontHaveAccLabel.Text = "Don't Have an Account";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.White;
            clearButton.Cursor = Cursors.Hand;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.ForeColor = Color.Black;
            clearButton.Location = new Point(45, 324);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(301, 35);
            clearButton.TabIndex = 21;
            clearButton.Text = "CLEAR";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Black;
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(45, 274);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(301, 35);
            loginButton.TabIndex = 20;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // checkBoxShowPass
            // 
            checkBoxShowPass.AutoSize = true;
            checkBoxShowPass.Cursor = Cursors.Hand;
            checkBoxShowPass.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxShowPass.ForeColor = Color.FromArgb(164, 165, 169);
            checkBoxShowPass.Location = new Point(213, 231);
            checkBoxShowPass.Name = "checkBoxShowPass";
            checkBoxShowPass.Size = new Size(133, 24);
            checkBoxShowPass.TabIndex = 19;
            checkBoxShowPass.Text = "Show Password";
            checkBoxShowPass.UseVisualStyleBackColor = true;
            checkBoxShowPass.CheckedChanged += checkBoxShowPass_CheckedChanged;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.FromArgb(230, 231, 233);
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Font = new Font("Arial", 12F);
            textPassword.Location = new Point(44, 197);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = 'x';
            textPassword.Size = new Size(301, 28);
            textPassword.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(41, 171);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.FromArgb(230, 231, 233);
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Font = new Font("Arial", 12F);
            textUsername.Location = new Point(44, 123);
            textUsername.Multiline = true;
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(301, 28);
            textUsername.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(41, 97);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 13;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(41, 26);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 12;
            label1.Text = "LOGIN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BackgroundImage = Properties.Resources.park_new;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(button2);
            panel1.Location = new Point(393, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 452);
            panel1.TabIndex = 24;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(368, 3);
            button2.Name = "button2";
            button2.Size = new Size(40, 32);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(41, 56);
            label4.Name = "label4";
            label4.Size = new Size(315, 20);
            label4.TabIndex = 25;
            label4.Text = "Please fill in the personal details to get started";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(createAccLabel);
            Controls.Add(dontHaveAccLabel);
            Controls.Add(clearButton);
            Controls.Add(loginButton);
            Controls.Add(checkBoxShowPass);
            Controls.Add(textPassword);
            Controls.Add(label3);
            Controls.Add(textUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label createAccLabel;
        private System.Windows.Forms.Label dontHaveAccLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Panel panel1;
        private Label label4;
        private Button button2;
    }
}