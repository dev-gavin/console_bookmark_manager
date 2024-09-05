namespace bookmark_manager;

// using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Command-Line Bookmark Manager!");
        Console.WriteLine("Type 'help' for a list of commands.");

        bool isValidInput = false;
        while (!isValidInput)
        {
            var input = GetUserInput();
            var inputArray = input.Split(" ");
            isValidInput = IsValidInput(inputArray);
            if (!isValidInput)
                Console.WriteLine("Invalid Command: Type 'help' for a list of commands");
        }
    }

    private static bool IsValidInput(string[] inputArray)
    {
        string command = inputArray[0];

        ICommandValidator? validator = CommandValidatorFactory.GetValidator(command);

        if (validator == null)
            return false;

        return validator.isValid(inputArray.Skip(1).ToArray());
    }

    private static string GetUserInput()
    {
        Console.Write(Environment.NewLine);
        Console.Write("> ");
        string? input = Console.ReadLine();
        while (string.IsNullOrEmpty(input))
        {
            Console.Write("> ");
            input = Console.ReadLine();
        }
        return input;
    }
}
