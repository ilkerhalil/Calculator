using System;
using System.Collections.Generic;

namespace Calculator.CommandPattern
{
    public class Receiver
    {
        private readonly List<decimal> _sayilar;
        public Receiver(List<decimal> sayilar)
        {
            this._sayilar = sayilar;
        }

        public void Action()
        {
            Console.WriteLine("Receiver içerisindeki Action metodu çalıştı.");
        }

        public decimal Cikarma()
        {
            decimal sonuc = 0;
            for (int i = 0; i < _sayilar.Count; i++)
            {
                sonuc -= _sayilar[i];
            }
            Console.WriteLine($"Cikarma isleminin sonucu => {sonuc}");
            return sonuc;
        }

        public decimal Toplama()
        {
            decimal sonuc = 0;
            for (int i = 0; i < _sayilar.Count; i++)
            {
                sonuc += _sayilar[i];
            }
            Console.WriteLine($"Toplama isleminin sonucu => {sonuc}");
            return sonuc;
        }
    }
}