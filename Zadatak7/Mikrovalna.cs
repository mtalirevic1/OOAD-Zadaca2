namespace Zadatak7
{
    public class Mikrovalna : IUredaj
    {
        public void upali(UredajDisplayVisitor uredajDisplayVisitor)
        {
            uredajDisplayVisitor.upali(this);
        }

        public void ugasi(UredajDisplayVisitor uredajDisplayVisitor)
        {
            uredajDisplayVisitor.ugasi(this);
        }
    }
}