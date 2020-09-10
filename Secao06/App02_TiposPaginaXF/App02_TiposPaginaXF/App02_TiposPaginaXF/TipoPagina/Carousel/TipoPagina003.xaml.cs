using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TiposPaginaXF.TipoPagina.Carousel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TipoPagina003 : ContentPage
	{
		public TipoPagina003 ()
		{
			InitializeComponent ();
		}

        private void MudarPagina(object sender, EventArgs args)
        {
            //App.Current.MainPage = new Navigation.Pagina001();
            // incluindo pagina na pilha, ativando desta forma o recurso de voltar pagina anterior            
            App.Current.MainPage = new NavigationPage(new Navigation.Pagina001(DateTime.Now.ToString("u")));
        }
    }
}