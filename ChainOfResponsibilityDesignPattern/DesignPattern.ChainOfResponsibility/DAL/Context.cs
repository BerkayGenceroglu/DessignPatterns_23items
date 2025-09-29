using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=DesignPattern1;Integrated Security=True;");
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
