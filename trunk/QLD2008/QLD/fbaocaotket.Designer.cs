﻿namespace QLD
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
            ((System.ComponentModel.ISupportInitialize)(this.viewdiemhsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDiem)).BeginInit();
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
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLD.rep_tket.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 44);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(685, 599);
            this.reportViewer1.TabIndex = 0;
            // 
            // viewdiemhsTableAdapter
            // 
            this.viewdiemhsTableAdapter.ClearBeforeFill = true;
            // 
            // fbaocaotket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QLD.Properties.Resources.hoavantrongdongvl5;
            this.ClientSize = new System.Drawing.Size(684, 640);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fbaocaotket";
            this.Text = "fbaocaotket";
            this.Load += new System.EventHandler(this.fbaocaotket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewdiemhsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetDiem dataSetDiem;
        private System.Windows.Forms.BindingSource viewdiemhsBindingSource;
        private QLD.DataSetDiemTableAdapters.viewdiemhsTableAdapter viewdiemhsTableAdapter;
    }
}