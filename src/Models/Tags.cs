using System.ComponentModel.DataAnnotations.Schema;

namespace BookmarkManager.Models;

public class Tag
{
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = null!;

    [Column("bookmarkid")]
    public Bookmark Bookmark { get; set; } = null!;
}
