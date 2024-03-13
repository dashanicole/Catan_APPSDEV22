namespace Parking_System_Application.view
{
    partial class PSParkout
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpBxPrkoutTime = new System.Windows.Forms.GroupBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtBoxParkoutDT = new System.Windows.Forms.TextBox();
            this.cmBoxPlateNum = new System.Windows.Forms.ComboBox();
            this.labelPlateNum = new System.Windows.Forms.Label();
            this.labelPltNo = new System.Windows.Forms.Label();
            this.btnDone2 = new System.Windows.Forms.Button();
            this.lstBxParkOut = new System.Windows.Forms.ListBox();
            this.labelParkOut = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridViewParkCust = new System.Windows.Forms.DataGridView();
            this.PlateNumberCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleTypeCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleBrandCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParkOutDateTimeCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelParkOutCus = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpBxPrkoutTime.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParkCust)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxPrkoutTime
            // 
            this.grpBxPrkoutTime.BackColor = System.Drawing.Color.White;
            this.grpBxPrkoutTime.Controls.Add(this.btnEnter);
            this.grpBxPrkoutTime.Controls.Add(this.txtBoxParkoutDT);
            this.grpBxPrkoutTime.Controls.Add(this.cmBoxPlateNum);
            this.grpBxPrkoutTime.Controls.Add(this.labelPlateNum);
            this.grpBxPrkoutTime.Controls.Add(this.labelPltNo);
            this.grpBxPrkoutTime.Font = new System.Drawing.Font("Yu Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxPrkoutTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpBxPrkoutTime.Location = new System.Drawing.Point(16, 68);
            this.grpBxPrkoutTime.Name = "grpBxPrkoutTime";
            this.grpBxPrkoutTime.Size = new System.Drawing.Size(287, 256);
            this.grpBxPrkoutTime.TabIndex = 1;
            this.grpBxPrkoutTime.TabStop = false;
            this.grpBxPrkoutTime.Text = "Park-out Date/Time";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(83, 202);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(129, 32);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtBoxParkoutDT
            // 
            this.txtBoxParkoutDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxParkoutDT.Font = new System.Drawing.Font("Gadugi", 12F);
            this.txtBoxParkoutDT.Location = new System.Drawing.Point(46, 153);
            this.txtBoxParkoutDT.Name = "txtBoxParkoutDT";
            this.txtBoxParkoutDT.Size = new System.Drawing.Size(200, 29);
            this.txtBoxParkoutDT.TabIndex = 4;
            this.txtBoxParkoutDT.TextChanged += new System.EventHandler(this.txtBoxParkoutDT_TextChanged);
            // 
            // cmBoxPlateNum
            // 
            this.cmBoxPlateNum.Font = new System.Drawing.Font("Gadugi", 12F);
            this.cmBoxPlateNum.FormattingEnabled = true;
            this.cmBoxPlateNum.Location = new System.Drawing.Point(46, 67);
            this.cmBoxPlateNum.Name = "cmBoxPlateNum";
            this.cmBoxPlateNum.Size = new System.Drawing.Size(200, 27);
            this.cmBoxPlateNum.TabIndex = 3;
            this.cmBoxPlateNum.Text = "Choose the Plate Number";
            this.cmBoxPlateNum.SelectedIndexChanged += new System.EventHandler(this.cmBoxPlateNum_SelectedIndexChanged);
            // 
            // labelPlateNum
            // 
            this.labelPlateNum.AutoSize = true;
            this.labelPlateNum.Font = new System.Drawing.Font("Gadugi", 12F);
            this.labelPlateNum.Location = new System.Drawing.Point(42, 36);
            this.labelPlateNum.Name = "labelPlateNum";
            this.labelPlateNum.Size = new System.Drawing.Size(105, 19);
            this.labelPlateNum.TabIndex = 2;
            this.labelPlateNum.Text = "Plate Number\r\n";
            // 
            // labelPltNo
            // 
            this.labelPltNo.AutoSize = true;
            this.labelPltNo.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPltNo.Location = new System.Drawing.Point(46, 106);
            this.labelPltNo.Name = "labelPltNo";
            this.labelPltNo.Size = new System.Drawing.Size(186, 57);
            this.labelPltNo.TabIndex = 1;
            this.labelPltNo.Text = "Park-out Date/Time \r\n     (MM/dd/yyyy HH:mm)\r\n\r\n";
            // 
            // btnDone2
            // 
            this.btnDone2.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDone2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDone2.Location = new System.Drawing.Point(684, 618);
            this.btnDone2.Name = "btnDone2";
            this.btnDone2.Size = new System.Drawing.Size(129, 32);
            this.btnDone2.TabIndex = 12;
            this.btnDone2.Text = "Done";
            this.btnDone2.UseVisualStyleBackColor = false;
            this.btnDone2.Click += new System.EventHandler(this.btnDone2_Click);
            // 
            // lstBxParkOut
            // 
            this.lstBxParkOut.BackColor = System.Drawing.Color.White;
            this.lstBxParkOut.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBxParkOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lstBxParkOut.FormattingEnabled = true;
            this.lstBxParkOut.ItemHeight = 19;
            this.lstBxParkOut.Location = new System.Drawing.Point(16, 420);
            this.lstBxParkOut.Name = "lstBxParkOut";
            this.lstBxParkOut.Size = new System.Drawing.Size(292, 251);
            this.lstBxParkOut.TabIndex = 6;
            // 
            // labelParkOut
            // 
            this.labelParkOut.AutoSize = true;
            this.labelParkOut.BackColor = System.Drawing.Color.IndianRed;
            this.labelParkOut.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParkOut.ForeColor = System.Drawing.Color.White;
            this.labelParkOut.Location = new System.Drawing.Point(17, 11);
            this.labelParkOut.Name = "labelParkOut";
            this.labelParkOut.Size = new System.Drawing.Size(284, 40);
            this.labelParkOut.TabIndex = 7;
            this.labelParkOut.Text = "Park-out Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grpBxPrkoutTime);
            this.panel1.Controls.Add(this.lstBxParkOut);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 683);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check Out";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Location = new System.Drawing.Point(3, -55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 111);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Controls.Add(this.labelParkOut);
            this.panel3.Location = new System.Drawing.Point(2, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 66);
            this.panel3.TabIndex = 9;
            // 
            // gridViewParkCust
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.gridViewParkCust.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewParkCust.BackgroundColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewParkCust.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewParkCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewParkCust.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlateNumberCol1,
            this.VehicleTypeCol1,
            this.VehicleBrandCol1,
            this.ParkOutDateTimeCol1});
            this.gridViewParkCust.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridViewParkCust.Location = new System.Drawing.Point(369, 68);
            this.gridViewParkCust.Name = "gridViewParkCust";
            this.gridViewParkCust.Size = new System.Drawing.Size(444, 526);
            this.gridViewParkCust.TabIndex = 10;
            // 
            // PlateNumberCol1
            // 
            this.PlateNumberCol1.HeaderText = "Plate Number";
            this.PlateNumberCol1.Name = "PlateNumberCol1";
            // 
            // VehicleTypeCol1
            // 
            this.VehicleTypeCol1.HeaderText = "Vehicle Type";
            this.VehicleTypeCol1.Name = "VehicleTypeCol1";
            // 
            // VehicleBrandCol1
            // 
            this.VehicleBrandCol1.HeaderText = "Vehicle Brand";
            this.VehicleBrandCol1.Name = "VehicleBrandCol1";
            // 
            // ParkOutDateTimeCol1
            // 
            this.ParkOutDateTimeCol1.HeaderText = "Park-out Date/Time";
            this.ParkOutDateTimeCol1.Name = "ParkOutDateTimeCol1";
            // 
            // labelParkOutCus
            // 
            this.labelParkOutCus.AutoSize = true;
            this.labelParkOutCus.BackColor = System.Drawing.Color.White;
            this.labelParkOutCus.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParkOutCus.ForeColor = System.Drawing.Color.DarkSalmon;
            this.labelParkOutCus.Location = new System.Drawing.Point(422, 9);
            this.labelParkOutCus.Name = "labelParkOutCus";
            this.labelParkOutCus.Size = new System.Drawing.Size(328, 47);
            this.labelParkOutCus.TabIndex = 11;
            this.labelParkOutCus.Text = "Park-out Customers";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.PeachPuff;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(369, 618);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 32);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PSParkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 683);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelParkOutCus);
            this.Controls.Add(this.gridViewParkCust);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDone2);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "PSParkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Park Out";
            this.grpBxPrkoutTime.ResumeLayout(false);
            this.grpBxPrkoutTime.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewParkCust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox grpBxPrkoutTime;
        public System.Windows.Forms.Label labelPltNo;
        public System.Windows.Forms.Button btnEnter;
        public System.Windows.Forms.Button btnDone2;
        public System.Windows.Forms.ListBox lstBxParkOut;
        public System.Windows.Forms.Label labelParkOut;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labelPlateNum;
        public System.Windows.Forms.DataGridView gridViewParkCust;
        public System.Windows.Forms.Label labelParkOutCus;
        public System.Windows.Forms.ComboBox cmBoxPlateNum;
        public System.Windows.Forms.DataGridViewTextBoxColumn PlateNumberCol1;
        public System.Windows.Forms.DataGridViewTextBoxColumn VehicleTypeCol1;
        public System.Windows.Forms.DataGridViewTextBoxColumn VehicleBrandCol1;
        public System.Windows.Forms.DataGridViewTextBoxColumn ParkOutDateTimeCol1;
        public System.Windows.Forms.TextBox txtBoxParkoutDT;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnBack;
    }
}