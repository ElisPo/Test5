using System;
using System.Collections.Generic;
using System.Text;

namespace Posani_Test5
{
    public class DatiImmatricolazione
    {
        private int matricolaSeed = 10000;
        public string Matricola { get; }
        public DateTime DataInizio { get; set; }
        public CorsoDiLaurea CorsoDiLaurea { get; set; }
        public bool FuoriCorso { get; set; }
        public uint CFUAccumulati { get; set; }

        public DatiImmatricolazione(Studente studente, DateTime dataInizio, CorsoDiLaurea corso) //Costruttore per immatricolazione.
        {
            Matricola = matricolaSeed.ToString();
            matricolaSeed++;

            DataInizio = dataInizio;
            CorsoDiLaurea = corso;

            if (dataInizio.AddYears(corso.AnniDiCorso) < DateTime.Now) //Check da solo se lo studente è fuoricorso in base al numero di anni.
            {
                FuoriCorso = true;
            }
            else
                FuoriCorso = false;

            uint cfuAccumulati = 0;
            foreach(Esame esame in studente.ListaEsami) //Calcola la somma dei CFU accumulati in base alla lista esami passata con lo studente
            {
                if (esame.Passato)
                    cfuAccumulati += esame.Corso.CFU;
            }
            CFUAccumulati = cfuAccumulati;
        }
        
    }
}
