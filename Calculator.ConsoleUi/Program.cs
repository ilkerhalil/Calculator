using Calculator.CommandPattern;
using System;
using System.Collections.Generic;

namespace Calculator.ConsoleUi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> sayilar = new List<decimal>();
            Console.WriteLine("islem yapilacak sayi adedini giriniz:");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < count + 1; i++)
            {
                Console.Write(i + ". sayiyi giriniz:");
                decimal sayi = Convert.ToDecimal(Console.ReadLine());
                sayilar.Add(sayi);
            }

            Receiver receiver = new Receiver(sayilar);

            Command commandToplama = new ConcreteCommandToplama(receiver);
            Invoker invokerToplama = new Invoker();
            invokerToplama.SetCommand(commandToplama);
            invokerToplama.ExecuteCommand();

            Command commandCikarma = new ConcreteCommandCikarma(receiver);
            Invoker invokerCikarma = new Invoker();
            invokerCikarma.SetCommand(commandCikarma);
            invokerCikarma.ExecuteCommand();

            Console.ReadKey();
        }
    }
}
