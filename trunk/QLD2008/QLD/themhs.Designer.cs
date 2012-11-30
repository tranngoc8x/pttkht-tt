namespace QLD
{
    partial class themhs
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
            this.txtmahs = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txthoten = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtque = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txttongiao = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtuutien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtbo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtnbo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txtme = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.txtnme = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.btnthemhs = new DevComponents.DotNetBar.ButtonX();
            this.btnclosethemhs = new DevComponents.DotNetBar.ButtonX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.btnhuy = new DevComponents.DotNetBar.ButtonX();
            this.cbgioitinh = new System.Windows.Forms.ComboBox();
            this.cblop = new System.Windows.Forms.ComboBox();
            this.listlopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commonData = new QLD.CommonData();
            this.cbnamhoc = new System.Windows.Forms.ComboBox();
            this.listnamhocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.list_namhocTableAdapter = new QLD.CommonDataTableAdapters.list_namhocTableAdapter();
            this.list_lopTableAdapter = new QLD.CommonDataTableAdapters.list_lopTableAdapter();
            this.txtngaysinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.listlopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listnamhocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmahs
            // 
            // 
            // 
            // 
            this.txtmahs.Border.Class = "TextBoxBorder";
            this.txtmahs.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmahs.Location = new System.Drawing.Point(130, 49);
            this.txtmahs.Name = "txtmahs";
            this.txtmahs.Size = new System.Drawing.Size(127, 20);
            this.txtmahs.TabIndex = 0;
            // 
            // txthoten
            // 
            // 
            // 
            // 
            this.txthoten.Border.Class = "TextBoxBorder";
            this.txthoten.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txthoten.Location = new System.Drawing.Point(130, 90);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(127, 20);
            this.txthoten.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(38, 91);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 19);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Họ tên";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(38, 46);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "Mã học sinh";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(38, 126);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "Ngày sinh";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(38, 175);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 10;
            this.labelX4.Text = "Giới tính";
            // 
            // txtque
            // 
            // 
            // 
            // 
            this.txtque.Border.Class = "TextBoxBorder";
            this.txtque.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtque.Location = new System.Drawing.Point(493, 48);
            this.txtque.Multiline = true;
            this.txtque.Name = "txtque";
            this.txtque.Size = new System.Drawing.Size(184, 64);
            this.txtque.TabIndex = 12;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(412, 61);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(64, 23);
            this.labelX5.TabIndex = 13;
            this.labelX5.Text = "Quê quán";
            // 
            // txttongiao
            // 
            // 
            // 
            // 
            this.txttongiao.Border.Class = "TextBoxBorder";
            this.txttongiao.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttongiao.Location = new System.Drawing.Point(130, 215);
            this.txttongiao.Name = "txttongiao";
            this.txttongiao.Size = new System.Drawing.Size(127, 20);
            this.txttongiao.TabIndex = 14;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(38, 211);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 15;
            this.labelX6.Text = "Tôn giáo";
            // 
            // txtuutien
            // 
            // 
            // 
            // 
            this.txtuutien.Border.Class = "TextBoxBorder";
            this.txtuutien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtuutien.Location = new System.Drawing.Point(130, 255);
            this.txtuutien.Name = "txtuutien";
            this.txtuutien.Size = new System.Drawing.Size(127, 20);
            this.txtuutien.TabIndex = 16;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(38, 251);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 17;
            this.labelX7.Text = "Ưu tiên";
            // 
            // txtbo
            // 
            // 
            // 
            // 
            this.txtbo.Border.Class = "TextBoxBorder";
            this.txtbo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtbo.Location = new System.Drawing.Point(493, 133);
            this.txtbo.Name = "txtbo";
            this.txtbo.Size = new System.Drawing.Size(125, 20);
            this.txtbo.TabIndex = 18;
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(412, 131);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 23);
            this.labelX8.TabIndex = 19;
            this.labelX8.Text = "Họ tên bố";
            // 
            // txtnbo
            // 
            // 
            // 
            // 
            this.txtnbo.Border.Class = "TextBoxBorder";
            this.txtnbo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtnbo.Location = new System.Drawing.Point(493, 173);
            this.txtnbo.Multiline = true;
            this.txtnbo.Name = "txtnbo";
            this.txtnbo.Size = new System.Drawing.Size(184, 59);
            this.txtnbo.TabIndex = 20;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(412, 187);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 23);
            this.labelX9.TabIndex = 21;
            this.labelX9.Text = "Nghề nghiệp";
            // 
            // txtme
            // 
            // 
            // 
            // 
            this.txtme.Border.Class = "TextBoxBorder";
            this.txtme.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtme.Location = new System.Drawing.Point(493, 251);
            this.txtme.Name = "txtme";
            this.txtme.Size = new System.Drawing.Size(125, 20);
            this.txtme.TabIndex = 22;
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(412, 253);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(75, 23);
            this.labelX10.TabIndex = 23;
            this.labelX10.Text = "Họ tên mẹ";
            // 
            // txtnme
            // 
            // 
            // 
            // 
            this.txtnme.Border.Class = "TextBoxBorder";
            this.txtnme.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtnme.Location = new System.Drawing.Point(493, 289);
            this.txtnme.Multiline = true;
            this.txtnme.Name = "txtnme";
            this.txtnme.Size = new System.Drawing.Size(184, 57);
            this.txtnme.TabIndex = 24;
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(412, 306);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(75, 23);
            this.labelX11.TabIndex = 25;
            this.labelX11.Text = "Nghề nghiệp";
            // 
            // btnthemhs
            // 
            this.btnthemhs.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthemhs.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthemhs.Location = new System.Drawing.Point(253, 369);
            this.btnthemhs.Name = "btnthemhs";
            this.btnthemhs.Size = new System.Drawing.Size(75, 23);
            this.btnthemhs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnthemhs.TabIndex = 26;
            this.btnthemhs.Text = "Thêm mới";
            this.btnthemhs.Click += new System.EventHandler(this.btnthemhs_Click);
            // 
            // btnclosethemhs
            // 
            this.btnclosethemhs.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnclosethemhs.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnclosethemhs.Location = new System.Drawing.Point(465, 369);
            this.btnclosethemhs.Name = "btnclosethemhs";
            this.btnclosethemhs.Size = new System.Drawing.Size(75, 23);
            this.btnclosethemhs.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnclosethemhs.TabIndex = 27;
            this.btnclosethemhs.Text = "Đóng";
            this.btnclosethemhs.Click += new System.EventHandler(this.btnclosethemhs_Click);
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.Location = new System.Drawing.Point(246, 1);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(272, 35);
            this.labelX12.TabIndex = 28;
            this.labelX12.Text = "Thêm mới thông tin học sinh";
            // 
            // labelX13
            // 
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(38, 327);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(75, 23);
            this.labelX13.TabIndex = 29;
            this.labelX13.Text = "Lớp";
            // 
            // labelX14
            // 
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Location = new System.Drawing.Point(38, 288);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(75, 23);
            this.labelX14.TabIndex = 32;
            this.labelX14.Text = "Năm học";
            // 
            // btnhuy
            // 
            this.btnhuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnhuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnhuy.Location = new System.Drawing.Point(358, 369);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnhuy.TabIndex = 33;
            this.btnhuy.Text = "Nhập lại";
            // 
            // cbgioitinh
            // 
            this.cbgioitinh.FormattingEnabled = true;
            this.cbgioitinh.Location = new System.Drawing.Point(130, 176);
            this.cbgioitinh.Name = "cbgioitinh";
            this.cbgioitinh.Size = new System.Drawing.Size(126, 21);
            this.cbgioitinh.TabIndex = 34;
            // 
            // cblop
            // 
            this.cblop.DataSource = this.listlopBindingSource;
            this.cblop.DisplayMember = "tenlop";
            this.cblop.FormattingEnabled = true;
            this.cblop.Location = new System.Drawing.Point(131, 329);
            this.cblop.Name = "cblop";
            this.cblop.Size = new System.Drawing.Size(126, 21);
            this.cblop.TabIndex = 35;
            this.cblop.ValueMember = "maLop";
            // 
            // listlopBindingSource
            // 
            this.listlopBindingSource.DataMember = "list_lop";
            this.listlopBindingSource.DataSource = this.commonData;
            // 
            // commonData
            // 
            this.commonData.DataSetName = "CommonData";
            this.commonData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbnamhoc
            // 
            this.cbnamhoc.DataSource = this.listnamhocBindingSource;
            this.cbnamhoc.DisplayMember = "tennamhoc";
            this.cbnamhoc.FormattingEnabled = true;
            this.cbnamhoc.Location = new System.Drawing.Point(131, 290);
            this.cbnamhoc.Name = "cbnamhoc";
            this.cbnamhoc.Size = new System.Drawing.Size(126, 21);
            this.cbnamhoc.TabIndex = 36;
            this.cbnamhoc.ValueMember = "manamhoc";
            this.cbnamhoc.SelectedIndexChanged += new System.EventHandler(this.cbnamhoc_SelectedIndexChanged);
            // 
            // listnamhocBindingSource
            // 
            this.listnamhocBindingSource.DataMember = "list_namhoc";
            this.listnamhocBindingSource.DataSource = this.commonData;
            // 
            // list_namhocTableAdapter
            // 
            this.list_namhocTableAdapter.ClearBeforeFill = true;
            // 
            // list_lopTableAdapter
            // 
            this.list_lopTableAdapter.ClearBeforeFill = true;
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtngaysinh.Location = new System.Drawing.Point(130, 131);
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(127, 20);
            this.txtngaysinh.TabIndex = 37;
            // 
            // themhs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::QLD.Properties.Resources.hoavantrongdongvl5;
            this.ClientSize = new System.Drawing.Size(745, 404);
            this.Controls.Add(this.txtngaysinh);
            this.Controls.Add(this.cbnamhoc);
            this.Controls.Add(this.cblop);
            this.Controls.Add(this.cbgioitinh);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.labelX14);
            this.Controls.Add(this.labelX13);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.btnclosethemhs);
            this.Controls.Add(this.btnthemhs);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.txtnme);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.txtme);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.txtnbo);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.txtbo);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.txtuutien);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.txttongiao);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txtque);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtmahs);
            this.Name = "themhs";
            this.Text = "Thêm mới học sinh";
            this.Load += new System.EventHandler(this.themhs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listlopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listnamhocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtmahs;
        private DevComponents.DotNetBar.Controls.TextBoxX txthoten;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtque;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txttongiao;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtuutien;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtbo;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnbo;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtme;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnme;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.ButtonX btnthemhs;
        private DevComponents.DotNetBar.ButtonX btnclosethemhs;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.ButtonX btnhuy;
        private System.Windows.Forms.ComboBox cbgioitinh;
        private System.Windows.Forms.ComboBox cblop;
        private System.Windows.Forms.ComboBox cbnamhoc;
        private CommonData commonData;
        private System.Windows.Forms.BindingSource listnamhocBindingSource;
        private QLD.CommonDataTableAdapters.list_namhocTableAdapter list_namhocTableAdapter;
        private System.Windows.Forms.BindingSource listlopBindingSource;
        private QLD.CommonDataTableAdapters.list_lopTableAdapter list_lopTableAdapter;
        private System.Windows.Forms.DateTimePicker txtngaysinh;
    }
}