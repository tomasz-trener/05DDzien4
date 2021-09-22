using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03TypyWartoscioweIReferencyjne
{
    class Program
    {
        static void Main(string[] args)
        {
            // reference types and value types 

            int a = 1;
            int b = a; // jako, że int jest value type to następuje przekazanie kopii wartości 

            b++;

            Console.WriteLine(a); // 1 
            Console.WriteLine(b); // 2

            Czlowiek c1 = new Czlowiek()
            {
                Wiek = 1
            };


            Czlowiek c2 = c1; // jako, że Klasa (dowolna) jest typem reference type to nastęiuje przekaznanie wartości przez referencje 
            c2.Wiek++;
            Console.WriteLine(c1.Wiek); // 2
            Console.WriteLine(c2.Wiek); // 2

            Czlowiek c3 = new Czlowiek();
            c3 = c1;

            Czlowiek c4 = c1.StworzKopie();
            c4.Wiek++;

            Console.WriteLine(c1.Wiek);
            Console.WriteLine(c4.Wiek);

            Czlowiek c5 = new Czlowiek();
            c5.ZawartoscPortfela = 100;

            Samochod s = new Samochod();
            s.Jedz(c5);
            Console.WriteLine(c5.ZawartoscPortfela);

            string str1 = "ala";
            string str2 = str1; // kopia 
            str2 += " ma kota";

            // jest wyjątek mianiowicie 
            // string jest klasą , która 
            // wygląda jak struktura i korzysta się
            // z tej klasy tak samo jak ze strukturut 

            //double, bool, char itp.. kopia 
            Console.WriteLine(str1);

            DateTime dt1 = new DateTime(2000, 1, 1);
            DateTime dt2 = dt1;
            dt2 = dt2.AddDays(1);

            Console.WriteLine(dt1.Day);
            Console.WriteLine(dt2.Day);


            // nalezy pamieac, że 
            // struktóry możemy inicializować tak samo jak klasy
            // ze zewnątrz są nie do odroznienia od klas 

            String s6 = new String('g',1);

            Int32 t1 = new Int32();
            t1 = 4;



            Pracownik p1;
            p1.Wiek = 4;

            Pracownik p2 = p1;
            p2.Wiek++;

            Console.WriteLine(p1.Wiek);
            Console.WriteLine(p2.Wiek);

            Pracownik p3 = new Pracownik();



            // zasada:
            // klasy -> referencje (wyjątek string) 
            // sturktury -> kopie 

            // klasy zawesze potrzeba new 
            // struktora mozna , nie trzeba uzywac new 


            int[] tab1 = { 1, 2, 3 };
            int[] tab2 = tab1;

            tab2[0] = 0;

            Console.WriteLine(tab1[0]);
            Console.WriteLine(tab2[0]);

            //List<>

            

            Console.ReadKey();

        }
    }
}
//C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\CommonExtensions\Microsoft\TeamFoundation\Team Explorer\Git\cmd