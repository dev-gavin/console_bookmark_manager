using BookmarkManager.Data;

namespace BookmarkManager;

class Program
{
    static void Main(string[] args)
    {
        using var context = new BookmarkManagerContext();
        var ui = new ConsoleUserInterface(context);

        ui.Run();
    }
}
