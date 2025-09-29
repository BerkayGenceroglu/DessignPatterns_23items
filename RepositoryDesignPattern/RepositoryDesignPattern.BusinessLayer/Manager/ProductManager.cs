using RepositoryDesignPattern.BusinessLayer.Abstract;
using RepositoryDesignPattern.DataAccessLayer.Abstract;
using RepositoryDesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryDesignPattern.BusinessLayer.Manager
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> TCategoryName()
        {
            return _productDal.CategoryName();
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t);
        }

        public List<Product> TGetAll()
        {
            return _productDal.GetAll();
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void TInsert(Product t)
        {
            _productDal.Insert(t);
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }
    }
}
