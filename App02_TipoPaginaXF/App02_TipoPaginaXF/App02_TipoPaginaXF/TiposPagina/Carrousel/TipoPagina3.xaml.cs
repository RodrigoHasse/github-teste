using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TiposPagina.Carrousel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TipoPagina3 : ContentPage
	{
		public TipoPagina3 ()
		{
			InitializeComponent ();
		}

        private void MudarPagin(object sender, EventArgs args)
        {
            //App.Current.MainPage = new NavigationPage(new Navegation.Page1()) {BarBackgroundColor = Color.Blue };
            App.Current.MainPage = new Tabbet.Abas();
        }

    }
}