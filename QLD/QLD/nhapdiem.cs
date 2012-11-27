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
    public partial class fthemdiem : Form
    {
        SqlConnection conn = new SqlConnection(Connection.Connec);
        private DataTable dtdiem = new DataTable("diem");
        private SqlDataAdapter diem = new SqlDataAdapter();
        public fthemdiem()
        {
            InitializeComponent();
        }

        private void btnthoatdiem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fthemdiem_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"Select  ROW_NUMBER() OVER (ORDER BY hocsinh.mahs) AS STT,
                hocsinh.mahs as N'Mã học sinh',
                hocsinh.hoten as N'Họ tên',
                lop.tenlop as N'Lớp',
                diem15 as 'Điểm 15 phút',
                diem1tiet as 'Điểm 1 tiết',
                diemthi as 'Điểm thi',
                (diemthi+diem1tiet*2+diem15)/4 as 'Điểm tổng kết'
            from hocsinh
            INNER JOIN lop ON hocsinh.malop = lop.malop
            INNER JOIN diem on hocsinh.mahs = diem.mahs
            ", conn);
            diem.SelectCommand = cmd;
            diem.Fill(dtdiem);
            griddiem.DataSource = dtdiem;
            conn.Close();
        }
    }
}
