namespace bookmark_manager;

public interface ICommandValidator
{
    bool IsValid(string[] arguments);
}
