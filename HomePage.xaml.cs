using Microsoft.Maui.Controls;

namespace FoodMap.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void OnMenuTapped(object sender, EventArgs e)
        {
            // Menu - non implémenté
        }

        private void OnCartTapped(object sender, EventArgs e)
        {
            // Panier - non implémenté
        }

        private void OnSupermarketTapped(object sender, EventArgs e)
        {
            // Super marché - non implémenté
        }

        private async void OnRestaurantTapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//RestaurantDetailPage");
        }
    }
}