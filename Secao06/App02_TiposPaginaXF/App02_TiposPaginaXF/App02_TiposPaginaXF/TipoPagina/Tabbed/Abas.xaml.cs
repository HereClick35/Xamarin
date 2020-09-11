using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TiposPaginaXF.TipoPagina.Tabbed
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Abas : TabbedPage
	{
		public Abas ()
		{
			InitializeComponent ();

            Children.Add(new NavigationPage(new TipoPagina.Navigation.Pagina001()) { Title = "Pag.03", BarBackgroundColor = Color.Yellow, Icon= "play.png" });
            Children.Add(new NavigationPage(new TipoPagina.Navigation.Pagina002()) { Title = "Pag.04", BarBackgroundColor = Color.YellowGreen, Icon = "play.png" });
        }
	}
}