namespace Zadatak4
{
    public class Graficka
    {
        private string id;
        private ProizvodacGrafickih proizvodac;

        public Graficka(string id, ProizvodacGrafickih proizvodac)
        {
            this.id = id;
            this.proizvodac = proizvodac;
        }

        public string Id
        {
            get => id;
            set => id = value;
        }

        public ProizvodacGrafickih Proizvodac
        {
            get => proizvodac;
            set => proizvodac = value;
        }
    }
}