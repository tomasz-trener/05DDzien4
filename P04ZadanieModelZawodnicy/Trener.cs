using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieModelZawodnicy
{
    class Trener
    {
        public int Id;
        public string Imie;
        public string Nazwisko;
        public DateTime DataUr;
        public Zawodnik[] Zawodnicy;

        public int[] Liczby;

        public string NazwaMaiasta
        {
            get
            {
                return Zawodnicy[0]?.Zawody[0]?.Skocznia?.Miasto?.Nazwa;
               // return Zawodnicy[0]?.Zawody[0]?.NazwaSkoczni
            }
        }
    }
}
