using System.Linq;

namespace Calculator.ConsoleUi
{
    public class Toplama : IAritmatikIslem
    {
        private readonly decimal[] _sayilar;

        public Toplama(params decimal[] sayilar)
        {
            _sayilar = sayilar;
            Sembol = "+";
        }


        public string Sembol { get; }

        public decimal Hesapla()
        {
            return _sayilar.Sum();
        }
    }
}