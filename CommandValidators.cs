namespace bookmark_manager;

public class HelpCommandValidator : ICommandValidator
{
    public bool IsValid(string[] arguments)
    {
        if (arguments.Length == 0)
            return true;
        else
            return false;
    }
}

public class AddCommandValidator : ICommandValidator
{
    public bool IsValid(string[] arguments)
    {
        throw new NotImplementedException();
    }
}

public class ListCommandValidator : ICommandValidator
{
    public bool IsValid(string[] arguments)
    {
        throw new NotImplementedException();
    }
}

public class SearchCommandValidator : ICommandValidator
{
    public bool IsValid(string[] arguments)
    {
        throw new NotImplementedException();
    }
}

public class EditCommandValidator : ICommandValidator
{
    public bool IsValid(string[] arguments)
    {
        throw new NotImplementedException();
    }
}

public class ExportCommandValidator : ICommandValidator
{
    public bool IsValid(string[] arguments)
    {
        throw new NotImplementedException();
    }
}

public class ExitCommandValidator : ICommandValidator
{
    public bool IsValid(string[] arguments)
    {
        return true;
    }
}
