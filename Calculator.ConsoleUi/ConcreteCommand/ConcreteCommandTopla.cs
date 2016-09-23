using Calculator.ConsoleUi.Command;
using Calculator.ConsoleUi.Receiver;

namespace Calculator.ConsoleUi.ConcreteCommand
{
    public class ConcreteCommandTopla : CommandIslemler
    {
        public ConcreteCommandTopla(ReceiverIslemler receiverIslemler) : base(receiverIslemler)
        {
        }

        public override void Execute()
        {
            _receiverIslemler.Topla();
        }
    }
}
