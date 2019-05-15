namespace Zadatak2
{
    public abstract class Palacinak
    {
        protected Palacinak(string vrstaNamaza)
        {
            this.vrstaNamaza = vrstaNamaza;
        }

        private string vrstaNamaza;

        public string VrstaNamaza
        {
            get => vrstaNamaza;
            set => vrstaNamaza = value;
        }
    }
}