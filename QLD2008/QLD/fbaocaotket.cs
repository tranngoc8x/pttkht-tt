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
            this.list_monhocTableAdapter.Fill(this.commonData.list_monhoc);
            this.list_namhocTableAdapter.Fill(this.commonData.list_namhoc);
            string namhoc = cbnamhoc.SelectedValue.ToString();
            this.list_lopTableAdapter.Fill(this.commonData.list_lop, namhoc);
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
               // panel_norecord.Visible = false;
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
