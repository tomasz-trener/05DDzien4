using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieBiblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            Karta k = new Karta()
            {
                Numer = "1308/00",
                Tytul = "O kurdlach dla opornych",
                Wydanie = 1,
                DataZakupu = new DateTime(2000, 1, 27),
                Cena = new Cena()
                {
                    Wartosc = 17.5,
                    Uwagi = "zakup z 18.08 – 20, 00"
                },
                Autorzy = new Autor[2]
                {
                    new Autor() 
                    { 
                        Nazwisko = "Tarantoga",
                        Imie = "L", DrugieImie="A"
                    },
                    new Autor()
                    {
                        Nazwisko = "Tichy",
                        Imie = "I"
                    },
                },
                Sygnatury = new List<Sygnatura>()
                {
                    new Sygnatura() {  Numer=012370},
                    new Sygnatura() 
                    {  
                        Numer=012371,
                        Aktywna=false,
                        Wypozyczenia = new List<Wypozyczenie>()
                        {
                            new Wypozyczenie()
                            {
                                Czytelnik= new Czytelnik()
                                {
                                    NrKarty="B2354"
                                },
                                DataWypozyczenia= new DateTime(2000,2,22),
                                PrzewidywanaDataZwrotu= new DateTime(2000,3,7),
                                Przedluzenie = new Wypozyczenie()
                                {
                                    PrzewidywanaDataZwrotu = new DateTime(2000,3,15),
                                    RzeczywistaDataZwrotu = new DateTime(2000,4,10)
                                },
                                Uwagi = "06.03.2000 Zgoda na przedłużenie"
                            }

                        }
                    },
                    new Sygnatura() {  Numer=012372},
                    new Sygnatura() 
                    {  
                        Numer=014568,
                        Uwagi="dodatkowy zakup 18.08.2000",
                    },
                }
                
            };

            Console.WriteLine(k.Sygnatury[1].Wypozyczenia[0].Uwagi);
        }
    }
}
