using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Biblioteka
{
    public class Zawody
    {
        public int Id;
        public string Nazwa;
        public DateTime Data;
        public Skocznia Skocznia;
        public Zawodnik[] Zawodnicy;

        public string NazwaSkoczni
        {
            //get { return Skocznia.Nazwa; }
          
            //get
            //{
            //    if (Skocznia != null)
            //        return Skocznia.Nazwa;
            //    else
            //        return null;
            //}
            get { return Skocznia?.Nazwa; }
            // to jest to samo co powyzej 
        }
    }
}
