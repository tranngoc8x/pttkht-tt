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
    public partial class fbaocaohocs : Form
    {
        public fbaocaohocs()
        {
            InitializeComponent();
        }

        private void fbaocaohocs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_dshs.viewdshs' table. You can move, or remove it, as needed.
            //this.viewdshsTableAdapter.Fill(this.data_dshs.viewdshs);
            // TODO: This line of code loads data into the 'commonData.list_namhoc' table. You can move, or remove it, as needed.
            this.list_namhocTableAdapter.Fill(this.commonData.list_namhoc);
            // TODO: This line of code loads data into the 'data_dshs.viewdshs' table. You can move, or remove it, as needed.
            string namhoc = cbnamhoc.SelectedValue.ToString();
            this.list_lopTableAdapter.Fill(this.commonData.list_lop, namhoc);
            
            //this.viewdshsTableAdapter.Fill(this.data_dshs.viewdshs,);

            this.reportViewer1.RefreshReport();
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
            this.viewdshsTableAdapter.Fill(this.data_dshs.viewdshs, lop);
            if (this.data_dshs.viewdshs.Count > 0)
            {
                this.reportViewer1.Visible = true;
                this.reportViewer1.RefreshReport();
               // panel_norecord.Visible = false;
            }
            else
            {
               // panel_norecord.Visible = true;
               // lberr.Visible = true;
                MessageBox.Show("Không có bản ghi nào !","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
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
    }
}
