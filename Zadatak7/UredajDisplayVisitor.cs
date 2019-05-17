using System;

namespace Zadatak7
{
    public class UredajDisplayVisitor : UredajVisitor
    {
        public void upali(VesMasina vesMasina)
        {
            Console.WriteLine("Upaljena ves masina");
        }

        public void ugasi(VesMasina vesMasina)
        {
            Console.WriteLine("Ugasena ves masina");
        }

        public void upali(Mikrovalna mikrovalna)
        {
            Console.WriteLine("Upaljena mikrovalna");
        }

        public void ugasi(Mikrovalna mikrovalna)
        {
            Console.WriteLine("Ugasena mikrovalna");
        }
    }
}