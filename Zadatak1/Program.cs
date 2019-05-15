using System;

namespace Zadatak1
{
    
    
    
    class Program
    {
        
        static void Main(string[] args)
        {
            AdapterDatum adapterDatum= new AdapterDatum();
            Console.WriteLine("Broj dana (prva varijanta): "+adapterDatum.Brojdana_godina("januar",2)); //treba isto ispisati
            Console.WriteLine("Broj dana (druga varijanta): "+adapterDatum.Brojdana_godina(1,2));
        }
    }
}