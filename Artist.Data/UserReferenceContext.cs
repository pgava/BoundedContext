using Microsoft.EntityFrameworkCore;

namespace Artist.Data
{
    public class UserReferenceContext : DbContext
    {
        public DbSet<Domain.User> Users { get; set; }

        public UserReferenceContext(DbContextOptions<UserReferenceContext> options) : base(options)
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
        }

    }
}
