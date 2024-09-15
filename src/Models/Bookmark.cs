using System.ComponentModel.DataAnnotations.Schema;

namespace BookmarkManager.Models;

public class Bookmark
{
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = null!;

    [Column("url")]
    public string Url { get; set; } = null!;

    public ICollection<Tag> Tags { get; set; } = null!;
}
