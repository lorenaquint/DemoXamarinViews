using System;
using System.Collections.Generic;
using System.Globalization;
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
            //btnImg.Clicked += btnImg_OnClicked;
            //dtp.MinimumDate = new DateTime(1990, 1, 1);
            //dtp.MaximumDate = new DateTime(2020, 1, 1);
            //dtp.DateSelected += Dtp_DateSelected;

        }

        //private void Dtp_DateSelected(object sender, DateChangedEventArgs e)
        //{
        //    CultureInfo culture = new CultureInfo("es-ES");
           
        //   //DisplayAlert("Fecha", e.NewDate.ToString("D",culture), "Aceptar");
        //    DisplayAlert("Fecha", e.NewDate.ToString(), "Aceptar");
        //}

        //private void btnImg_OnClicked(object sender, EventArgs e)
        //{
        //    DisplayAlert("Mensaje", "Manenando eventos con sintaxis estándar", "Aceptar");
        //}

        //private void btnImg_Clicked(object sender, EventArgs args)

        //{
        //    DisplayAlert("Mensaje", "Manejando eventos desde XAML", "Aceptar");
        //}
    }
}
