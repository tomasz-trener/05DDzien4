using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieFirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Firma f = new Firma();
            f.Pracownicy = new Pracownik[3];
            f.Pracownicy[0] = new Pracownik()
            {
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Pensja = 6000
            };

            Pracownik p = new Pracownik()
            {
                Imie = "Ala",
                Nazwisko = "Kowalska",
                Pensja = 7000
            };
            f.Pracownicy[1] = p;

            //  do Ali mogę dostać się na 2 sposoby:
            //np: 
            p.Pensja += 500;
            //lub
            f.Pracownicy[1].Pensja += 200;

            // ale do Jana mogę dostać się tylko na 1 sposób:
            f.Pracownicy[0].Pensja += 600;

            f.Pracownicy[2] = new Pracownik();
            f.Pracownicy[2].Imie = "Adam";
            f.Pracownicy[2].Nazwisko = "Nowak";

        }
    }
}
