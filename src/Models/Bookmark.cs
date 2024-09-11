namespace BookmarkManager.Models;

public class Bookmark
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Url { get; set; } = null!;
    public ICollection<Tag> Tags { get; set; } = null!;
}
