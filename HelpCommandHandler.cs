namespace bookmark_manager;

public class HelpCommandHandler : ICommandHandler
{
    public void HandleCommand(string[] commandArgs)
    {
        Console.WriteLine("add\tadd a new bookmark");
        Console.WriteLine("list\tlist all bookmarks");
        Console.WriteLine("search\tsearch bookmarks");
        Console.WriteLine("edit\tedit a bookmarks");
        Console.WriteLine("exit\texit the program");
    }
}
