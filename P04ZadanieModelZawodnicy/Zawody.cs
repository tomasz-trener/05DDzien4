﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieModelZawodnicy
{
    class Zawody
    {
        public int Id;
        public string Nazwa;
        public DateTime Data;
        public Skocznia Skocznia;
        public Zawodnik[] Zawodnicy;
    }
}
