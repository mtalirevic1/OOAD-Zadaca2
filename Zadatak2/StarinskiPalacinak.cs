namespace Zadatak2
{
    public class StarinskiPalacinak : Palacinak
    {
        public StarinskiPalacinak(string vrstaNamaza) : base(vrstaNamaza)
        {
        }
        
        public override string ToString()
        {
            return "Starinski palačinak sa vrstom namaza "+ VrstaNamaza;
        }
    }
}