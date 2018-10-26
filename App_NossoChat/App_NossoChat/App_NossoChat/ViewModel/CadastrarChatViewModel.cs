using App_NossoChat.Model;
using App_NossoChat.Service;
using System.ComponentModel;
using Xamarin.Forms;

namespace App_NossoChat.ViewModel
{
    public class CadastrarChatViewModel : INotifyPropertyChanged
    {
        private string _Mensagem;

        public event PropertyChangedEventHandler PropertyChanged;

        public string nome { get; set; }
        public string Mensagem {
            get { return _Mensagem; }
            set { _Mensagem = value; PropertyChanged(this, new PropertyChangedEventArgs("Mensagem")); } }

        public Command CadastrarCommand { get; set; }


        public CadastrarChatViewModel()
        {
            CadastrarCommand = new Command(Cadastrar);    
        }

        private void Cadastrar()
        {
            Chat chat = new Chat(){ nome = nome};
            bool ok =  ServiceWS.InsertChat(chat);
            if(ok == true)
            {                
                ((NavigationPage)App.Current.MainPage).Navigation.PopAsync();

                var nav = (NavigationPage)App.Current.MainPage;

                var Chats = (View.Chats)nav.RootPage;

                var ViewModel = (ChatsViewModel)Chats.BindingContext;

                if (ViewModel.AtualizarCommand.CanExecute(null))
                {
                    ViewModel.AtualizarCommand.Execute(null);
                }
            }
            else
            {
                Mensagem = "Erro ao salvar";
            }
        }
    }
}
