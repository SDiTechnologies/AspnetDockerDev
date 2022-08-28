using WebApi.Domain.Models;

namespace WebApi.DataFaker;

public partial class DataProvider
{
    public Book NewBook()
    {
        return new Book
        {
            Title = Faker.Name.FullName(),
            ReleaseDate = Faker.Identification.DateOfBirth()
        };
    }
}
