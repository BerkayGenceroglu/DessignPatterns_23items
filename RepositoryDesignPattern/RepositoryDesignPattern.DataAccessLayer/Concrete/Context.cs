using Microsoft.EntityFrameworkCore;
using RepositoryDesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.DataAccessLayer.Concrete
{
    //Al bu ayarları, benim Context sınıfımı bu ayarlarla çalıştır ve veritabanıyla iletişime hazır hale getir.
    public class Context : DbContext
    {
        public Context()
        {
        }

        //Context, DbContext'ten miras aldığı için siz base(options) ile ayarları DbContext'e yollayarak aslında Context sınıfınızı yapılandırmış olursunuz.
        public Context(DbContextOptions<Context> options):base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
