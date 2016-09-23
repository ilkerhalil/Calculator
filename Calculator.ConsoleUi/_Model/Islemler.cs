using System.Collections.Generic;

namespace Calculator.ConsoleUi._Model
{
    public class Islemler
    {
        public int Id { get; set; }
        public List<decimal> Toplama { get; set; }
        public List<decimal> Cikarma { get; set; }
        public List<decimal> Carpma { get; set; }
        public List<decimal> Bolme { get; set; }
    }
}
