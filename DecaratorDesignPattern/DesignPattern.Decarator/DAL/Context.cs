using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Decarator.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=DesignPatternDecarator;Integrated Security=True;");
        }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notifier>  Notifiers { get; set; }
    }
}
