namespace QLD
{
    partial class fbaocaohocsinh
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
            this.viewdshsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_dshs = new QLD.data_dshs();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.viewdshsTableAdapter = new QLD.data_dshsTableAdapters.viewdshsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewdshsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_dshs)).BeginInit();
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
            reportDataSource1.Name = "data_dshs_viewdshs";
            reportDataSource1.Value = this.viewdshsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLD.rep_dshs.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 39);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(786, 539);
            this.reportViewer1.TabIndex = 0;
            // 
            // viewdshsTableAdapter
            // 
            this.viewdshsTableAdapter.ClearBeforeFill = true;
            // 
            // frp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 598);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frp";
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.frp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewdshsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_dshs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource viewdshsBindingSource;
        private data_dshs data_dshs;
        private QLD.data_dshsTableAdapters.viewdshsTableAdapter viewdshsTableAdapter;


    }
}