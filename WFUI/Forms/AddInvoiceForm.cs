using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace WFUI.Forms
{
    public partial class AddInvoiceForm : Form
    {
        IInvoiceServices _invoiceServices;
        int managerId;

        public AddInvoiceForm(IOrderServices orderServ, IInvoiceServices invServ, int managerId)
        {
            InitializeComponent();

            foreach (OrderDTO iter in orderServ.GetAllOrders())
            {
                if (iter.Order_status == "Waiting") ordersComboBox.Items.Add(iter);
            }

            _invoiceServices = invServ;
            this.managerId = managerId;
        }

        private void addInvoiceButton_Click(object sender, EventArgs e)
        {
            _invoiceServices.AddInvoice(((OrderDTO)ordersComboBox.SelectedItem).Id, managerId);
            Close();
        }

        private void ordersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            customerLabel.Text = "Customer :   " + ((OrderDTO)ordersComboBox.SelectedItem).UserLogin;
            productLabel.Text =  "Product :    " + ((OrderDTO)ordersComboBox.SelectedItem).ProductName;
            dateTimeLabel.Text = "Date/Time :  " + ((OrderDTO)ordersComboBox.SelectedItem).UpdateTime;
        }
    }
}
