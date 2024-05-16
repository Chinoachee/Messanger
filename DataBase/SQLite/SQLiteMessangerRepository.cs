using Microsoft.Data.Sqlite;

namespace Messanger.DataBase.SQLite {
    internal class SQLiteMessangerRepository : IMessangerRepository {
        private const string connectionString = "Data Source ";
        private SqliteConnection _connection;
        public SQLiteMessangerRepository(string connectionString = connectionString) {
            _connection = new SqliteConnection(connectionString);
        }

        //методы для подключения к базе данных
        public bool CloseConnect()
        {
            try
            {
                _connection.Close();
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public bool OpenConnect()
        {
            try
            {
                _connection.Open();
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }
    }
}
