using BookmarkManager.Data;
using BookmarkManager.Models;

namespace BookmarkManager.Handlers;

public class ListCommandHandler : ICommandHandler
{
    public void HandleCommand(string[] arguments, BookmarkManagerContext context)
    {
        Console.WriteLine("Querying for a bookmark");
        var bookmarks = from bookmark in context.Bookmarks where bookmark.Id == 1 select bookmark;

        foreach (Bookmark bookmark in bookmarks)
        {
            Console.WriteLine(bookmark.Name);
            Console.WriteLine(bookmark.Url);
        }
    }
}
