using App_Jwt.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Jwt
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void GetTokenAction(object sender, EventArgs args)
        {
            string resultado = await JWTService.GetToken(nome.Text, password.Text);
            LblToken.Text = resultado;
        }

        private async void VerificarAction(object sender, EventArgs args)
        {
            string resultado = await JWTService.Verificar();
            LblResultado.Text = resultado;
        }
    }
}
