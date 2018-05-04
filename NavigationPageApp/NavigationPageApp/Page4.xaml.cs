using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationPageApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page4 : ContentPage
	{
		public Page4 ()
		{
			InitializeComponent ();
            this.btnCerrar.Clicked += BtnCerrar_Clicked;
		}

        private void BtnCerrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}