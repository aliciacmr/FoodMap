using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace FoodMap
{
    public partial class HomePage : ContentPage
    {
        public ObservableCollection<CategoryItem> Categories { get; set; }

        public HomePage()
        {
            InitializeComponent();

            // Sample data
            Categories = new ObservableCollection<CategoryItem>
            {
                new CategoryItem
                {
                    Name = "Super marché",
                    Image = "supermarket.jpg"
                },
                new CategoryItem
                {
                    Name = "Restaurant",
                    Image = "restaurant.jpg"
                }
            };

            // IMPORTANT: Définir le BindingContext AVANT d'accéder à la vue
            BindingContext = this;
        }

        private void OnMenuTapped(object sender, EventArgs e)
        {
            // Menu - non implémenté
        }

        private void OnCartTapped(object sender, EventArgs e)
        {
            // Panier - non implémenté
        }

        private void OnCategoryTapped(object sender, TappedEventArgs e)
        {
            if (e.Parameter is CategoryItem category)
            {
                if (category.Name == "Restaurant")
                {
                    Shell.Current.GoToAsync("//RestaurantDetailPage");
                }
                else if (category.Name == "Super marché")
                {
                    // Super marché - non implémenté
                }
            }
        }
    }

    public class CategoryItem
    {
        public string Name { get; set; }
        public string Image { get; set; }
    }
}