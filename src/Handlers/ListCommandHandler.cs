using BookmarkManager.Data;
using BookmarkManager.Models;

namespace BookmarkManager.Handlers;

public class ListCommandHandler : ICommandHandler
{
    public void HandleCommand(string[] arguments, BookmarkManagerContext context)
    {
        var bookmarks =
            from bookmark in context.Bookmarks
            where bookmark.IsArchived == false
            select bookmark;

        foreach (Bookmark bookmark in bookmarks)
        {
            var tags = from tag in context.Tags where tag.Bookmark.Id == bookmark.Id select tag;
            var formattedTags = string.Join(",", tags.Select(tag => tag.Name));
            Console.WriteLine(
                $"[{bookmark.Id}] {bookmark.Name} - {bookmark.Url} (Tags: {formattedTags})"
            );
        }
    }
}
