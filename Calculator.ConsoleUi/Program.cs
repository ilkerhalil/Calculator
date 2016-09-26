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

            IReceiver receiverIslemler = new ReceiverIslemler(islem);

            ICommand commandTopla = new ConcreteCommandTopla(receiverIslemler);
            ICommand commandCikarma = new ConcreteCommandCikarma(receiverIslemler);
            ICommand commandCarpma = new ConcreteCommandCarpma(receiverIslemler);
            ICommand commandBolme = new ConcreteCommandBolme(receiverIslemler);

            InvokerIslemler invokerIslemler = new InvokerIslemler();
            invokerIslemler.CommandIslemlerList.Add(commandTopla);
            invokerIslemler.CommandIslemlerList.Add(commandCikarma);
            invokerIslemler.CommandIslemlerList.Add(commandCarpma);
            invokerIslemler.CommandIslemlerList.Add(commandBolme);
            invokerIslemler.ExecuteAll();

            Console.Read();
        }
    }
}
