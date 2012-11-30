namespace QLD
{
    partial class fbaocaotket
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.viewdiemhsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDiem = new QLD.DataSetDiem();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.viewdiemhsTableAdapter = new QLD.DataSetDiemTableAdapters.viewdiemhsTableAdapter();
            this.cbnamhoc = new System.Windows.Forms.ComboBox();
            this.listnamhocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commonData = new QLD.CommonData();
            this.cblop = new System.Windows.Forms.ComboBox();
            this.listlopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbnam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbmon = new System.Windows.Forms.ComboBox();
            this.listmonhocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.list_namhocTableAdapter = new QLD.CommonDataTableAdapters.list_namhocTableAdapter();
            this.list_monhocTableAdapter = new QLD.CommonDataTableAdapters.list_monhocTableAdapter();
            this.list_lopTableAdapter = new QLD.CommonDataTableAdapters.list_lopTableAdapter();
            this.btnxembc = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.viewdiemhsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listnamhocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listlopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listmonhocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // viewdiemhsBindingSource
            // 
            this.viewdiemhsBindingSource.DataMember = "viewdiemhs";
            this.viewdiemhsBindingSource.DataSource = this.dataSetDiem;
            // 
            // dataSetDiem
            // 
            this.dataSetDiem.DataSetName = "DataSetDiem";
            this.dataSetDiem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetDiem_viewdiemhs";
            reportDataSource1.Value = this.viewdiemhsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLD.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-13, 42);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(685, 599);
            this.reportViewer1.TabIndex = 0;
            // 
            // viewdiemhsTableAdapter
            // 
            this.viewdiemhsTableAdapter.ClearBeforeFill = true;
            // 
            // cbnamhoc
            // 
            this.cbnamhoc.DataSource = this.listnamhocBindingSource;
            this.cbnamhoc.DisplayMember = "tennamhoc";
            this.cbnamhoc.FormattingEnabled = true;
            this.cbnamhoc.Location = new System.Drawing.Point(106, 14);
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
            // cblop
            // 
            this.cblop.DataSource = this.listlopBindingSource;
            this.cblop.DisplayMember = "tenlop";
            this.cblop.FormattingEnabled = true;
            this.cblop.Location = new System.Drawing.Point(276, 15);
            this.cblop.Name = "cblop";
            this.cblop.Size = new System.Drawing.Size(128, 21);
            this.cblop.TabIndex = 2;
            this.cblop.ValueMember = "maLop";
            // 
            // listlopBindingSource
            // 
            this.listlopBindingSource.DataMember = "list_lop";
            this.listlopBindingSource.DataSource = this.commonData;
            // 
            // lbnam
            // 
            this.lbnam.AutoSize = true;
            this.lbnam.BackColor = System.Drawing.Color.Transparent;
            this.lbnam.Location = new System.Drawing.Point(21, 18);
            this.lbnam.Name = "lbnam";
            this.lbnam.Size = new System.Drawing.Size(76, 13);
            this.lbnam.TabIndex = 3;
            this.lbnam.Text = "Chọn năm học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(245, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(415, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Môn";
            // 
            // cbmon
            // 
            this.cbmon.DataSource = this.listmonhocBindingSource;
            this.cbmon.DisplayMember = "tenmon";
            this.cbmon.FormattingEnabled = true;
            this.cbmon.Location = new System.Drawing.Point(449, 14);
            this.cbmon.Name = "cbmon";
            this.cbmon.Size = new System.Drawing.Size(121, 21);
            this.cbmon.TabIndex = 6;
            this.cbmon.ValueMember = "mamon";
            // 
            // listmonhocBindingSource
            // 
            this.listmonhocBindingSource.DataMember = "list_monhoc";
            this.listmonhocBindingSource.DataSource = this.commonData;
            // 
            // list_namhocTableAdapter
            // 
            this.list_namhocTableAdapter.ClearBeforeFill = true;
            // 
            // list_monhocTableAdapter
            // 
            this.list_monhocTableAdapter.ClearBeforeFill = true;
            // 
            // list_lopTableAdapter
            // 
            this.list_lopTableAdapter.ClearBeforeFill = true;
            // 
            // btnxembc
            // 
            this.btnxembc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxembc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxembc.Location = new System.Drawing.Point(597, 12);
            this.btnxembc.Name = "btnxembc";
            this.btnxembc.Size = new System.Drawing.Size(60, 23);
            this.btnxembc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxembc.TabIndex = 14;
            this.btnxembc.Text = "Xem";
            this.btnxembc.Click += new System.EventHandler(this.btnxembc_Click);
            // 
            // fbaocaotket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QLD.Properties.Resources.hoavantrongdongvl5;
            this.ClientSize = new System.Drawing.Size(673, 640);
            this.Controls.Add(this.btnxembc);
            this.Controls.Add(this.cbmon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbnam);
            this.Controls.Add(this.cblop);
            this.Controls.Add(this.cbnamhoc);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fbaocaotket";
            this.Text = "fbaocaotket";
            this.Load += new System.EventHandler(this.fbaocaotket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewdiemhsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listnamhocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listlopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listmonhocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetDiem dataSetDiem;
        private System.Windows.Forms.BindingSource viewdiemhsBindingSource;
        private QLD.DataSetDiemTableAdapters.viewdiemhsTableAdapter viewdiemhsTableAdapter;
        private System.Windows.Forms.ComboBox cbnamhoc;
        private System.Windows.Forms.ComboBox cblop;
        private System.Windows.Forms.Label lbnam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbmon;
        private CommonData commonData;
        private System.Windows.Forms.BindingSource listnamhocBindingSource;
        private QLD.CommonDataTableAdapters.list_namhocTableAdapter list_namhocTableAdapter;
        private System.Windows.Forms.BindingSource listmonhocBindingSource;
        private QLD.CommonDataTableAdapters.list_monhocTableAdapter list_monhocTableAdapter;
        private System.Windows.Forms.BindingSource listlopBindingSource;
        private QLD.CommonDataTableAdapters.list_lopTableAdapter list_lopTableAdapter;
        private DevComponents.DotNetBar.ButtonX btnxembc;
    }
}