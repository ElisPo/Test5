using System;

namespace Posani_Test5
{
    class Program
    {
        static void Main(string[] args)
            //FUNZIONANO LE CLASSI, NON HO PROVATO I METODI DI STUDENTE
        {
            CorsoDiLaurea Fisica = Miscellanee.CreazioneCorsiLaurea("fisica");
            Studente Elisa = new Studente(new DateTime(2020,10,11),"Elisa","Posani",1996,Miscellanee.CreazioneCorsiLaurea("fisica"), Miscellanee.CreazioneEsami(1));
            Console.WriteLine(Elisa.Cognome);
        }
    }
}
