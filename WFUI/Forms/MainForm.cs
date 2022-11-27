using BLL;
using DTO;
using WFUI.Forms;

namespace WFUI
{
    public partial class MainForm : Form
    {
        //private CommentsForm _commentForm { get; set; }
        private TextPromptForm _textPromptForm { get; set; }
        private IManagerServices _managerServices { get; set; }
        private IOrderServices _orderServices { get; set; }
        private IInvoiceServices _invoiceServices { get; set; }
        private ManagerDTO _manager { get; set; }
        private string _clearPassword { get; set; }
        private List<OrderDTO> _orders { get; set; }
        private List<OrderDTO> _ordersFiltered { get; set; }
        List<InvoiceDTO> _invoice { get; set; }

        public MainForm(
            IManagerServices userServices,
            IOrderServices orderServices, 
            IInvoiceServices commentServices,
            //CommentsForm commentsForm,
            TextPromptForm textPromptForm)
        {
            InitializeComponent();
            //
            _managerServices = userServices;
            _orderServices = orderServices;
            _invoiceServices = commentServices;
            //
            //_commentForm = commentsForm;
            _textPromptForm = textPromptForm;
        }

        public void LoadLoginPassword(string userLogin, string userPassword)
        {
            _manager = _managerServices.Get(userLogin);
            _clearPassword = userPassword;
            //Profile
            RefreshProfile();
            //Orders
            RefreshOrders();
            foreach (DataGridViewColumn col in ordersDataGridView.Columns)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // Invoices
            RefreshInvoice();
            foreach (DataGridViewColumn col in invoicesDataGridView.Columns)
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void RefreshProfile()
        {
            displayNameLabel.Text = "Display Name : " + _manager.DispName;
            loginLabel.Text = "Login : " + _manager.Login;
            passwordLabel.Text = "Password : " + _clearPassword;
        }

        private void RefreshOrders()
        {
            _orders = _orderServices.GetAllOrders();
            _ordersFiltered = _orderServices.GetAllOrders();
            RefreshOrderDataGrid();
        }

        private void RefreshInvoice()
        {
            _invoice = _invoiceServices.GetInvoicesOfManager(_manager.Id);
            RefreshInvoicesGataGrid();
        }

        private void RefreshManager()
        {
            _manager = _managerServices.Get(_manager.Id);
            RefreshProfile();
        }

        private void RefreshOrderDataGrid() => ordersDataGridView.DataSource = _ordersFiltered
            .Select(orderDTO => new
            {
                OrderID = orderDTO.Id,
                UserLogin = orderDTO.UserLogin,
                ProductName = orderDTO.ProductName,
                OrederStatus = orderDTO.Order_status,
                OrderTime = orderDTO.InsertTime
            }).ToList();

        private void RefreshInvoicesGataGrid() => invoicesDataGridView.DataSource = _invoice
            .Select(invoiceDTO => new
            {
                InvoseId = invoiceDTO.Id,
                Product = invoiceDTO.OrderItem,
                Customer = invoiceDTO.CustomerName,
                ManagerName = invoiceDTO.ManagerName,
                InvoiceStatus = invoiceDTO.InvoiceStatus
            }).ToList();

        private void SearchToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            _ordersFiltered = _orders
                .Where(orderDTO => orderDTO.ProductName
                .Contains(searchToolStripTextBox.Text))
                .ToList();

            RefreshOrderDataGrid();
        }

        private void SortDescToolStripButton_Click(object sender, EventArgs e)
        {
            _ordersFiltered = _ordersFiltered.OrderBy(orderDTO => orderDTO.Id).ToList();
            RefreshOrderDataGrid();
        }

        private void sortAscToolStripButton_Click(object sender, EventArgs e)
        {
            _ordersFiltered = _ordersFiltered.OrderByDescending(orderDTO => orderDTO.Id).ToList();
            RefreshOrderDataGrid();
        }

        private void RepeatOrderToolStripButton_Click(object sender, EventArgs e)
        {
            //_orderServices.PlaceOrder(_manager., (int)ordersDataGridView.SelectedRows[0].Cells[0].Value);
            //RefreshOrders();
        }

        private void ShowCommentsToolStripButton_Click(object sender, EventArgs e)
        {
            //_commentForm.LoadUser(_user);
            //_commentForm.LoadOrderID((int)ordersDataGridView.SelectedRows[0].Cells[0].Value);
            //_commentForm.ShowDialog();
        }

        private void CommentToolStripButton_Click(object sender, EventArgs e)
        {
            _textPromptForm.Configure("New Comment", "Comment");
            if (_textPromptForm.ShowDialog() == DialogResult.OK) ;
                
        }

        private void changeDisplayNameButton_Click(object sender, EventArgs e)
        {
            _textPromptForm.Configure("New Display Name", "Change");
            if (_textPromptForm.ShowDialog() == DialogResult.OK)
                _managerServices.UpdateDispName(_manager.Login, _textPromptForm._res);
            RefreshManager();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            _textPromptForm.Configure("New Password", "Change");
            if (_textPromptForm.ShowDialog() == DialogResult.OK)
            {
                _managerServices.UpdatePassword(_manager.Login, _textPromptForm._res);
                _clearPassword = _textPromptForm._res;
            }
            RefreshManager();
        }

        private void addInvoiceToolStripButton_Click(object sender, EventArgs e)
        {
            AddInvoiceForm addInvoiceForm = new AddInvoiceForm(_orderServices, _invoiceServices, _manager.Id);
            addInvoiceForm.ShowDialog();
            RefreshOrders();
            RefreshInvoice();
        }

        private void sendInvoiceButton_Click(object sender, EventArgs e)
        {
            SendInvoiceForm sendInvoiceFrom = new SendInvoiceForm(_invoiceServices, _manager.Id);
            sendInvoiceFrom.ShowDialog();
            RefreshInvoice();
        }
    }
}
