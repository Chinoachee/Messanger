using Messanger.Model.User;
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
        public void AddUser(User user)
        {
           if(!OpenConnect()) return;
            string query = "INSERT INTO users VALUES (null, @fn, @sn, @log, @pas);";
            SqliteCommand cmd = _connection.CreateCommand();
            cmd.CommandText = query;
            //добавление параметров в таблицу
            cmd.Parameters.AddWithValue("@fn", user.FirstName);
            cmd.Parameters.AddWithValue("@sn", user.SecondName);
            cmd.Parameters.AddWithValue("@log", user.Login);
            cmd.Parameters.AddWithValue("@pas", user.Password);
            cmd.ExecuteNonQuery();  //выполнить запрос
        }

        public void RemoveUser(User user)
        {
            
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
