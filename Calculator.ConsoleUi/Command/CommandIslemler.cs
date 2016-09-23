using Calculator.ConsoleUi.Receiver;

namespace Calculator.ConsoleUi.Command
{
    public abstract class CommandIslemler
    {
        protected ReceiverIslemler _receiverIslemler;
        public CommandIslemler(ReceiverIslemler receiverIslemler)
        {
            this._receiverIslemler = receiverIslemler;
        }

        public abstract void Execute();
    }
}
