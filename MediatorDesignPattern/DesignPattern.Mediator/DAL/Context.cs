using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Mediator.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=DesignPatternMediator;Integrated Security=True;");
        }
        public DbSet<Product> Products { get; set; }
    }
}
