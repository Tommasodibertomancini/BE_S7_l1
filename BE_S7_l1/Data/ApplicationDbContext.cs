using BE_S7_l1.Models;
using Microsoft.EntityFrameworkCore;

namespace BE_S7_l1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
