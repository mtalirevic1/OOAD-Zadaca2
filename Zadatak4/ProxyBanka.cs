namespace Zadatak4
{
    public class ProxyBanka : iNovac
    {
        private Banka _banka;
        private string _password;

        public string Password
        {
            get => _password;
            set => _password = value;
        }

        public ProxyBanka(Banka banka, string password)
        {
            _banka = banka;
            _password = password;
        }
     
        public Banka Banka
        {
            get => _banka;
            set => _banka = value;
        }


        public void PozajmiNovac(double iznos)
        {
            if (Verifikacija(_password))
            {
                _banka.PozajmiNovac(iznos);
            }
        }

        private bool Verifikacija(string password)
        {
            if (password == "password")
            {
                return true;
            }

            return false;
        }
    }
}