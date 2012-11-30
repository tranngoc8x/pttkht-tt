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
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"Select  ROW_NUMBER() OVER (ORDER BY mahs) AS STT,
                mahs as N'Mã học sinh',
                hoten as N'Họ tên',
                ngaysinh as N'Ngày sinh',
                case gioitinh when
                    1 then N'Nam'
                    else N'Nữ' end
                    as N'Giới tính',
                lop.tenlop as Lớp,
                tongiao as N'Tôn giáo'
            from hocsinh
            INNER JOIN lop ON hocsinh.malop = lop.malop
            ", conn);
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

       
    }
}
