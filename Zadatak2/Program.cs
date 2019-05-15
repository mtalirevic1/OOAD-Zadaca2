using System;

namespace Zadatak2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            TvornicaPalacinaka tvornicaPalacinaka=new TvornicaPalacinaka();
            Meni meni=new Meni();
            StarinskiPalacinak starinskiPalacinak = tvornicaPalacinaka.napraviStarinski("nutela");
            ModerniPalacinak moderniPalacinak = tvornicaPalacinaka.napraviModerni("eurokrem", "plazma");
            Console.WriteLine(starinskiPalacinak);
            Console.WriteLine(moderniPalacinak);
            meni.dodajVrstu(starinskiPalacinak);
            meni.dodajVrstu(moderniPalacinak);
            meni.ispisiMeni();
        }
        
    }
}