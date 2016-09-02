using System.Runtime.CompilerServices;

namespace Calculator.ConsoleUi
{
    public interface IAritmatikIslem
    {
        string Sembol { get; }
        decimal Hesapla();
    }

     

}