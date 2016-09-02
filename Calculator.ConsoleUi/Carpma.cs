namespace Calculator.ConsoleUi
{
    public class Carpma : IAritmatikIslem
    {
        private readonly decimal[] _sayilar;
        public string Sembol { get; }
        public decimal Hesapla()
        {
            decimal hesap =1;
            for (var i = 0; i < _sayilar.Length; i++)
            {

                hesap = _sayilar[i]*_sayilar[i + 1];
            }
            return hesap;
        }

        public Carpma(params decimal[] sayilar)
        {
            _sayilar = sayilar;
            Sembol = "*";
        }
    }
}