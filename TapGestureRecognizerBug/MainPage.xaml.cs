using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TapGestureRecognizerBug
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new PersonViewModel();
        }

        private async void OnGridClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Tap Detected!", "Tap Detected!", "ok");
        }
    }
}
