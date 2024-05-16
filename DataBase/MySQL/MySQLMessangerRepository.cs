using MySql.Data.MySqlClient;

namespace Messanger.DataBase.MySQL {
    internal class MySQLMessangerRepository : IMessangerRepository {
        private const string _connectionString = "server=localhost;user id=root;password=d89-kQV-SW6-KLb;database=messanger";
        private MySqlConnection _connection;

        public MySQLMessangerRepository(string connectionString = _connectionString) {
            _connection = new MySqlConnection(connectionString);
        }

        bool IMessangerRepository.OpenConnect() {
            try {
                _connection.Open();
                return true;
            } catch(Exception) {
                return false;
            }
        }

        bool IMessangerRepository.CloseConnect() {
            try {
                _connection.Close();
                return true;
            } catch(Exception) {
                return false;
            }
        }
    }
}
