namespace tictactoe.Application.Console
{
    public class ConsoleWrapper : IConsole
    {
        public void ClearScreen()
        {
            System.Console.Clear();
        }

        public void WriteLine(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}
