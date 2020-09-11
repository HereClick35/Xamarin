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
	public partial class Pagina001 : ContentPage
	{
        public Pagina001 ()
		{   
			InitializeComponent ();            
            lblDataAtual.Text = DateTime.Now.ToString();
        }

        private void MudarParaPagina2(object sender, EventArgs args)
        {
            
            Navigation.PushAsync(new Pagina002(), true);
        }
        
        private void ChamarModal(object sender, EventArgs args)
        {
            // Aula 40 - NavigationPage - Modal
            Navigation.PushModalAsync(new Modal());
        }
    }
}