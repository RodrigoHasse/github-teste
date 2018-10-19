using App_Vagas.Banco;
using App_Vagas.UWP.Banco;
using System.IO;
using Xamarin.Forms;
using Windows.Storage;

[assembly: Dependency(typeof(Caminho))]
namespace App_Vagas.UWP.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            string caminhoDaPasta = ApplicationData.Current.LocalFolder.Path;
            
            string caminhoBanco = Path.Combine(caminhoDaPasta, NomeArquivoBanco);

            return caminhoBanco;            
        }
    }
}
