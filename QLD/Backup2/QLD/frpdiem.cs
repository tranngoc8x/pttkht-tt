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
    public partial class frpdiem : Form
    {
        public frpdiem()
        {
            InitializeComponent();
        }

        private void frpdiem_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
