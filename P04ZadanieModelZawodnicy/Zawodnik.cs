using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieModelZawodnicy
{
    class Zawodnik
    {
        public int Id;
        public string Imie;
        public string Nazwisko;
        public int Waga;
        public int Wzrost;
        public DateTime DataUr;
        public string Kraj;
        public Trener Trener;
        public Zawody[] Zawody;
    }
}
