using System;
using System.Collections.Generic;

namespace Zadatak6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Aukcija aukcija=new Aukcija(new List<Observer>(),0,"");
            Observer.Aukcija = aukcija;
            Observer observer1=new PredstavnikPrva();
            Observer observer2=new PredstavnikTreca();           
            observer1.AdapterNotifikacija=new AdapterNotifikacija();            
            observer2.AdapterNotifikacija=new AdapterNotifikacija();
            observer1.PostaviPonudu(20);
            observer2.PostaviPonudu(30);
        }
    }
}