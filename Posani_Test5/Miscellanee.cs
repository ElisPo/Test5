using System;
using System.Collections.Generic;
using System.Text;

namespace Posani_Test5
{
    public class Miscellanee //Funzioni varie per creazioni di liste
    {
        public static CorsoDiLaurea CreazioneCorsiLaurea(string corso)
        {
            //Creo un po' di corsi, anche per diversi corsi di laurea.

            Corso Analisi = new Corso
            {
                NomeCorso = "Analisi 1",
                CFU = 50
            };

            Corso Fisica2 = new Corso
            {
                NomeCorso = "Fisica 2",
                CFU = 50
            };

            Corso Programmazione = new Corso
            {
                NomeCorso = "Basi di Programmazione",
                CFU = 50
            };

            Corso Fisica1 = new Corso
            {
                NomeCorso = "Fisica 1",
                CFU = 50
            };

            Corso Latino = new Corso
            {
                NomeCorso = "Latino Tardo Impero",
                CFU = 50
            };

            Corso Greco = new Corso
            {
                NomeCorso = "Greco Antico",
                CFU = 50
            };

            Corso Lettere1 = new Corso
            {
                NomeCorso = "Lettere Moderne",
                CFU = 50
            };

            Corso Lettere2 = new Corso
            {
                NomeCorso = "Lettere Medievali",
                CFU = 50
            };

            Corso Astronavi = new Corso
            {
                NomeCorso = "Metodi per veicoli spaziali",
                CFU = 50
            };

            Corso Java = new Corso
            {
                NomeCorso = "Programmazione Java",
                CFU = 50
            };

            Corso Quantistica = new Corso
            {
                NomeCorso = "Meccanica Quantistica",
                CFU = 50
            };

            Corso Geometria = new Corso
            {
                NomeCorso = "Geometria Differenziale",
                CFU = 50
            };

            //Creo le liste con i corsi per i diversi corsi di laurea.

            List<Corso> fisica = new List<Corso>()
            {
                Fisica1,
                Fisica2,
                Analisi,
                Programmazione,
                Quantistica
            };

            List<Corso> ingegneria = new List<Corso>()
            {
                Fisica1,
                Fisica2,
                Analisi,
                Programmazione,
                Astronavi
            };

            List<Corso> informatica = new List<Corso>()
            {
                Fisica1,
                Fisica2,
                Analisi,
                Programmazione,
                Java
            };

            List<Corso> matematica = new List<Corso>()
            {
                Fisica1,
                Fisica2,
                Analisi,
                Programmazione,
                Geometria
            };

            List<Corso> lettere = new List<Corso>
            {
                Lettere1,
                Lettere2,
                Latino,
                Greco
            };

            //Do in output il corso richiesto con i parametri richiesti e la lista dei corsi appena creati.

            if (corso == "fisica")
                return new CorsoDiLaurea(CorsoDiLaurea.NomeCorso.Fisica, 5, 180, fisica);
            if (corso == "ingegneria")
                return  new CorsoDiLaurea(CorsoDiLaurea.NomeCorso.Ingegneria, 5, 180, ingegneria);
            if (corso == "informatica")
                return new CorsoDiLaurea(CorsoDiLaurea.NomeCorso.Informatica, 5, 150, informatica);
            if (corso == "matematica")
                return new CorsoDiLaurea(CorsoDiLaurea.NomeCorso.Matematica, 6, 200, matematica);
            if (corso == "lettere")
                return new CorsoDiLaurea(CorsoDiLaurea.NomeCorso.Lettere, 3, 100, lettere);

            return null;
        }

        public static List<Esame> CreazioneEsami(int lista)
        {

            //Scusa non avevo il tempo di fare una cosa fatta bene per la creazione iniziale.. ho ripreso quelli di prima e basta

            Corso Analisi = new Corso
            {
                NomeCorso = "Analisi 1",
                CFU = 50
            };

            Corso Fisica2 = new Corso
            {
                NomeCorso = "Fisica 2",
                CFU = 50
            };

            Corso Programmazione = new Corso
            {
                NomeCorso = "Basi di Programmazione",
                CFU = 50
            };

            Corso Fisica1 = new Corso
            {
                NomeCorso = "Fisica 1",
                CFU = 50
            };

            Corso Latino = new Corso
            {
                NomeCorso = "Latino Tardo Impero",
                CFU = 50
            };

            Corso Greco = new Corso
            {
                NomeCorso = "Greco Antico",
                CFU = 50
            };

            Corso Lettere1 = new Corso
            {
                NomeCorso = "Lettere Moderne",
                CFU = 50
            };

            Corso Lettere2 = new Corso
            {
                NomeCorso = "Lettere Medievali",
                CFU = 50
            };

            Corso Astronavi = new Corso
            {
                NomeCorso = "Metodi per veicoli spaziali",
                CFU = 50
            };

            Corso Java = new Corso
            {
                NomeCorso = "Programmazione Java",
                CFU = 50
            };

            Corso Quantistica = new Corso
            {
                NomeCorso = "Meccanica Quantistica",
                CFU = 50
            };

            Corso Geometria = new Corso
            {
                NomeCorso = "Geometria Differenziale",
                CFU = 50
            };

            

            if (lista == 1)
                return new List<Esame>() { new Esame() { Corso = Fisica1, Passato = true }, new Esame() { Corso = Quantistica, Passato = false } };
            if (lista == 2)
                return new List<Esame>() { new Esame() { Corso = Analisi, Passato = true }, new Esame() { Corso = Geometria, Passato = true } };
            if (lista == 1)
                return new List<Esame>() { new Esame() { Corso = Latino, Passato = true }, new Esame() { Corso = Greco, Passato = true } };
            return null;
        }


    }

}
