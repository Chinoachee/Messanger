using Messanger.View.Pages.AutorizationPages;
using System.Windows.Controls;

namespace Messanger.View {
    public partial class AutorizationPage : Page {
        public AutorizationPage() {
            InitializeComponent();
            RegistrationFrame.NavigationService.Navigate(new LoginPage());
        }
    }
}
