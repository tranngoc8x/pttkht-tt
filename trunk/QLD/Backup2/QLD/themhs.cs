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
    public partial class themhs : Form
    {
        public themhs()
        {
            InitializeComponent();
        }

        private void themhs_Load(object sender, EventArgs e)
        {

        }

        private void btnclosethemhs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthemhs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc muôn thêm học sinh này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
