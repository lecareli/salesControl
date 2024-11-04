using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salesControl.br.com.views.customers
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmInsCustomer = new frmInsCustomers();
            frmInsCustomer.Show();
        }
    }
}
