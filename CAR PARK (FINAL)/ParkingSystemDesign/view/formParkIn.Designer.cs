namespace ParkingSystemDesign.view
{
    partial class formParkIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formParkIn));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            panel1 = new Panel();
            confirmParkinButton = new Button();
            vBrandParkinComboBox = new ComboBox();
            vTypeParkinComboBox = new ComboBox();
            PlateNumTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridViewParkin = new DataGridView();
            plateNum = new DataGridViewTextBoxColumn();
            vType = new DataGridViewTextBoxColumn();
            vBrand = new DataGridViewTextBoxColumn();
            dateTime = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParkin).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small Semibol", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 43);
            label1.TabIndex = 0;
            label1.Text = "PARK IN\r\n";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(confirmParkinButton);
            panel1.Controls.Add(vBrandParkinComboBox);
            panel1.Controls.Add(vTypeParkinComboBox);
            panel1.Controls.Add(PlateNumTextBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 422);
            panel1.TabIndex = 1;
            // 
            // confirmParkinButton
            // 
            confirmParkinButton.BackColor = Color.WhiteSmoke;
            confirmParkinButton.FlatAppearance.BorderSize = 0;
            confirmParkinButton.FlatStyle = FlatStyle.Flat;
            confirmParkinButton.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmParkinButton.ForeColor = SystemColors.ActiveCaptionText;
            confirmParkinButton.Location = new Point(85, 302);
            confirmParkinButton.Name = "confirmParkinButton";
            confirmParkinButton.Size = new Size(101, 29);
            confirmParkinButton.TabIndex = 2;
            confirmParkinButton.Text = "CONFIRM";
            confirmParkinButton.UseVisualStyleBackColor = false;
            confirmParkinButton.Click += confirmParkinButton_Click;
            // 
            // vBrandParkinComboBox
            // 
            vBrandParkinComboBox.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vBrandParkinComboBox.FormattingEnabled = true;
            vBrandParkinComboBox.Location = new Point(22, 243);
            vBrandParkinComboBox.Name = "vBrandParkinComboBox";
            vBrandParkinComboBox.Size = new Size(218, 28);
            vBrandParkinComboBox.TabIndex = 8;
            vBrandParkinComboBox.SelectedIndexChanged += vBrandParkinComboBox_SelectedIndexChanged;
            // 
            // vTypeParkinComboBox
            // 
            vTypeParkinComboBox.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vTypeParkinComboBox.FormattingEnabled = true;
            vTypeParkinComboBox.Items.AddRange(new object[] { "Motorbike", "SUV", "Van", "Sedan" });
            vTypeParkinComboBox.Location = new Point(22, 164);
            vTypeParkinComboBox.Name = "vTypeParkinComboBox";
            vTypeParkinComboBox.Size = new Size(218, 28);
            vTypeParkinComboBox.TabIndex = 7;
            vTypeParkinComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // PlateNumTextBox
            // 
            PlateNumTextBox.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlateNumTextBox.Location = new Point(22, 84);
            PlateNumTextBox.Name = "PlateNumTextBox";
            PlateNumTextBox.Size = new Size(218, 32);
            PlateNumTextBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(19, 220);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 5;
            label5.Text = "Vehicle Brand";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(19, 141);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 4;
            label4.Text = "Vehicle Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(19, 61);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 3;
            label3.Text = "Plate Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(36, 25);
            label2.Name = "label2";
            label2.Size = new Size(189, 25);
            label2.TabIndex = 2;
            label2.Text = "Vehicle Information";
            // 
            // dataGridViewParkin
            // 
            dataGridViewParkin.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewParkin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewParkin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewParkin.Columns.AddRange(new DataGridViewColumn[] { plateNum, vType, vBrand, dateTime });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewParkin.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewParkin.GridColor = SystemColors.WindowText;
            dataGridViewParkin.Location = new Point(297, 55);
            dataGridViewParkin.Name = "dataGridViewParkin";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewParkin.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewParkin.RowHeadersWidth = 60;
            dataGridViewParkin.Size = new Size(431, 422);
            dataGridViewParkin.TabIndex = 2;
            // 
            // plateNum
            // 
            plateNum.HeaderText = "Plate Number";
            plateNum.Name = "plateNum";
            // 
            // vType
            // 
            vType.HeaderText = "Vehicle Type";
            vType.Name = "vType";
            // 
            // vBrand
            // 
            vBrand.HeaderText = "Vehicle Brand";
            vBrand.Name = "vBrand";
            // 
            // dateTime
            // 
            dateTime.HeaderText = "Park-in Date/Time";
            dateTime.Name = "dateTime";
            // 
            // formParkIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(760, 489);
            Controls.Add(dataGridViewParkin);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formParkIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formParkIn";
            Load += formParkIn_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParkin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridViewTextBoxColumn plateNum;
        private DataGridViewTextBoxColumn vType;
        private DataGridViewTextBoxColumn vBrand;
        private DataGridViewTextBoxColumn dateTime;
        public DataGridView dataGridViewParkin;
        public Button confirmParkinButton;
        public ComboBox vBrandParkinComboBox;
        public ComboBox vTypeParkinComboBox;
        public TextBox PlateNumTextBox;
    }
}