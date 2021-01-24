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
    public partial class EntryEditorPage : ContentPage
    {
        public EntryEditorPage()
        {
            InitializeComponent();
            //faz com que aparça em tempo real
            TxtIdade.TextChanged += delegate (object sender,TextChangedEventArgs args) {

                Lbl_Duplicado.Text = args.OldTextValue;
            };

            //conta a quantifdade de caractere quando tira o foco do Edito
            TxtComentario.Completed += delegate(Object sender, EventArgs args){
              LblQuantidadeCaracteres.Text =   TxtComentario.Text.Length.ToString();
            };
        }

       
    }
}