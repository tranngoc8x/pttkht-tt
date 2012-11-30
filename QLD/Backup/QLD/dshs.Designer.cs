namespace QLD
{
    partial class dshs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.griddshs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.textBoxDropDown1 = new DevComponents.DotNetBar.Controls.TextBoxDropDown();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnxem = new DevComponents.DotNetBar.ButtonX();
            this.btnsuahs = new DevComponents.DotNetBar.ButtonX();
            this.btnxoahs = new DevComponents.DotNetBar.ButtonX();
            this.closehs = new DevComponents.DotNetBar.ButtonX();
            this.btnthemhs = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.griddshs)).BeginInit();
            this.SuspendLayout();
            // 
            // griddshs
            // 
            this.griddshs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.griddshs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.griddshs.DefaultCellStyle = dataGridViewCellStyle1;
            this.griddshs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.griddshs.Location = new System.Drawing.Point(12, 76);
            this.griddshs.Name = "griddshs";
            this.griddshs.Size = new System.Drawing.Size(608, 260);
            this.griddshs.TabIndex = 0;
            // 
            // textBoxDropDown1
            // 
            this.textBoxDropDown1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxDropDown1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            // 
            // 
            // 
            this.textBoxDropDown1.BackgroundStyle.Class = "TextBoxBorder";
            this.textBoxDropDown1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxDropDown1.ButtonDropDown.Visible = true;
            this.textBoxDropDown1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxDropDown1.Location = new System.Drawing.Point(82, 30);
            this.textBoxDropDown1.Name = "textBoxDropDown1";
            this.textBoxDropDown1.Size = new System.Drawing.Size(104, 24);
            this.textBoxDropDown1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.textBoxDropDown1.TabIndex = 1;
            this.textBoxDropDown1.Text = "";
            this.textBoxDropDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxDropDown1.WatermarkText = "Danh sách lớp học";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(17, 32);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(51, 19);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Chọn lớp";
            // 
            // btnxem
            // 
            this.btnxem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxem.Location = new System.Drawing.Point(193, 30);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(75, 23);
            this.btnxem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxem.TabIndex = 3;
            this.btnxem.Text = "Xem";
            // 
            // btnsuahs
            // 
            this.btnsuahs.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsuahs.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsuahs.Location = new System.Drawing.Point(210, 357);
            this.btnsuahs.Name = "btnsuahs";
            this.btnsuahs.Size = new System.Drawing.Size(75, 23);
            this.btnsuahs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsuahs.TabIndex = 4;
            this.btnsuahs.Text = "Sửa thông tin";
            // 
            // btnxoahs
            // 
            this.btnxoahs.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxoahs.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxoahs.Location = new System.Drawing.Point(321, 357);
            this.btnxoahs.Name = "btnxoahs";
            this.btnxoahs.Size = new System.Drawing.Size(75, 23);
            this.btnxoahs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxoahs.TabIndex = 5;
            this.btnxoahs.Text = "Xóa học sinh";
            // 
            // closehs
            // 
            this.closehs.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.closehs.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.closehs.Location = new System.Drawing.Point(437, 356);
            this.closehs.Name = "closehs";
            this.closehs.Size = new System.Drawing.Size(75, 23);
            this.closehs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.closehs.TabIndex = 6;
            this.closehs.Text = "Đóng";
            this.closehs.Click += new System.EventHandler(this.closehs_Click);
            // 
            // btnthemhs
            // 
            this.btnthemhs.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthemhs.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthemhs.Location = new System.Drawing.Point(82, 357);
            this.btnthemhs.Name = "btnthemhs";
            this.btnthemhs.Size = new System.Drawing.Size(85, 23);
            this.btnthemhs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthemhs.TabIndex = 7;
            this.btnthemhs.Text = "Thêm học sinh";
            this.btnthemhs.Click += new System.EventHandler(this.btnthemhs_Click);
            // 
            // dshs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(632, 400);
            this.Controls.Add(this.btnthemhs);
            this.Controls.Add(this.closehs);
            this.Controls.Add(this.btnxoahs);
            this.Controls.Add(this.btnsuahs);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxDropDown1);
            this.Controls.Add(this.griddshs);
            this.Name = "dshs";
            this.Text = "Danh sách học sinh";
            this.Load += new System.EventHandler(this.dshs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.griddshs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX griddshs;
        private DevComponents.DotNetBar.Controls.TextBoxDropDown textBoxDropDown1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnxem;
        private DevComponents.DotNetBar.ButtonX btnsuahs;
        private DevComponents.DotNetBar.ButtonX btnxoahs;
        private DevComponents.DotNetBar.ButtonX closehs;
        private DevComponents.DotNetBar.ButtonX btnthemhs;
    }
}