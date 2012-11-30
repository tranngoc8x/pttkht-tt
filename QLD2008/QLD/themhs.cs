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
    public partial class themhs : Form
    {
        public themhs()
        {
            InitializeComponent();
        }

        private void themhs_Load(object sender, EventArgs e)
        {
            //chọn lớp từ năm học
            this.list_namhocTableAdapter.Fill(this.commonData.list_namhoc);
            string namhoc = cbnamhoc.SelectedValue.ToString();
            this.list_lopTableAdapter.Fill(this.commonData.list_lop, namhoc);

            //giới tính
            
            cbgioitinh.SelectedText = "Chọn giới tính";
            cbgioitinh.Items.Add("Nữ");
            cbgioitinh.Items.Add("Nam");
        }

        private void btnclosethemhs_Click(object sender, EventArgs e)
        {
            this.Close();
            dshs ds = new dshs();
            ds.Show();
        }

        private void btnthemhs_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtmahs.Text)) { MessageBox.Show("Bạn chưa nhập mã học sinh !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (txtmahs.Text.ToString().Trim().Length >10) { MessageBox.Show("Mã học sinh không được phép vượt quá 10 !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            
            if (String.IsNullOrEmpty(txthoten.Text)) { MessageBox.Show("Bạn chưa nhập tên học sinh !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (txthoten.Text.ToString().Length > 50 || txthoten.Text.ToString().Length <7) { MessageBox.Show("Độ dài họ tên không phug hợp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            
            
            DateTime now = DateTime.Now.Date;
            DateTime ngaysinh = Convert.ToDateTime(txtngaysinh.Text);
            TimeSpan tuoi = now - ngaysinh;
            if (tuoi.Days<5000 || tuoi.Days > 7500) { MessageBox.Show("Tuổi không phù hợp !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
           
           
            //check ma hs
            SqlConnection conn = new SqlConnection(Connection.Connec);
            SqlCommand cmd = new SqlCommand("kiemtrama", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ma", txtmahs.Text.ToString());
            try
            {
                conn.Open();
            }
            catch { }
           SqlDataReader dreader = cmd.ExecuteReader();
           if (dreader.Read())
            {
                if(Convert.ToInt32(dreader.GetValue(0))>0){
                    MessageBox.Show("Mã học sinh đã tồn tại. Hãy nhập mã khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
           dreader.Dispose();
           dreader.Close();
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

            //chwck giới tính

            string gioitinh = "";
            if (cblop.Items.Count > 0)
            {
                gioitinh = cbgioitinh.SelectedIndex.ToString();
            }
            if (gioitinh == "-1")
            {
                MessageBox.Show("Bạn chưa chọn giới tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //insert  data
            SqlCommand ins = new SqlCommand("themhs", conn);
            ins.CommandType = CommandType.StoredProcedure;
            ins.Parameters.AddWithValue("@mahs",txtmahs.Text.ToString().Trim().TrimEnd().TrimStart().ToUpper());
            ins.Parameters.AddWithValue("@malop", cblop.SelectedValue.ToString());
            ins.Parameters.AddWithValue("@hoten", txthoten.Text.ToString().TrimEnd().TrimStart());
            DateTime ngays = Convert.ToDateTime(txtngaysinh.Text.ToString());
            string sqlFormattedDate = ngays.Date.ToString("MM/dd/yyyy");
            ins.Parameters.AddWithValue("@ngaysinh", sqlFormattedDate);
            ins.Parameters.AddWithValue("@quequan", txtque.Text.ToString());
            ins.Parameters.AddWithValue("@tongiao", txttongiao.Text.ToString());
            ins.Parameters.AddWithValue("@uutien", txtuutien.Text.ToString());
            ins.Parameters.AddWithValue("@tenbo", txtbo.Text.ToString());
            ins.Parameters.AddWithValue("@tenme", txtme.Text.ToString());
            ins.Parameters.AddWithValue("@nghebo", txtnbo.Text.ToString());
            ins.Parameters.AddWithValue("@ngheme", txtnme.Text.ToString());
            ins.Parameters.AddWithValue("@gioitinh", Convert.ToInt32(cbgioitinh.SelectedIndex));
            ins.Parameters.AddWithValue("@mauser", txthoten.Text.ToString());
            try
            {
                ins.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Bạn có chắc muôn thêm học sinh này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                txthoten.Text = "";
                txtque.Text = "";
                txtbo.Text = "";
                txtme.Text = "";
                txtnbo.Text = "";
                txtnme.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra. Hãy kiểm tra dữ liệu nhập vào. " + ex.Message.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
