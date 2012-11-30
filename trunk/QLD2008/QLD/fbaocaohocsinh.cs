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
    public partial class fbaocaohocsinh : Form
    {
        public fbaocaohocsinh()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_dshs.viewdshs' table. You can move, or remove it, as needed.
            this.viewdshsTableAdapter.Fill(this.data_dshs.viewdshs);

            this.reportViewer1.RefreshReport();
        }
    }
}
