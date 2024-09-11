namespace BookmarkManager.Models;

public class Tag
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public Bookmark Bookmark { get; set; } = null!;
}
