using BookmarkManager.Data;

namespace BookmarkManager.Handlers;

public class ArchiveCommandHandler : ICommandHandler
{
    public void HandleCommand(string[] arguments, BookmarkManagerContext context)
    {
        foreach (string bookmarkIdString in arguments)
        {
            int bookmarkId;
            int.TryParse(bookmarkIdString, out bookmarkId);

            var relevantBookMark = (
                from bookmark in context.Bookmarks
                where bookmark.Id == bookmarkId
                select bookmark
            ).First();

            relevantBookMark.IsArchived = relevantBookMark.IsArchived ? false : true;
            context.SaveChanges();
        }
    }
}
