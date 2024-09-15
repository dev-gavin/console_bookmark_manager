using BookmarkManager.Data;

namespace BookmarkManager.Handlers;

public class HelpCommandHandler : ICommandHandler
{
    public void HandleCommand(string[] arguments, BookmarkManagerContext context)
    {
        Console.WriteLine("add\tadd a new bookmark");
        Console.WriteLine("list\tlist all bookmarks");
        Console.WriteLine("search\tsearch bookmarks");
        Console.WriteLine("edit\tedit a bookmarks");
        Console.WriteLine("exit\texit the program");
    }
}
