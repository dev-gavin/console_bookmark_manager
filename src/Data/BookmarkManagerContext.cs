using BookmarkManager.Models;
using Microsoft.EntityFrameworkCore;

namespace BookmarkManager.Data;

public class BookmarkManagerContext : DbContext
{
    public DbSet<Bookmark> Bookmarks { get; set; } = null!;
    public DbSet<Tag> Tags { get; set; } = null!;
    public string DbPath { get; }

    public BookmarkManagerContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "bookmarks.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }
}
