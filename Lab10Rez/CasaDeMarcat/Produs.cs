using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10Rez.CasaDeMarcat
{
    class Produs
    {
        public int Pret { get; set; }
        public string Nume { get; set; }

        public Produs(int pret, string nume)
        {
            Pret = pret;
            Nume = nume;
        }
    }
}
