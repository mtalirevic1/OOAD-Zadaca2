using System.Collections.Generic;

namespace Zadatak4
{
    public class OOADDigital
    {
        private List<Racunar> racunari;
        private string tekuciRacun;
        private ProxyBanka banka;
        private Dobavljac dobavljac;

        public OOADDigital(List<Racunar> racunari, string tekuciRacun, ProxyBanka banka, Dobavljac dobavljac)
        {
            this.racunari = racunari;
            this.tekuciRacun = tekuciRacun;
            this.banka = banka;
            this.dobavljac = dobavljac;
        }

        public List<Racunar> Racunari
        {
            get => racunari;
            set => racunari = value;
        }

        public string TekuciRacun
        {
            get => tekuciRacun;
            set => tekuciRacun = value;
        }

        public ProxyBanka Banka
        {
            get => banka;
            set => banka = value;
        }

        public Dobavljac Dobavljac
        {
            get => dobavljac;
            set => dobavljac = value;
        }

        public void AzurirajTekuci(string s)
        {
            tekuciRacun = tekuciRacun + s;
        }

        public Racunar SklopiRacunar(Procesor p, Graficka g, RAM r)
        {
            return new Racunar(p,g,r);
        }
    }
}