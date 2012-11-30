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
            // TODO: This line of code loads data into the 'dataSetDiem1.viewdiemhs' table. You can move, or remove it, as needed.
            this.viewdiemhsTableAdapter.Fill(this.dataSetDiem1.viewdiemhs);
           
        }
    }
}
