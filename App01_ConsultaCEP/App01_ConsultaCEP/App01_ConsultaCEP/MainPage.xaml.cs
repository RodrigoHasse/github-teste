using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultaCEP.Servico.Modelo;
using App01_ConsultaCEP.Servico;

namespace App01_ConsultaCEP
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            BOTAO.Clicked += BuscarCep;

		}

        private void BuscarCep(object sender, EventArgs args)
        {
            string cep = CEP.Text.Trim();
            if(isValidCEP(cep))
            {
                try
                {
                    Endereco end = ViaCEPServico.BuscaEnderecoViaCEP(cep);
                    if (end != null)
                        RESULTADO.Text = string.Format("Endereco: {0},{1} {2}", end.localidade, end.uf, end.logradouro);
                    else
                        DisplayAlert("ERRO", "Nenhum endereço encontrado para o cep informado: " + cep, "OK");
                }catch(Exception e){
                    DisplayAlert("ERRO CRÍTICO", e.Message, "OK");
                }
                
            }
        }

        private bool isValidCEP(string cep)
        {
            bool valido = true;
            int novoCEP = 0;

            if(cep.Length != 8)
            {
                DisplayAlert("ERRO", "CEP inválido, deve conter 8 dígitos!", "OK");
                valido = false;
            }

            if (!int.TryParse(cep, out novoCEP))
            {
                DisplayAlert("ERRO", "CEP inválido, deve conter apenas números!", "OK");
                valido = false;
            }

            return valido;
        }
	}
}
