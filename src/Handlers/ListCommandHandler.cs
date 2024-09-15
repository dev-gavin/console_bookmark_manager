using BookmarkManager.Data;
using BookmarkManager.Models;

namespace BookmarkManager.Handlers;

public class ListCommandHandler : ICommandHandler
{
    public void HandleCommand(string[] arguments, BookmarkManagerContext context)
    {
        // TODO: need better handling of command flags/arguments
        bool showArchived = arguments.Length > 0 && arguments[0].Equals("--archived");

        IQueryable<Bookmark> bookmarks;
        bookmarks =
            from bookmark in context.Bookmarks
            where bookmark.IsArchived == showArchived
            select bookmark;

        foreach (Bookmark bookmark in bookmarks)
        {
            var tags = from tag in context.Tags where tag.Bookmark.Id == bookmark.Id select tag;
            var formattedTags = tags.Any()
                ? string.Join(",", tags.Select(tag => tag.Name))
                : "No Tags";

            Console.WriteLine(
                $"{(showArchived ? "ARCHIVED: " : "")}[{bookmark.Id}] {bookmark.Name} - {bookmark.Url} (Tags: {formattedTags})"
            );
        }
    }
}
