using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieBiblioteka
{
    class Karta
    {
        public string Numer;
        public Autor[] Autorzy;
        public List<Sygnatura> Sygnatury;
        public DateTime DataZakupu;
        public Cena Cena;
        public Karta Nastepna;
        public Karta Poprzednia;
        public string Tytul;
        public int Wydanie;
    }
}
