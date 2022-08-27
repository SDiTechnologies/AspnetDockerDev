namespace WebApi.Models;

// Book related Attributes
public class Publisher
{
    public int Id { get; set; }
    public string? Name { get; set; }
}

public class Author
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    // Some measure of a collection of books?
}

public class Genre
{
    public int Id { get; set; }
    public string? GenreName { get; set; }
    public string? GenreAlias { get; set; }
}


// Library/Location related attributes
public class Address
{
    public Guid Id { get; set; }
    public string? AddressLn1 { get; set; }
    public string? AddressLn2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? PostalCode { get; set; }
}
