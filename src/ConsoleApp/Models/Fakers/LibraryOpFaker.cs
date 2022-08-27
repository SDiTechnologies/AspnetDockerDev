// using Faker.Net;
using WebApi.Models;

namespace ConsoleApp.Fakers;

public class OperationFaker: IFaker
{
    public OperationFaker() {}

    public Operation NewOperation()
    {
        return new Operation(
            Faker.Company.Name(),
            Faker.Company.Name()
        );
    }
}

public class AttributeFaker: IFaker
{
    public AttributeFaker() {}

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
