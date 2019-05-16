using System;

namespace Zadatak5
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory shapeFactory = FactoryProducer.getFactory(false);
            Sveska sveska1 = shapeFactory.getSveska("kockice");
            sveska1.Napravi();
            Sveska sveska2 = shapeFactory.getSveska("linije");
            sveska2.Napravi();
            AbstractFactory shapeFactory1 = FactoryProducer.getFactory(true);
            Sveska sveska3 = shapeFactory1.getSveska("kockice");
            sveska3.Napravi();
            Sveska sveska4= shapeFactory1.getSveska("linije");
            sveska4.Napravi();
        }
    }
}