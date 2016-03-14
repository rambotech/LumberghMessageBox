using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOG.LumberghMessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select an entry in the dropdown list", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnLumbergh_Click(object sender, EventArgs e)
        {
            frmLumbergMessageBox f = new frmLumbergMessageBox("Select an entry in the dropdown list");
            f.ShowDialog(this);
        }
    }
}
