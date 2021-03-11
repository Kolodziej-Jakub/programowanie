using System;

namespace ConsoleAppinteraktywnie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Witaj!");


            Console.Write("Podaj imię:");
            string imie;
            imie = Console.ReadLine();

            Console.Write("Podaj Nazwisko:");
            string Nazwisko;
            Nazwisko = Console.ReadLine();

            Console.WriteLine("Witaj" + imie + " " + Nazwisko + "!");

           string napis = string.Format("Witaj {0} {1}!", imie, Nazwisko);
            Console.WriteLine(napis);

            Console.WriteLine("Witaj {0} {1}!", Nazwisko, imie);

            Console.WriteLine( $"Witaj {imie} {Nazwisko}!" );
            
        }
    }
}
