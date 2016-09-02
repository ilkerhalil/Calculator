namespace Calculator.ConsoleUi
{
    public class Cikartma : IAritmatikIslem
    {
        private readonly decimal _a;
        private readonly decimal _b;

        public Cikartma(decimal a,decimal b)
        {
            _a = a;
            _b = b;
            Sembol = "-";
        }
        public string Sembol { get; }
        public decimal Hesapla()
        {
            return _a - _b;
        }
    }
}