using Calculator.ConsoleUi.Command;
using System.Collections.Generic;

namespace Calculator.ConsoleUi.Invoker
{
    public class InvokerIslemler
    {
        public List<CommandIslemler> CommandIslemlerList { get; set; }
        public InvokerIslemler()
        {
            CommandIslemlerList = new List<CommandIslemler>();
        }

        public void ExecuteAll()
        {
            if (CommandIslemlerList.Count == 0)
                return;

            foreach (CommandIslemler item in CommandIslemlerList)
            {
                item.Execute();
            }
        }
    }
}
