namespace Parking_System_Application
{
    partial class PSLogin
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
            this.txtBxUsern = new System.Windows.Forms.TextBox();
            this.txtBxPassw = new System.Windows.Forms.TextBox();
            this.labelUsern = new System.Windows.Forms.Label();
            this.labelCPassw = new System.Windows.Forms.Label();
            this.labelPassw = new System.Windows.Forms.Label();
            this.bttnLogin = new System.Windows.Forms.Button();
            this.txtBxCPassw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBxUsern
            // 
            this.txtBxUsern.Location = new System.Drawing.Point(221, 183);
            this.txtBxUsern.Name = "txtBxUsern";
            this.txtBxUsern.Size = new System.Drawing.Size(142, 20);
            this.txtBxUsern.TabIndex = 0;
            // 
            // txtBxPassw
            // 
            this.txtBxPassw.Location = new System.Drawing.Point(221, 236);
            this.txtBxPassw.Name = "txtBxPassw";
            this.txtBxPassw.Size = new System.Drawing.Size(142, 20);
            this.txtBxPassw.TabIndex = 1;
            this.txtBxPassw.UseSystemPasswordChar = true;
            // 
            // labelUsern
            // 
            this.labelUsern.AutoSize = true;
            this.labelUsern.Location = new System.Drawing.Point(141, 186);
            this.labelUsern.Name = "labelUsern";
            this.labelUsern.Size = new System.Drawing.Size(55, 13);
            this.labelUsern.TabIndex = 3;
            this.labelUsern.Text = "Username";
            // 
            // labelCPassw
            // 
            this.labelCPassw.AutoSize = true;
            this.labelCPassw.Location = new System.Drawing.Point(105, 289);
            this.labelCPassw.Name = "labelCPassw";
            this.labelCPassw.Size = new System.Drawing.Size(91, 13);
            this.labelCPassw.TabIndex = 4;
            this.labelCPassw.Text = "Confirm Password";
            // 
            // labelPassw
            // 
            this.labelPassw.AutoSize = true;
            this.labelPassw.Location = new System.Drawing.Point(141, 236);
            this.labelPassw.Name = "labelPassw";
            this.labelPassw.Size = new System.Drawing.Size(53, 13);
            this.labelPassw.TabIndex = 5;
            this.labelPassw.Text = "Password";
            // 
            // bttnLogin
            // 
            this.bttnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnLogin.Location = new System.Drawing.Point(192, 355);
            this.bttnLogin.Name = "bttnLogin";
            this.bttnLogin.Size = new System.Drawing.Size(75, 23);
            this.bttnLogin.TabIndex = 6;
            this.bttnLogin.Text = "Login";
            this.bttnLogin.UseVisualStyleBackColor = true;
            this.bttnLogin.Click += new System.EventHandler(this.bttnLogin_Click);
            // 
            // txtBxCPassw
            // 
            this.txtBxCPassw.Location = new System.Drawing.Point(221, 289);
            this.txtBxCPassw.Name = "txtBxCPassw";
            this.txtBxCPassw.Size = new System.Drawing.Size(142, 20);
            this.txtBxCPassw.TabIndex = 7;
            this.txtBxCPassw.UseSystemPasswordChar = true;
            // 
            // PSLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 552);
            this.Controls.Add(this.txtBxCPassw);
            this.Controls.Add(this.bttnLogin);
            this.Controls.Add(this.labelPassw);
            this.Controls.Add(this.labelCPassw);
            this.Controls.Add(this.labelUsern);
            this.Controls.Add(this.txtBxPassw);
            this.Controls.Add(this.txtBxUsern);
            this.Name = "PSLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parking System Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxUsern;
        private System.Windows.Forms.TextBox txtBxPassw;
        private System.Windows.Forms.Label labelUsern;
        private System.Windows.Forms.Label labelCPassw;
        private System.Windows.Forms.Label labelPassw;
        private System.Windows.Forms.Button bttnLogin;
        private System.Windows.Forms.TextBox txtBxCPassw;
    }
}

