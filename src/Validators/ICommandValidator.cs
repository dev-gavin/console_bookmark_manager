namespace BookmarkManager.Validators;

public interface ICommandValidator
{
    bool IsValid(string[] arguments);
}
