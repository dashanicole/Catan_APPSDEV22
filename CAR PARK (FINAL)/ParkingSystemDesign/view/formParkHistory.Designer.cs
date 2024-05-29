namespace ParkingSystemDesign.view
{
    partial class formParkHistory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            gridViewHistory = new DataGridView();
            plateNum = new DataGridViewTextBoxColumn();
            parkinDateTime = new DataGridViewTextBoxColumn();
            parkoutDateTime = new DataGridViewTextBoxColumn();
            parkHours = new DataGridViewTextBoxColumn();
            totalAmount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridViewHistory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small Semibol", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(240, 43);
            label1.TabIndex = 0;
            label1.Text = "PARK HISTORY";
            // 
            // gridViewHistory
            // 
            gridViewHistory.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridViewHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewHistory.Columns.AddRange(new DataGridViewColumn[] { plateNum, parkinDateTime, parkoutDateTime, parkHours, totalAmount });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridViewHistory.DefaultCellStyle = dataGridViewCellStyle2;
            gridViewHistory.Location = new Point(99, 65);
            gridViewHistory.Name = "gridViewHistory";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridViewHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridViewHistory.ShowEditingIcon = false;
            gridViewHistory.Size = new Size(543, 365);
            gridViewHistory.TabIndex = 0;
            // 
            // plateNum
            // 
            plateNum.HeaderText = "Plate Number";
            plateNum.Name = "plateNum";
            // 
            // parkinDateTime
            // 
            parkinDateTime.HeaderText = "Park-in Date/Time";
            parkinDateTime.Name = "parkinDateTime";
            // 
            // parkoutDateTime
            // 
            parkoutDateTime.HeaderText = "Park-out Date/Time";
            parkoutDateTime.Name = "parkoutDateTime";
            // 
            // parkHours
            // 
            parkHours.HeaderText = "Parking Hours";
            parkHours.Name = "parkHours";
            // 
            // totalAmount
            // 
            totalAmount.HeaderText = "Total Payment";
            totalAmount.Name = "totalAmount";
            // 
            // formParkHistory
            // 
            AutoScaleDimensions = new SizeF(20F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(771, 524);
            Controls.Add(gridViewHistory);
            Controls.Add(label1);
            Font = new Font("Yu Gothic UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(9);
            Name = "formParkHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formParkHistory";
            Load += formParkHistory_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView gridViewHistory;
        private DataGridViewTextBoxColumn plateNum;
        private DataGridViewTextBoxColumn parkinDateTime;
        private DataGridViewTextBoxColumn parkoutDateTime;
        private DataGridViewTextBoxColumn parkHours;
        private DataGridViewTextBoxColumn totalAmount;
    }
}