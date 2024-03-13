namespace Parking_System_Application.view
{
    partial class PSDashboard
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
            this.mnItemLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemParkIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnItemLogin
            // 
            this.mnItemLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mnItemLogin.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnItemLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mnItemLogin.Name = "mnItemLogin";
            this.mnItemLogin.Size = new System.Drawing.Size(60, 23);
            this.mnItemLogin.Text = "Login";
            this.mnItemLogin.Click += new System.EventHandler(this.mnItemLogin_Click);
            // 
            // mnItemParkIn
            // 
            this.mnItemParkIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mnItemParkIn.Enabled = false;
            this.mnItemParkIn.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnItemParkIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mnItemParkIn.Name = "mnItemParkIn";
            this.mnItemParkIn.Size = new System.Drawing.Size(69, 23);
            this.mnItemParkIn.Text = "Park in";
            this.mnItemParkIn.Click += new System.EventHandler(this.mnItemParkIn_Click);
            // 
            // mnItemSignOut
            // 
            this.mnItemSignOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mnItemSignOut.Enabled = false;
            this.mnItemSignOut.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnItemSignOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mnItemSignOut.Name = "mnItemSignOut";
            this.mnItemSignOut.Size = new System.Drawing.Size(82, 23);
            this.mnItemSignOut.Text = "Sign Out";
            this.mnItemSignOut.Click += new System.EventHandler(this.mnItemSignOut_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnItemLogin,
            this.mnItemParkIn,
            this.mnItemSignOut});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PSDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Parking_System_Application.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 567);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PSDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.PSDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStripMenuItem mnItemLogin;
        public System.Windows.Forms.ToolStripMenuItem mnItemParkIn;
        public System.Windows.Forms.ToolStripMenuItem mnItemSignOut;
        public System.Windows.Forms.MenuStrip menuStrip1;
    }
}