using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadanieFirma
{
    class Pracownik
    {
        public string Imie;
        public string Nazwisko;
        public double Pensja;

        // tutaj określamy tylko, że coś co zwracamy
        // będzie typu faktura 
        public Faktura StworzFakture(int numer)
        {
            Faktura f = new Faktura();
            f.Numer = numer;
            f.DataUtworzenia = DateTime.Now; // zwraca nową istancję DateTime z aktualnym czasem i datą
            return f; // tutaj zwracamy konkretną
                      // instację (konkretny obiekt) czyli konkretną
                      // fakturę
        }
    }
}
