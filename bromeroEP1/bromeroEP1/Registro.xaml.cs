using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace bromeroEP1
{
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
        }

        void btnCalcular_Clicked(System.Object sender, System.EventArgs e)
        {
            double vInicial = Convert.ToDouble(txtValorInicial.Text);

            double mesmas5 = Convert.ToDouble(txtPagoMensual.Text);

            double curso = 4000;
            double vRestante = (curso - vInicial);
            double cuotas = (vRestante / 5);

            mesmas5 = (cuotas * 1.05);

            txtPagoMensual.Text = mesmas5.ToString();

            if (vInicial >= 1 && vInicial < 4000)
            {
                DisplayAlert("Dato Correcto ", "Ingreso de datos corecto", "Cerrar");

            }
            else
            {
                DisplayAlert("Dato incorrecto " + vInicial, "Ingrese un Dato correcto", "Cerrar");
            }
        }

        void btnGardar_Clicked(System.Object sender, System.EventArgs e)
        {
            String nombre = Convert.ToString(txtNombre.Text);
            double mesmas5 = Convert.ToDouble(txtPagoMensual.Text);
            double vInicial = Convert.ToDouble(txtValorInicial.Text);

            double op = ((mesmas5 * 5 )+ vInicial);

         

            Navigation.PushAsync(new Resumen(nombre, op));
        }
    }
}


