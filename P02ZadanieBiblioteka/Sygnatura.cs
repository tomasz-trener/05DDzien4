using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieBiblioteka
{
    class Sygnatura
    {
        public int Numer;
        public string Uwagi;
        public bool Aktywna;
        public List<Wypozyczenie> Wypozyczenia;
        public Karta Karta;
    }
}
