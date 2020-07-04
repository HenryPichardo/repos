using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace CalculadoraAFP
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
      
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Acumulado.Text))
            {
                var acumulado = double.Parse(Acumulado.Text);
                var resultado = acumulado * 0.30;

                Resultado.Text = resultado.ToString();

                string aviso;

                if (acumulado <= 10000)
                {
                    aviso = "Error debe introducir un acumulado mayor a diez mil pesos.";
                }
                else if (acumulado >= 5000000)
                {
                    aviso = "Error debe introducir un acumulado menor a cinco millones de pesos.";
                }
                else
                {
                    aviso = "Esta aplicacion fue desarrollada por Henry Pichardo";
                }
                DisplayAlert("Aviso", aviso, "Ok");
            }
            else
            {
                DisplayAlert("Error", "El campo: Acumulado, no puede estar vacio, por favor ingrese su acumulado", "Ok");
            }
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Browser.OpenAsync("http://www.sipen.gov.do/index.php/servicios/consulta-de-afp", BrowserLaunchMode.SystemPreferred);
        }

        private void Acumulado_Focused(object sender, FocusEventArgs e)
        {
            Resultado.Text = "";
        }
    }
}
