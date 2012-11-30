using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLD
{
    public partial class fbaocaotket : Form
    {
        public fbaocaotket()
        {
            InitializeComponent();
        }

        private void fbaocaotket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'commonData.list_monhoc' table. You can move, or remove it, as needed.
            this.list_monhocTableAdapter.Fill(this.commonData.list_monhoc);
            // TODO: This line of code loads data into the 'commonData.list_namhoc' table. You can move, or remove it, as needed.
            this.list_namhocTableAdapter.Fill(this.commonData.list_namhoc);
            string namhoc = cbnamhoc.SelectedValue.ToString();
            this.list_lopTableAdapter.Fill(this.commonData.list_lop, namhoc);
            // TODO: This line of code loads data into the 'dataSetDiem.viewdiemhs' table. You can move, or remove it, as needed.
           // this.viewdiemhsTableAdapter.Fill(this.dataSetDiem.viewdiemhs, cbmon.SelectedValue.ToString(), cblop.SelectedValue.ToString());
            this.reportViewer1.Visible = false;
            this.reportViewer1.RefreshReport();
        }

        private void cbnamhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string namhoc = cbnamhoc.SelectedValue.ToString();
                this.list_lopTableAdapter.Fill(this.commonData.list_lop, namhoc);
                string lop = cblop.SelectedValue.ToString();
            }
            catch { }
        }

        private void btnxembc_Click(object sender, EventArgs e)
        {
            string lop = "";
            if (cblop.Items.Count > 0)
            {
                lop = cblop.SelectedValue.ToString();
            }
            if (String.IsNullOrEmpty(lop))
            {
                MessageBox.Show("Bạn chưa chọn lớp !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.viewdiemhsTableAdapter.Fill(this.dataSetDiem.viewdiemhs,cbmon.SelectedValue.ToString(),cblop.SelectedValue.ToString());
            if (this.dataSetDiem.viewdiemhs.Count > 0)
            {
                this.reportViewer1.Visible = true;
                this.reportViewer1.RefreshReport();
                panel_norecord.Visible = false;
            }
            else
            {
                panel_norecord.Visible = true;
                lberror.Visible = true;
            }
        }

    }
}
