namespace ParkingSystemDesign.view
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button2 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            sidebar = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            parkIn = new Button();
            panel4 = new Panel();
            parkOut = new Button();
            panel5 = new Panel();
            panel7 = new Panel();
            parkHistory = new Button();
            panel6 = new Panel();
            logOut = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            welcomePanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(923, 35);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(880, 0);
            button2.Name = "button2";
            button2.Size = new Size(40, 32);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 1;
            label1.Text = "Car Park | Parking System";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.menus;
            pictureBox1.Location = new Point(11, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Black;
            sidebar.BackgroundImageLayout = ImageLayout.None;
            sidebar.Controls.Add(pictureBox2);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel6);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 35);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(164, 489);
            sidebar.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = Properties.Resources.CARPARK2_LOGO;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(161, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 45);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 30, 0, 0);
            panel2.Size = new Size(161, 47);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(9, 11);
            button1.Name = "button1";
            button1.Padding = new Padding(25, 0, 0, 0);
            button1.Size = new Size(105, 27);
            button1.TabIndex = 2;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(parkIn);
            panel3.Location = new Point(3, 98);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 30, 0, 0);
            panel3.Size = new Size(161, 51);
            panel3.TabIndex = 4;
            // 
            // parkIn
            // 
            parkIn.BackColor = Color.Black;
            parkIn.BackgroundImage = (Image)resources.GetObject("parkIn.BackgroundImage");
            parkIn.BackgroundImageLayout = ImageLayout.None;
            parkIn.FlatStyle = FlatStyle.Popup;
            parkIn.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parkIn.ForeColor = Color.White;
            parkIn.ImageAlign = ContentAlignment.MiddleLeft;
            parkIn.Location = new Point(9, 11);
            parkIn.Name = "parkIn";
            parkIn.Padding = new Padding(25, 0, 0, 0);
            parkIn.Size = new Size(105, 27);
            parkIn.TabIndex = 2;
            parkIn.Text = "Park In";
            parkIn.UseVisualStyleBackColor = false;
            parkIn.Click += parkIn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(parkOut);
            panel4.Location = new Point(3, 155);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 30, 0, 0);
            panel4.Size = new Size(161, 53);
            panel4.TabIndex = 5;
            panel4.Paint += panel4_Paint;
            // 
            // parkOut
            // 
            parkOut.BackColor = Color.Black;
            parkOut.BackgroundImage = (Image)resources.GetObject("parkOut.BackgroundImage");
            parkOut.BackgroundImageLayout = ImageLayout.None;
            parkOut.FlatStyle = FlatStyle.Popup;
            parkOut.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parkOut.ForeColor = Color.White;
            parkOut.ImageAlign = ContentAlignment.MiddleLeft;
            parkOut.Location = new Point(9, 11);
            parkOut.Name = "parkOut";
            parkOut.Padding = new Padding(25, 0, 0, 0);
            parkOut.Size = new Size(105, 27);
            parkOut.TabIndex = 2;
            parkOut.Text = "Park Out";
            parkOut.UseVisualStyleBackColor = false;
            parkOut.Click += parkOut_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(3, 214);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 30, 0, 0);
            panel5.Size = new Size(161, 50);
            panel5.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.Controls.Add(parkHistory);
            panel7.Location = new Point(9, 9);
            panel7.Name = "panel7";
            panel7.Size = new Size(117, 27);
            panel7.TabIndex = 3;
            // 
            // parkHistory
            // 
            parkHistory.BackColor = Color.Black;
            parkHistory.BackgroundImage = (Image)resources.GetObject("parkHistory.BackgroundImage");
            parkHistory.BackgroundImageLayout = ImageLayout.None;
            parkHistory.FlatStyle = FlatStyle.Popup;
            parkHistory.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parkHistory.ForeColor = Color.White;
            parkHistory.ImageAlign = ContentAlignment.MiddleLeft;
            parkHistory.Location = new Point(0, 0);
            parkHistory.Name = "parkHistory";
            parkHistory.Padding = new Padding(25, 0, 0, 0);
            parkHistory.Size = new Size(116, 27);
            parkHistory.TabIndex = 2;
            parkHistory.Text = "Park History";
            parkHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            parkHistory.UseVisualStyleBackColor = false;
            parkHistory.Click += parkHistory_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(logOut);
            panel6.Location = new Point(3, 270);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(0, 30, 0, 0);
            panel6.Size = new Size(161, 47);
            panel6.TabIndex = 5;
            // 
            // logOut
            // 
            logOut.BackColor = Color.Black;
            logOut.BackgroundImage = (Image)resources.GetObject("logOut.BackgroundImage");
            logOut.BackgroundImageLayout = ImageLayout.None;
            logOut.FlatStyle = FlatStyle.Popup;
            logOut.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logOut.ForeColor = Color.White;
            logOut.ImageAlign = ContentAlignment.MiddleLeft;
            logOut.Location = new Point(9, 11);
            logOut.Name = "logOut";
            logOut.Padding = new Padding(25, 0, 0, 0);
            logOut.Size = new Size(95, 27);
            logOut.TabIndex = 2;
            logOut.Text = "Logout";
            logOut.UseVisualStyleBackColor = false;
            logOut.Click += logOut_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // welcomePanel
            // 
            welcomePanel.BackColor = SystemColors.ButtonHighlight;
            welcomePanel.BackgroundImage = Properties.Resources._445660923_1434954607904659_5138231480479296219_n;
            welcomePanel.BackgroundImageLayout = ImageLayout.Zoom;
            welcomePanel.Dock = DockStyle.Right;
            welcomePanel.Location = new Point(162, 35);
            welcomePanel.Name = "welcomePanel";
            welcomePanel.Size = new Size(761, 489);
            welcomePanel.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(923, 524);
            Controls.Add(welcomePanel);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private FlowLayoutPanel sidebar;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button parkOut;
        private Panel panel5;
        private Button parkHistory;
        private Panel panel6;
        private Button logOut;
        private System.Windows.Forms.Timer sidebarTransition;
        private PictureBox pictureBox2;
        public Button parkIn;
        private Button button2;
        private Panel panel7;
        public Panel welcomePanel;
    }
}
