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
		public Pagina002 (string data)
		{
			InitializeComponent ();
            lblDataAtual2.Text = data;
        }
	}
}