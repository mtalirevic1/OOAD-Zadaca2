using System.Collections.Generic;

namespace Zadatak6
{
    public class Aukcija
    {
        private List<Observer> _observeri;
        private double _najvecaPonuda;
        private string _arhiva;

        public Aukcija(List<Observer> observeri, double najvecaPonuda, string arhiva)
        {
            _observeri = observeri;
            _najvecaPonuda = najvecaPonuda;
            _arhiva = arhiva;
        }

        public List<Observer> Observeri
        {
            get => _observeri;
            set => _observeri = value;
        }

        public double NajvecaPonuda
        {
            get => _najvecaPonuda;
            set => _najvecaPonuda = value;
        }

        public string Arhiva
        {
            get => _arhiva;
            set => _arhiva = value;
        }

        public void DodajPonudu(double iznos)
        {

            if (iznos <= NajvecaPonuda)
            {
                return;
            }
            
            ObavijestiSve();
            _najvecaPonuda = iznos;
            _arhiva = _arhiva + "Ponuda: " + iznos + "\n";
        }

        private void ObavijestiSve()
        {
            foreach (var observer in _observeri)
            {
                observer.Obavijesti();
            }
        }
    }
}