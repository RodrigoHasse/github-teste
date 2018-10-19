using System;
using System.Collections.Generic;
using System.Text;

namespace App_Vagas.Banco
{
    public interface ICaminho
    {
        string ObterCaminho(string NomeArquivoBanco);
    }
}
