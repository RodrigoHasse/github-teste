﻿using System;
using System.Collections.Generic;
using System.Text;

namespace App_NossoChat.Model
{
    public class Mensagem
    {
        public int id { get; set; }
        public int id_chat { get; set; }
        public int id_usuario { get; set; }
        public string mensagem { get; set; }
        public Usuario Usuario { get; set; }
    }
}
