using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace bromeroEP1
{
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre, double op)
        {
            InitializeComponent();

            //lblUsuario.Text = "Bienvedido" + usuario;
            lblEstud.Text = "Estudiante  " + nombre;
            lbltCancelado.Text = "Valor Total Cancelado:  " + op;
        }

        void btnAyuda_Clicked(System.Object sender, System.EventArgs e)
        {
            String nombre = "Byron";
            String apellido = "Romero";
            String ex = "Examen parcia 1";
            DisplayAlert("Datos Personales",  nombre+"\n " + apellido +"\n"+ ex, "Datos", "Cerrar");
        }
    }
}

