using Messanger.DataBase;
using Messanger.DataBase.MySQL;
using Messanger.DataBase.SQLite;
using Messanger.Model.User;
using System.Windows;

namespace Messanger.View.Windows {
    public partial class MainWindow : Window {
        IMessangerRepository _repository;
        public MainWindow() {
            _repository = new SQLiteMessangerRepository;
            InitializeComponent();
        }

        private void buttonAccept_Click(object sender,RoutedEventArgs e) {
            User user = _repository.GetUser(loginTextBox.Text,passwordTextBox.Text);
            if(user == null) return;
            idNameLabel.Content = user.Id;
            firstNameLabel.Content = user.FirstName;
            secondNameLabel.Content = user.SecondName;
            loginNameLabel.Content = user.Login;
            passwordNameLabel.Content = user.Password;
        }
    }
}
