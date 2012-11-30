namespace QLD
{
    partial class frpdiem
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
            this.dataSetDiem1 = new QLD.DataSetDiem();
            this.viewdshsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewdiemhsTableAdapter = new QLD.DataSetDiemTableAdapters.viewdiemhsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDiem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewdshsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetDiem1
            // 
            this.dataSetDiem1.DataSetName = "DataSetDiem";
            this.dataSetDiem1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewdshsBindingSource
            // 
            this.viewdshsBindingSource.DataMember = "viewdiemhs";
            this.viewdshsBindingSource.DataSource = this.dataSetDiem1;
            // 
            // viewdiemhsTableAdapter
            // 
            this.viewdiemhsTableAdapter.ClearBeforeFill = true;
            // 
            // frpdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 413);
            this.Name = "frpdiem";
            this.Text = "frpdiem";
            this.Load += new System.EventHandler(this.frpdiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDiem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewdshsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetDiem dataSetDiem1;
        private System.Windows.Forms.BindingSource viewdshsBindingSource;
        private DataSetDiemTableAdapters.viewdiemhsTableAdapter viewdiemhsTableAdapter;
    }
}