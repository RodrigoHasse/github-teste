using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TiposPagina.Navegation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}

        private void MudarPagina2(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Page2());
        }

        private void MostrarModal(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new modal());
        }

        private void MostrarMaster(object sender,EventArgs args)
        {
            App.Current.MainPage = new Master.Master();
        }

    }
}