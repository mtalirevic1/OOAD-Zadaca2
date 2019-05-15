namespace Zadatak2
{
    public class TvornicaPalacinaka
    {
       public StarinskiPalacinak napraviStarinski(string vrstaNamaza)
        {
            return new StarinskiPalacinak(vrstaNamaza);
        }

        public ModerniPalacinak napraviModerni(string vrstaNamaza, string vrstaDodatka)
        {
            return new ModerniPalacinak(vrstaNamaza,vrstaDodatka);
        }
    }
}