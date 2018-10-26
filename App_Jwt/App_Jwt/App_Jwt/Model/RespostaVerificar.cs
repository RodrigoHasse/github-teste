using System;
using System.Collections.Generic;
using System.Text;

namespace App_Jwt.Model
{
    public class RespostaVerificar
    {
        public string JWT { get; set; }
        public Usuario usuario { get; set; }
    }
}
