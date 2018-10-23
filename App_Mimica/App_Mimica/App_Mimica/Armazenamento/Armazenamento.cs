using App_Mimica.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Mimica.Armazenamento
{
    public class Armazenamento
    {
        public static Jogo Jogo { get; set; }
        public static short RodadaAtual { get; set; }

        public static string[][] Palvras =
        {
            //Faceis pontuação 1
            new string[]{"Olho", "Lingua", "Chinelo", "Milho", "Penalti", "Bola", "Ping-Pong"},
           //Medias pontuação 3
            new string[]{"Carpinteiro", "Amarelho", "Limão", "Abelha"},
           //Dificeis pontuação 5
            new string[]{"Sisterna", "Lanterna", "Batman vs Superman", "Notebook"},
        };
    }
}
