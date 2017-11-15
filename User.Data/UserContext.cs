using Microsoft.EntityFrameworkCore;

namespace User.Data
{
    public class UserContext : DbContext
    {
        public DbSet<Domain.User> Users { get; set; }

        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
    }
}
