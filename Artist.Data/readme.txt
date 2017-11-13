
For CLI details:
https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/migrations#pmc

Use Dotnet EF

1. Add NuGet packages: 
	- Microsoft.EntityFrameworkCore
	- Microsoft.EntityFrameworkCore.Design
2. Add: 
	<DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="2.0.0" />
    <DotNetCliToolReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Tools" Version="2.0.0" />
	
	to the <ItemGroup) of the project

3. Then: dotnet ef migrations add InitialCreate

No database provider has been configured for this DbContext. A provider can be configured by overriding
 the DbContext.OnConfiguring method or by using AddDbContext on the application service provider. If AddDbContext
 is used, then also ensure that your DbContext type accepts a DbContextOptions<TContext> object in its constructor
 and passes it to the base constructor for DbContext.

 
 Your target project 'BoundedContext' doesn't match your migrations assembly 'Artist.Data'. Either change your target 
 project or change your migrations assembly.
Change your migrations assembly by using DbContextOptionsBuilder. 
E.g. options.UseSqlServer(connection, b => b.MigrationsAssembly("BoundedContext")). 
By default, the migrations assembly is the assembly containing the DbContext.
Change your target project to the migrations project by using the Package Manager Console's 
Default project drop-down list, or by executing "dotnet ef" from the directory containing the migrations project.

Tutorial
--------
https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro