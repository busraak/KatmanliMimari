using KatmanliMimari.Dal;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using KatmanliMimari.Entity;

namespace KatmanliMimari.Ui.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        Context _db;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, Context db)
            : base(options)
        {
            _db = db;
        }
        public DbSet<KatmanliMimari.Entity.Categories> Categories { get; set; }
        public DbSet<KatmanliMimari.Entity.Products> Products { get; set; }
    }
}