using WebApi.Domain.Models;

namespace WebApi.DataFaker;

public partial class DataProvider
{
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
