using System;
using Xamarin.Forms;

namespace MobileCenterDemoApp
{
    public partial class MainPage : ContentPage
    {
        string translatedNumber;

        public MainPage()
        {
            InitializeComponent();
        }

        private void translateButton_Clicked(object sender, EventArgs e)
        {
            translatedNumber = Core.PhoneTranslator.ToNumber(phoneNubmerText.Text);

            if(!string.IsNullOrWhiteSpace(translatedNumber))
            {
                callButton.IsEnabled = true;
                callButton.Text = "Call " + translatedNumber;
            }
            else
            {
                callButton.IsEnabled = false;
                callButton.Text = "Call";
            }
        }

        async void callButton_Clicked(object sender, EventArgs e)
        {
            if(await this.DisplayAlert (
                    "Dial a Number", 
                    "Would you like to call " + translatedNumber + "?",
                    "Yes",
                    "No")) {
                var dialer = DependencyService.Get<IDialer>();
                if (dialer != null)
                    dialer.Dial(translatedNumber);

            }
        }
    }
}
