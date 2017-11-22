using System;
using System.IO;
using System.Linq;
using Artist.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SqlServerMigrations
{
    class Program
    {
        private static string _connectionString = "Server=.;uid=sa; password=Australia01!;Database=BoundedContext";

        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ArtistContext>
        {
            public ArtistContext CreateDbContext(string[] args)
            {
                var builder = new DbContextOptionsBuilder<ArtistContext>();

                builder.UseSqlServer(_connectionString, b => b.MigrationsAssembly("SqlServerMigrations"));

                return new ArtistContext(builder.Options);
            }
        }

        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<ArtistContext>(
                    options => options.UseSqlServer(_connectionString))
                .BuildServiceProvider();

            using (var context = serviceProvider.GetService<ArtistContext>())
            {
                var artists = context.Artists.ToList();
                artists.ForEach(a => Console.WriteLine(a.Name));
            }

        }
    }
}
