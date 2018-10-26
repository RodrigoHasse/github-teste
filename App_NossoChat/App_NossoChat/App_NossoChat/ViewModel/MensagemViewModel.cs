using App_NossoChat.Model;
using App_NossoChat.Service;
using App_NossoChat.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace App_NossoChat.ViewModel
{
    public class MensagemViewModel : INotifyPropertyChanged
    {
        private StackLayout SL;
        private Chat chat;

        private List<Mensagem> _Mensagens;
        public List<Mensagem> Mensagens
        {
            get { return _Mensagens; }
            set
            {
                _Mensagens = value; OnPropertyChanged("Mensagens");
                if(_Mensagens != null)
                {
                    ShowOnScreem();
                }
            }
        }

        private string _TxtMensagens;
        public string TxtMensagens
        {
            get { return _TxtMensagens; }
            set
            {
                _TxtMensagens = value; OnPropertyChanged("TxtMensagens");
            }
        }

        public Command BtnEnviarCommand { get; set; }
        public Command AtualizarCommand { get; set; }

        private void ShowOnScreem()
        {
            var usuario = UsuarioUtil.GetUsuarioLogado();
            SL.Children.Clear();
            foreach( var msg in Mensagens)
            {
                if (msg.Usuario.id == usuario.id)
                {
                    SL.Children.Add(CriarMensagemPropria(msg));
                }
                else
                {
                    SL.Children.Add(CriarMensagemOutrosUsuarios(msg));
                }
            }
        }

        private Xamarin.Forms.View CriarMensagemPropria( Mensagem mensagem)
        {
            var layout = new StackLayout() { Padding = 5, BackgroundColor = Color.FromHex("#5ED055"), HorizontalOptions = LayoutOptions.End };
            var label = new Label() { TextColor = Color.White, Text = mensagem.mensagem };

            layout.Children.Add(label);

            return layout;
        }

        private Xamarin.Forms.View CriarMensagemOutrosUsuarios(Mensagem mensagem)
        {
            var labelNome = new Label() { Text = mensagem.Usuario.nome, FontSize = 10, TextColor = Color.FromHex("#5ED055") };
            var labelMensagem = new Label() {Text = mensagem.mensagem, TextColor = Color.FromHex("#5ED055") };

            var SL = new StackLayout();
            SL.Children.Add(labelNome);
            SL.Children.Add(labelMensagem);

            var frame = new Frame() { BorderColor = Color.FromHex("#5ED055"), CornerRadius = 0, HorizontalOptions = LayoutOptions.Start };
            frame.Content = SL;

            return frame;
        }

        public MensagemViewModel(Chat chat, StackLayout SLMensagemContainer)
        {
            this.chat = chat;
            SL = SLMensagemContainer;
            Atualizar();

            BtnEnviarCommand = new Command(BtnEnviar);
            AtualizarCommand = new Command(Atualizar);

            Device.StartTimer(TimeSpan.FromSeconds(1), () => {
                Atualizar();
                return true;
            });
        }

        private void Atualizar()
        {
            Mensagens = ServiceWS.GetMensagensChat(chat);
        }

        private void BtnEnviar()
        {
            var msg = new Mensagem()
            {
                id_usuario = UsuarioUtil.GetUsuarioLogado().id,
                mensagem = TxtMensagens,
                id_chat = chat.id
            };
            ServiceWS.InsertMensagemChat(msg);
            Atualizar();
            TxtMensagens = string.Empty;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
