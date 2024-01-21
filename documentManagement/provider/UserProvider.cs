using Npgsql;
using System;

namespace documentManagement.provider
{
    public class UserProvider
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Document;User Id=postgres;Password=0987");

        public bool isValidUser(string username, string password)
        {
            connection.Open();
            var command = new NpgsqlCommand("Select * from users u INNER JOIN role r ON r.id = u.role_id" +
                " where login=@username and password=@password", connection); 
            command.Parameters.AddWithValue("username", username);
            command.Parameters.AddWithValue("password", password);
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                string role = (string)reader["title"];
                connection.Close();
                reader.Close();
                if (!role.Equals("Администратор") && !role.Equals("Менеджер"))
                {
                    return false;
                }
                return true;
            }
            else
            {
                connection.Close();
                reader.Close();
                return false;
            }
        }

        public string getRoleByLogin(string login)
        {
            connection.Open();
            var command = new NpgsqlCommand("Select r.title from users u INNER JOIN role r ON r.id = u.role_id where u.login=@username", connection);
            command.Parameters.AddWithValue("username", login);
            string role = (string)command.ExecuteScalar();
            connection.Close();
            return role;
        }

        public bool isValidReg(string login)
        {
            connection.Open();
            var command = new NpgsqlCommand("Select * from users where login=@login", connection);
            command.Parameters.AddWithValue("login", login);
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                connection.Close();
                return false;
            }
            else
            {
                reader.Close();
                connection.Close();
                return true;
            }
        }

        public bool addUser(string login, string password, string role)
        {
            if (isValidReg(login))
            {
                connection.Open();
                var command1 = new NpgsqlCommand("Select id from role where title=@role", connection);
                command1.Parameters.AddWithValue("role", role);
                int roleId = (int)command1.ExecuteScalar();

                var command2 = new NpgsqlCommand("INSERT INTO users (id, login, password, role_id) VALUES (nextval('user_id_seq'), @login, @password, @role_id)", connection);
                command2.Parameters.AddWithValue("login", login);
                command2.Parameters.AddWithValue("password", password);
                command2.Parameters.AddWithValue("role_id", roleId);
                int rowsAffected = command2.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool existsByLogin(string login)
        {
            connection.Open();
            var command = new NpgsqlCommand("SELECT COUNT(1) FROM Users WHERE Login = @login", connection);
            command.Parameters.AddWithValue("login", login);

            long countRow = (long)command.ExecuteScalar();
            connection.Close();
            if (countRow != 1) { return false; }
            return true;
        }

        public void resetPassword(string password, string login)
        {
            connection.Open();
            var command = new NpgsqlCommand("Update users SET password=@password WHERE login=@login", connection);
            command.Parameters.AddWithValue("password", password);
            command.Parameters.AddWithValue("login", login);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
