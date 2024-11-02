using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Models;

namespace SupermarketWEB.Data
{
    public class SumpermarketContext
    {
        public class SupermarketContext : DbContext
        {
            public SupermarketContext(DbContextOptions options) : base(options)
            {
            }
            public DbSet<Category> Categories { get; set; }
            public DbSet<Product> Products { get; set; }
        }
    }
}
