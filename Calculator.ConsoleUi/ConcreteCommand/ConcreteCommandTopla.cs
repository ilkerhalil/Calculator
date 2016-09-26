using Calculator.ConsoleUi.Command;
using Calculator.ConsoleUi.Receiver;

namespace Calculator.ConsoleUi.ConcreteCommand
{
    public class ConcreteCommandTopla : ICommand
    {
        private IReceiver _receiver;
        public ConcreteCommandTopla(IReceiver receiver)
        {
            this._receiver = receiver;
        }
        public void Execute()
        {
            _receiver.Toplama();
        }
    }
}
