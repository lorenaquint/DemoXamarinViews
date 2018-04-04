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
            //edDesc.Completed += EdDesc_Completed;
            //edDesc.TextChanged += EdDesc_TextChanged;
            //this.entPassword.TextChanged += EntPassword_TextChanged;
            //this.entPassword.Completed += EntPassword_Completed;

        }

        //private void EntPassword_Completed(object sender, EventArgs e)
        //{
        //    DisplayAlert("Entry", "Completado", "Aceptar");
        //}

        //private void EntPassword_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    DisplayAlert("Entry", "Modificando", "Aceptar");
        //}

        //private void EdDesc_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    DisplayAlert("Editor", "Modificando", "Aceptar");
        //}

        //private void EdDesc_Completed(object sender, EventArgs e)
        //{
        //    DisplayAlert("Editor", "Fuera del área de texto", "Aceptar");
        //}

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
