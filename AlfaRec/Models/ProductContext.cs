using Microsoft.EntityFrameworkCore;

namespace AlfaRec.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        public ProductContext()
        {

        }
        public virtual DbSet<Product> Products { get; set; }
    }
}
