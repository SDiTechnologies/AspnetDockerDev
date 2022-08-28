using WebApi.Domain.Models;

namespace WebApi.DataFaker;

public partial class DataProvider
{
    // public DataProvider() { }

    public Book NewBook()
    {
        return new Book(
            Faker.Name.FullName(),
            Faker.Identification.DateOfBirth()
        );
    }
}
