using Messanger.DataBase;
using Messanger.DataBase.MySQL;
using Messanger.Model.User;
using System.Windows;

namespace Messanger.View.Windows {
    public partial class MainWindow : Window {
        IMessangerRepository _repository;
        public MainWindow() {
            _repository = new MySQLMessangerRepository();
            InitializeComponent();
        }

        private void buttonAccept_Click(object sender,RoutedEventArgs e) {
            User newUser = new User() {
                FirstName = firstNameTextBox.Text,
                SecondName = secondNameTextBox.Text,
                Login = loginTextBox.Text,
                Password = passwordTextBox.Text,
            };
            _repository.AddUser(newUser);
        }
    }
}
