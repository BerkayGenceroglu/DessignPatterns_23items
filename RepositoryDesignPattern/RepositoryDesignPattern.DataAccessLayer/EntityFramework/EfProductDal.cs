using Microsoft.EntityFrameworkCore;
using RepositoryDesignPattern.DataAccessLayer.Abstract;
using RepositoryDesignPattern.DataAccessLayer.Concrete;
using RepositoryDesignPattern.DataAccessLayer.Repositories;
using RepositoryDesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly Context _context;
        public EfProductDal(Context context) : base(context)
        {
            _context = context;
        }

        public List<Product> CategoryName()
        {
            var values = _context.Products.Include(x => x.Category).ToList();
            //Bu sefer EF Core, Products tablosunu çekerken Category tablosunu da join ederek getirir.
            //Yani her ürünün yanında ilişkili Category bilgisi de doldurulur.Category Dahil Edilir
            return values;
        }
    }
}
