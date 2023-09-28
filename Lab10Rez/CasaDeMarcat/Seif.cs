using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10Rez.CasaDeMarcat
{
    class Seif
    {
        public int Cash { get; private set; }
        public void DepuneInSeif(int suma)
        {

            Cash += suma;
        }
        public void DeschideSeif()
        {
            Console.WriteLine("Seiful este deschis");
        }
        public void InchideSeif()
        {
            Console.WriteLine("Seiful este inchis");
        }
    }
}
