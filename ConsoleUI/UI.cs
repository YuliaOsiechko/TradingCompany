using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using BLL;


namespace ConsoleUI
{
    public class UI

    {
        private ManagerServices _managerServices { get; set; }
        private OrderServices _orderServices { get; set; }
        private InvoiceServices _invoiceServices { get; set; }

        private ManagerRepository _managerRepository;
        private OrderRepository _orderRepository;
        private InvoiceRepository _invoiceRepository;

        private bool exit { get; set; }
        private ManagerDTO _manager { get; set; }
        private List<OrderDTO> orders { get; set; }
        //private List<OrderDTO> ordersFiltered { get; set; }
        private List<InvoiceDTO> invoices { get; set; }

        public UI()
        {
            _managerRepository = new ManagerRepository();
            _orderRepository = new OrderRepository();
            _invoiceRepository = new InvoiceRepository();

            _managerServices = new ManagerServices(_managerRepository);
            _orderServices = new OrderServices(_orderRepository);
            _invoiceServices = new InvoiceServices(_invoiceRepository);
            exit = false;

            orders = _orderServices.GetAllOrders();
        }

        //===========================
        public void LogPage()
        {
            string login, password;
            do
            {
                Console.Clear();
                Console.Write("Login : ");
                login = Console.ReadLine();
                Console.Write("Password : ");
                password = Console.ReadLine();
            } while (!_managerServices.CheckPassword(login, password));

            _manager = _managerServices.Get(login);
            RefreshOrdersList();
            RefreshInvoicesList();
            CallMainPage();
        }
        private void Menu(string title, string[] options, Action[] actions)
        {
            int rowN = options.Length, pPos = 1;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine($"\t{title}");
                for (var i = 0; i < rowN; i++)
                {
                    Console.Write($"{i + 1}. ");
                    Console.Write("{0,-20}", options[i]);
                    if (i + 1 == pPos)
                        Console.Write("<");
                    Console.WriteLine();
                }

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        if (1 < pPos) pPos--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (pPos < rowN) pPos++;
                        break;
                    case ConsoleKey.E:
                    case ConsoleKey.Enter:
                        Console.Clear();
                        actions[pPos - 1]();
                        break;
                }
            }

            exit = false;
        }
        private void CallInvoicesPage()
        {
            Menu("Invoices",
                new[] { "Add Invoice", "Send Invoice", "All Invoices", "Back" },
                new Action[] { AddInvoice, SendInvoice, ShowInvoice, GoToExit });
        }
        //===========================Log -> Main
        private void CallMainPage()
        {
            Console.WriteLine("MAIN PAGE...");
            Menu("===MAIN MENU===",
                new[] { "Role Page", "Orders & Invoices", "Exit" },
                new Action[] { CallRolePage, CallInvoicesOrdersPage, GoToExit });
        }
        private void CallInvoicesOrdersPage()
        {
            Menu("Orders & Onvoices",
                new[] { "Orders", "Invoices", "Back" },
                new Action[] { CallOrdersPage, CallInvoicesPage, GoToExit });
        }
        private void CallOrdersPage()
        {
            Menu("Orders",
                new[] { "Sort", "Search", "Result", "Repeat Order", "Back" },
                new Action[] { CallSortPage, SearchOrderPage, ShowOrdersResult, RepeatOrderPage, GoToExit });
        }
        //Role Page -> Profile Info/Settings
        private void CallProfileSettings()
        {
            Menu("Settings", new[] { "Change Password", "Change Display Name", "Back" },
                new Action[] { ChangeUserPassword, ChangeUserDisplayName, GoToExit });
        }

        //===========================Main -> Role/OrderHistory
        private void CallRolePage()
        {
            Menu("Role Page", new[] { "Profile Info", "Settings", "Logout", "Back" },
                new Action[] { ShowProfileInfo, CallProfileSettings, LogPage, GoToExit });
        }

        //===========================OrderHistory -> Sort / Search / Repeat Order / Show Result / Write Invoice
        private void CallSortPage()
        {
            Menu("Sort",
                new[] { "Ascending", "Descending", "Back" },
                new Action[] { SortOrderHistoryASC, SortOrderHistoryDESC, GoToExit });
        } //Sort -> ASC / DESC

        //===========================
        private void ShowProfileInfo()
        {
            Console.WriteLine("{0,-25}{1,-20}{2,-20}", "Display Name", "Login", "Password");
            Console.WriteLine(new string('=', 65));
            Console.WriteLine("{0,-25}{1,-20}{2,-20}", _manager.DispName, _manager.Login, _manager.Password);
            Console.ReadKey();
        }
        private void ShowOrdersResult()
        {
            Console.WriteLine("{0,-10}{1,-15}{2,-25}{3,-20}\n{4}", "ID", "Product", "Order Time", "Status", 
                new string('=', 58));
            foreach (var order in orders)
            {
                Console.WriteLine("{0,-10}{1,-15}{2,-25}{3, -10}", order.Id, order.ProductName, order.InsertTime, order.Order_status);
            }

            Console.ReadKey();
        }
        private void ShowInvoice()
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3, 5}\n{4}", "Customer", "Product", "Manager", "Invoice Created Time",
                new string('=', 70));
            foreach (var invoice in invoices)
                Console.WriteLine("{0,-15}{1,-15}{2,-15}{3, 5}", invoice.CustomerName, invoice.OrderItem, invoice.ManagerName,
                    invoice.InsertTime);
            Console.ReadKey();
        }
        private void AddInvoice()
        {
            Console.WriteLine("Id \t Product \t Customer \t Order Time");
            foreach (OrderDTO iter in orders)
            {
                if (iter.Order_status == "Waiting") 
                { 
                    Console.WriteLine(iter.Id + "\t" + iter.ProductName + "\t" + iter.UserLogin + "\t" + iter.UpdateTime);
                }
            }
            Console.WriteLine(new String('=', 70));

            Console.Write("Order id : ");
            var order_id = int.Parse(Console.ReadLine());
            if (orders.Find(x=>x.Id == order_id).Order_status == "Waiting")
            {
                Console.Write("Invoice : ");
                
                _invoiceServices.AddInvoice(order_id, _manager.Id);
            }
            RefreshOrdersList();
            RefreshInvoicesList();
        }
        private void SendInvoice()
        {
            Console.WriteLine("Id \t Product \t Customer \t Invoice Time");
            foreach (InvoiceDTO iter in invoices)
            {
                if (iter.InvoiceStatus == "Waiting")
                {
                    Console.WriteLine(iter.Id + "\t" + iter.OrderItem + "\t" 
                        + orders.Find(x=>x.Id==iter.OrderId).UserLogin + "\t" + iter.UpdateTime);
                }
            }
            Console.WriteLine(new String('=', 70));

            Console.Write("Invoice id : ");
            var invoice_id = int.Parse(Console.ReadLine());
            if (invoices.Find(x => x.Id == invoice_id).InvoiceStatus == "Waiting")
            {
                Console.Write("Invoice : ");

                _invoiceServices.SendInvoice(invoice_id);
            }
            RefreshOrdersList();
            RefreshInvoicesList();
        }
        private void SearchOrderPage()
        {
            Console.WriteLine("\tSearch");
            Console.Write("Product name : ");
            var productName = Console.ReadLine();

            Console.WriteLine("{0,-10}{1,-15}{2,-25}{3,-20}\n{4}", "ID", "Product", "Order Time", "Status",
               new string('=', 58));
            foreach (var order in orders.Where(x=>x.ProductName == productName))
            {
                Console.WriteLine("{0,-10}{1,-15}{2,-25}{3, -10}", order.Id, order.ProductName, order.InsertTime, order.Order_status);
            }

            Console.ReadKey();
        }
        private void RepeatOrderPage()
        {
            Console.WriteLine("\tRepeat order");
            Console.Write("Order id : ");
            var order_id = int.Parse(Console.ReadLine());
            var order = _orderServices.GetOrder(order_id);
            if (_orderServices.UserOrderCheck(orders.Find(x=>x.Id== order_id).UserLogin, order_id))
                _orderServices.PlaceOrder(orders.Find(x => x.Id == order_id).UserLogin, order.ProductId);
            RefreshOrdersList();
        }
        private void ChangeUserDisplayName()
        {
            Console.WriteLine("\tChange Display Name");
            Console.Write("New name : ");
            var new_disp_name = Console.ReadLine();
            _managerServices.UpdateDispName(_manager.Login, new_disp_name);
            RefreshCurrentUser();
        }
        private void ChangeUserPassword()
        {
            Console.WriteLine("\tChange Password");
            Console.Write("New password : ");
            var new_password = Console.ReadLine();
            _managerServices.UpdatePassword(_manager.Login, new_password);
            RefreshCurrentUser();
        }

        private void SortOrderHistoryASC() => orders= orders.OrderBy(order => order.ProductName).ToList();
        private void SortOrderHistoryDESC() => orders= orders.OrderByDescending(order => order.ProductName).ToList();
        private void RefreshInvoicesList() => invoices = _invoiceServices.GetInvoicesOfManager(_manager.Id);
        private void RefreshOrdersList()
        {
            orders = _orderServices.GetAllOrders();
        }
        private void RefreshCurrentUser() => _manager = _managerServices.Get(_manager.Id);
        private void GoToExit() => exit = true;
    }
}
