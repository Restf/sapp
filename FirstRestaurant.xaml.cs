using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SApp
{
    public partial class FirstRestaurant : ContentPage
    {
       

        //public FirstRestaurant()
        //{
        //    InitializeComponent();
        //    Title = "пр Мира,4";BackgroundColor = Color.Lavender;
        //}
        Label data;




        public FirstRestaurant(){
            InitializeComponent();
            Title = "пр Мира,4"; BackgroundColor = Color.Lavender;
            data = new Label
            {
                Text = "выберите дату",
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label))

            };

            choice = new Picker
            {
                Title = "дата"
            };
            choice.Items.Add("1");
            choice.Items.Add("2");
            choice.Items.Add("3");
            choice.Items.Add("4");
            choice.Items.Add("5");
            choice.Items.Add("6");
            choice.Items.Add("7");
            choice.Items.Add("8");
            choice.Items.Add("9");
            choice.Items.Add("10");
            choice.Items.Add("11");
            choice.Items.Add("12");
            choice.Items.Add("13");
            choice.Items.Add("14");
            choice.Items.Add("15");
            choice.Items.Add("16");
            choice.Items.Add("17");
            choice.Items.Add("18");
            choice.Items.Add("19");
            choice.Items.Add("20");
            choice.Items.Add("21");
            choice.Items.Add("22");
            choice.Items.Add("23");
            choice.Items.Add("24");
            choice.Items.Add("25"); 
            choice.Items.Add("26");
            choice.Items.Add("27");
            choice.Items.Add("28");
            choice.Items.Add("29");
            choice.Items.Add("30");
            choice.Items.Add("31");
           
            choice.SelectedIndexChanged+=Choice_SelectedIndexChanged;

        }
        void Choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.Text = "вы выбрали" + choice.Items[choice.SelectedIndex];
        }

    }
}
