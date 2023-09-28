using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10Rez.CasaDeMarcat
{
    class BonCasa
    {
        Produs produs;
        List<Produs> Produse = new List<Produs>();

      
        public void GetProdus(Produs produs)
        {
            this.produs = produs;
            Produse.Add(this.produs);

        }

        public void CitesteBon()
        {
            foreach (var produs in Produse)
            {
                Console.WriteLine($"{produs.Nume}:{produs.Pret}");
            }
        }


    }
}
