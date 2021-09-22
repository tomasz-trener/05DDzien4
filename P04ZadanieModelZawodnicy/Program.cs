using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieModelZawodnicy
{
    class Program
    {
        static void Main(string[] args)
        {
            Zawodnik z = new Zawodnik()
            {
                Imie = "Jan",
                Nazwisko = "Kowalski"
            };

            z.Trener = new Trener()
            { 
                Imie = "Adam",
                Nazwisko = "Nowak",
                Zawodnicy = new Zawodnik[] {z},
                //Liczby = new int[] {4,7,4}
            };

            //z.Trener.Zawodnicy[0] = z;

            Zawodnik z2 = new Zawodnik("Jan", "Kowalksi", "Adam", "Nowak");


            //int[] liczby = new int[2];
            //liczby[0] = 1;
            //liczby[1] = 2;

            //int[] liczby2 = new int[2] { 1, 2 };
            //int[] liczby3 = new int[] { 1, 2 };

            Miasto m = new Miasto() { Nazwa = "Krakow" };

            Skocznia s2 = new Skocznia()
            {
                Nazwa = "Skocznia2",
                Miasto = m
            };

            z.Zawody = new Zawody[2]
            {
                new Zawody()
                {
                    Nazwa="Zawody 1",
                    Skocznia = new Skocznia()
                    {
                        Nazwa="Skocznia 1",
                        Miasto = new Miasto()
                        {
                            Nazwa = "Warszawa"
                        }
                    }
                },
                new Zawody()
                {
                    Nazwa = "Zawody 2",
                    Skocznia = s2
                }
            };


            Trener t = z.Trener;

            string nazwa =
                t.Zawodnicy[0].Zawody[0].Skocznia.Miasto.Nazwa;

            Console.WriteLine(nazwa) ;
            Console.ReadKey();
        }
    }
}
