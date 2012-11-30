namespace QLD
{
    partial class fbaocaohocs
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.viewdshsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_dshs = new QLD.data_dshs();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.viewdshsTableAdapter = new QLD.data_dshsTableAdapters.viewdshsTableAdapter();
            this.btnxembc = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.lbnam = new System.Windows.Forms.Label();
            this.cblop = new System.Windows.Forms.ComboBox();
            this.cbnamhoc = new System.Windows.Forms.ComboBox();
            this.listnamhocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commonData = new QLD.CommonData();
            this.list_namhocTableAdapter = new QLD.CommonDataTableAdapters.list_namhocTableAdapter();
            this.listlopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.list_lopTableAdapter = new QLD.CommonDataTableAdapters.list_lopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewdshsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_dshs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listnamhocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listlopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // viewdshsBindingSource
            // 
            this.viewdshsBindingSource.DataMember = "viewdshs";
            this.viewdshsBindingSource.DataSource = this.data_dshs;
            // 
            // data_dshs
            // 
            this.data_dshs.DataSetName = "data_dshs";
            this.data_dshs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "data_dshs_viewdshs";
            reportDataSource2.Value = this.viewdshsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLD.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 81);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(798, 445);
            this.reportViewer1.TabIndex = 0;
            // 
            // viewdshsTableAdapter
            // 
            this.viewdshsTableAdapter.ClearBeforeFill = true;
            // 
            // btnxembc
            // 
            this.btnxembc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxembc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxembc.Location = new System.Drawing.Point(576, 22);
            this.btnxembc.Name = "btnxembc";
            this.btnxembc.Size = new System.Drawing.Size(60, 23);
            this.btnxembc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxembc.TabIndex = 26;
            this.btnxembc.Text = "Xem";
            this.btnxembc.Click += new System.EventHandler(this.btnxembc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(347, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Lớp";
            // 
            // lbnam
            // 
            this.lbnam.AutoSize = true;
            this.lbnam.BackColor = System.Drawing.Color.Transparent;
            this.lbnam.Location = new System.Drawing.Point(123, 26);
            this.lbnam.Name = "lbnam";
            this.lbnam.Size = new System.Drawing.Size(76, 13);
            this.lbnam.TabIndex = 24;
            this.lbnam.Text = "Chọn năm học";
            // 
            // cblop
            // 
            this.cblop.DataSource = this.listlopBindingSource;
            this.cblop.DisplayMember = "tenlop";
            this.cblop.FormattingEnabled = true;
            this.cblop.Location = new System.Drawing.Point(378, 23);
            this.cblop.Name = "cblop";
            this.cblop.Size = new System.Drawing.Size(128, 21);
            this.cblop.TabIndex = 23;
            this.cblop.ValueMember = "maLop";
            // 
            // cbnamhoc
            // 
            this.cbnamhoc.DataSource = this.listnamhocBindingSource;
            this.cbnamhoc.DisplayMember = "tennamhoc";
            this.cbnamhoc.FormattingEnabled = true;
            this.cbnamhoc.Location = new System.Drawing.Point(208, 22);
            this.cbnamhoc.Name = "cbnamhoc";
            this.cbnamhoc.Size = new System.Drawing.Size(121, 21);
            this.cbnamhoc.TabIndex = 22;
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
            // fbaocaohocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QLD.Properties.Resources.hoavantrongdongvl5;
            this.ClientSize = new System.Drawing.Size(799, 528);
            this.Controls.Add(this.btnxembc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbnam);
            this.Controls.Add(this.cblop);
            this.Controls.Add(this.cbnamhoc);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fbaocaohocs";
            this.Text = "fbaocaohocs";
            this.Load += new System.EventHandler(this.fbaocaohocs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewdshsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_dshs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listnamhocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commonData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listlopBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource viewdshsBindingSource;
        private data_dshs data_dshs;
        private QLD.data_dshsTableAdapters.viewdshsTableAdapter viewdshsTableAdapter;
        private DevComponents.DotNetBar.ButtonX btnxembc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbnam;
        private System.Windows.Forms.ComboBox cblop;
        private System.Windows.Forms.ComboBox cbnamhoc;
        private CommonData commonData;
        private System.Windows.Forms.BindingSource listnamhocBindingSource;
        private QLD.CommonDataTableAdapters.list_namhocTableAdapter list_namhocTableAdapter;
        private System.Windows.Forms.BindingSource listlopBindingSource;
        private QLD.CommonDataTableAdapters.list_lopTableAdapter list_lopTableAdapter;
    }
}