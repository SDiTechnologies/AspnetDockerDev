namespace WebApi.Models;

// Book related Attributes
public class Publisher
{
    public Publisher() { }

    public Publisher(string name)
    {
        PublisherName = name;
    }

    public int Id { get; set; }
    public string? PublisherName { get; set; }

    // debug override ToString() method
    public string ToString()
    {
        return $"PublisherName: {PublisherName}";
    }
}

public class Author
{
    public Author() { }
    public Author(string fName, string lName)
    {
        FirstName = fName;
        LastName = lName;
    }
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    // Some measure of a collection of books?

    // debug override ToString() method
    public string ToString()
    {
        return $"FirstName: {FirstName}\nLastName: {LastName}";
    }
}

public class Genre
{
    public Genre() { }
    public Genre(string name, string alias)
    {
        GenreName = name;
        GenreAlias = alias;
    }

    public int Id { get; set; }
    public string? GenreName { get; set; }
    public string? GenreAlias { get; set; }

    // debug override ToString() method
    public string ToString()
    {
        return $"GenreName: {GenreName}\nGenreAlias: {GenreAlias}";
    }
}


// Library/Location related attributes
public class Address
{
    public Address() { }

    public Address(string addressLn1, string addressLn2, string city, string state, string postalCode)
    {
        AddressLn1 = addressLn1;
        AddressLn2 = addressLn2;
        City = city;
        State = state;
        PostalCode = postalCode;
    }

    public Guid Id { get; set; }
    public string? AddressLn1 { get; set; }
    public string? AddressLn2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? PostalCode { get; set; }

    // debug override ToString() method
    public string ToString()
    {
        return $"AddressLn1: {AddressLn1}\nAddressLn2: {AddressLn2}\nCity: {City}\nState: {State}\nPostalCode: {PostalCode}";
    }
}
