using FrontBack2.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontBack2.DAL
{
    public class AppDbContext : DbContext
    {
        

        public AppDbContext(DbContextOptions options) : base(options) 
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
