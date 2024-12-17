using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tictactoe.Application.Console;

namespace tictactoe.Application.Test.Mocks
{
    public class ConsoleWrapperMock : IConsole
    {
        public StringBuilder screenContent = new StringBuilder();
        public string LineToWrite { get; set; }

        public void ClearScreen()
        {
            screenContent.Clear();
        }

        public void WriteLine(string message)
        {
            LineToWrite = message;
            screenContent.AppendLine(message);
        }
    }
}
