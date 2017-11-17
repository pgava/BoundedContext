using BC.Sharedkernel.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Artist.Data
{
    public class ArtistContext : DbContext
    {
        public DbSet<Domain.Artist> Artists { get; set; }
        public DbSet<Domain.ArtistMember> ArtistMembers { get; set; }
        public DbSet<Domain.Music> Musics { get; set; }

        public ArtistContext(DbContextOptions<ArtistContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //optionsBuilder.UseSqlServer(@"Server=202.164.59.44,5143;uid=sa; password=Raj@igniva;Database=ZimriiNew;");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("Artist");      

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {

                modelBuilder.Entity(entity.Name).Ignore("State");
            }

            //modelBuilder.Entity<Domain.Artist>().Ignore(p => p.State);

            //modelBuilder.Types<IStateObject>().Configure(c => c.Ignore(p => p.State));
        }

    }
}
