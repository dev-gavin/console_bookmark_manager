namespace bookmark_manager;

public interface ICommandHandler
{
    void HandleCommand(string[] arguments);
}
