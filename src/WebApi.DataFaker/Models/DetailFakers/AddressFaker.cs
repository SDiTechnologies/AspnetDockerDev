using WebApi.Domain.Models;

namespace WebApi.DataFaker;

public partial class DataProvider
{
    public Address NewAddress()
    {
        return new Address
        {
            AddressLn1 = Faker.Address.StreetAddress(),
            AddressLn2 = Faker.Address.SecondaryAddress(),
            City = Faker.Address.City(),
            State = Faker.Address.UsStateAbbr(),
            PostalCode = Faker.Address.ZipCode()
        };
    }
}
