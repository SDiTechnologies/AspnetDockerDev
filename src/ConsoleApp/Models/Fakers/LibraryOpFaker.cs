// using Faker.Net;
using WebApi.Models;

namespace ConsoleApp.Fakers;

public class LibraryOpFaker: IFaker
{
    public LibraryOpFaker() {}

    public Operation NewOperation()
    {
        return new Operation(
            Faker.Company.Name(),
            Faker.Company.Name()
        );
    }

    public Location NewLocation()
    {
        return new Location(
            Faker.Name.Last(),
            Faker.Name.First()
        );
    }

    public Book NewBook()
    {
        // There isn't really a fake provider for this data
        return new Book(
            Faker.Name.FullName(),
            Faker.Identification.DateOfBirth()
        );
    }

    public Publisher NewPublisher()
    {
        return new Publisher(
            Faker.Company.Name()
        );
    }

    public Author NewAuthor()
    {
        return new Author(
            Faker.Name.First(),
            Faker.Name.Last()
        );
    }

    public Genre NewGenre()
    {
        // // TODO: make custom faker provider using enum; though all genre's should be distinct
        return new Genre(
            // Faker.Name.First(),
            // Faker.Name.Last()
        );
    }

    public Address NewAddress()
    {
        return new Address(
            Faker.Address.StreetAddress(),
            Faker.Address.SecondaryAddress(),
            Faker.Address.City(),
            Faker.Address.UsStateAbbr(),
            Faker.Address.ZipCode()
        );
    }


}
