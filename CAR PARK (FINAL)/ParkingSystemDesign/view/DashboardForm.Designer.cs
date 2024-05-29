namespace ParkingSystemDesign.view
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            panel6 = new Panel();
            occpdSlot = new Label();
            label6 = new Label();
            panel5 = new Panel();
            availSlot = new Label();
            label5 = new Label();
            panel4 = new Panel();
            sedanAddLabel = new Label();
            motorbikeAddLabel = new Label();
            vanSuvAddLabel = new Label();
            label4 = new Label();
            panel3 = new Panel();
            vanSuvFlagdownLabel = new Label();
            motorbikeFlagdownLabel = new Label();
            sedanFlagdownLabel = new Label();
            label3 = new Label();
            panel2 = new Panel();
            sedanButton = new Button();
            suvButton = new Button();
            vanButton = new Button();
            motorbikeButton = new Button();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(occpdSlot);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(507, 289);
            panel6.Name = "panel6";
            panel6.Size = new Size(228, 111);
            panel6.TabIndex = 11;
            // 
            // occpdSlot
            // 
            occpdSlot.AutoSize = true;
            occpdSlot.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            occpdSlot.Location = new Point(97, 50);
            occpdSlot.Name = "occpdSlot";
            occpdSlot.Size = new Size(25, 30);
            occpdSlot.TabIndex = 14;
            occpdSlot.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(45, 11);
            label6.Name = "label6";
            label6.Size = new Size(145, 26);
            label6.TabIndex = 3;
            label6.Text = "Occupied slot/s";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(availSlot);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(267, 289);
            panel5.Name = "panel5";
            panel5.Size = new Size(214, 111);
            panel5.TabIndex = 10;
            // 
            // availSlot
            // 
            availSlot.AutoSize = true;
            availSlot.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            availSlot.Location = new Point(94, 50);
            availSlot.Name = "availSlot";
            availSlot.Size = new Size(25, 30);
            availSlot.TabIndex = 13;
            availSlot.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 11);
            label5.Name = "label5";
            label5.Size = new Size(138, 26);
            label5.TabIndex = 3;
            label5.Text = "Available Slot/s";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(sedanAddLabel);
            panel4.Controls.Add(motorbikeAddLabel);
            panel4.Controls.Add(vanSuvAddLabel);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(450, 129);
            panel4.Name = "panel4";
            panel4.Size = new Size(285, 111);
            panel4.TabIndex = 9;
            // 
            // sedanAddLabel
            // 
            sedanAddLabel.AutoSize = true;
            sedanAddLabel.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sedanAddLabel.Location = new Point(111, 51);
            sedanAddLabel.Name = "sedanAddLabel";
            sedanAddLabel.Size = new Size(80, 30);
            sedanAddLabel.TabIndex = 6;
            sedanAddLabel.Text = "P15.00";
            // 
            // motorbikeAddLabel
            // 
            motorbikeAddLabel.AutoSize = true;
            motorbikeAddLabel.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            motorbikeAddLabel.Location = new Point(111, 51);
            motorbikeAddLabel.Name = "motorbikeAddLabel";
            motorbikeAddLabel.Size = new Size(68, 30);
            motorbikeAddLabel.TabIndex = 6;
            motorbikeAddLabel.Text = "P5.00";
            // 
            // vanSuvAddLabel
            // 
            vanSuvAddLabel.AutoSize = true;
            vanSuvAddLabel.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vanSuvAddLabel.Location = new Point(111, 51);
            vanSuvAddLabel.Name = "vanSuvAddLabel";
            vanSuvAddLabel.Size = new Size(80, 30);
            vanSuvAddLabel.TabIndex = 5;
            vanSuvAddLabel.Text = "P20.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 7);
            label4.Name = "label4";
            label4.Size = new Size(260, 28);
            label4.TabIndex = 3;
            label4.Text = "Additional Amout per Hour\r\n";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(vanSuvFlagdownLabel);
            panel3.Controls.Add(motorbikeFlagdownLabel);
            panel3.Controls.Add(sedanFlagdownLabel);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(267, 129);
            panel3.Name = "panel3";
            panel3.Size = new Size(161, 111);
            panel3.TabIndex = 8;
            // 
            // vanSuvFlagdownLabel
            // 
            vanSuvFlagdownLabel.AutoSize = true;
            vanSuvFlagdownLabel.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vanSuvFlagdownLabel.Location = new Point(39, 51);
            vanSuvFlagdownLabel.Name = "vanSuvFlagdownLabel";
            vanSuvFlagdownLabel.Size = new Size(80, 30);
            vanSuvFlagdownLabel.TabIndex = 5;
            vanSuvFlagdownLabel.Text = "P40.00";
            // 
            // motorbikeFlagdownLabel
            // 
            motorbikeFlagdownLabel.AutoSize = true;
            motorbikeFlagdownLabel.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            motorbikeFlagdownLabel.Location = new Point(39, 51);
            motorbikeFlagdownLabel.Name = "motorbikeFlagdownLabel";
            motorbikeFlagdownLabel.Size = new Size(80, 30);
            motorbikeFlagdownLabel.TabIndex = 4;
            motorbikeFlagdownLabel.Text = "P20.00";
            // 
            // sedanFlagdownLabel
            // 
            sedanFlagdownLabel.AutoSize = true;
            sedanFlagdownLabel.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sedanFlagdownLabel.Location = new Point(39, 51);
            sedanFlagdownLabel.Name = "sedanFlagdownLabel";
            sedanFlagdownLabel.Size = new Size(80, 30);
            sedanFlagdownLabel.TabIndex = 6;
            sedanFlagdownLabel.Text = "P30.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 7);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 3;
            label3.Text = "Flagdown\r\n";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(sedanButton);
            panel2.Controls.Add(suvButton);
            panel2.Controls.Add(vanButton);
            panel2.Controls.Add(motorbikeButton);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(24, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 400);
            panel2.TabIndex = 7;
            // 
            // sedanButton
            // 
            sedanButton.BackColor = Color.Black;
            sedanButton.FlatAppearance.BorderSize = 0;
            sedanButton.FlatStyle = FlatStyle.Flat;
            sedanButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sedanButton.ForeColor = SystemColors.ButtonHighlight;
            sedanButton.Location = new Point(26, 315);
            sedanButton.Name = "sedanButton";
            sedanButton.Size = new Size(170, 34);
            sedanButton.TabIndex = 4;
            sedanButton.Text = "Sedan";
            sedanButton.UseVisualStyleBackColor = false;
            sedanButton.Click += sedanButton_Click;
            // 
            // suvButton
            // 
            suvButton.BackColor = Color.Black;
            suvButton.FlatAppearance.BorderSize = 0;
            suvButton.FlatStyle = FlatStyle.Flat;
            suvButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suvButton.ForeColor = SystemColors.ButtonHighlight;
            suvButton.Location = new Point(26, 162);
            suvButton.Name = "suvButton";
            suvButton.Size = new Size(170, 34);
            suvButton.TabIndex = 3;
            suvButton.Text = "SUV";
            suvButton.UseVisualStyleBackColor = false;
            suvButton.Click += suvButton_Click;
            // 
            // vanButton
            // 
            vanButton.BackColor = Color.Black;
            vanButton.FlatAppearance.BorderSize = 0;
            vanButton.FlatStyle = FlatStyle.Flat;
            vanButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vanButton.ForeColor = SystemColors.ButtonHighlight;
            vanButton.Location = new Point(26, 239);
            vanButton.Name = "vanButton";
            vanButton.Size = new Size(170, 34);
            vanButton.TabIndex = 3;
            vanButton.Text = "Van";
            vanButton.UseVisualStyleBackColor = false;
            vanButton.Click += vanButton_Click;
            // 
            // motorbikeButton
            // 
            motorbikeButton.BackColor = Color.Black;
            motorbikeButton.FlatAppearance.BorderSize = 0;
            motorbikeButton.FlatStyle = FlatStyle.Flat;
            motorbikeButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            motorbikeButton.ForeColor = SystemColors.ButtonHighlight;
            motorbikeButton.Location = new Point(26, 86);
            motorbikeButton.Name = "motorbikeButton";
            motorbikeButton.Size = new Size(170, 34);
            motorbikeButton.TabIndex = 2;
            motorbikeButton.Text = "Motorbike";
            motorbikeButton.UseVisualStyleBackColor = false;
            motorbikeButton.Click += motorbikeButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(14, 28);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 2;
            label2.Text = "VEHICLE TYPE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Variable Small Semibol", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.ImageAlign = ContentAlignment.TopLeft;
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 43);
            label1.TabIndex = 0;
            label1.Text = "DASHBOARD";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.ImageAlign = ContentAlignment.TopLeft;
            label7.Location = new Point(391, 73);
            label7.Name = "label7";
            label7.Size = new Size(221, 37);
            label7.TabIndex = 12;
            label7.Text = "Key Information";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(760, 489);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel6;
        private Label label6;
        private Panel panel5;
        private Label label5;
        private Panel panel4;
        private Label sedanAddLabel;
        private Label motorbikeAddLabel;
        private Label vanSuvAddLabel;
        private Label label4;
        private Panel panel3;
        private Label vanSuvFlagdownLabel;
        private Label motorbikeFlagdownLabel;
        private Label sedanFlagdownLabel;
        private Label label3;
        private Panel panel2;
        private Button sedanButton;
        private Button suvButton;
        private Button vanButton;
        private Button motorbikeButton;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label occpdSlot;
        private Label availSlot;
    }
}