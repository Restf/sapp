using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SApp
{
    public partial class FirstRestaurant : ContentPage
    {
        void Choice_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        async void Method_Button1(object sender, EventArgs e) {
            string[] arr = new string[30];

            for (int i = 0; i < 30; i++)
                arr[i] = (i + 1).ToString();
            var acr = await DisplayActionSheet("Menu", "Cancel", null, arr);
        }
        async void Method_Button2(object sender, EventArgs e)
        {
            string[] arr = new string[12];

            for (int i = 0; i < 12; i++)
                arr[i] = (i + 1).ToString();
            var acr = await DisplayActionSheet("Menu", "Cancel", null, arr);
        }
        async void Method_Button3(object sender, EventArgs e)
        {
            string[] arr = new string[5];

            for (int i = 0; i < 5; i++)
                arr[i] = (i + 1).ToString();
            var acr = await DisplayActionSheet("Menu", "Cancel", null, arr);
        }
       

        //public FirstRestaurant()
        //{
        //    InitializeComponent();
        //    Title = "пр Мира,4";BackgroundColor = Color.Lavender;
        //}
        Label data;



        Picker choice;
        public FirstRestaurant(){
            InitializeComponent();
            Title = "пр Мира,4"; BackgroundColor = Color.Lavender;
  

        }
      

    }
}
