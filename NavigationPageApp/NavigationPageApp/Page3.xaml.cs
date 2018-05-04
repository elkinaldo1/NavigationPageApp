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
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();
            this.btnInicial.Clicked += BtnInicial_Clicked;
            this.btnAtras.Clicked += BtnAtras_Clicked;
            this.btnModal.Clicked += BtnModal_Clicked;
		}

        private async void BtnModal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page4());
        }

        private async void BtnAtras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void BtnInicial_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}