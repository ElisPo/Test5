using System;
using System.Collections.Generic;
using System.Text;

namespace Posani_Test5
{
    public class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        private uint annoDiNascita;
        public uint AnnoDiNascita
        {
            get { return annoDiNascita; }
            set { annoDiNascita = value; }
        }
        public bool RichiestaLaurea { get; set; }

        public List<Esame> ListaEsami = new List<Esame>();
        DatiImmatricolazione Immatricolazione;

        public Studente(DateTime dataInizio, string nome, string cognome, uint annoNascita, CorsoDiLaurea corso, List<Esame> listaEsami = null)
        { //Costruttore per la classe studente, che ha come parametro anche Immatricolazione
            Nome = nome;
            Cognome = cognome;
            AnnoDiNascita = annoNascita;
            ListaEsami = listaEsami;
            Immatricolazione = new DatiImmatricolazione(this, dataInizio, corso); //Inizializza da solo l'immatricolazione.
            if (Immatricolazione.CFUAccumulati >= corso.CFUTotali) //check per la richiesta di laurea, che fa automaticamente
            {
                RichiestaLaurea = true;
            }
            else
            {
                RichiestaLaurea = false;
            }
        }

        public void AggiungiEsame(Esame esame)
        {
            bool corsoPresente = false;
            foreach (Corso corso in Immatricolazione.CorsoDiLaurea.ListaCorsi)
            {
                if (RichiestaLaurea == true) //Check se lo studente è un laureando
                {
                    Console.WriteLine("Hai finito gli esami!");
                    return;
                }

                if (esame.Corso.NomeCorso == corso.NomeCorso) //Verifica che il corso appartenga a quelli del corso di laurea
                {
                    corsoPresente = true;
                    break;
                }

                if (corsoPresente) 
                { //Se è presente e non supera i CFU del corso di laurea, lo aggiungo alla lista degli esami.
                    if (Immatricolazione.CFUAccumulati + esame.Corso.CFU <= Immatricolazione.CorsoDiLaurea.CFUTotali)
                    {
                        ListaEsami.Add(esame);
                    }
                    else
                    {
                        Console.WriteLine("Scegli un esame con meno CFU"); //Altrimenti dà errore
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Non fa parte deli esami del tuo corso di laurea!!"); //Se corsoPresente è falso dà errore perché non può essere sostenuto.
                }
            }
        }

        public void EsamePassato(Esame esame)
        {
            //Per ora gli faccio solo cambiare un esame da non passato a passato, perché lo aggiungo con la funzione precedente alla lista esami.
            bool esamePresente = false;

            foreach (Esame ex in ListaEsami) //Check se l'esame è presente nella lista degli esami
            {
                if (esame.Corso.NomeCorso == ex.Corso.NomeCorso)
                {
                    esamePresente = true;
                    esame = ex;
                    break;
                }
            }
            if (esamePresente)
            {
                Immatricolazione.CFUAccumulati += esame.Corso.CFU; //Aggiunge i CFU 
                esame.Passato = true; //Mette l'esame passato, anche se non sono sicura che funzioni perché non l'ho provato
                if (Immatricolazione.CFUAccumulati >= Immatricolazione.CorsoDiLaurea.CFUTotali) //Setta la richiesta di laurea se ha raggiunge i crediti necessari
                {
                    RichiestaLaurea = true;
                }
            }
            else //altrimenti dà errore
            {
                Console.WriteLine("Prima devi aggiungere l'esame alla tua lista esami");
                return;
            }
        }
    }
}
