using Lab10Rez.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10Rez.CasaDeMarcat
{
    /*Casa de marcat
O casa de marcat va avea o metoda prin care va scana un produs, va oferi metode de plata cash sau prin
intermediul unui POS.
• In cazul platii cash, casa de marcat
1. va deschide un seif
2. va introduce suma in seif
3. va inchide seif-ul
4. Va elibera chitanta
Aceasta functionalitate va fi modelata printr-o metoda care va primi un singur parametru, suma
de plata. La fiecare dintre operatiunile de mai sus, un mesaj corespunzator va fi afisat pe ecran
• In cazul platii cu cardul, casa de marcat va pune la dispozitia clientului un POS, printr-o metoda care
va oferi la cerere un POS
POS-ul
POS-ul va accepta atat plata contactless cat si plata contact-full. Cele doua modalitati de plata vor fi
modelate prin intermediul a doua metode, ce vor primi doi parametri: suma si dispozitivul prin care se
va efectua plata „ascuns” sub o interfata specifica fiecarui mod de plata.
Pentru plata prin intermediul POS-ului, clientul va putea folosi atat
 carduri clasice – suporta doar plati contactfull
 carduri contactless - suporta atat plati contact-full cat si plati contactless
 telefoane mobile contactless - suporta doar plati contactles*/
    class CasaDeMarcat
    {
        private Seif seif= new Seif();
        public PoS Pos;
        Produs produs;
        
        List<BonCasa> ListaBonuri= new List<BonCasa>();

            
        public CasaDeMarcat()
        {

        }

        public CasaDeMarcat(PoS pos)
        {
            this.Pos = pos;
        }

        public void ScaneazaProdus(Produs produs)
        {
            var bon = new BonCasa();
            this.produs = produs;
            bon.GetProdus(this.produs);
            ListaBonuri.Add(bon);
          
        }

        public void AfiseazaBonuri()
        {
            foreach (var bon in ListaBonuri)
            {
                bon.CitesteBon();
            }
        }
        private void BonDeCasa()
        {
            Console.WriteLine($"A-ti achitat suma de :{this.produs.Pret} pentru {produs.Nume}");
        }

        public  void PlataCash()
        {
            seif.DeschideSeif();
            seif.DepuneInSeif(produs.Pret);
            seif.InchideSeif();
            BonDeCasa();
        }

        public void PlataPoS( IContactLessPayment device)
        {

            Pos.ContBancar = produs.Pret;
            Pos.Plateste(device);
            Console.WriteLine($"At-ti achitat suam de :{produs.Pret}");
            BonDeCasa();
            
        }

        public void PlataPoS( IContactFullpayment device)
        {

            Pos.ContBancar = +produs.Pret;
            Pos.Plateste(device);
            Console.WriteLine($"At-ti achitat suam de :{produs.Pret}");
            BonDeCasa();
        }




    }


}
