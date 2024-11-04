using salesControl.br.com.projeto.dao;
using salesControl.br.com.projeto.model;

namespace salesControl.br.com.views.customers
{
    public partial class frmInsCustomers : Form
    {
        public frmInsCustomers()
        {
            InitializeComponent();
        }

        private void clearFormFields()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtRG.Text = string.Empty;
            mTxtCPF.Text = string.Empty;
            txtEmail.Text = string.Empty;
            mTxtPhone.Text = string.Empty;
            mTxtPostalCode.Text = string.Empty;
            txtStreet.Text = string.Empty;
            txtHouseNumber.Text = string.Empty;
            txtNeighborhood.Text = string.Empty;
            txtCity.Text = string.Empty;
            cbxUF.Text = string.Empty;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();

            customers.Name = txtName.Text.Trim();
            customers.Rg = txtRG.Text.Trim();
            customers.Cpf = mTxtCPF.Text.Trim();
            customers.Email = txtEmail.Text.Trim();
            customers.Phone = mTxtPhone.Text.Trim();
            customers.postalCode = mTxtPostalCode.Text.Trim();
            customers.Street = txtStreet.Text.Trim();
            customers.HouseNumber = txtHouseNumber.Text.Trim();
            customers.Neighborhood = txtNeighborhood.Text.Trim();
            customers.City = txtCity.Text.Trim();
            customers.UF = cbxUF.Text.Trim();

            CustomersDAO customersDAO = new CustomersDAO();
            customersDAO.insertCustomer(customers);

            clearFormFields();

            this.Close();
        }
    }
}
