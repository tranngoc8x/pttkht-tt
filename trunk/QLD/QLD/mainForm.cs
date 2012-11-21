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

    public partial class mainForm : Form
    {
       // private SqlDataAdapter da = new SqlDataAdapter();
       // private DataTable dt = new DataTable();
        SqlConnection conn = new SqlConnection(Connection.Connec);
        private DataTable dths = new DataTable("tblhocsinh");
        private SqlDataAdapter da = new SqlDataAdapter();
        public mainForm()
        {
            InitializeComponent();
        }
        private void mainform_Load(object sender, EventArgs e)
        {
            mainmenu.Visible = false;
            panellogin.Visible = true;
            //pa_dshs.Visible = false;
            status.Text = "Xin chào khách. Hãy đăng nhập để bắt đầu làm việc !"; 
        }

        private void quit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát khỏi chương trình không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(user.Text))
            {
                MessageBox.Show("Bạn chưa nhập tài khoản", "Lỗi đăng nhập", MessageBoxButtons.OK);
            }
            else if (String.IsNullOrEmpty(pass.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Lỗi đăng nhập", MessageBoxButtons.OK);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"Select * from users where username = '"+user.Text+"' and password='"+pass.Text+"'", conn);
                var check = cmd.ExecuteScalar();
                if (check != null)
                {
                    mainmenu.Visible = true;
                    panellogin.Visible = false;
                    status.Text = "Xin chào : " + check.ToString();
                    conn.Close();
                }
                else
                {

                    if (MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác. Bạn có muốn thử lại không ?", "Lỗi đăng nhập", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
                
            }
        }

        
        private void logout_Click(object sender, EventArgs e)
        {
            mainmenu.Visible = false;
            panellogin.Visible = true;
          //  pa_dshs.Visible = false;
            user.Text = "";
            pass.Text = "";
            status.Text = "Xin chào khách. Hãy đăng nhập để bắt đầu làm việc !";
        }

        private void danhsachhs_Click(object sender, EventArgs e)
        {
            //pa_dshs.Refresh();
            //pa_dshs.RefreshItems();
            //pa_dshs.Visible = true;
            
            conn.Open();
            SqlCommand cmd = new SqlCommand(@"Select 
                ROW_NUMBER() OVER (ORDER BY mahs) AS STT,
                mahs as 'Mã học sinh',
                hoten as 'Họ tên',
                ngaysinh as 'Ngày sinh',
                gioitinh as 'Giới tính',
                lop.tenlop as Lớp,
                tongiao as 'Tôn giáo'
            from hocsinh
            INNER JOIN lop ON hocsinh.malop = lop.malop
            ", conn);
            da.SelectCommand = cmd;
            da.Fill(dths);
            //data_dshs.DataSource = dths;
            conn.Close();
        }

        private void exitapp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
