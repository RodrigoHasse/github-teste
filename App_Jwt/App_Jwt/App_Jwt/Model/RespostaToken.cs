using System;
using System.Collections.Generic;
using System.Text;

namespace App_Jwt.Model
{
    public class RespostaToken
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
    }
}
