using System;
using System.Collections.Generic;

namespace Zadatak2
{
    public class Meni
    {
        List<Palacinak> vrstePalacinaka=new List<Palacinak>();

        public void dodajVrstu(Palacinak palacinak)
        {
            foreach (Palacinak p in vrstePalacinaka)
            {
                if (p.GetType() == palacinak.GetType() && p.VrstaNamaza==palacinak.VrstaNamaza)
                {
                    return;
                }
            }
            vrstePalacinaka.Add(palacinak);
        }

        public void ispisiMeni()
        {
            foreach (var VARIABLE in vrstePalacinaka)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}