using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Wlasciwosci
{
    class Czlowiek
    {

        // z czego moze skadac sie klasa? 

        // pola, właściwości, metody i kostruktory 

        public string Imie; // to jest zwykłe pole 

        public string Nazwisko { get; set; } // to jest właściwość 

        private string drugieImie;

        public string Inicialy 
        { 
            get
            {
                // tutaj jest kod wykonawczy tak samo jak w metodzie (to taka trochę metoda)
                string a = Imie.Substring(0, 1);
                string b = Nazwisko.Substring(0, 1);
                string wynik = $"{a}. {b}.";

                return wynik;
                // można sobie pomysleć, że get to jest jest taka metoda, która nie przyjmuje żadnych argumentów wejściowych
                // ale zwraca jakiś wynik, który jest typu takiego jak zadeklarowaiśmy we właściwości 
            } 

            // jak jest własicowść , która ma tylko get a nie ma set to znaczy, że jest to właściowć
            // tylko do odczytu 
        }

        public string DrugieImie
        {
            set
            {
                drugieImie = value;
            }
            // value to jest tak jaby taki argument wejsciowy 
        }


        public void Test()
        {
            File.WriteAllText("c:\\dane\\a.txt", drugieImie);
        }


    }
}
