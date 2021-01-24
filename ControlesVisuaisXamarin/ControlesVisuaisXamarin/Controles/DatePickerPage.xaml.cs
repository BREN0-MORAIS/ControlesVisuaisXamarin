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
    public partial class DatePickerPage : ContentPage
    {
        public DatePickerPage()
        {
            InitializeComponent();
        }

        public void Action(object sender, DateChangedEventArgs args)
        {
            Resultado.Text = args.OldDate.ToString("dd/mm/yyyy") +  "" + "" + args.NewDate.ToString("dd/mm/yyyy");
        }
    }
}