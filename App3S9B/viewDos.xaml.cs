using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3S9B
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class viewDos : ContentPage
    {
        public viewDos(string usuario, string contrasena)
        {
            InitializeComponent();
            //Envio a los Label
            lblUsuario.Text = usuario;
            lblContrasena.Text = contrasena;
            //Envio a las cajas de texto
            txtUsuario.Text = usuario;
            txtContrasena.Text = contrasena;
        }
    }
}