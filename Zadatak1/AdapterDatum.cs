namespace Zadatak1
{
    public class AdapterDatum : IDatum
    {
        public AdapterDatum()
        {
        }

        private string BrojUMjesec(int mjesec)
        {

            if (mjesec == 1)
            {
                return  "januar";
            } 
            else if (mjesec == 2)
            {
                return "februar";
            }
            else if (mjesec ==3)
            {
                return  "mart";
            }
            //poenta je tu, nećemo svih 12
            return "nepostojeći mjesec";
        }
        
        public int Brojdana_godina(string mjesec, int dan)
        {
            if (mjesec ==  "januar")
            {
                return dan;
            } 
            else if (mjesec == "februar")
            {
                return 31+dan;
            }
            else if (mjesec =="mart")
            {
                return  31+28+dan;
            }

            return 42;
        }

        public int Brojdana_godina(int mjesec, int dan)
        {
            return Brojdana_godina(BrojUMjesec(mjesec), dan);
        }

        
    }
}