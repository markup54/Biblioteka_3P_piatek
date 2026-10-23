using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Czytelnik : Osoba
    {
        private int nrEwidencyjny;
        private List<Ksiazka> wypozyczoneKsiazki;


        public Czytelnik(string imie) : base(imie)
        {
            nrEwidencyjny = licznikOsob;
            wypozyczoneKsiazki = new List<Ksiazka>();
        }


        public override string ToString()
        {
            return "Imię: " + imie + " nr karty bibliotecznej " + nrEwidencyjny;
        }

        public void wypozyczKsiazke(Ksiazka ksiazka)
        {
            if(ksiazka.czyWypozyczona == false)
            {
                ksiazka.czyWypozyczona = true;
                wypozyczoneKsiazki.Add(ksiazka);
            }
        }

        public void oddajKsiazke(Ksiazka ksiazka)
        {
            if (wypozyczoneKsiazki.Contains(ksiazka))
            {
                {
                    wypozyczoneKsiazki.Remove(ksiazka);
                    ksiazka.czyWypozyczona = false;
                }
            }
        }
        public void wypiszWypozyczoneKsiazki()
        {
            foreach(Ksiazka k in wypozyczoneKsiazki)
            {
                Console.WriteLine(k.Tytul);
            }
            
        }
    }
}
