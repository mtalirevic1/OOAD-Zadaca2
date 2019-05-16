namespace Zadatak5
{
    public class MalaSveskaFactory : AbstractFactory
    {
        public override Sveska getSveska(string tip)
        {
            if (tip.ToLower().Equals("linije"))
            {
                return new MalaSveskaLinije();
            }
            else if (tip.ToLower().Equals("kockice"))
            {
                return new MalaSveskaKockice();
            }

            return null;
        }
    }
}