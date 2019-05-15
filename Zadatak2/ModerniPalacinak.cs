namespace Zadatak2
{
    public class ModerniPalacinak : Palacinak
    {
        private string vrstaDodatka;

        public string VrstaDodatka
        {
            get => vrstaDodatka;
            set => vrstaDodatka = value;
        }

        public ModerniPalacinak(string vrstaNamaza, string vrstaDodatka) : base(vrstaNamaza)
        {
            this.vrstaDodatka = vrstaDodatka;
        }

        public override string ToString()
        {
            return "Moderni palačinak sa vrstom namaza "+ VrstaNamaza +" i dodatkom "+ VrstaDodatka;
        }
    }
    
    
}