using KatmanliMimari.Entity;
using KatmanliMimari.Entity.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimari.Dal
{
    public class Context: DbContext
    {
        
        public Context(DbContextOptions<Context> db):base(db)
        {
            
        }
        public DbSet<Categories>? Categories { get; set; }
        public DbSet<Products>? Products { get; set; }
    }
}
