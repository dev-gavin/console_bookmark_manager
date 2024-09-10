namespace bookmark_manager;

public class HelpCommandHandler : ICommandHandler
{
    public void HandleCommand(string[] commandArgs)
    {
        Console.WriteLine("add\tadd a new bookmark");
    }
}
