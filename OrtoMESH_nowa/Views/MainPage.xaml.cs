using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace OrtoMESH_nowa.Views
{
    public partial class MainPage : ContentPage
    {
        void PushTo_Doctor(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Doctor());
        }

        void PushTo_Patient(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Patient());
        }

        public MainPage()
        {
            InitializeComponent();
    
        }

    
    }
}

