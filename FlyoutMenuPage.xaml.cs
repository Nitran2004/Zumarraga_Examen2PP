using Microsoft.Maui.Controls;
using System;

namespace Zumarraga_Examen2P
{
    public partial class FlyoutMenuPage : ContentPage
    {
        public FlyoutMenuPage()
        {
            InitializeComponent();
        }

        private async void OnOption1Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opcion1Page());
        }

        private async void OnOption2Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Opcion2Page());
        }

        private async void OnCustomPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomPage());
        }
    }
}
