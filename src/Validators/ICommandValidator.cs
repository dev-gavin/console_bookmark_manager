namespace BookmarkManager;

public interface ICommandValidator
{
    bool IsValid(string[] arguments);
}
