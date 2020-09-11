using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TiposPaginaXF.TipoPagina.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina002 : ContentPage
	{
		public Pagina002 ()
		{
			InitializeComponent ();
            lblDataAtual2.Text = DateTime.Now.ToString("u");
        }

        private void ChamarModal(object sender, EventArgs args)
        {
            // Aula 40 - NavigationPage - Modal
            Navigation.PushModalAsync(new Modal());
        }

        private void CallPageTabbed(object sender, EventArgs args)
        {
            // Class 41 - Working with TabbedPage
            Navigation.PushAsync(new Tabbed.Abas());
        }
    }
}