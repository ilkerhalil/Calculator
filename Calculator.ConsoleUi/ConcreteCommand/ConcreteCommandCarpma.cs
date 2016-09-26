using Calculator.ConsoleUi.Command;
using Calculator.ConsoleUi.Receiver;

namespace Calculator.ConsoleUi.ConcreteCommand
{
    class ConcreteCommandCarpma : ICommand
    {
        private IReceiver _receiver;
        public ConcreteCommandCarpma(IReceiver receiver)
        {
            this._receiver = receiver;
        }
        public void Execute()
        {
            _receiver.Carpma();
        }
    }
}
