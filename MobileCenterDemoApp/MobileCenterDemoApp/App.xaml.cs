using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MobileCenterDemoApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MobileCenterDemoApp.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            /*
            MobileCenter.Start("ios=d27ac740-6556-48dc-b50e-9bf7d0f24c2f;" +
                                "uwp=" +
                                "android=",
                                typeof(Analytics), typeof(Crashes));
                                */
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
