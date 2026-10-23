using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Ksiazka
    {
        public string Tytul { get; set; }
        public Autor AutorKsiazki { get; set; }

        public bool czyWypozyczona;

        public Ksiazka(string tytul, Autor autorKsiazki) 
        { 
            Tytul = tytul;
            AutorKsiazki = autorKsiazki;
            this.czyWypozyczona = false;
        }
    }
}
