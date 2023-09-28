using System;

namespace Lab10Rez
{
    class Phone :IContactLessPayment
    {
        public void EfectueazaPlata( )
        {
            Console.WriteLine("Efectuam plata");

        }

        public void ApropieDispozitiv()
        {
            Console.WriteLine("Apropie telefonul");

        }
    }
}
