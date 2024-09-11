using BookmarkManager.Validators;

namespace BookmarkManager.Factories;

public class CommandValidatorFactory
{
    public static ICommandValidator? GetValidator(string command)
    {
        return command switch
        {
            "help" => new HelpCommandValidator(),
            "add" => new AddCommandValidator(),
            "list" => new ListCommandValidator(),
            "search" => new SearchCommandValidator(),
            "edit" => new ExportCommandValidator(),
            "exit" => new ExitCommandValidator(),
            _ => null,
        };
    }
}
