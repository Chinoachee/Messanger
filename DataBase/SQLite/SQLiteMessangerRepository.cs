using Microsoft.Data.Sqlite;

namespace Messanger.DataBase.SQLite {
    internal class SQLiteMessangerRepository : IMessangerRepository {
        private const string connectionString = "Data Source ";
        private SqliteConnection _connection;
        public SQLiteMessangerRepository(string connectionString = connectionString) {
            _connection = new SqliteConnection(connectionString);
        }

        public bool CloseConnect()
        {
            throw new NotImplementedException();
        }

        public bool OpenConnect()
        {
            throw new NotImplementedException();
        }
    }
}
