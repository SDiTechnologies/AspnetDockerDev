using WebApi.Domain.Models;

namespace WebApi.DataFaker;

public partial class DataProvider
{
    public Organization NewOrganization()
    {
        return new Organization
        {
            OrganizationName = Faker.Company.Name(),
            OrganizationAlias = Faker.Company.Name(),
            OrganizationSlogan = Faker.Company.CatchPhrase()
        };
    }
}
