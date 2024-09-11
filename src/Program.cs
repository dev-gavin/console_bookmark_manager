namespace BookmarkManager;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Command-Line Bookmark Manager!");
        Console.WriteLine("Type 'help' for a list of commands.");

        bool isProgramRunning = true;
        while (isProgramRunning)
        {
            string[] inputArray = GetValidUserInput();
            string command = inputArray[0];

            if (String.Equals(command, "exit"))
            {
                isProgramRunning = false;
                break;
            }

            Console.WriteLine();
            HandleCommand(command, inputArray.Skip(1).ToArray());
        }
    }

    private static void HandleCommand(string command, string[] commandArgs)
    {
        ICommandHandler handler = CommandHandlerFactory.GetHandler(command);
        handler.HandleCommand(commandArgs);
    }

    private static string[] GetValidUserInput()
    {
        string[] inputArray = Array.Empty<string>();
        bool isValidInput = false;

        while (!isValidInput)
        {
            var input = PromptUserForInput();
            inputArray = input.Split(" ");

            isValidInput = IsValidInput(inputArray);

            if (!isValidInput)
            {
                Console.WriteLine("Invalid Command: Type 'help' for a list of commands");
                continue;
            }
        }

        return inputArray;
    }

    private static bool IsValidInput(string[] inputArray)
    {
        if (inputArray.Length == 0)
            return false;

        string command = inputArray[0];
        ICommandValidator? validator = CommandValidatorFactory.GetValidator(command);

        if (validator == null)
            return false;

        return validator.IsValid(inputArray.Skip(1).ToArray());
    }

    private static string PromptUserForInput()
    {
        string? input = String.Empty;
        Console.Write(Environment.NewLine);
        do
        {
            Console.Write("> ");
            input = Console.ReadLine();
        } while (string.IsNullOrEmpty(input));

        return input;
    }
}
