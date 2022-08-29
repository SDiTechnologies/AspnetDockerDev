using WebApi.Domain.Models;

namespace WebApi.DataFaker;

public partial class DataProvider
{
    public Location NewLocation()
    {
        // var locationAddress = NewAddress();
        return new Location
        {
            LocationName = Faker.Company.Name(),
            LocationAlias = Faker.Company.Name(),
            Address = NewAddress(),
            // Organization
            Organization = NewOrganization()
            // // OrganizationSlogan = Faker.Company.CatchPhrase()
            // AddressId = locationAddress.Id,
            // Address = locationAddress,


        };
    }
}
