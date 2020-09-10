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
        string _DtAtual = "";
        public Pagina001 (string date)
		{   
			InitializeComponent ();
            _DtAtual = date.ToString();
            lblDataAtual.Text = _DtAtual;
        }

        private void MudarParaPagina2(object sender, EventArgs args)
        {
            _DtAtual = DateTime.Now.ToString("u");
            Navigation.PushAsync(new Pagina002(_DtAtual), true);
        }
        
        private void ChamarModal(object sender, EventArgs args)
        {
            // Aula 40 - NavigationPage - Modal
            Navigation.PushModalAsync(new Modal());
        }
    }
}