using System;
using System.Collections.Generic;

namespace Zadatak3
{
    public class TvornicaOblika
    {
        private static List<Oblik> oblici = new List<Oblik>();

        public static Oblik dajKvadrat(double a, string boja)
        {
            Kvadrat kvadrat = null;
            foreach (Kvadrat oblik in oblici)
            {
                if (oblik.DuzinaStranice == a && oblik.Boja == boja)
                {
                    kvadrat = oblik;
                    break;
                }
            }

            if (kvadrat == null)
            {
                kvadrat=new Kvadrat(a,boja);
                oblici.Add(kvadrat);
                Console.WriteLine("Kreiranje novog kvadrata...");
            }

            return kvadrat;
        }

        public TvornicaOblika()
        {
        }
    }
}