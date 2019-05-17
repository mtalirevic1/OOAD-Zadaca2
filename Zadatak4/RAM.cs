namespace Zadatak4
{
    public class RAM
    {
        private string id;
        private int kolicina;

        public RAM(string id, int kolicina)
        {
            this.id = id;
            this.kolicina = kolicina;
        }

        public string Id
        {
            get => id;
            set => id = value;
        }

        public int Kolicina
        {
            get => kolicina;
            set => kolicina = value;
        }
    }
}