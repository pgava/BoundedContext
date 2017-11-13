using Microsoft.EntityFrameworkCore;

namespace Artist.Data
{
    public class ArtistContext : DbContext
    {
        public DbSet<Domain.Artist> Artists { get; set; }
        public DbSet<Domain.ArtistMember> ArtistMembers { get; set; }

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
            //modelBuilder.HasDefaultSchema("ShoppingCart");     
        }

    }
}
