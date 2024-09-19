using BookmarkManager.Factories;
using BookmarkManager.Validators;

public class InputHandler
{
    public string[] GetValidUserInput()
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

    private static string PromptUserForInput()
    {
        string input;
        Console.Write(Environment.NewLine);
        do
        {
            Console.Write("> ");
            input = Console.ReadLine() ?? string.Empty;
        } while (string.IsNullOrEmpty(input));

        return input;
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
}
