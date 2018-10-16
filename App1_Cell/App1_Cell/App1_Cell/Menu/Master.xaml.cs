using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        public void GoPagina1(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Paginas.TextCellPage());
        }

        public void GoImageCellPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Paginas.ImageCellPage());
        }

        public void GoEntryCellPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Paginas.EntryCellPage());
        }

        public void GoSwitchCellPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Paginas.SwitchCellPage());
        }

        public void GoViewCellPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Paginas.ViewCellPage());
        }

    }
}