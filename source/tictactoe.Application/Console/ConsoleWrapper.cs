using System.Text;

namespace tictactoe.Application.Console
{
    public class ConsoleWrapper : IConsole
    {
        private StringBuilder consoleContent = new StringBuilder();
        public void ClearScreen()
        {
            consoleContent.Clear();
            System.Console.Clear();
        }

        public void WriteLine(string line)
        {
            consoleContent.AppendLine(line);
            System.Console.WriteLine(line);
        }
    }
}
