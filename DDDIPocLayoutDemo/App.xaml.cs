using Xamarin.Forms;
using DLToolkit.Forms.Controls;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace DDDIPocLayoutDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            MainPage = new  NavigationPage(new LoginPage());

        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("android=a8d22aaa-2379-4252-878d-c098aaa51f68;" + "uwp={Your UWP App secret here};" +
                   "ios={Your iOS App secret here}",
                   typeof(Analytics), typeof(Crashes));
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
