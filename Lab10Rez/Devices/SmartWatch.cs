using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10Rez.Devices
{
    class SmartWatch : IContactLessPayment
    {
        public void ApropieDispozitiv()
        {
            Console.WriteLine("Apropie Ceasul");
        }

        public void EfectueazaPlata( )
        {
            Console.WriteLine("Platim");
        }

      
    }
}
