namespace Zadatak7
{
    public interface UredajVisitor
    {
        void upali(VesMasina vesMasina);
        void ugasi(VesMasina vesMasina);
        void upali(Mikrovalna mikrovalna);
        void ugasi(Mikrovalna mikrovalna);
    }
}