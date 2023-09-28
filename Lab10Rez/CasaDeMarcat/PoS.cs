using Lab10Rez.Devices;
using Lab10Rez.Interfaces;
using System;

namespace Lab10Rez.CasaDeMarcat
{
    class PoSWithouthInterface
    {
        public void Plateste(Card card)
        {
            card.IntroduCardul();
            card.EfectueazaPlata();
            card.ExtrageCardul();

        }
        public void PlatesteContactLess(Phone card)
        {
            card.ApropieDispozitiv();
            card.EfectueazaPlata();
        }

        public void PlatesteContactLess(CardContactLess card)
        {
            card.ApropieDispozitiv();
        }
    }

    class PoS
    {
        public int ContBancar { get; set; }
        public override string ToString()
        {
            return $"A-ti achitat "; 
        }

        public void Plateste(IContactLessPayment card)
        {
            card.ApropieDispozitiv();
            card.EfectueazaPlata();
            Console.WriteLine($"{ToString()} Contactless");
           

        }

        public void Plateste(IContactFullpayment card)
        {
            card.IntroduCardul();
            card.EfectueazaPlata();
            card.ExtrageCardul();
            Console.WriteLine($"{ToString()} Contactfull");
        }


    }
}
