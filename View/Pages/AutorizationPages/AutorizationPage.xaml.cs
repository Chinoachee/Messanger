using Messanger.View.Pages.AutorizationPages;
using System.Windows.Controls;
using System.Windows.Media;

namespace Messanger.View {
    public partial class AutorizationPage : Page {
        public AutorizationPage() {
            InitializeComponent();
            RegistrationFrame.NavigationService.Navigate(new LoginPage());
        }

        private void gotoLoginPage_Click(object sender,System.Windows.RoutedEventArgs e) {
            gotoLoginPage.BorderBrush = (Brush)new BrushConverter().ConvertFrom("#eeaa74");
            gotoRegistrationPage.BorderBrush = (Brush)new BrushConverter().ConvertFrom("Transparent");
            RegistrationFrame.NavigationService.Navigate(new LoginPage());
        }

        private void gotoRegistrationPage_Click(object sender,System.Windows.RoutedEventArgs e) {
            gotoLoginPage.BorderBrush = (Brush)new BrushConverter().ConvertFrom("Transparent");
            gotoRegistrationPage.BorderBrush = (Brush)new BrushConverter().ConvertFrom("#eeaa74");
            RegistrationFrame.NavigationService.Navigate(new RegisrationPage());
        }
    }
}
