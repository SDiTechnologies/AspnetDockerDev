// using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebApi.Domain.Models;

public class Book
{
    public Book() { }
    public Book(string title, DateTime releaseDate)
    {
        Title = title;
        ReleaseDate = releaseDate;
    }

    public Guid Id { get; set; }
    public string? Title { get; set; }
    public DateTime ReleaseDate { get; set; }
    // public ICollection<Genre>? Genres { get; set; }
    // public ICollection<Author>? Authors { get; set; }
    // public Publisher? Publisher { get; set; }
    // public DateTime Created
    // public DateTime Updated

    // debug override ToString() method
    public override string ToString()
    {
        // system.text.json + system.text.json.serialization
        return JsonSerializer.Serialize(this);

        // // newtonsoft.json
        // return JsonConvert.SerializeObject(this);
    }
}
