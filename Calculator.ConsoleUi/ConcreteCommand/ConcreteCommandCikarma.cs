using Calculator.ConsoleUi.Command;
using Calculator.ConsoleUi.Receiver;

namespace Calculator.ConsoleUi.ConcreteCommand
{
    class ConcreteCommandCikarma : ICommand
    {
        private IReceiver _receiver;
        public ConcreteCommandCikarma(IReceiver receiver)
        {
            this._receiver = receiver;
        }
        public void Execute()
        {
            _receiver.Cikarma();
        }
    }
}
