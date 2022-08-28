using WebApi.Domain.Models;

namespace WebApi.DataFaker;

public partial class DataProvider
{
    public Author NewAuthor()
    {
        return new Author
        {
            FirstName = Faker.Name.First(),
            LastName = Faker.Name.Last()
        };
    }
}
