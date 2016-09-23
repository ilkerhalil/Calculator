using Calculator.ConsoleUi.Command;
using Calculator.ConsoleUi.Receiver;

namespace Calculator.ConsoleUi.ConcreteCommand
{
    class ConcreteCommandCikarma : CommandIslemler
    {
        public ConcreteCommandCikarma(ReceiverIslemler receiverIslemler) : base(receiverIslemler)
        {
        }

        public override void Execute()
        {
            _receiverIslemler.Cikar();
        }
    }
}
