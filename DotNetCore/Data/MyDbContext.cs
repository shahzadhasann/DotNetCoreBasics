using DotNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore.Data
{
    public class MyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=MSI\SQLEXPRESS;Database=AspTest;Trusted_Connection=True;");
        }

        // DbSet
        public DbSet<Category> Category { get; set; }
    }
}
