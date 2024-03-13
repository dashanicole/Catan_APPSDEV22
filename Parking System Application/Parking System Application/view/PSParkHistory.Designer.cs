namespace Parking_System_Application.view
{
    partial class PSParkHistory
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
            this.gridViewHistory = new System.Windows.Forms.DataGridView();
            this.HPlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HVType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HVBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParkInDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParkOutDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParkingHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHistory)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewHistory
            // 
            this.gridViewHistory.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HPlateNo,
            this.HVType,
            this.HVBrand,
            this.ParkInDateTime,
            this.ParkOutDateTime,
            this.ParkingHours,
            this.TotalPayment});
            this.gridViewHistory.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridViewHistory.Location = new System.Drawing.Point(52, 80);
            this.gridViewHistory.Name = "gridViewHistory";
            this.gridViewHistory.Size = new System.Drawing.Size(756, 362);
            this.gridViewHistory.TabIndex = 0;
            // 
            // HPlateNo
            // 
            this.HPlateNo.HeaderText = "Plate Number";
            this.HPlateNo.Name = "HPlateNo";
            // 
            // HVType
            // 
            this.HVType.HeaderText = "Vehicle Type";
            this.HVType.Name = "HVType";
            // 
            // HVBrand
            // 
            this.HVBrand.HeaderText = "Vehicle Brand";
            this.HVBrand.Name = "HVBrand";
            // 
            // ParkInDateTime
            // 
            this.ParkInDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ParkInDateTime.HeaderText = "Park-in Date/Time";
            this.ParkInDateTime.Name = "ParkInDateTime";
            this.ParkInDateTime.Width = 109;
            // 
            // ParkOutDateTime
            // 
            this.ParkOutDateTime.HeaderText = "Park-out Date/Time";
            this.ParkOutDateTime.Name = "ParkOutDateTime";
            // 
            // ParkingHours
            // 
            this.ParkingHours.HeaderText = "Parking Hours";
            this.ParkingHours.Name = "ParkingHours";
            // 
            // TotalPayment
            // 
            this.TotalPayment.HeaderText = "Total Payment";
            this.TotalPayment.Name = "TotalPayment";
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.White;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Gadugi", 13F);
            this.btnDone.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnDone.Location = new System.Drawing.Point(708, 461);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(100, 32);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(299, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "Park History";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 108);
            this.panel1.TabIndex = 3;
            // 
            // btnBack1
            // 
            this.btnBack1.BackColor = System.Drawing.Color.White;
            this.btnBack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack1.Font = new System.Drawing.Font("Gadugi", 13F);
            this.btnBack1.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnBack1.Location = new System.Drawing.Point(570, 461);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(100, 32);
            this.btnBack1.TabIndex = 4;
            this.btnBack1.Text = "Back";
            this.btnBack1.UseVisualStyleBackColor = false;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // PSParkHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(862, 683);
            this.Controls.Add(this.btnBack1);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.gridViewHistory);
            this.Controls.Add(this.panel1);
            this.Name = "PSParkHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PSParkHistory";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHistory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView gridViewHistory;
        public System.Windows.Forms.Button btnDone;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridViewTextBoxColumn HPlateNo;
        public System.Windows.Forms.DataGridViewTextBoxColumn HVType;
        public System.Windows.Forms.DataGridViewTextBoxColumn HVBrand;
        public System.Windows.Forms.DataGridViewTextBoxColumn ParkInDateTime;
        public System.Windows.Forms.DataGridViewTextBoxColumn ParkOutDateTime;
        public System.Windows.Forms.DataGridViewTextBoxColumn ParkingHours;
        public System.Windows.Forms.DataGridViewTextBoxColumn TotalPayment;
        public System.Windows.Forms.Button btnBack1;
    }
}