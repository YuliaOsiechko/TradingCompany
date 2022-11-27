using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class ManagerRepository : BaseRepository, IManagerRepository
    {
        public ManagerRepository() : base(Helper.CnnVal()) { }
        public ManagerRepository(string connectionString) : base(connectionString) { }

        public void Create(ManagerDTO newManager)
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand command = new("INSERT INTO managers (login, password, disp_name) VALUES (@login, @password, @disp_name)", connection);
                command.Parameters.Add(new SqlParameter("@login", newManager.Login));
                command.Parameters.Add(new SqlParameter("@password", newManager.Password));
                command.Parameters.Add(new SqlParameter("@disp_name", newManager.DispName));
                command.ExecuteNonQuery();
            }
        }
        public List<ManagerDTO> GetAll()
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand command = new("SELECT * FROM managers", connection);
                List<ManagerDTO> managers = new List<ManagerDTO>();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        managers.Add(new ManagerDTO()
                        {
                            Id = (int)reader["id"],
                            Login = (string)reader["login"],
                            Password = (string)reader["password"],
                            DispName = (string)reader["disp_name"],
                            InsertTime = (DateTime)reader["insert_time"],
                            UpdateTime = (DateTime)reader["update_time"]
                        });
                }
                return managers;
            }
        }
        public void DeleteAll()
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand command = new(@"DELETE FROM managers;", connection);
                command.ExecuteNonQuery();
            }
        }
        public ManagerDTO Get(string login)
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand command = new("SELECT * FROM managers WHERE login = @login", connection);
                command.Parameters.Add(new SqlParameter("@login", login));
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        return new ManagerDTO()
                        {
                            Id = (int)reader["id"],
                            Login = (string)reader["login"],
                            Password = (string)reader["password"],
                            DispName = (string)reader["disp_name"],
                            InsertTime = (DateTime)reader["insert_time"],
                            UpdateTime = (DateTime)reader["update_time"]
                        };
                }
                return null;
            }
        }
        public ManagerDTO Get(int id)
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand command = new("SELECT * FROM managers WHERE id = @id", connection);
                command.Parameters.Add(new SqlParameter("@id", id));
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        return new ManagerDTO()
                        {
                            Id = (int)reader["id"],
                            Login = (string)reader["login"],
                            Password = (string)reader["password"],
                            DispName = (string)reader["disp_name"],
                            InsertTime = (DateTime)reader["insert_time"],
                            UpdateTime = (DateTime)reader["update_time"]
                        };
                }
                return null;
            }
        }
        public void UpdateDispName(string login, string newDispName)
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand command = new("UPDATE managers SET disp_name = @new_disp_name WHERE login = @login;", connection);
                command.Parameters.Add(new SqlParameter("@new_disp_name", newDispName));
                command.Parameters.Add(new SqlParameter("@login", login));
                command.ExecuteNonQuery();
            }
        }
        public void UpdatePassword(string login, string newPassword)
        {
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand command = new("UPDATE managers SET password = @new_password WHERE login = @login;", connection);
                command.Parameters.Add(new SqlParameter("@new_password", newPassword));
                command.Parameters.Add(new SqlParameter("@login", login));
                command.ExecuteNonQuery();
            }
        }
    }
}