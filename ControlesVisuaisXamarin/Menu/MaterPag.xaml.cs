using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlesVisuaisXamarin.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MaterPag : MasterDetailPage
    {
        public MaterPag()
        {
            InitializeComponent();
        }


        private void GoActivit(object sender, EventArgs args)
        {
            Detail = new Controles.ActivityIndicatorPage();
        }  
        private void GoProgressBarPage(object sender, EventArgs args)
        {
            Detail = new Controles.ProgresseBarPage();
        } 
        private void GoBoxViewPage(object sender, EventArgs args)
        {
            Detail = new Controles.BoxPage();
        }  
        private void GoLabel(object sender, EventArgs args)
        {
            Detail = new Controles.Label();
        }  
        private void GoButton(object sender, EventArgs args)
        {
            Detail = new Controles.ButtonPage();
        }  
        private void GoEntryEditorPage(object sender, EventArgs args)
        {
            Detail = new Controles.EntryEditorPage();
        }
        private void GoDataPickerPage(object sender, EventArgs args)
        {
            Detail = new Controles.DatePickerPage();
        }
        private void GoTimerPickerPage(object sender, EventArgs args)
        {
            Detail = new Controles.TimerPickerPage();
        }
  
        private void GoPickerPage(object sender, EventArgs args)
        {
            Detail = new Controles.PickerPage();
        }
        private void GoSerchBarPage(object sender, EventArgs args)
        {
            Detail = new Controles.SerchBarPage();
        }
    }
}