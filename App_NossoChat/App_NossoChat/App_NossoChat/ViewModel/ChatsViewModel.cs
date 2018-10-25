using App_NossoChat.Model;
using App_NossoChat.Service;
using App_NossoChat.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace App_NossoChat.ViewModel
{
    public class ChatsViewModel : INotifyPropertyChanged
    {
        private List<Chat> _chats;
        public List<Chat> chats{
            get {return _chats;}
            set {_chats = value; OnPropertyChanged("chats"); }
        }

        public Command AdicionarCommand { get; set; }
        public Command OrdenarCommand { get; set; }
        public Command AtualizarCommand { get; set; }

        public ChatsViewModel()
        {
            chats = ServiceWS.GetChats();

            AdicionarCommand = new Command(Adicionar);
            OrdenarCommand = new Command(Ordenar);
            AtualizarCommand = new Command(Atualizar);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        private void Adicionar()
        {
            ((NavigationPage)App.Current.MainPage).Navigation.PushAsync(new View.CadastrarChat());
        }

        private void Ordenar()
        {
            chats = chats.OrderBy(a => a.nome).ToList();
        }

        private void Atualizar()
        {
            chats = ServiceWS.GetChats();
        }
    }
}
