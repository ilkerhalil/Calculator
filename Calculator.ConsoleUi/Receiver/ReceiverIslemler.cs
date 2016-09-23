﻿using Calculator.ConsoleUi._Model;
using System;

namespace Calculator.ConsoleUi.Receiver
{
    public class ReceiverIslemler
    {
        private Islemler _islemler;
        public ReceiverIslemler(Islemler islemler)
        {
            this._islemler = islemler;
        }

        public decimal Topla()
        {
            decimal sonuc = 0;
            foreach (var item in _islemler.Toplama)
            {
                sonuc += item;
            }

            Console.WriteLine($"Toplama isleminin sonucu => {sonuc}");
            return sonuc;
        }

        public decimal Cikar()
        {
            decimal sonuc = 0;
            foreach (var item in _islemler.Cikarma)
            {
                sonuc -= item;
            }

            Console.WriteLine($"Cikarma isleminin sonucu => {sonuc}");
            return sonuc;
        }

        public decimal Carpma()
        {
            decimal sonuc = 0;
            foreach (var item in _islemler.Carpma)
            {
                sonuc *= item;
            }

            Console.WriteLine($"Carpma isleminin sonucu => {sonuc}");
            return sonuc;
        }

        public decimal Bolme()
        {
            decimal sonuc = 0;
            foreach (var item in _islemler.Bolme)
            {
                sonuc /= item;
            }

            Console.WriteLine($"Bolme isleminin sonucu => {sonuc}");
            return sonuc;
        }
    }
}