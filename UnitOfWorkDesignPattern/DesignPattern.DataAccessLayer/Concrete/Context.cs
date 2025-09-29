using DesignPattern.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DesignPattern.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        //: :base(options) → Startup’tan gelen connection string ve ayarları EF Core’un DbContext sınıfına gönderir.
        //services.Add... → Ayarları hazırla + Context’i kaydet.
        //DbContextOptions → Connection string paketini taşır.
        //:base(options) → EF Core’a “şu ayarlarla bağlan” de.
        public Context(DbContextOptions<Context> options):base(options)
        {
            
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Process> processes { get; set; }

    }
}
//EF Core’a PostgreSQL desteğini ekliyoruz → AddEntityFrameworkNpgsql()
//Kendi Context sınıfımızı DI’ye tanıtıyoruz → AddDbContext<Context>()
//Bu context için ayar yapıyoruz (provider + connection string) → opt.UseNpgsql(...)
//Hazırlanan bu ayarlar DbContextOptions paketi olarak Context constructor’ına geliyor
//Context : DbContext olduğu için :base(options) ile EF Core’un DbContext’ine gidiyor
//DbContext de “tamam, şu provider + şu connection string ile bağlanacağım” diye kendini ayarlıyor ✅
