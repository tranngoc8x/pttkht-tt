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
    public partial class themdiem : Form
    {
        private SqlDataAdapter da = new SqlDataAdapter();
        public themdiem()
        {
            InitializeComponent();
        }

        private void themdiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'commonData.view_listdiem' table. You can move, or remove it, as needed.
            this.view_listdiemTableAdapter.Fill(this.commonData.view_listdiem);
            // TODO: This line of code loads data into the 'commonData.list_monhoc' table. You can move, or remove it, as needed.
            this.list_monhocTableAdapter.Fill(this.commonData.list_monhoc);
            // TODO: This line of code loads data into the 'commonData.list_namhoc' table. You can move, or remove it, as needed.
            this.list_namhocTableAdapter.Fill(this.commonData.list_namhoc);


        }

        private void btnthoatdiem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoadiem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang trong quá trình xây dựng. Hãy thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsuadiem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang trong quá trình xây dựng. Hãy thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbnamhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string namhoc = cbnamhoc.SelectedValue.ToString();
                this.list_lopTableAdapter.Fill(this.commonData.list_lop, namhoc);
                string lop = cblop.SelectedValue.ToString();
                this.selectHSTableAdapter.Fill(this.commonData.selectHS, lop);
            }
            catch { }
        }

        private void cblop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string lop = cblop.SelectedValue.ToString();
                this.selectHSTableAdapter.Fill(this.commonData.selectHS, lop);
            }
            catch { }
        }

        private void btnthemdiem_Click(object sender, EventArgs e)
        {

            //hoc sinh
            string hocsinh = "";
            if (cbhocsinh.Items.Count > 0)
            {
                hocsinh = cbhocsinh.SelectedValue.ToString();
            }
            if (String.IsNullOrEmpty(hocsinh))
            {
                MessageBox.Show("Bạn chưa chọn học sinh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //mon hoc

            string mon = "";
            if (cbmon.Items.Count > 0)
            {
                mon = cbmon.SelectedValue.ToString();
            }
            if (String.IsNullOrEmpty(mon))
            {
                MessageBox.Show("Bạn chưa chọn môn học!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //hoc ky

            string hocky = "";
            int vhocky = 1;
            if (cbhocky.Items.Count > 0)
            {
                hocky = cbhocky.SelectedIndex.ToString();
            }
            if (hocky == "-1")
            {
                MessageBox.Show("Bạn chưa chọn học kỳ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(hocky) == 0) vhocky = 1;
            else vhocky = 2;
            //diem 
            if (String.IsNullOrEmpty(txt15p.Text.ToString()) && String.IsNullOrEmpty(txt45p.Text.ToString()) && String.IsNullOrEmpty(txtthi.Text.ToString()))
            {

                MessageBox.Show("Bạn chưa nhập điểm môn học!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float diem15;
            float diem45 = -1;
            float diemthi = -1;
            if (!String.IsNullOrEmpty(txt15p.Text.ToString())) diem15 = float.Parse(txt15p.Text.ToString());
            else diem15 = -1;
            if (!String.IsNullOrEmpty(txt45p.Text.ToString())) diem45 = float.Parse(txt45p.Text.ToString());
            else diem45 = -1;
            if (!String.IsNullOrEmpty(txtthi.Text.ToString())) diemthi = float.Parse(txtthi.Text.ToString());
            else diemthi = -1;
            //validate diem

           if (!String.IsNullOrEmpty(txt15p.Text.ToString()) && (diem15 < 0 || diem15 > 10))
           {
               MessageBox.Show("Điểm không hợp lệ !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
           }
           if (!String.IsNullOrEmpty(txt45p.Text.ToString()) && (diem45 < 0 || diem45 > 10))
           {
               MessageBox.Show("Điểm không hợp lệ !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
           }
           if (!String.IsNullOrEmpty(txtthi.Text.ToString()) && (diemthi < 0 || diemthi > 10))
           {
               MessageBox.Show("Điểm không hợp lệ !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
           }

            //check isset diem

           SqlConnection conn = new SqlConnection(Connection.Connec);
           SqlCommand cmd = new SqlCommand("checkdiem", conn);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@mahs", cbhocsinh.SelectedValue.ToString());
           cmd.Parameters.AddWithValue("@mamon", cbmon.SelectedValue.ToString());
           cmd.Parameters.AddWithValue("@hocky", Convert.ToInt32(cbhocky.SelectedIndex));
           try
           {
               conn.Open();
           }
           catch { }
           SqlDataReader dreader = cmd.ExecuteReader();
           if (dreader.Read())
           {
               if (Convert.ToInt32(dreader.GetValue(0)) > 0)
               {
                   MessageBox.Show("Điểm môn " + cbmon.Text.ToString() + " của học sinh " + cbhocsinh.Text.ToString() + " ở học kỳ " + (Convert.ToInt32(cbhocky.SelectedIndex) + 1).ToString() + " đã có !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return;
               }
           }
           dreader.Dispose();
           dreader.Close();

            

            // tinh diem trung binh neu nhap du 3 diem
           if (!String.IsNullOrEmpty(txt15p.Text.ToString()) && !String.IsNullOrEmpty(txt45p.Text.ToString()) && !String.IsNullOrEmpty(txtthi.Text.ToString()))
           {
               txttb.Text = System.Math.Round(((diem15+diem45*2)/3+diemthi)/2,2).ToString();
           }
            //------
            //insert
             
            SqlCommand ins = new SqlCommand("nhapdiem", conn);
            ins.CommandType = CommandType.StoredProcedure;
            ins.Parameters.AddWithValue("@mahs", cbhocsinh.SelectedValue.ToString());
            ins.Parameters.AddWithValue("@mamon", cbmon.SelectedValue.ToString());
            ins.Parameters.AddWithValue("@hocky", vhocky);
            ins.Parameters.AddWithValue("@diem15", diem15);
            ins.Parameters.AddWithValue("@diem1tiet", diem45);
            ins.Parameters.AddWithValue("@diemthi", diemthi);
            ins.Parameters.AddWithValue("@mauser", txttb.Text.ToString());
             try
            {

                if (MessageBox.Show("Bạn có chắc muốn thêm điểm cho học sinh này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ins.ExecuteNonQuery();
                    DataTable reload = new DataTable("diem");
                    SqlCommand f5 = new SqlCommand("pro_listdiem", conn);
                    f5.CommandType = CommandType.StoredProcedure;
                    f5.ExecuteNonQuery();
                    da.SelectCommand = f5;
                    griddiem.DataSource = reload;
                    da.Fill(reload);
                    conn.Close();
                    cbhocsinh.Text = "";
                    txt15p.Text = "";
                    txt45p.Text = "";
                    txtthi.Text = "";
                    txttb.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Hãy kiểm tra dữ liệu nhập vào. " + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtthi_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt15p.Text.ToString()) && !String.IsNullOrEmpty(txt45p.Text.ToString()) && !String.IsNullOrEmpty(txtthi.Text.ToString()))
            {
                try
                {
                    txttb.Text = System.Math.Round(((float.Parse(txt15p.Text.ToString()) + float.Parse(txt45p.Text.ToString()) * 2) / 3 + float.Parse(txtthi.Text.ToString())) / 2, 2).ToString();
                }
                catch { }
            }
        }

        private void txt15p_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt15p.Text.ToString()) && !String.IsNullOrEmpty(txt45p.Text.ToString()) && !String.IsNullOrEmpty(txtthi.Text.ToString()))
            {
                try
                {
                    txttb.Text = System.Math.Round(((float.Parse(txt15p.Text.ToString()) + float.Parse(txt45p.Text.ToString()) * 2) / 3 + float.Parse(txtthi.Text.ToString())) / 2, 2).ToString();
                }
                catch { }
            }
        }

        private void txt45p_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt15p.Text.ToString()) && !String.IsNullOrEmpty(txt45p.Text.ToString()) && !String.IsNullOrEmpty(txtthi.Text.ToString()))
            {
                try
                {
                    txttb.Text = System.Math.Round(((float.Parse(txt15p.Text.ToString()) + float.Parse(txt45p.Text.ToString()) * 2) / 3 + float.Parse(txtthi.Text.ToString())) / 2, 2).ToString();
                }
                catch { }
            }
        }
    }
}
