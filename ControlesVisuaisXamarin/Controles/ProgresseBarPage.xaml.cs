using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlesVisuaisXamarin.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProgresseBarPage : ContentPage
    {
        public ProgresseBarPage()
        {
            InitializeComponent();
        
        }

        private void Modificar(object sender, EventArgs e)
        {
            Bar1.Progress =+ 1;
            Bar2.ProgressTo(1, 5000,Easing.Linear);
            Bar3.ProgressTo(1, 6000, Easing.SpringIn);
        }
    }
}