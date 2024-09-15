using BookmarkManager.Handlers;

namespace BookmarkManager.Factories;

public class CommandHandlerFactory
{
    public static ICommandHandler? GetHandler(string command)
    {
        return command switch
        {
            "help" => new HelpCommandHandler(),
            // "add" => new AddCommandValidator(),
            "list" => new ListCommandHandler(),
            // "search" => new SearchCommandValidator(),
            // "edit" => new ExportCommandValidator(),
            // "exit" => new ExitCommandValidator(),
        };
    }
}
