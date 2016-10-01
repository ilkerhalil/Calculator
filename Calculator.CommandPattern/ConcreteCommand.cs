namespace Calculator.CommandPattern
{
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            _receiver.Action();
        }
    }
}
