using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
          BackgroundColor = Color.Lavender;
           // Title = "Fretins Group";


        }

        void Handle_Pressed(object sender, System.EventArgs e)
        {
            //return string = "Your choice";
                    
        }
       
        private async void Go(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new first_page());
        }
    }
}
