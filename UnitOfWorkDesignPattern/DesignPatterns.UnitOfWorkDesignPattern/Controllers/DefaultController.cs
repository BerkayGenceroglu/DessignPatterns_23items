using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.EntityLayer.Concrete;
using DesignPatterns.UnitOfWorkDesignPattern.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DesignPatterns.UnitOfWorkDesignPattern.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICustomerService _customerService;

        public DefaultController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerViewModel model)
        {
            var sender= _customerService.TGetById(model.SenderId);
            var reciver = _customerService.TGetById(model.ReceiverId);

            sender.CustomerBalance -= model.Amount;
            reciver.CustomerBalance += model.Amount;

            List<Customer> modifiedCustomers = new List<Customer>()
            {
                sender,
                reciver
            };
            _customerService.TMultiUpdate(modifiedCustomers);
            return View();
        }
    }
}
