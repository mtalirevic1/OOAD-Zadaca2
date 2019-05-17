namespace Zadatak6
{
    public abstract class Observer
    {
        private static Aukcija _aukcija;

        private AdapterNotifikacija _adapterNotifikacija;

        public AdapterNotifikacija AdapterNotifikacija
        {
            get => _adapterNotifikacija;
            set => _adapterNotifikacija = value;
        }

        public abstract void Obavijesti();
        public abstract void PostaviPonudu(double iznos);

        public static Aukcija Aukcija
        {
            get => _aukcija;
            set => _aukcija = value;
        }
       
    }
}