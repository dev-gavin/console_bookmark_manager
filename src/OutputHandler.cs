public class OutputHandler
{
    public void ShowWelcomeMessage()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Command-Line Bookmark Manager!");
        Console.WriteLine("Type 'help' for a list of commands.");
    }

    public void ShowInvalidCommandMessage()
    {
        Console.WriteLine("Invalid Command: Type 'help' for a list of commands");
    }

    public void DisplayResult(string command, object results)
    {
        throw new NotImplementedException();
    }
}
