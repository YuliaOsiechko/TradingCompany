using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class InvoiceRepository : BaseRepository, IInvoiceRepository
    {
        public InvoiceRepository() : base(Helper.CnnVal()) { }
        public InvoiceRepository(string connectionString) : base(connectionString) { }

        public void AddInvoice(int orderId, int managerId)
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand command = new(@"INSERT INTO invoices (order_id, manager_id, invoice_status) VALUES (@order_id, @manager_id, @status);", connection);
                command.Parameters.Add(new SqlParameter("@order_id", orderId));
                command.Parameters.Add(new SqlParameter("@manager_id", managerId));
                command.Parameters.Add(new SqlParameter("@status", "Waiting"));
                command.ExecuteNonQuery();
            }
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand command = new(@"UPDATE orders SET order_status = @order_status WHERE id = @order_id;", connection);
                command.Parameters.Add(new SqlParameter("@order_id", orderId));
                command.Parameters.Add(new SqlParameter("@order_status", "Processed"));
                command.ExecuteNonQuery();
            }
        }

        public List<InvoiceDTO> GetAllInvoices()
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand command = new(@"SELECT
                                                    invoices.id AS id
                                                   ,invoices.order_id AS order_id
                                                   ,invoices.manager_id AS manager_id
                                                   ,managers.login AS manager_login
                                                   ,orders.user_login AS customer_login
                                                   ,products.name AS product_name
                                                   ,invoices.invoice_status AS invoice_status
                                                   ,invoices.insert_time AS insert_time
                                                   ,invoices.update_time AS update_time
                                                FROM invoices
                                                JOIN orders
                                                 ON invoices.order_id = orders.id
                                                JOIN products
                                                 ON orders.product_id = products.id
                                                JOIN managers
                                                    ON invoices.manager_id = managers.id;", connection);

                List<InvoiceDTO> invoices = new();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        invoices.Add(new InvoiceDTO
                        {
                            Id = (int)reader["id"],
                            OrderId = (int)reader["order_id"],
                            ManagerId = (int)reader["manager_id"],
                            ManagerName = (string)reader["manager_login"],
                            CustomerName = (string)reader["customer_login"],
                            OrderItem = (string)reader["product_name"],
                            InvoiceStatus = (string)reader["invoice_status"],
                            InsertTime = (DateTime)reader["insert_time"],
                            UpdateTime = (DateTime)reader["update_time"]
                        });
                }

                return invoices;
            }
        }

        public List<InvoiceDTO> GetInvoicesOfManager(int id) => GetAllInvoices().Where(x => x.ManagerId == id).ToList();

        public void SendInvoice(int id)
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand command = new(@"UPDATE invoices SET invoice_status = @invoice_status WHERE id = @invoice_id;", connection);
                command.Parameters.Add(new SqlParameter("@invoice_id", id));
                command.Parameters.Add(new SqlParameter("@invoice_status", "Sended"));
                command.ExecuteNonQuery();
            }
        }
    }
}