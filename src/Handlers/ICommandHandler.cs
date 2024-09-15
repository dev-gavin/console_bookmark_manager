using BookmarkManager.Data;

namespace BookmarkManager.Handlers;

public interface ICommandHandler
{
    void HandleCommand(string[] arguments, BookmarkManagerContext context);
}
