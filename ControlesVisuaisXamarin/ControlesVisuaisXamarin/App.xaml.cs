using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlesVisuaisXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ControlesVisuaisXamarin.Menu.MaterPag();
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
