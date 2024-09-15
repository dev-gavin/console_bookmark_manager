using BookmarkManager.Data;

namespace BookmarkManager.Handlers;

public class ArchiveCommandHandler : ICommandHandler
{
    public void HandleCommand(string[] arguments, BookmarkManagerContext context)
    {
        foreach (string arg in arguments)
        {
            Console.WriteLine(arg);
        }
    }
}
