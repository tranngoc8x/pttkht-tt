namespace QLD
{
    partial class rpdiem
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
            this.QLDTHDataSet1 = new QLD.QLDTHDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.viewdiemhsTableAdapter = new QLD.QLDTHDataSet1TableAdapters.viewdiemhsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewdiemhsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLDTHDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewdiemhsBindingSource
            // 
            this.viewdiemhsBindingSource.DataMember = "viewdiemhs";
            this.viewdiemhsBindingSource.DataSource = this.QLDTHDataSet1;
            // 
            // QLDTHDataSet1
            // 
            this.QLDTHDataSet1.DataSetName = "QLDTHDataSet1";
            this.QLDTHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "QLDTHDataSet1_viewdiemhs";
            reportDataSource1.Value = this.viewdiemhsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLD.rep_diem.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1116, 684);
            this.reportViewer1.TabIndex = 0;
            // 
            // viewdiemhsTableAdapter
            // 
            this.viewdiemhsTableAdapter.ClearBeforeFill = true;
            // 
            // rpdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1141, 709);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rpdiem";
            this.Text = "Báo cáo tổng kết điểm học sinh";
            this.Load += new System.EventHandler(this.rpdiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewdiemhsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLDTHDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource viewdiemhsBindingSource;
        private QLDTHDataSet1 QLDTHDataSet1;
        private QLD.QLDTHDataSet1TableAdapters.viewdiemhsTableAdapter viewdiemhsTableAdapter;

    }
}