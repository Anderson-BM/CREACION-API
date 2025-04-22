using Microsoft.EntityFrameworkCore;
using MiPrimerAPI.Models;



namespace MiPrimerAPI.Data
{
    // Data/AppDbContext.cs
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }


}
