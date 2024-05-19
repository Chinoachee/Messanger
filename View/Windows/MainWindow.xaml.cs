using Messanger.DataBase;
using Messanger.DataBase.EntityFramework.MySQL;
using Messanger.DataBase.MySQL;
using Messanger.Model.User;
using System.Windows;

namespace Messanger.View.Windows {
    public partial class MainWindow : Window {
        IMessangerRepository _repository;
        MySQLApplicationContext _context;
        public MainWindow() {
            _context = new MySQLApplicationContext();
            _repository = new MySQLMessangerRepository();
            InitializeComponent();
        }

        private void buttonAccept_Click(object sender,RoutedEventArgs e) {
            User user = new User();
            user.FirstName = "Andrey";
            user.SecondName = "Pupkin";
            user.Login = "andrushka";
            user.Password = "1234";
            _context.Users.Add(user);
            _context.SaveChanges();



        }
    }
}
