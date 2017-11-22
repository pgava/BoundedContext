using System;
using System.Linq;
using Artist.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql;



namespace MySqlMigrations
{
    public class Program
    {
        private static string _connectionString = "server=OCTLT002;userid=sa;password=Australia01!;database=BoundedContext;";

        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ArtistContext>
        {

            public ArtistContext CreateDbContext(string[] args)
            {
                var builder = new DbContextOptionsBuilder<ArtistContext>();

                builder.UseMySql(_connectionString, b => b.MigrationsAssembly("MySqlMigrations"));

                return new ArtistContext(builder.Options);
            }
        }

        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<ArtistContext>(
                    options => options.UseMySql(_connectionString))
                .BuildServiceProvider();

            using (var context = serviceProvider.GetService<ArtistContext>())
            {
                var artists = context.Artists.ToList();
                artists.ForEach(a => Console.WriteLine(a.Name));
            }
        }
    }
}
