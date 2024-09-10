namespace bookmark_manager;

public class CommandHandlerFactory
{
    public static ICommandHandler? GetHandler(string command)
    {
        return command switch
        {
            "help" => new HelpCommandHandler(),
            // "add" => new AddCommandValidator(),
            // "list" => new ListCommandValidator(),
            // "search" => new SearchCommandValidator(),
            // "edit" => new ExportCommandValidator(),
            // "exit" => new ExitCommandValidator(),
            // _ => null,
        };
    }
}
