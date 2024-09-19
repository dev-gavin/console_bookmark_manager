using BookmarkManager;
using BookmarkManager.Data;
using BookmarkManager.Factories;
using BookmarkManager.Handlers;

public class ConsoleUserInterface : IUserInterface
{
    private readonly BookmarkManagerContext _context;
    private readonly InputHandler _inputHandler;
    private readonly OutputHandler _outputHandler;

    public ConsoleUserInterface(BookmarkManagerContext context)
    {
        _context = context;
        _inputHandler = new InputHandler();
        _outputHandler = new OutputHandler();
    }

    public void Run()
    {
        _outputHandler.ShowWelcomeMessage();

        bool isUiRunning = true;
        while (isUiRunning)
        {
            string[] inputArray = _inputHandler.GetValidUserInput();
            string command = inputArray[0];

            if (String.Equals(command, "exit"))
            {
                isUiRunning = false;
                break;
            }

            Console.WriteLine();
            HandleCommand(command, inputArray.Skip(1).ToArray(), _context);
        }
    }

    private void HandleCommand(string command, string[] strings, BookmarkManagerContext context)
    {
        ICommandHandler handler = CommandHandlerFactory.GetHandler(command);
        // handler.HandleCommand(args, context);
    }
}
