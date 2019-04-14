using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzytkownik user1 = new Uzytkownik();
            user1.wiek = 34;
            user1.imie = "Kamil";

            Uzytkownik user2 = new Uzytkownik();  // deklarowanie obiektu
            user1.wiek = 10;
            user1.imie = "Michał";

            Dog1 dog = new Dog1();
            Dog1 dogH = new Dog1();
            dog.wiek = 5;
            dog.rasa = "Pug";
            dog.waga = 4.5f;
            dog.Szczekaj("Pug szczeka");
            dogH.Szczekaj("Huskey szczeka");

            Console.ReadKey();
        }
    }

    class Uzytkownik // klasa
    {
        public int wiek;
        public string imie;

    }
}
