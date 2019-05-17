namespace Zadatak6
{
    public class PredstavnikTreca : Observer
    {
        public override void Obavijesti()
        {
            AdapterNotifikacija.Obavijesti(this);
        }

        public override void PostaviPonudu(double iznos)
        {
            Aukcija.DodajPonudu(iznos);
        }
    }
}