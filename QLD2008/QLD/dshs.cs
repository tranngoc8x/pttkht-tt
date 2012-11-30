using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLD
{
    public partial class dshs : Form
    {
        SqlConnection conn = new SqlConnection(Connection.Connec);
        private DataTable dths = new DataTable("hocsinh");
        private SqlDataAdapter da = new SqlDataAdapter();
        public dshs()
        {
            InitializeComponent();
        }

        private void dshs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'commonData.list_namhoc' table. You can move, or remove it, as needed.
            this.list_namhocTableAdapter.Fill(this.commonData.list_namhoc);
            string namhoc = cbnamhoc.SelectedValue.ToString();
            this.list_lopTableAdapter.Fill(this.commonData.list_lop, namhoc);
            string lop = "";
            conn.Open();
            SqlCommand cmd = new SqlCommand("selectshbylop", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try{
               lop =  cblop.SelectedValue.ToString();
            }catch{}
            cmd.Parameters.AddWithValue("@ma", lop);
            da.SelectCommand = cmd;
            da.Fill(dths);
            griddshs.DataSource = dths;
            conn.Close();
        }

        private void closehs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthemhs_Click(object sender, EventArgs e)
        {
            this.Close();
            themhs themhs = new themhs();
            themhs.Show();
        }

        private void cbnamhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string namhoc = cbnamhoc.SelectedValue.ToString();
                this.list_lopTableAdapter.Fill(this.commonData.list_lop, namhoc);
            }
            catch { }
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            string lophoc = "";
            if (cblop.Items.Count > 0)
            {
                lophoc = cblop.SelectedValue.ToString();
            }
            if (String.IsNullOrEmpty(lophoc))
            {
                MessageBox.Show("Bạn chưa chọn lớp học!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string lop = "";
            conn.Open();
            SqlCommand cmd = new SqlCommand("selectshbylop", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                lop = cblop.SelectedValue.ToString();
            }
            catch { }
            cmd.Parameters.AddWithValue("@ma", lop);
            da.SelectCommand = cmd;
            da.Fill(dths);
            griddshs.Refresh();
            griddshs.DataSource = dths;
            conn.Close();
        }

       
    }
}
