using System;
using TestDrive.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TestDrive
{
    public partial class App : Application
    {
        #region Constructor
        public App()
        {
            InitializeComponent();

            InitializeIocApp();

            MainPage = new MainPage();
        } 
        #endregion

        #region Methods Privates
        private void InitializeIocApp()
        {
            ModuleInitialize.Inicialize();
        } 
        #endregion

        #region Cicly of Life App
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
        #endregion
    }
}
