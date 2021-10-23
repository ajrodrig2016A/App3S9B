using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3S9B
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //GIT
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            //Almacenar los datos en variables
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;


            //Navengando a la ventana dos.
            await Navigation.PushAsync(new viewDos(usuario, contrasena));

        }
    }
}
