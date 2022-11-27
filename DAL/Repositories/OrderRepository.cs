using System.Data.SqlClient;
using DTO;

namespace DAL
{
	public class OrderRepository : BaseRepository, IOrderRepository
	{
		public OrderRepository() : base(Helper.CnnVal()) { }
		public OrderRepository(string connectionString):base(connectionString) { }

		public void CreateOrder(string userLogin, int productId)
		{
			using (SqlConnection connection = new(connectionString))
			{
				connection.Open();
				SqlCommand command =
					new(@"INSERT INTO orders (user_login, product_id, order_status) VALUES (@user_login, @product_id, @order_status);",
						connection);
				command.Parameters.Add(new SqlParameter("@user_login", userLogin));
				command.Parameters.Add(new SqlParameter("@product_id", productId));
				command.Parameters.Add(new SqlParameter("@order_status", "Waiting"));
				command.ExecuteNonQuery();
			}
		}
		public OrderDTO Get(int id)
		{
			using (SqlConnection connection = new(connectionString))
			{
				connection.Open();
				SqlCommand command = new(@"SELECT
													orders.id AS id
												   ,user_login AS user_login
												   ,products.id AS product_id
												   ,products.name AS product_name
												   ,orders.insert_time AS insert_time
												   ,orders.update_time AS update_time
												FROM orders
												JOIN products
													ON orders.product_id = products.id
												WHERE orders.id = @id", connection);
				command.Parameters.Add(new SqlParameter("@id", id));
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
						return new OrderDTO
						{
							Id = (int)reader["id"],
							UserLogin = reader["user_login"].ToString(),
							ProductId = (int)reader["product_id"],
							ProductName = (string)reader["product_name"],
							InsertTime = (DateTime)reader["insert_time"],
							UpdateTime = (DateTime)reader["update_time"]
						};
				}

				return null;
			}
		}
		public List<OrderDTO> GetAll()
		{
            using (SqlConnection connection = new(connectionString))
			{
                connection.Open();
                SqlCommand command = new(@"SELECT
													orders.id AS id
												   ,user_login AS user_login
												   ,products.id AS product_id
												   ,products.name AS product_name
												   ,orders.order_status AS order_status
												   ,orders.insert_time AS insert_time
												   ,orders.update_time AS update_time
												FROM orders
												JOIN products
													ON orders.product_id = products.id
												", connection);
				List<OrderDTO> oreders = new List<OrderDTO>();
				using (var reader = command.ExecuteReader())
				{
					while(reader.Read())
					{
						oreders.Add(new OrderDTO
						{
							Id = (int)reader["id"],
							UserLogin = reader["user_login"].ToString(),
							ProductId = (int)reader["product_id"],
							ProductName = (string)reader["product_name"],
							Order_status = (string)reader["order_status"],
							InsertTime = (DateTime)reader["insert_time"],
							UpdateTime = (DateTime)reader["update_time"]
						});
					}
				}

				return oreders;
            }

        }
		public List<OrderDTO> GetOrderHistory(string userLogin)
		{
			using (SqlConnection connection = new(connectionString))
			{
				connection.Open();
				SqlCommand command = new(@"SELECT
													orders.id AS id
												   ,products.id AS product_id
												   ,products.name AS product_name
												   ,orders.insert_time AS insert_time
												   ,orders.update_time AS update_time
												FROM orders
												JOIN products
													ON orders.product_id = products.id
												WHERE user_login = @user_login", connection);
				command.Parameters.Add(new SqlParameter("@user_login", userLogin));
				List<OrderDTO> orders = new();
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
						orders.Add(new OrderDTO
						{
							Id = (int)reader["id"],
							ProductId = (int)reader["product_id"],
							ProductName = (string)reader["product_name"],
							InsertTime = (DateTime)reader["insert_time"],
							UpdateTime = (DateTime)reader["update_time"]
						});
				}

				return orders;
			}
		}
	}
}