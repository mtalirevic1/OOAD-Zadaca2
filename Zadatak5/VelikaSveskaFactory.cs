namespace Zadatak5
{
    public class VelikaSveskaFactory : AbstractFactory
    {
        public override Sveska getSveska(string tip)
        {
            if (tip.ToLower().Equals("linije"))
            {
                return new VelikaSveskaLinije();
            }
            else if (tip.ToLower().Equals("kockice"))
            {
                return new VelikaSveskaKockice();
            }

            return null;
        }
    }
}