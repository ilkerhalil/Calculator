using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.CommandPattern
{
    public class ConcreteCommandToplama : Command
    {
        public ConcreteCommandToplama(Receiver receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            _receiver.Toplama();
        }
    }
}
