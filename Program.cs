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
        }
    }

    private static bool IsValidInput(string[] inputArray)
    {
        bool isValidInput = false;
        string[] validCommands = { "add", "list", "search", "edit", "export", "exit" };
        isValidInput = validCommands.Contains(inputArray[0]);

        return isValidInput;
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
