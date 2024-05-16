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
            string query = "INSERT INTO TABLE users(null,@fsn,@scn,@log,@pass)";
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
<<<<<<< HEAD
          if(!OpenConnect())return;
            string query = "DELETE FROM users WHERE id = @id;";
            MySqlCommand command= _connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@id", user.Id);
            command.ExecuteNonQuery();
            CloseConnect(); 
=======
            if(!OpenConnect()) return;
            string query = "delete from users where id = @id";
            MySqlCommand command = _connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@id",user.Id);
            command.ExecuteNonQuery();
            CloseConnect();
>>>>>>> 449fd80b176a455fc8f9366af0c593146cde84af
        }

        public void UpdateUser(User user) {
            throw new NotImplementedException();
        }
    }
}
