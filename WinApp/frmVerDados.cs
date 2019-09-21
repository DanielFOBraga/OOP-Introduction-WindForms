using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class frmVerDados : Form
    {
        public frmVerDados()
        {
            InitializeComponent();
        }

        private void CustomersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsNorthwind);

        }

        private void FrmVerDados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsNorthwind.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.dsNorthwind.Order_Details);
            // TODO: This line of code loads data into the 'dsNorthwind.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.dsNorthwind.Orders);
            // TODO: This line of code loads data into the 'dsNorthwind.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dsNorthwind.Customers);

        }
    }
}
