using System;
using System.Collections.Generic;
using System.Text;

namespace Posani_Test5
{
    public class CorsoDiLaurea
    {
        public enum NomeCorso //Per essere uno di questi e basta.
        {
            Matematica,
            Fisica,
            Informatica,
            Ingegneria,
            Lettere
        }

        public NomeCorso Nome { get; set; }
        public byte AnniDiCorso { get; set; }
        public uint CFUTotali { get; set; }
        public List<Corso> ListaCorsi = new List<Corso>();

        public CorsoDiLaurea(NomeCorso nome, byte anni, uint cfuTotali, List<Corso> listaCorsi)
        {
            Nome = nome;
            AnniDiCorso = anni;
            CFUTotali = cfuTotali;
            ListaCorsi = listaCorsi;
        }
    }
}
