namespace WebApi.Models;

public class Book
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public ICollection<Genre> Genres { get; set; }
    public DateTime ReleaseDate { get; set; }
    public ICollection<Author> Authors { get; set; }
    public Publisher Publisher { get; set; }
    // public DateTime Created
    // public DateTime Updated
}
