namespace bookmark_manager;

public interface ICommandValidator
{
    bool isValid(string[] arguments);
}
