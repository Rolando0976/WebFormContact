using Microsoft.EntityFrameworkCore;

namespace WebFormContact.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options) { }

        public DbSet<ContactMessage> ContactMessages { get; set; }
    }
}