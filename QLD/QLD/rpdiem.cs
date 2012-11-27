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
    public partial class rpdiem : Form
    {
        public rpdiem()
        {
            InitializeComponent();
        }

        private void rpdiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLDTHDataSet1.viewdiemhs' table. You can move, or remove it, as needed.
            this.viewdiemhsTableAdapter.Fill(this.QLDTHDataSet1.viewdiemhs);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
