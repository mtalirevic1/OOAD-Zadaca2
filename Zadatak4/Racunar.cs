namespace Zadatak4
{
    public class Racunar
    {
        private Procesor procesor;
        private Graficka graficka;
        private RAM ram;

        public Racunar(Procesor procesor, Graficka graficka, RAM ram)
        {
            this.procesor = procesor;
            this.graficka = graficka;
            this.ram = ram;
        }

        public Procesor Procesor
        {
            get => procesor;
            set => procesor = value;
        }

        public Graficka Graficka
        {
            get => graficka;
            set => graficka = value;
        }

        public RAM Ram
        {
            get => ram;
            set => ram = value;
        }
    }
}