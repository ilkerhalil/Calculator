namespace Calculator.CommandPattern
{
    public abstract class Command
    {
        protected Receiver _receiver;
        public Command(Receiver receiver)
        {
            this._receiver = receiver;
        }

        public abstract void Execute();
    }
}
