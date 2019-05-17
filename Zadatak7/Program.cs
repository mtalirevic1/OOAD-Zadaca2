using System;

namespace Zadatak7
{
    class Program
    {
        static void Main(string[] args)
        {
            IUredaj uredaj1=new Mikrovalna();
            IUredaj uredaj2=new VesMasina();
            uredaj1.upali(new UredajDisplayVisitor());
            uredaj1.ugasi(new UredajDisplayVisitor());
            uredaj2.upali(new UredajDisplayVisitor());
            uredaj2.ugasi(new UredajDisplayVisitor());
        }
    }
}