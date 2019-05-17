using System;

namespace Zadatak4
{
    public class Banka : iNovac
    {
        public void PozajmiNovac(double iznos)
        {
            Console.WriteLine("Pozajmljeno "+iznos+" KM");
        }
    }
}