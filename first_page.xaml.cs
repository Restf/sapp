using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SApp
{
    public partial class first_page : ContentPage
    {
        

        public first_page()
        {
            InitializeComponent();
            BackgroundColor = Color.Lavender;
        }

        private async void BackButton_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FirstRestaurant());
        }

    }
}
