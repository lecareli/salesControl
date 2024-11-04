using salesControl.br.com.views.customers;

namespace salesControl
{
    public partial class frmStandard : Form
    {
        public frmStandard()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Form frmCustomers = new frmCustomers();
            frmCustomers.Show();
        }
    }
}
