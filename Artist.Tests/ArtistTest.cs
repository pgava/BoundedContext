using System;
using System.Collections.Generic;
using System.Linq;
using Artist.Data;
using Artist.Domain;
using BC.Sharedkernel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Artist.Tests
{
    public class ArtistTest
    {
        private string _connectionString = "Server=.;uid=sa; password=Australia01!;Database=BoundedContext";

        [Fact]
        public void Test1()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkSqlServer()
                .AddDbContext<ArtistContext>(
                    options => options.UseSqlServer(_connectionString))
                .BuildServiceProvider();

            using (var context = serviceProvider.GetService<ArtistContext>())
            {
                var artists = context.Artists.ToList();
                artists.ForEach(a => Console.WriteLine(a.Name));
            }
        }

        [Fact]
        public void Test2()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkSqlServer()
                .AddDbContext<ArtistContext>(
                    options => options.UseInMemoryDatabase("Artist"))
                .BuildServiceProvider();

            var a1 = Domain.Artist.Create(Guid.Parse("D1CFD061-B8FC-4761-837E-900B1ACF6FB7"), "A1");
            a1.AddMusic("M1");

            using (var context = serviceProvider.GetService<ArtistContext>())
            {
                context.ChangeTracker.TrackGraph(a1, ChangeTrackerHelpers.ConvertStateOfNode);

                var expected = new List<int> { 2, 0, 0 };
                var addedCount = context.ChangeTracker.Entries().Count(e => e.State == EntityState.Added);
                var modifiedCount = context.ChangeTracker.Entries().Count(e => e.State == EntityState.Modified);
                var unchangedCount = context.ChangeTracker.Entries().Count(e => e.State == EntityState.Unchanged);
                Assert.Equal(expected, new List<int> { addedCount, modifiedCount, unchangedCount });
            }

        }
    }
}
