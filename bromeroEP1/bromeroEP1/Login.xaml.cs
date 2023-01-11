using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace bromeroEP1
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        void btnIniciar_Clicked(System.Object sender, System.EventArgs e)
        {
            string usuario = "estudiante2023";

            string contraseña = "uisrael2023";
            if (usuario == txtUsuario.Text && contraseña == txtContraseña.Text)
            {
                Navigation.PushAsync(new Registro(usuario));
            }
            else
            {
                DisplayAlert("MENSAJE DE ERROR", "Usuario o Contraseña incdorrecta", "Cerrar");


            }
        }
    }
}

