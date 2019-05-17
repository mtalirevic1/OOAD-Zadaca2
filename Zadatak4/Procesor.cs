namespace Zadatak4
{
    public class Procesor
    {
        private string id;
        private TipProcesora tip;

        public Procesor(string id, TipProcesora tip)
        {
            this.id = id;
            this.tip = tip;
        }

        public string Id
        {
            get => id;
            set => id = value;
        }

        public TipProcesora Tip
        {
            get => tip;
            set => tip = value;
        }
    }
}