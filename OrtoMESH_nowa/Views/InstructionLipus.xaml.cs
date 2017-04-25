using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OrtoMESH_nowa.Views
{
    public partial class InstructionLIPUS : ContentPage
    {
        void Start_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new LipusPage());
            DisplayAlert("Lipus treatment", "I have read the Lipus manual", "Start");
        }

        public InstructionLIPUS()
        {
            InitializeComponent();
        }
    }
}
