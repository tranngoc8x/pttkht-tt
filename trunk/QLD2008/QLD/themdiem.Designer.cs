namespace QLD
{
    partial class themdiem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbmon = new System.Windows.Forms.ComboBox();
            this.listmonhocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commonData = new QLD.CommonData();
            this.cbhocky = new System.Windows.Forms.ComboBox();
            this.cbhocsinh = new System.Windows.Forms.ComboBox();
            this.selectHSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cblop = new System.Windows.Forms.ComboBox();
            this.listlopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbnamhoc = new System.Windows.Forms.ComboBox();
            this.listnamhocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnhuy = new DevComponents.DotNetBar.ButtonX();
            this.btnthoatdiem = new DevComponents.DotNetBar.ButtonX();
            this.btnxoadiem = new DevComponents.DotNetBar.ButtonX();
            this.btnsuadiem = new DevComponents.DotNetBar.ButtonX();
            this.btnthemdiem = new DevComponents.DotNetBar.ButtonX();
            this.griddiem = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txttb = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtthi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txt45p = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txt15p = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.list_namhocTableAdapter = new QLD.CommonDataTableAdapters.list_namhocTableAdapter();
            this.list_lopTableAdapter = new QLD.CommonDataTableAdapters.list_lopTableAdapter();
            this.list_monhocTableAdapter = new QLD.CommonDataTableAdapters.list_monhocTableAdapter();
            this.selectHSTableAdapter = new QLD.CommonDataTableAdapters.selectHSTableAdapter();
            this.dataSetDiem = new QLD.DataSetDiem();
            this.viewlistdiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_listdiemTableAdapter = new QLD.CommonDataTableAdapters.view_listdiemTableAdapter();
            this.mahsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hockyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem15DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem1tietDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemthiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listmonhocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectHSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listlopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listnamhocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griddiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewlistdiemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbmon
            // 
            this.cbmon.DataSource = this.listmonhocBindingSource;
            this.cbmon.DisplayMember = "tenmon";
            this.cbmon.FormattingEnabled = true;
            this.cbmon.Location = new System.Drawing.Point(143, 168);
            this.cbmon.Name = "cbmon";
            this.cbmon.Size = new System.Drawing.Size(121, 21);
            this.cbmon.TabIndex = 25;
            this.cbmon.ValueMember = "mamon";
            // 
            // listmonhocBindingSource
            // 
            this.listmonhocBindingSource.DataMember = "list_monhoc";
            this.listmonhocBindingSource.DataSource = this.commonData;
            // 
            // commonData
            // 
            this.commonData.DataSetName = "CommonData";
            this.commonData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbhocky
            // 
            this.cbhocky.FormattingEnabled = true;
            this.cbhocky.Items.AddRange(new object[] {
            "Học kỳ 1",
            "Học kỳ 2"});
            this.cbhocky.Location = new System.Drawing.Point(144, 130);
            this.cbhocky.Name = "cbhocky";
            this.cbhocky.Size = new System.Drawing.Size(121, 21);
            this.cbhocky.TabIndex = 24;
            // 
            // cbhocsinh
            // 
            this.cbhocsinh.DataSource = this.selectHSBindingSource;
            this.cbhocsinh.DisplayMember = "hoten";
            this.cbhocsinh.FormattingEnabled = true;
            this.cbhocsinh.Location = new System.Drawing.Point(144, 93);
            this.cbhocsinh.Name = "cbhocsinh";
            this.cbhocsinh.Size = new System.Drawing.Size(121, 21);
            this.cbhocsinh.TabIndex = 23;
            this.cbhocsinh.ValueMember = "mahs";
            // 
            // selectHSBindingSource
            // 
            this.selectHSBindingSource.DataMember = "selectHS";
            this.selectHSBindingSource.DataSource = this.commonData;
            // 
            // cblop
            // 
            this.cblop.DataSource = this.listlopBindingSource;
            this.cblop.DisplayMember = "tenlop";
            this.cblop.FormattingEnabled = true;
            this.cblop.Location = new System.Drawing.Point(144, 58);
            this.cblop.Name = "cblop";
            this.cblop.Size = new System.Drawing.Size(121, 21);
            this.cblop.TabIndex = 22;
            this.cblop.ValueMember = "maLop";
            this.cblop.SelectedIndexChanged += new System.EventHandler(this.cblop_SelectedIndexChanged);
            // 
            // listlopBindingSource
            // 
            this.listlopBindingSource.DataMember = "list_lop";
            this.listlopBindingSource.DataSource = this.commonData;
            // 
            // cbnamhoc
            // 
            this.cbnamhoc.DataSource = this.listnamhocBindingSource;
            this.cbnamhoc.DisplayMember = "tennamhoc";
            this.cbnamhoc.FormattingEnabled = true;
            this.cbnamhoc.Location = new System.Drawing.Point(144, 24);
            this.cbnamhoc.Name = "cbnamhoc";
            this.cbnamhoc.Size = new System.Drawing.Size(121, 21);
            this.cbnamhoc.TabIndex = 19;
            this.cbnamhoc.ValueMember = "manamhoc";
            this.cbnamhoc.SelectedIndexChanged += new System.EventHandler(this.cbnamhoc_SelectedIndexChanged);
            // 
            // listnamhocBindingSource
            // 
            this.listnamhocBindingSource.DataMember = "list_namhoc";
            this.listnamhocBindingSource.DataSource = this.commonData;
            // 
            // btnhuy
            // 
            this.btnhuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnhuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnhuy.Location = new System.Drawing.Point(520, 164);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnhuy.TabIndex = 34;
            this.btnhuy.Text = "Hủy";
            // 
            // btnthoatdiem
            // 
            this.btnthoatdiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthoatdiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthoatdiem.Location = new System.Drawing.Point(410, 435);
            this.btnthoatdiem.Name = "btnthoatdiem";
            this.btnthoatdiem.Size = new System.Drawing.Size(75, 23);
            this.btnthoatdiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthoatdiem.TabIndex = 39;
            this.btnthoatdiem.Text = "Thoát";
            this.btnthoatdiem.Click += new System.EventHandler(this.btnthoatdiem_Click);
            // 
            // btnxoadiem
            // 
            this.btnxoadiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxoadiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxoadiem.Location = new System.Drawing.Point(260, 435);
            this.btnxoadiem.Name = "btnxoadiem";
            this.btnxoadiem.Size = new System.Drawing.Size(107, 23);
            this.btnxoadiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxoadiem.TabIndex = 37;
            this.btnxoadiem.Text = "Xóa thông tin điểm";
            this.btnxoadiem.Click += new System.EventHandler(this.btnxoadiem_Click);
            // 
            // btnsuadiem
            // 
            this.btnsuadiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnsuadiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnsuadiem.Location = new System.Drawing.Point(143, 435);
            this.btnsuadiem.Name = "btnsuadiem";
            this.btnsuadiem.Size = new System.Drawing.Size(75, 23);
            this.btnsuadiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnsuadiem.TabIndex = 36;
            this.btnsuadiem.Text = "Sửa điểm";
            this.btnsuadiem.Click += new System.EventHandler(this.btnsuadiem_Click);
            // 
            // btnthemdiem
            // 
            this.btnthemdiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthemdiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthemdiem.Location = new System.Drawing.Point(391, 164);
            this.btnthemdiem.Name = "btnthemdiem";
            this.btnthemdiem.Size = new System.Drawing.Size(100, 23);
            this.btnthemdiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthemdiem.TabIndex = 33;
            this.btnthemdiem.Text = "Lưu điểm";
            this.btnthemdiem.Click += new System.EventHandler(this.btnthemdiem_Click);
            // 
            // griddiem
            // 
            this.griddiem.AutoGenerateColumns = false;
            this.griddiem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.griddiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griddiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahsDataGridViewTextBoxColumn,
            this.hotenDataGridViewTextBoxColumn,
            this.tenlopDataGridViewTextBoxColumn,
            this.hockyDataGridViewTextBoxColumn,
            this.diem15DataGridViewTextBoxColumn,
            this.diem1tietDataGridViewTextBoxColumn,
            this.diemthiDataGridViewTextBoxColumn,
            this.mamonDataGridViewTextBoxColumn});
            this.griddiem.DataSource = this.viewlistdiemBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.griddiem.DefaultCellStyle = dataGridViewCellStyle5;
            this.griddiem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.griddiem.Location = new System.Drawing.Point(11, 204);
            this.griddiem.Name = "griddiem";
            this.griddiem.Size = new System.Drawing.Size(706, 215);
            this.griddiem.TabIndex = 42;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(391, 124);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 23);
            this.labelX9.TabIndex = 41;
            this.labelX9.Text = "Trung bình";
            // 
            // txttb
            // 
            // 
            // 
            // 
            this.txttb.Border.Class = "TextBoxBorder";
            this.txttb.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttb.Location = new System.Drawing.Point(495, 122);
            this.txttb.Name = "txttb";
            this.txttb.ReadOnly = true;
            this.txttb.Size = new System.Drawing.Size(100, 20);
            this.txttb.TabIndex = 100;
            // 
            // txtthi
            // 
            // 
            // 
            // 
            this.txtthi.Border.Class = "TextBoxBorder";
            this.txtthi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtthi.Location = new System.Drawing.Point(495, 89);
            this.txtthi.Name = "txtthi";
            this.txtthi.Size = new System.Drawing.Size(100, 20);
            this.txtthi.TabIndex = 30;
            this.txtthi.TextChanged += new System.EventHandler(this.txtthi_TextChanged);
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(391, 92);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 23);
            this.labelX8.TabIndex = 40;
            this.labelX8.Text = "Điểm thi";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(391, 57);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 38;
            this.labelX7.Text = "Điểm 1 tiết";
            // 
            // txt45p
            // 
            // 
            // 
            // 
            this.txt45p.Border.Class = "TextBoxBorder";
            this.txt45p.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt45p.Location = new System.Drawing.Point(495, 57);
            this.txt45p.Name = "txt45p";
            this.txt45p.Size = new System.Drawing.Size(100, 20);
            this.txt45p.TabIndex = 29;
            this.txt45p.TextChanged += new System.EventHandler(this.txt45p_TextChanged);
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(391, 21);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 35;
            this.labelX6.Text = "Điểm 15 \'";
            // 
            // txt15p
            // 
            // 
            // 
            // 
            this.txt15p.Border.Class = "TextBoxBorder";
            this.txt15p.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt15p.Location = new System.Drawing.Point(495, 24);
            this.txt15p.Name = "txt15p";
            this.txt15p.Size = new System.Drawing.Size(100, 20);
            this.txt15p.TabIndex = 27;
            this.txt15p.TextChanged += new System.EventHandler(this.txt15p_TextChanged);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(72, 167);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(65, 23);
            this.labelX5.TabIndex = 31;
            this.labelX5.Text = "Môn học";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(72, 129);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(65, 23);
            this.labelX4.TabIndex = 28;
            this.labelX4.Text = "Học kỳ";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(72, 92);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(65, 23);
            this.labelX3.TabIndex = 26;
            this.labelX3.Text = "Học sinh";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(72, 56);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(65, 23);
            this.labelX2.TabIndex = 21;
            this.labelX2.Text = "Lớp";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(72, 23);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(65, 23);
            this.labelX1.TabIndex = 20;
            this.labelX1.Text = "Năm học";
            // 
            // list_namhocTableAdapter
            // 
            this.list_namhocTableAdapter.ClearBeforeFill = true;
            // 
            // list_lopTableAdapter
            // 
            this.list_lopTableAdapter.ClearBeforeFill = true;
            // 
            // list_monhocTableAdapter
            // 
            this.list_monhocTableAdapter.ClearBeforeFill = true;
            // 
            // selectHSTableAdapter
            // 
            this.selectHSTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetDiem
            // 
            this.dataSetDiem.DataSetName = "DataSetDiem";
            this.dataSetDiem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewlistdiemBindingSource
            // 
            this.viewlistdiemBindingSource.DataMember = "view_listdiem";
            this.viewlistdiemBindingSource.DataSource = this.commonData;
            // 
            // view_listdiemTableAdapter
            // 
            this.view_listdiemTableAdapter.ClearBeforeFill = true;
            // 
            // mahsDataGridViewTextBoxColumn
            // 
            this.mahsDataGridViewTextBoxColumn.DataPropertyName = "mahs";
            this.mahsDataGridViewTextBoxColumn.HeaderText = "mahs";
            this.mahsDataGridViewTextBoxColumn.Name = "mahsDataGridViewTextBoxColumn";
            // 
            // hotenDataGridViewTextBoxColumn
            // 
            this.hotenDataGridViewTextBoxColumn.DataPropertyName = "hoten";
            this.hotenDataGridViewTextBoxColumn.HeaderText = "hoten";
            this.hotenDataGridViewTextBoxColumn.Name = "hotenDataGridViewTextBoxColumn";
            // 
            // tenlopDataGridViewTextBoxColumn
            // 
            this.tenlopDataGridViewTextBoxColumn.DataPropertyName = "tenlop";
            this.tenlopDataGridViewTextBoxColumn.HeaderText = "tenlop";
            this.tenlopDataGridViewTextBoxColumn.Name = "tenlopDataGridViewTextBoxColumn";
            // 
            // hockyDataGridViewTextBoxColumn
            // 
            this.hockyDataGridViewTextBoxColumn.DataPropertyName = "hocky";
            this.hockyDataGridViewTextBoxColumn.HeaderText = "hocky";
            this.hockyDataGridViewTextBoxColumn.Name = "hockyDataGridViewTextBoxColumn";
            // 
            // diem15DataGridViewTextBoxColumn
            // 
            this.diem15DataGridViewTextBoxColumn.DataPropertyName = "diem15";
            this.diem15DataGridViewTextBoxColumn.HeaderText = "diem15";
            this.diem15DataGridViewTextBoxColumn.Name = "diem15DataGridViewTextBoxColumn";
            // 
            // diem1tietDataGridViewTextBoxColumn
            // 
            this.diem1tietDataGridViewTextBoxColumn.DataPropertyName = "diem1tiet";
            this.diem1tietDataGridViewTextBoxColumn.HeaderText = "diem1tiet";
            this.diem1tietDataGridViewTextBoxColumn.Name = "diem1tietDataGridViewTextBoxColumn";
            // 
            // diemthiDataGridViewTextBoxColumn
            // 
            this.diemthiDataGridViewTextBoxColumn.DataPropertyName = "diemthi";
            this.diemthiDataGridViewTextBoxColumn.HeaderText = "diemthi";
            this.diemthiDataGridViewTextBoxColumn.Name = "diemthiDataGridViewTextBoxColumn";
            // 
            // mamonDataGridViewTextBoxColumn
            // 
            this.mamonDataGridViewTextBoxColumn.DataPropertyName = "mamon";
            this.mamonDataGridViewTextBoxColumn.HeaderText = "mamon";
            this.mamonDataGridViewTextBoxColumn.Name = "mamonDataGridViewTextBoxColumn";
            // 
            // themdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLD.Properties.Resources.hoavantrongdongvl5;
            this.ClientSize = new System.Drawing.Size(728, 487);
            this.Controls.Add(this.cbmon);
            this.Controls.Add(this.cbhocky);
            this.Controls.Add(this.cbhocsinh);
            this.Controls.Add(this.cblop);
            this.Controls.Add(this.cbnamhoc);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnthoatdiem);
            this.Controls.Add(this.btnxoadiem);
            this.Controls.Add(this.btnsuadiem);
            this.Controls.Add(this.btnthemdiem);
            this.Controls.Add(this.griddiem);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.txttb);
            this.Controls.Add(this.txtthi);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.txt45p);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.txt15p);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Name = "themdiem";
            this.Text = "Nhập điểm";
            this.Load += new System.EventHandler(this.themdiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listmonhocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectHSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listlopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listnamhocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griddiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewlistdiemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmon;
        private System.Windows.Forms.ComboBox cbhocky;
        private System.Windows.Forms.ComboBox cbhocsinh;
        private System.Windows.Forms.ComboBox cblop;
        private System.Windows.Forms.ComboBox cbnamhoc;
        private DevComponents.DotNetBar.ButtonX btnhuy;
        private DevComponents.DotNetBar.ButtonX btnthoatdiem;
        private DevComponents.DotNetBar.ButtonX btnxoadiem;
        private DevComponents.DotNetBar.ButtonX btnsuadiem;
        private DevComponents.DotNetBar.ButtonX btnthemdiem;
        private DevComponents.DotNetBar.Controls.DataGridViewX griddiem;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txttb;
        private DevComponents.DotNetBar.Controls.TextBoxX txtthi;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txt45p;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txt15p;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private CommonData commonData;
        private System.Windows.Forms.BindingSource listnamhocBindingSource;
        private QLD.CommonDataTableAdapters.list_namhocTableAdapter list_namhocTableAdapter;
        private System.Windows.Forms.BindingSource listlopBindingSource;
        private QLD.CommonDataTableAdapters.list_lopTableAdapter list_lopTableAdapter;
        private System.Windows.Forms.BindingSource listmonhocBindingSource;
        private QLD.CommonDataTableAdapters.list_monhocTableAdapter list_monhocTableAdapter;
        private System.Windows.Forms.BindingSource selectHSBindingSource;
        private QLD.CommonDataTableAdapters.selectHSTableAdapter selectHSTableAdapter;
        private DataSetDiem dataSetDiem;
        private System.Windows.Forms.BindingSource viewlistdiemBindingSource;
        private QLD.CommonDataTableAdapters.view_listdiemTableAdapter view_listdiemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hockyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem15DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem1tietDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemthiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamonDataGridViewTextBoxColumn;

    }
}