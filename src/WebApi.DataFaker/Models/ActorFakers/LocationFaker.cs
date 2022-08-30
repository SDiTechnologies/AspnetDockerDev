using System;
using WebApi.Domain.Models;

namespace WebApi.DataFaker;

public partial class DataProvider
{
    public Location NewLocation()
    {
        return new Location
        {
            LocationName = Faker.Company.Name(),
            LocationAlias = Faker.Company.Name(),
            Address = NewAddress()

            // Organization = NewOrganization()
            // // OrganizationSlogan = Faker.Company.CatchPhrase()
        };
    }
    public Location NewLocation(Organization org)
    {
        return new Location
        {
            LocationName = Faker.Company.Name(),
            LocationAlias = Faker.Company.Name(),
            Address = NewAddress(),
            OrganizationId = org.Id,
            Organization = org
        };
    }
}
