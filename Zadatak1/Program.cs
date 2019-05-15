using System;

namespace Zadatak1
{
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd=new Random();
            Console.WriteLine("Broj dana od početka godine je "+ rnd.Next(0,365)); // da ne bude main prazan :)
        }
    }
}