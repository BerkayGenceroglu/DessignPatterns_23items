using DesignPattern.Facade.DAL;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Facade.Controllers
{
    public class CustomerController : Controller
    {
        Context context = new Context();
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return RedirectToAction(nameof(CustomerController.CustomerList));
        }

        public IActionResult CustomerList() 
        {
            var values = context.Customers.ToList();
            return View(values);
        }

        public IActionResult DeleteCustomer(int id)
        {
            var value = context.Customers.Find(id);
            context.Customers.Remove(value);
            context.SaveChanges();
            return RedirectToAction(nameof(CustomerController.CustomerList));
        }
        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var values = context.Customers.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
            return RedirectToAction(nameof(CustomerController.CustomerList));
        }
    }
}
