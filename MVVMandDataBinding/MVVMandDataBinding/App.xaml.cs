using MVVMandDataBinding.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMandDataBinding
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MessagePage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
