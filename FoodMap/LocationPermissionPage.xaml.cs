using Microsoft.Maui.Controls;

namespace FoodMap
{
    public partial class LocationPermissionPage : ContentPage
    {
        public LocationPermissionPage()
        {
            InitializeComponent();
        }

        private async void OnAcceptClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//HomePage");
        }

        private void OnCheckboxLabelTapped(object sender, EventArgs e)
        {
            DontAskCheckbox.IsChecked = !DontAskCheckbox.IsChecked;
        }
    }
}