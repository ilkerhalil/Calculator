using System;
using System.Collections.Generic;
using Calculator.ConsoleUi.Command;
using Calculator.ConsoleUi.ConcreteCommand;
using Calculator.ConsoleUi.Invoker;
using Calculator.ConsoleUi.Receiver;
using Calculator.ConsoleUi._Model;

namespace Calculator.ConsoleUi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> degerler = new List<decimal> { 6, 3, 2, 6, 2, 7 };

            Islemler islem = new Islemler() { Id = 1, Toplama = degerler, Cikarma = degerler, Carpma = degerler, Bolme = degerler };

            ReceiverIslemler receiverIslemler = new ReceiverIslemler(islem);

            CommandIslemler commandTopla = new ConcreteCommandTopla(receiverIslemler);
            CommandIslemler commandCikar = new ConcreteCommandCikarma(receiverIslemler);
            CommandIslemler commandCarp = new ConcreteCommandCarpma(receiverIslemler);
            CommandIslemler commandBol = new ConcreteCommandBolme(receiverIslemler);

            InvokerIslemler invokerIslemler = new InvokerIslemler();
            invokerIslemler.CommandIslemlerList.Add(commandTopla);
            invokerIslemler.CommandIslemlerList.Add(commandCikar);
            invokerIslemler.CommandIslemlerList.Add(commandCarp);
            invokerIslemler.CommandIslemlerList.Add(commandBol);
            invokerIslemler.ExecuteAll();

            Console.Read();
        }
    }
}
