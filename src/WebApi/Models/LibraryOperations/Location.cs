namespace WebApi.Models;

public class Location
{
    public Guid Id { get; set; }
    // public int? LocationNumber { get; set; }
    public string? LocationName { get; set; }
    public string? LocationAlias { get; set; }
    public Address? LocationAddress { get; set; }
    public ICollection<Book>? Books { get; set; }


    // debug override ToString() method
    public string ToString()
    {
        return $"LocationName: {LocationName}\nLocationAlias: {LocationAlias}";
    }
}
