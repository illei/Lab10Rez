using System;
using Lab10Rez.Devices;


namespace Lab10Rez.CasaDeMarcat
{
    class Program
    {
        static void Main(string[] args)
        {

            var card = new Card();
            var phone = new Phone();
            var cc = new CardContactLess();
            var SmartWatch = new SmartWatch();
            var pos = new PoS();

            /* pos.Plateste(card);*/
            //pos.Plateste(cc);
            // pos.Plateste(phone);
            // pos.Plateste(SmartWatch);
            //var posWOI = new PoSWithouthInterface();


            var produs = new Produs(300, "Deodorant");
            var casaDeMarcat = new CasaDeMarcat(pos);
            casaDeMarcat.ScaneazaProdus(produs);
            casaDeMarcat.ScaneazaProdus(produs);
            casaDeMarcat.ScaneazaProdus(produs);
            casaDeMarcat.PlataCash();
            casaDeMarcat.AfiseazaBonuri();
           



        }
    }
}
