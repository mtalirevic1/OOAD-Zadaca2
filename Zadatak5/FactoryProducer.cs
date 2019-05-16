using System;

namespace Zadatak5
{
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(bool mala)
        {
            if (mala)
            {
                return new MalaSveskaFactory();
            }

            return new VelikaSveskaFactory();
        }
    }
}