using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01Ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            txtArea.Text = Convert.ToString(Convert.ToDecimal( txtLength.Text )* Convert.ToDecimal(txtWidth.Text));
            txtPerim.Text = Convert.ToString((Convert.ToDecimal(txtLength.Text) + Convert.ToDecimal(txtWidth.Text)) *2 );
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
