using BLL;
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

namespace WFUI.Forms
{
    public partial class SendInvoiceForm : Form
    {
        IInvoiceServices _invoiceServices;

        public SendInvoiceForm(IInvoiceServices invoiceServices, int managerId)
        {
            InitializeComponent();

            _invoiceServices = invoiceServices;

            foreach (InvoiceDTO iter in invoiceServices.GetInvoicesOfManager(managerId))
            {
                if (iter.InvoiceStatus == "Waiting") invoicesComboBox.Items.Add(iter);
            }
        }

        private void sendInvoiceButton_Click(object sender, EventArgs e)
        {
            _invoiceServices.SendInvoice(((InvoiceDTO)invoicesComboBox.SelectedItem).Id);
            Close();
        }

        private void invoicesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            managerLabel.Text = "Manager :   " + ((InvoiceDTO)invoicesComboBox.SelectedItem).ManagerName;
            productLabel.Text = "Product :   " + ((InvoiceDTO)invoicesComboBox.SelectedItem).OrderItem;
            customerLabel.Text = "Customer :  " + ((InvoiceDTO)invoicesComboBox.SelectedItem).CustomerName;
        }
    }
}
