namespace Parking_System_Application.view
{
    partial class PSParkin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpBxVInfo = new System.Windows.Forms.GroupBox();
            this.labelVBrand = new System.Windows.Forms.Label();
            this.btnParkIn = new System.Windows.Forms.Button();
            this.cmbBxVType = new System.Windows.Forms.ComboBox();
            this.cmbBxVBrand = new System.Windows.Forms.ComboBox();
            this.labelVType = new System.Windows.Forms.Label();
            this.labelPltNo = new System.Windows.Forms.Label();
            this.txtBxPlateNo = new System.Windows.Forms.TextBox();
            this.labelParkIn = new System.Windows.Forms.Label();
            this.btnDone1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViewParkIn = new System.Windows.Forms.DataGridView();
            this.PlateNumberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleBrandCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParkInDateTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBxVInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParkIn)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxVInfo
            // 
            this.grpBxVInfo.BackColor = System.Drawing.Color.PeachPuff;
            this.grpBxVInfo.Controls.Add(this.labelVBrand);
            this.grpBxVInfo.Controls.Add(this.btnParkIn);
            this.grpBxVInfo.Controls.Add(this.cmbBxVType);
            this.grpBxVInfo.Controls.Add(this.cmbBxVBrand);
            this.grpBxVInfo.Controls.Add(this.labelVType);
            this.grpBxVInfo.Controls.Add(this.labelPltNo);
            this.grpBxVInfo.Controls.Add(this.txtBxPlateNo);
            this.grpBxVInfo.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxVInfo.ForeColor = System.Drawing.Color.Black;
            this.grpBxVInfo.Location = new System.Drawing.Point(12, 133);
            this.grpBxVInfo.Name = "grpBxVInfo";
            this.grpBxVInfo.Size = new System.Drawing.Size(233, 302);
            this.grpBxVInfo.TabIndex = 0;
            this.grpBxVInfo.TabStop = false;
            this.grpBxVInfo.Text = "Vehicle Information";
            // 
            // labelVBrand
            // 
            this.labelVBrand.AutoSize = true;
            this.labelVBrand.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVBrand.Location = new System.Drawing.Point(22, 163);
            this.labelVBrand.Name = "labelVBrand";
            this.labelVBrand.Size = new System.Drawing.Size(104, 19);
            this.labelVBrand.TabIndex = 7;
            this.labelVBrand.Text = "Vehicle Brand";
            // 
            // btnParkIn
            // 
            this.btnParkIn.BackColor = System.Drawing.Color.LightSalmon;
            this.btnParkIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParkIn.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParkIn.ForeColor = System.Drawing.Color.White;
            this.btnParkIn.Location = new System.Drawing.Point(49, 240);
            this.btnParkIn.Name = "btnParkIn";
            this.btnParkIn.Size = new System.Drawing.Size(129, 32);
            this.btnParkIn.TabIndex = 2;
            this.btnParkIn.Text = "Park In";
            this.btnParkIn.UseVisualStyleBackColor = false;
            this.btnParkIn.Click += new System.EventHandler(this.btnParkIn_Click);
            // 
            // cmbBxVType
            // 
            this.cmbBxVType.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBxVType.FormattingEnabled = true;
            this.cmbBxVType.Items.AddRange(new object[] {
            "Motorbike",
            "SUV",
            "Van",
            "Sedan"});
            this.cmbBxVType.Location = new System.Drawing.Point(25, 124);
            this.cmbBxVType.Name = "cmbBxVType";
            this.cmbBxVType.Size = new System.Drawing.Size(174, 27);
            this.cmbBxVType.TabIndex = 6;
            this.cmbBxVType.Text = "Choose Vehicle Type";
            this.cmbBxVType.SelectedIndexChanged += new System.EventHandler(this.cmbBxVType_SelectedIndexChanged);
            // 
            // cmbBxVBrand
            // 
            this.cmbBxVBrand.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBxVBrand.FormattingEnabled = true;
            this.cmbBxVBrand.Location = new System.Drawing.Point(25, 185);
            this.cmbBxVBrand.Name = "cmbBxVBrand";
            this.cmbBxVBrand.Size = new System.Drawing.Size(174, 27);
            this.cmbBxVBrand.TabIndex = 5;
            this.cmbBxVBrand.Text = "Choose Vehicle Brand";
            // 
            // labelVType
            // 
            this.labelVType.AutoSize = true;
            this.labelVType.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVType.Location = new System.Drawing.Point(21, 102);
            this.labelVType.Name = "labelVType";
            this.labelVType.Size = new System.Drawing.Size(96, 19);
            this.labelVType.TabIndex = 2;
            this.labelVType.Text = "Vehicle Type";
            // 
            // labelPltNo
            // 
            this.labelPltNo.AutoSize = true;
            this.labelPltNo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPltNo.Location = new System.Drawing.Point(21, 51);
            this.labelPltNo.Name = "labelPltNo";
            this.labelPltNo.Size = new System.Drawing.Size(105, 19);
            this.labelPltNo.TabIndex = 1;
            this.labelPltNo.Text = "Plate Number";
            // 
            // txtBxPlateNo
            // 
            this.txtBxPlateNo.BackColor = System.Drawing.Color.White;
            this.txtBxPlateNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxPlateNo.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxPlateNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBxPlateNo.Location = new System.Drawing.Point(25, 73);
            this.txtBxPlateNo.Name = "txtBxPlateNo";
            this.txtBxPlateNo.Size = new System.Drawing.Size(174, 27);
            this.txtBxPlateNo.TabIndex = 0;
            // 
            // labelParkIn
            // 
            this.labelParkIn.AutoSize = true;
            this.labelParkIn.BackColor = System.Drawing.Color.IndianRed;
            this.labelParkIn.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParkIn.ForeColor = System.Drawing.Color.White;
            this.labelParkIn.Location = new System.Drawing.Point(155, 9);
            this.labelParkIn.Name = "labelParkIn";
            this.labelParkIn.Size = new System.Drawing.Size(304, 47);
            this.labelParkIn.TabIndex = 4;
            this.labelParkIn.Text = "Park-In Customers";
            // 
            // btnDone1
            // 
            this.btnDone1.BackColor = System.Drawing.Color.White;
            this.btnDone1.Enabled = false;
            this.btnDone1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone1.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnDone1.Location = new System.Drawing.Point(404, 508);
            this.btnDone1.Name = "btnDone1";
            this.btnDone1.Size = new System.Drawing.Size(129, 32);
            this.btnDone1.TabIndex = 5;
            this.btnDone1.Text = "Done";
            this.btnDone1.UseVisualStyleBackColor = false;
            this.btnDone1.Click += new System.EventHandler(this.btnDone1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.dataGridViewParkIn);
            this.panel1.Controls.Add(this.btnDone1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(259, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 569);
            this.panel1.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnDelete.Location = new System.Drawing.Point(89, 508);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 32);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.dtnDelete_Click);
            // 
            // dataGridViewParkIn
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewParkIn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewParkIn.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewParkIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewParkIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParkIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlateNumberCol,
            this.VehicleTypeCol,
            this.VehicleBrandCol,
            this.ParkInDateTimeCol});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewParkIn.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewParkIn.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewParkIn.Location = new System.Drawing.Point(89, 77);
            this.dataGridViewParkIn.Name = "dataGridViewParkIn";
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewParkIn.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewParkIn.Size = new System.Drawing.Size(444, 404);
            this.dataGridViewParkIn.TabIndex = 7;
            // 
            // PlateNumberCol
            // 
            this.PlateNumberCol.HeaderText = "Plate Number";
            this.PlateNumberCol.Name = "PlateNumberCol";
            // 
            // VehicleTypeCol
            // 
            this.VehicleTypeCol.HeaderText = "Vehicle Type";
            this.VehicleTypeCol.Name = "VehicleTypeCol";
            // 
            // VehicleBrandCol
            // 
            this.VehicleBrandCol.HeaderText = "Vehicle Brand";
            this.VehicleBrandCol.Name = "VehicleBrandCol";
            // 
            // ParkInDateTimeCol
            // 
            this.ParkInDateTimeCol.HeaderText = "Park-in Date/Time";
            this.ParkInDateTimeCol.Name = "ParkInDateTimeCol";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.labelParkIn);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 60);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label1.Location = new System.Drawing.Point(53, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 47);
            this.label1.TabIndex = 7;
            this.label1.Text = "Check In";
            // 
            // PSParkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBxVInfo);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "PSParkin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Park In";
            this.grpBxVInfo.ResumeLayout(false);
            this.grpBxVInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParkIn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox grpBxVInfo;
        public System.Windows.Forms.TextBox txtBxPlateNo;
        public System.Windows.Forms.Label labelPltNo;
        public System.Windows.Forms.Label labelVType;
        public System.Windows.Forms.ComboBox cmbBxVBrand;
        public System.Windows.Forms.Label labelParkIn;
        public System.Windows.Forms.ComboBox cmbBxVType;
        public System.Windows.Forms.Button btnParkIn;
        public System.Windows.Forms.Label labelVBrand;
        public System.Windows.Forms.Button btnDone1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridViewParkIn;
        public System.Windows.Forms.DataGridViewTextBoxColumn PlateNumberCol;
        public System.Windows.Forms.DataGridViewTextBoxColumn VehicleTypeCol;
        public System.Windows.Forms.DataGridViewTextBoxColumn VehicleBrandCol;
        public System.Windows.Forms.DataGridViewTextBoxColumn ParkInDateTimeCol;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Panel panel2;
    }
}