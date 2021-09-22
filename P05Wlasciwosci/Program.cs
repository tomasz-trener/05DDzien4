using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Wlasciwosci
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek c = new Czlowiek();

            c.Imie = "Adam";
            c.Nazwisko = "Kowalski";

            // c.Inicialy = "asd";
            Console.WriteLine(c.Inicialy);

            c.DrugieImie = "Krzysztof";

           // Console.WriteLine(c.DrugieImie);
        }
    }
}
