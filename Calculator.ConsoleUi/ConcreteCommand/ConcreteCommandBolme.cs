using Calculator.ConsoleUi.Command;
using Calculator.ConsoleUi.Receiver;

namespace Calculator.ConsoleUi.ConcreteCommand
{
    class ConcreteCommandBolme : ICommand
    {
        private IReceiver _receiver;
        public ConcreteCommandBolme(IReceiver receiver)
        {
            this._receiver = receiver;
        }
        public void Execute()
        {
            _receiver.Bolme();
        }
    }
}
