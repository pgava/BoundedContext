
To manage migrations you can use PMC or CLI details:

https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/migrations#pmc

To enable dotnet ef

1. Add NuGet packages: 
	- Microsoft.EntityFrameworkCore
	- Microsoft.EntityFrameworkCore.Design
2. Add: 
	<DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.0.0" />
    <DotNetCliToolReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Tools" Version="2.0.0" />
	
	to the <ItemGroup> of the project

3. Then: dotnet ef migrations add <name of migration>

If you use separate projects for the DbContext you can run into issues when creating the migrations:

^^^^^
No database provider has been configured for this DbContext. A provider can be configured by overriding
the DbContext.OnConfiguring method or by using AddDbContext on the application service provider. If AddDbContext
is used, then also ensure that your DbContext type accepts a DbContextOptions<TContext> object in its constructor
and passes it to the base constructor for DbContext.

^^^^^
Your target project 'BoundedContext' doesn't match your migrations assembly 'Artist.Data'. Either change your target 
project or change your migrations assembly.
Change your migrations assembly by using DbContextOptionsBuilder. 
E.g. options.UseSqlServer(connection, b => b.MigrationsAssembly("BoundedContext")). 
By default, the migrations assembly is the assembly containing the DbContext.
Change your target project to the migrations project by using the Package Manager Console's 
Default project drop-down list, or by executing "dotnet ef" from the directory containing the migrations project.

It depends on which project you use as "default". To set the database provider use this inside the "ConfigureServices"
in the Startup class:

var connection = Configuration.GetConnectionString("DefaultConnection");
services.AddDbContext<Artist.Data.ArtistContext>(options => options.UseSqlServer(connection, b => b.MigrationsAssembly("BoundedContext")));

1. Use UserContext & ArtistContext - done
Sometime you need to get and combined data from more than one context. Use separate contexts like in this case "UserReferenceContext"
You can bind only the data that you need in the model which can be differenty from the original model.
You have to use different context if you use separate dtabase schemas. Also using separate context help with the migrations.

2. Disconnected Graphs
3. Fix relationship

Tutorial
--------
https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro