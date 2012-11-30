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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.griddshs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnxem = new DevComponents.DotNetBar.ButtonX();
            this.btnsuahs = new DevComponents.DotNetBar.ButtonX();
            this.btnxoahs = new DevComponents.DotNetBar.ButtonX();
            this.closehs = new DevComponents.DotNetBar.ButtonX();
            this.btnthemhs = new DevComponents.DotNetBar.ButtonX();
            this.cblop = new System.Windows.Forms.ComboBox();
            this.cbnamhoc = new System.Windows.Forms.ComboBox();
            this.listnamhocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commonData = new QLD.CommonData();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.list_namhocTableAdapter = new QLD.CommonDataTableAdapters.list_namhocTableAdapter();
            this.listlopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.list_lopTableAdapter = new QLD.CommonDataTableAdapters.list_lopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.griddshs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listnamhocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listlopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // griddshs
            // 
            this.griddshs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.griddshs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.griddshs.DefaultCellStyle = dataGridViewCellStyle8;
            this.griddshs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.griddshs.Location = new System.Drawing.Point(12, 76);
            this.griddshs.Name = "griddshs";
            this.griddshs.Size = new System.Drawing.Size(608, 260);
            this.griddshs.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(321, 34);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(51, 19);
            this.labelX1.TabIndex = 20;
            this.labelX1.Text = "Chọn lớp";
            // 
            // btnxem
            // 
            this.btnxem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxem.Location = new System.Drawing.Point(484, 34);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(75, 21);
            this.btnxem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxem.TabIndex = 3;
            this.btnxem.Text = "Xem";
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // btnsuahs
            // 
            this.btnsuahs.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsuahs.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsuahs.Location = new System.Drawing.Point(210, 357);
            this.btnsuahs.Name = "btnsuahs";
            this.btnsuahs.Size = new System.Drawing.Size(75, 23);
            this.btnsuahs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsuahs.TabIndex = 5;
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
            this.btnxoahs.TabIndex = 6;
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
            this.closehs.TabIndex = 7;
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
            this.btnthemhs.TabIndex = 4;
            this.btnthemhs.Text = "Thêm học sinh";
            this.btnthemhs.Click += new System.EventHandler(this.btnthemhs_Click);
            // 
            // cblop
            // 
            this.cblop.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listlopBindingSource, "tenlop", true));
            this.cblop.DataSource = this.listlopBindingSource;
            this.cblop.DisplayMember = "tenlop";
            this.cblop.FormattingEnabled = true;
            this.cblop.ItemHeight = 13;
            this.cblop.Location = new System.Drawing.Point(373, 34);
            this.cblop.Name = "cblop";
            this.cblop.Size = new System.Drawing.Size(105, 21);
            this.cblop.TabIndex = 2;
            this.cblop.ValueMember = "maLop";
            // 
            // cbnamhoc
            // 
            this.cbnamhoc.DataSource = this.listnamhocBindingSource;
            this.cbnamhoc.DisplayMember = "tennamhoc";
            this.cbnamhoc.FormattingEnabled = true;
            this.cbnamhoc.Location = new System.Drawing.Point(146, 34);
            this.cbnamhoc.Name = "cbnamhoc";
            this.cbnamhoc.Size = new System.Drawing.Size(121, 21);
            this.cbnamhoc.TabIndex = 1;
            this.cbnamhoc.ValueMember = "manamhoc";
            this.cbnamhoc.SelectedIndexChanged += new System.EventHandler(this.cbnamhoc_SelectedIndexChanged);
            // 
            // listnamhocBindingSource
            // 
            this.listnamhocBindingSource.DataMember = "list_namhoc";
            this.listnamhocBindingSource.DataSource = this.commonData;
            // 
            // commonData
            // 
            this.commonData.DataSetName = "CommonData";
            this.commonData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(65, 35);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 19);
            this.labelX2.TabIndex = 10;
            this.labelX2.Text = "Chọn năn học";
            // 
            // list_namhocTableAdapter
            // 
            this.list_namhocTableAdapter.ClearBeforeFill = true;
            // 
            // listlopBindingSource
            // 
            this.listlopBindingSource.DataMember = "list_lop";
            this.listlopBindingSource.DataSource = this.commonData;
            // 
            // list_lopTableAdapter
            // 
            this.list_lopTableAdapter.ClearBeforeFill = true;
            // 
            // dshs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(632, 400);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cbnamhoc);
            this.Controls.Add(this.cblop);
            this.Controls.Add(this.btnthemhs);
            this.Controls.Add(this.closehs);
            this.Controls.Add(this.btnxoahs);
            this.Controls.Add(this.btnsuahs);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.griddshs);
            this.Name = "dshs";
            this.Text = "Danh sách học sinh";
            this.Load += new System.EventHandler(this.dshs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.griddshs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listnamhocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listlopBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX griddshs;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnxem;
        private DevComponents.DotNetBar.ButtonX btnsuahs;
        private DevComponents.DotNetBar.ButtonX btnxoahs;
        private DevComponents.DotNetBar.ButtonX closehs;
        private DevComponents.DotNetBar.ButtonX btnthemhs;
        private System.Windows.Forms.ComboBox cblop;
        private System.Windows.Forms.ComboBox cbnamhoc;
        private DevComponents.DotNetBar.LabelX labelX2;
        private CommonData commonData;
        private System.Windows.Forms.BindingSource listnamhocBindingSource;
        private QLD.CommonDataTableAdapters.list_namhocTableAdapter list_namhocTableAdapter;
        private System.Windows.Forms.BindingSource listlopBindingSource;
        private QLD.CommonDataTableAdapters.list_lopTableAdapter list_lopTableAdapter;
    }
}