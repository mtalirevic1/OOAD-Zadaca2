using System;

namespace Zadatak3
{
    public class Kvadrat : Oblik
    {
        private double _duzinaStranice;

        private string _boja;

        public double DuzinaStranice
        {
            get => _duzinaStranice;
            set => _duzinaStranice = value;
        }

        public string Boja
        {
            get => _boja;
            set => _boja = value;
        }

        public Kvadrat(double duzinaStranice, string boja)
        {
            _duzinaStranice = duzinaStranice;
            _boja = boja;
        }

        public override void Nacrtaj()
        {
          Console.WriteLine("Kvadrat, dužina stranica: "+DuzinaStranice+", boja: "+Boja);  
        }
    }
}