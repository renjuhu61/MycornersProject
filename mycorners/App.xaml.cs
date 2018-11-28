using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace mycorners
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new EditPersonInfo();
            MainPage = new MainTabbedPage();

            //MainPage = new NavigationPage(new MainTabbedPage())
            //{
            //    BarBackgroundColor = Color.FromHex("#94af76"),
            //    BarTextColor = Color.White
            //};

        }

        //public async void OnBackButtonPressed(object sender, EventArgs e)
        //{
        //    await NavigationPage.PopAsync();
        //}

        protected override void OnStart()
        {
            // Handle when your app starts
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
