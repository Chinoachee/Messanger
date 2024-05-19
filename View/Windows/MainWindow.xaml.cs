using Messanger.DataBase;
using Messanger.DataBase.MySQL;
using System.Windows;

namespace Messanger.View.Windows {
    public partial class MainWindow : Window {
        IMessangerRepository _repository;
        public MainWindow() {
            _repository = new MySQLMessangerRepository();
            InitializeComponent();
            mainPage.NavigationService.Navigate(new AutorizationPage());
        }
    }
}
