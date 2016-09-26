using Calculator.ConsoleUi.Command;
using System.Collections.Generic;

namespace Calculator.ConsoleUi.Invoker
{
    public class InvokerIslemler
    {
        public List<ICommand> CommandIslemlerList { get; set; }
        public InvokerIslemler()
        {
            CommandIslemlerList = new List<ICommand>();
        }

        public void ExecuteAll()
        {
            if (CommandIslemlerList.Count == 0)
                return;

            foreach (ICommand item in CommandIslemlerList)
            {
                item.Execute();
            }
        }
    }
}
