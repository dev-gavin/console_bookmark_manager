namespace BookmarkManager;

public interface ICommandHandler
{
    void HandleCommand(string[] arguments);
}
