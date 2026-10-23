using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract  class Osoba
    {
        protected string imie;
        protected static int licznikOsob = 0;
        public Osoba(string imie)
        {
            this.imie = imie;
            licznikOsob++;
        }
    }
}
