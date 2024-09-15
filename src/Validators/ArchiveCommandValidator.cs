namespace BookmarkManager.Validators;

public class ArchiveCommandHandler : ICommandValidator
{
    public bool IsValid(string[] arguments)
    {
        if (arguments.Length == 0)
            return false;

        return arguments.All(arg => int.TryParse(arg, out _));
    }
}
