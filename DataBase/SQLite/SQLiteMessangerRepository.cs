﻿using Messanger.Model.User;
using Microsoft.Data.Sqlite;
using MySql.Data.MySqlClient;

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
            if (!OpenConnect()) return;
            string query = "DELETE FROM users WHERE id = @id;";
            SqliteCommand command = _connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@id", user.Id);
            command.ExecuteNonQuery();
            CloseConnect();
        }

        public void UpdateUser(User user)
        {
            if(!OpenConnect()) return;
            string query = "UPDATE users SET firstName = @fn, secondName = @sn, login =@log, password = @pass WHERE id = @id";
            SqliteCommand command= _connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@fn", user.FirstName);
            command.Parameters.AddWithValue("@sn", user.SecondName);
            command.Parameters.AddWithValue("@log", user.Login);
            command.Parameters.AddWithValue("@pass", user.Password);
            command.ExecuteNonQuery();
            CloseConnect(); 
        }

        public User GetUser(string login, string password)
        {
            if (!OpenConnect()) return null;
            string query = "SELECT FROM users where login = @log and password = @pass";
            SqliteCommand command = _connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@log", login);
            command.Parameters.AddWithValue("@pass", password);
            SqliteDataReader reader = command.ExecuteReader();
            reader.Read();
            User user = new User()
            {
                Id = reader.GetInt32(0),
                FirstName = reader.GetString(1),
                SecondName = reader.GetString(2),
                Login = reader.GetString(3),
                Password = reader.GetString(4)
            };
            return user;

        }
    }
}
