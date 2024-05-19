using Messanger.Model.Message;
using Messanger.Model.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messanger.DataBase.EntityFramework.MySQL
{
    
    public class MySQLApplicationContext : DbContext
    {
        private string _connectionString = "Server=localhost;user id=user;password=user;database=efMessanger;";
        public DbSet<User> Users {  get; set; } 
        public DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;user id=user;password=user;database=efmessanger;"
                , new MySqlServerVersion(new Version(8, 0, 37)));
        }
        public MySQLApplicationContext()
        {
            Database.EnsureCreated();
        }
    }
}
