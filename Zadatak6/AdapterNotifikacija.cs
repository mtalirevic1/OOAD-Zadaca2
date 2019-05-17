using System;

namespace Zadatak6
{
    public class AdapterNotifikacija
    {
        public void Obavijesti(PredstavnikPrva prva)
        {
            Console.WriteLine("Predstavnik prve godine obaviješten putem maila o novoj najvećoj ponudi");
        }
        
        public void Obavijesti(PredstavnikTreca treca)
        {
            Console.WriteLine("Predstavnik trece godine obaviješten putem SMS-a o novoj najvećoj ponudi");
        }
    }
}