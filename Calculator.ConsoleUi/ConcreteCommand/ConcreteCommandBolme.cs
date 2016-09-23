using Calculator.ConsoleUi.Command;
using Calculator.ConsoleUi.Receiver;

namespace Calculator.ConsoleUi.ConcreteCommand
{
    class ConcreteCommandBolme : CommandIslemler
    {
        public ConcreteCommandBolme(ReceiverIslemler receiverIslemler) : base(receiverIslemler)
        {
        }

        public override void Execute()
        {
            _receiverIslemler.Bolme();
        }
    }
}
