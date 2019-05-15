using System;

namespace Zadatak3
{
    class Program
    {
        private static string[] boje = {"Crvena", "Zelena", "Plava", "Crna", "Bijela"};
        
        private static int dajRandomX()
        {
            Random random= new Random();
            return (random.Next(1, 5));
        }

        private static string dajRandomBoju()
        {
            Random random= new Random();
            return boje[random.Next(0, boje.Length - 1)];
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Kvadrat kvadrat = (Kvadrat) TvornicaOblika.dajKvadrat(dajRandomX(), dajRandomBoju());
                kvadrat.Nacrtaj();
            }
        }
    }
}