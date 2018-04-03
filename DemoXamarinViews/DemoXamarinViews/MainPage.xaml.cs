using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoXamarinViews
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        private void Button_Clicked(object sender, EventArgs args)

        {
            DisplayAlert("Mensaje", "Haz hecho clic", "Ok");
        }
    }
}
