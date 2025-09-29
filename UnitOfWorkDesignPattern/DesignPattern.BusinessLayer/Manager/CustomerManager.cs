using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.UnitOfWork;
using DesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BusinessLayer.Manager
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly IUowDal _uowDal;

        public CustomerManager(IUowDal uowDal, ICustomerDal customerDal = null)
        {
            _uowDal = uowDal;
            _customerDal = customerDal;
        }

        public void TDelete(Customer t)
        {
            _customerDal.Delete(t);
            _uowDal.SaveChanges();
        }

        public List<Customer> TGetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public void TInsert(Customer t)
        {
            _customerDal.Insert(t);
            _uowDal.SaveChanges();
        }

        public void TMultiUpdate(List<Customer> t)
        {
            _customerDal.MultiUpdate(t);
            _uowDal.SaveChanges();
        }

        public void TUpdate(Customer t)
        {
            _customerDal.Update(t);
            _uowDal.SaveChanges();
        }
    }
}
