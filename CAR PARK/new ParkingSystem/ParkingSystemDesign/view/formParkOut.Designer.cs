namespace ParkingSystemDesign.view
{
    partial class formParkOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formParkOut));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            panel2 = new Panel();
            enterParkoutButton = new Button();
            DateTimeTxtBox = new TextBox();
            label3 = new Label();
            plateNumComboBox = new ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            parkOutListBox = new ListBox();
            label4 = new Label();
            panel3 = new Panel();
            dataGridViewParkout = new DataGridView();
            plateNum = new DataGridViewTextBoxColumn();
            vType = new DataGridViewTextBoxColumn();
            vBrand = new DataGridViewTextBoxColumn();
            dateTime = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParkout).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small Semibol", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(174, 43);
            label1.TabIndex = 0;
            label1.Text = "PARK OUT";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(enterParkoutButton);
            panel2.Controls.Add(DateTimeTxtBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(plateNumComboBox);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(269, 208);
            panel2.TabIndex = 2;
            // 
            // enterParkoutButton
            // 
            enterParkoutButton.BackColor = Color.Transparent;
            enterParkoutButton.FlatStyle = FlatStyle.Popup;
            enterParkoutButton.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterParkoutButton.ForeColor = SystemColors.ButtonHighlight;
            enterParkoutButton.Location = new Point(63, 155);
            enterParkoutButton.Name = "enterParkoutButton";
            enterParkoutButton.Size = new Size(140, 36);
            enterParkoutButton.TabIndex = 3;
            enterParkoutButton.Text = "ENTER";
            enterParkoutButton.UseVisualStyleBackColor = false;
            enterParkoutButton.Click += enterParkoutButton_Click;
            // 
            // DateTimeTxtBox
            // 
            DateTimeTxtBox.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateTimeTxtBox.Location = new Point(12, 112);
            DateTimeTxtBox.Name = "DateTimeTxtBox";
            DateTimeTxtBox.Size = new Size(240, 27);
            DateTimeTxtBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 89);
            label3.Name = "label3";
            label3.Size = new Size(240, 20);
            label3.TabIndex = 4;
            label3.Text = "Date/Time (MM/dd/yyyy HH:mm)";
            // 
            // plateNumComboBox
            // 
            plateNumComboBox.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            plateNumComboBox.FormattingEnabled = true;
            plateNumComboBox.Location = new Point(12, 45);
            plateNumComboBox.Name = "plateNumComboBox";
            plateNumComboBox.Size = new Size(240, 28);
            plateNumComboBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 22);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 3;
            label2.Text = "Plate Number";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InfoText;
            panel1.Controls.Add(parkOutListBox);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 269);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 208);
            panel1.TabIndex = 3;
            // 
            // parkOutListBox
            // 
            parkOutListBox.BackColor = SystemColors.InfoText;
            parkOutListBox.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parkOutListBox.ForeColor = SystemColors.Info;
            parkOutListBox.FormattingEnabled = true;
            parkOutListBox.ItemHeight = 20;
            parkOutListBox.Location = new Point(12, 34);
            parkOutListBox.Name = "parkOutListBox";
            parkOutListBox.Size = new Size(240, 164);
            parkOutListBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(3, 9);
            label4.Name = "label4";
            label4.Size = new Size(200, 22);
            label4.TabIndex = 4;
            label4.Text = "Park-out Information";
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(dataGridViewParkout);
            panel3.Location = new Point(287, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(461, 447);
            panel3.TabIndex = 4;
            // 
            // dataGridViewParkout
            // 
            dataGridViewParkout.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewParkout.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewParkout.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewParkout.Columns.AddRange(new DataGridViewColumn[] { plateNum, vType, vBrand, dateTime });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewParkout.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewParkout.GridColor = Color.Black;
            dataGridViewParkout.Location = new Point(23, 28);
            dataGridViewParkout.Name = "dataGridViewParkout";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewParkout.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewParkout.RowHeadersWidth = 60;
            dataGridViewParkout.Size = new Size(417, 395);
            dataGridViewParkout.TabIndex = 0;
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
            dateTime.HeaderText = "Date/Time";
            dateTime.Name = "dateTime";
            // 
            // formParkOut
            // 
            AutoScaleDimensions = new SizeF(20F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(760, 489);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel3);
            Font = new Font("Yu Gothic UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(9);
            Name = "formParkOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formParkOut";
            Load += formParkOut_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewParkout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox DateTimeTxtBox;
        private Label label3;
        private Button enterParkoutButton;
        private Panel panel1;
        private Label label4;
        private Panel panel3;
        private DataGridView dataGridViewParkout;
        private DataGridViewTextBoxColumn plateNum;
        private DataGridViewTextBoxColumn vType;
        private DataGridViewTextBoxColumn vBrand;
        private DataGridViewTextBoxColumn dateTime;
        private ListBox parkOutListBox;
        public ComboBox plateNumComboBox;
    }
}