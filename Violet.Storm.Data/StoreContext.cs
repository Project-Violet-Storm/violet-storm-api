using Violet.Storm.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Violet.Storm.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        { }

        public DbSet<Item> Items {get; set; }    
    }
}    
