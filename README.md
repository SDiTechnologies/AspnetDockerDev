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
-->
