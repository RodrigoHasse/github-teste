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
            IsPresented = false;
        }

        public void GoImageCellPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Paginas.ImageCellPage());
            IsPresented = false;
        }

        public void GoEntryCellPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Paginas.EntryCellPage());
            IsPresented = false;
        }

        public void GoSwitchCellPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Paginas.SwitchCellPage());
            IsPresented = false;
        }

        public void GoViewCellPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Paginas.ViewCellPage());
            IsPresented = false;
        }

        public void GoListViewPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Paginas.ListViewPage());
            IsPresented = false;
        }

        public void GoListViewButtonPage(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Paginas.ListViewButtonPage());
            IsPresented = false;
        }
    }
}