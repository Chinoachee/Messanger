using Messanger.DataBase;
using Messanger.DataBase.MySQL;
using System.Windows;
using System.Windows.Input;

namespace Messanger.View.Windows {
    public partial class MainWindow : Window {
        IMessangerRepository _repository;
        public static MainWindow window;
        public MainWindow() {
            _repository = new MySQLMessangerRepository();
            InitializeComponent();
            mainPage.NavigationService.Navigate(new AutorizationPage());
            window = this;
        }
        private void MovingWindow(object sender,RoutedEventArgs e) {
            if(Mouse.LeftButton == MouseButtonState.Pressed) {
                MainWindow.window.DragMove();
            }
        }
    }
}
