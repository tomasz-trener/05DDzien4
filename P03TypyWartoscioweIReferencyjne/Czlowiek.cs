using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03TypyWartoscioweIReferencyjne
{
    class Czlowiek
    {
        public int Wiek;
        public int ZawartoscPortfela;

        public Czlowiek StworzKopie()
        {
            Czlowiek c = new Czlowiek();
            c.Wiek = Wiek;
            return c;
        }


    }
}
