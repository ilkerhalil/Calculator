using System.Collections.Generic;
using System.Linq;

namespace Calculator.ConsoleUi
{
    public class AritmatikIslemFactory
    {
        private readonly List<IAritmatikIslem> _aritmatikIslemler;

        public AritmatikIslemFactory()
        {
            _aritmatikIslemler = new List<IAritmatikIslem>();
        }

        public void RegisterAritmatikIslem(params IAritmatikIslem[] aritmatikIslemler)
        {
            _aritmatikIslemler.AddRange(aritmatikIslemler);
        }

        public IAritmatikIslem Calistir(string sembol)
        {
            return _aritmatikIslemler.Single(s => s.Sembol == sembol);
        }
    }
}