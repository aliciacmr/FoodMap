using Microsoft.Maui.Controls;

namespace FoodMap.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LocationPermissionPage");
        }

        private void OnCreateAccountClicked(object sender, EventArgs e)
        {
            // Création de compte - non implémentée
        }
    }
}