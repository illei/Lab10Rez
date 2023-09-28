using Lab10Rez.Interfaces;
using System;

namespace Lab10Rez
{
    class Card :IContactFullpayment
    {
       
       

        public void EfectueazaPlata( )
        {
            Console.WriteLine("Efectuam plata");

        }

        public void IntroduCardul()
        {
            Console.WriteLine("Introducem cardul");
        }

        public void ExtrageCardul()
        {
            Console.WriteLine("Extragem Cardul");
        }
    }
}
