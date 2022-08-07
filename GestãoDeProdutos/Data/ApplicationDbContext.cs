using GestãoDeProdutos.Models;
using Microsoft.EntityFrameworkCore;

namespace GestãoDeProdutos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
