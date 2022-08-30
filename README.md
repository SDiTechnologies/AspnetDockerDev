# AspnetDockerDev


<!--

using the dotnet cli for generating components:

requirements:
    LIST REQUIRED LIBRARIES

    EF-Core:
        Required:
            Microsoft.EntityFrameworkCore.Design
            Microsoft.EntityFrameworkCore.SqlServer
            Microsoft.VisualStudio.Web.CodeGeneration.Design

        Optional:
            Microsoft.EntityFrameworkCore.InMemory
            Microsoft.EntityFrameworkCore.Sqlite
            Npgsql
            Npgsql.EntityFrameworkCore.PostgreSQL
            Swashbuckle.AspNetCore

    dotnet-ef:
        https://docs.microsoft.com/en-us/ef/core/cli/dotnet
    dotnet-aspnet-codegenerator:
        https://docs.microsoft.com/en-us/aspnet/core/fundamentals/tools/dotnet-aspnet-codegenerator?view=aspnetcore-6.0

    Identity: (TBD)
        https://docs.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-6.0

```bash
# install dotnet-ef
>$ dotnet tool install -g dotnet-ef
# install aspnet-code-generator
>$ dotnet tool install -g dotnet-aspnet-codegenerator

# update, eg.
>$ dotnet tool update -g dotnet-aspnet-codegenerator

# nuget requirements
dotnet tool uninstall --global dotnet-aspnet-codegenerator
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

# scaffold new objects:
# - area
# - controller
# - identity
# - razorpage
# - view

# scaffold a new controller
dotnet aspnet-codegenerator -name {controllerName} -m {modelName} -dc {dbContext} -o {outputDirectory}

dotnet-aspnet-codegenerator controller -name OperationsController -m Operation -dc ApplicationDbContext -outDir Controllers -async -api
dotnet-aspnet-codegenerator controller -name LocationsController -m Location -dc ApplicationDbContext -outDir Controllers -async -api
dotnet-aspnet-codegenerator controller -name BooksController -m Book -dc ApplicationDbContext -outDir Controllers -async -api
dotnet-aspnet-codegenerator controller -name AuthorsController -m Author -dc ApplicationDbContext -outDir Controllers -async -api
dotnet-aspnet-codegenerator controller -name PublishersController -m Publisher -dc ApplicationDbContext -outDir Controllers -async -api
dotnet-aspnet-codegenerator controller -name GenresController -m Genre -dc ApplicationDbContext -outDir Controllers -async -api
dotnet-aspnet-codegenerator controller -name AddressesController -m Address -dc ApplicationDbContext -outDir Controllers -async -api


    public DbSet<Operation> Operations { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Genre> Genres { get; set; }


dotnet-ef

>$ dotnet-ef migrations add PgInitialCreate -o Data/Migrations
>$ dotnet-ef database update

```

install:
    DEMONSTRATE INSTALL SCRIPT

general use:
    DEMO TYPICAL USE FOR CREATING COMPONENTS


RESOURCES:

npgsql resources:
    - https://www.npgsql.org/
    - https://github.com/npgsql/Npgsql
    - https://github.com/npgsql/efcore.pg

generate uuid in postgres:
    - https://stackoverflow.com/questions/12505158/generating-a-uuid-in-postgres-for-insert-statement

async console app in csharp:
    - https://stackoverflow.com/questions/17630506/using-async-in-a-console-application-in-c-sharp
    - https://stackoverflow.com/questions/41407221/startup-cs-in-a-self-hosted-net-core-console-application
    - https://github.com/sonicmouse/Host.CreateDefaultBuilder.Example

faker data in csharp:
    - https://blog.elmah.io/easy-generation-of-fake-dummy-data-in-c-with-faker-net/
    - https://github.com/oriches/faker-cs
    - https://github.com/slashdotdash/faker-cs

seperating data access from models and api:
    - https://medium.com/oppr/net-core-using-entity-framework-core-in-a-separate-project-e8636f9dc9e5
-->






<!-- Refocus session:

Current projects:
    - WebApi - home to the web API actions
    - WebApi.Domain - home to the models
    - WebApi.DataAccess - home to the DataAccess layer, migrations, database ops like seeding.
    - WebApi.DataFaker - home to a fake data generator for seeding the db

Next Steps:
    - Construct proper data model for organization -> library -> members structure; Start with organization -> book collection

 -->
