namespace Calculator.CommandPattern
{
    public class ConcreteCommandCikarma : Command
    {
        public ConcreteCommandCikarma(Receiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            _receiver.Cikarma();
        }
    }
}
