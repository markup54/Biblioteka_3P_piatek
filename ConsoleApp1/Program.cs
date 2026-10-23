using ConsoleApp1;

Console.WriteLine("Hello, World!");

//Osoba osoba = new Osoba("Jan");
Czytelnik czytelnik1 = new Czytelnik("Jaś");
Console.WriteLine(czytelnik1.ToString());

Czytelnik czytelnik2 = new Czytelnik("Asia");
Console.WriteLine(czytelnik2.ToString());

Ksiazka ksiazka = new Ksiazka("Pan Tadeusz", new Autor("Adam"));
Ksiazka ksiazka1 = new Ksiazka("W pustyni i w puszczy", new Autor("Henryk"));
czytelnik1.wypozyczKsiazke(ksiazka);
Console.WriteLine("Ksiązki JAsia");
czytelnik1.wypiszWypozyczoneKsiazki();
czytelnik1.wypozyczKsiazke(ksiazka);
czytelnik1.wypozyczKsiazke(ksiazka1);
Console.WriteLine("Ksiązki JAsia");
czytelnik1.wypiszWypozyczoneKsiazki();
czytelnik1.oddajKsiazke(ksiazka1);
czytelnik1.oddajKsiazke(ksiazka);
Console.WriteLine("Ksiązki JAsia");
czytelnik1.wypiszWypozyczoneKsiazki();

