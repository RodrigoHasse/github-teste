using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TiposPagina.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void MudarPagina1(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Navegation.Page1());
            IsPresented = false;
        }

        private void MudarPagina2(object sender, EventArgs args)
        {
            Detail = new Navegation.Page2();
            IsPresented = false;
        }

        private void MudarConteudo(object sender, EventArgs args)
        {
            Detail = new Conteudo();
            IsPresented = false;
        }
    }
}