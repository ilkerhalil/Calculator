using Calculator.ConsoleUi.Command;
using Calculator.ConsoleUi.Receiver;

namespace Calculator.ConsoleUi.ConcreteCommand
{
    class ConcreteCommandCarpma : CommandIslemler
    {
        public ConcreteCommandCarpma(ReceiverIslemler receiverIslemler) : base(receiverIslemler)
        {
        }

        public override void Execute()
        {
            _receiverIslemler.Carpma();
        }
    }
}
