using App_NossoChat.Model;
using App_NossoChat.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace App_NossoChat.ViewModel
{
    public class PaginaInicialViewModel : INotifyPropertyChanged
    {
        private string _Nome;
        private string _Senha;
        private string _Mensagem;

        public string Nome { get { return _Nome ;} set {_Nome = value; PropertyChanged(this, new PropertyChangedEventArgs( "Nome"));}}
        public string Senha { get { return _Senha; } set { _Senha = value; PropertyChanged(this, new PropertyChangedEventArgs("Senha")); } }
        public string Mensagem { get { return _Mensagem; } set { _Mensagem = value; PropertyChanged(this, new PropertyChangedEventArgs("Mensagem")); } }

        public Command AcessarCommand { get; set; }

        public PaginaInicialViewModel()
        {
            AcessarCommand = new Command(Acessar);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Acessar()
        {
            var user = new Usuario();
            user.nome = Nome;
            user.password = Senha;

            var usuarioLogado =  ServiceWS.GetUsuario(user);
            if (usuarioLogado == null)
            {
                Mensagem = "Senha incorreta";
            }
            else
            {
                App.Current.Properties["LOGIN"] = JsonConvert.SerializeObject(usuarioLogado);
                App.Current.MainPage = new NavigationPage(new View.Chats()) {BarBackgroundColor = Color.FromHex("#5ED055"), BarTextColor = Color.White};
            }
        }
    }
}
