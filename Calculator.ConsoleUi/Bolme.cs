namespace Calculator.ConsoleUi
{
    public  class Bolme : IAritmatikIslem
    {
        private readonly decimal _a;
        private readonly decimal _b;
        public string Sembol { get; }
        public decimal Hesapla()
        {
            return _a/_b;
        }

        public Bolme(decimal a,decimal b)
        {
            _a = a;
            _b = b;
            Sembol = "/";
        }
    }
}