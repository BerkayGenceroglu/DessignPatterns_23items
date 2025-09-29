using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.Composite.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=DesignPatternComposite;Integrated Security=True;");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
