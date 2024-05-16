using Messanger.Model.User;
using MySql.Data.MySqlClient;
using System.Net.Sockets;

namespace Messanger.DataBase.MySQL {
    internal class MySQLMessangerRepository : IMessangerRepository {
        private const string _connectionString = "server=localhost;user id=root;password=d89-kQV-SW6-KLb;database=messanger";
        private MySqlConnection _connection;

        public MySQLMessangerRepository(string connectionString = _connectionString) {
            _connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnect() {
            try {
                _connection.Open();
                return true;
            } catch(Exception) {
                return false;
            }
        }

        public bool CloseConnect() {
            try {
                _connection.Close();
                return true;
            } catch(Exception) {
                return false;
            }
        }

        public void AddUser(User user) {
            if(!OpenConnect()) return;
            string query = "INSERT INTO users values(null,@fsn,@scn,@log,@pass)";
            MySqlCommand command = _connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@fsn",user.FirstName);
            command.Parameters.AddWithValue("@scn",user.SecondName);
            command.Parameters.AddWithValue("@log",user.Login);
            command.Parameters.AddWithValue("@pass",user.Password);
            command.ExecuteNonQuery();
            CloseConnect();
        }

        public void RemoveUser(User user) {
            if(!OpenConnect()) return;
            string query = "delete from users where id = @id";
            MySqlCommand command = _connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@id",user.Id);
            command.ExecuteNonQuery();
            CloseConnect();
        }

        public void UpdateUser(User user) {
            if(!OpenConnect()) return;
            string query = @"update users
                           set firstName = @fsn,
                               secondName = @snc,
                               login = @log,
                               password = @pass where id = @id";
            MySqlCommand command = _connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@fsn",user.FirstName);
            command.Parameters.AddWithValue("@scn",user.SecondName);
            command.Parameters.AddWithValue("@log",user.Login);
            command.Parameters.AddWithValue("@pass",user.Password);
            command.Parameters.AddWithValue("@id",user.Id);
            command.ExecuteNonQuery();
            CloseConnect();
        }

        public User GetUser(string login,string password) {
            if(OpenConnect()) return null;
            User user = new User();
            string query = "select * from users where login = @log and password = @pass";
            MySqlCommand command = _connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@log",login);
            command.Parameters.AddWithValue("@pass",password);
            MySqlDataReader reader = command.ExecuteReader();

            user.Id = reader.GetInt32(0);
            user.FirstName = reader.GetString(1);
            user.SecondName = reader.GetString(2);
            user.Login = reader.GetString(3);
            user.Password = reader.GetString(4);
            return user;
        }
    }
}
