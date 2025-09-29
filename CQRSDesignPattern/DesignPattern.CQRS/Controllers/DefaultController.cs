using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.CQRSPattern.Handlers;
using DesignPattern.CQRS.CQRSPattern.Querys;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.CQRS.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly CreateProductCommandHandler _createProductCommandHandler;
        private readonly GetProductByIDQueryHandler _getProductByIDQueryHandler;
        private readonly RemoveProductCommandHandler _removeProductCommandHandler;
        private readonly GetProductUpdateByIdQueryHandler _getProductUpdateByIdQueryHandler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;
        public DefaultController(GetProductQueryHandler getProductQueryHandler, CreateProductCommandHandler createProductCommandHandler = null, GetProductByIDQueryHandler getProductByIDQueryHandler = null, RemoveProductCommandHandler removeProductCommandHandler = null, GetProductUpdateByIdQueryHandler getProductUpdateByIdQueryHandler = null, UpdateProductCommandHandler updateProductCommandHandler = null)
        {
            _getProductQueryHandler = getProductQueryHandler;
            _createProductCommandHandler = createProductCommandHandler;
            _getProductByIDQueryHandler = getProductByIDQueryHandler;
            _removeProductCommandHandler = removeProductCommandHandler;
            _getProductUpdateByIdQueryHandler = getProductUpdateByIdQueryHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductCommand command)
        {
            _createProductCommandHandler.Handle(command);
            return RedirectToAction(nameof(DefaultController.Index));
        }

        public IActionResult GetProduct(int id)
        {
            var value = _getProductByIDQueryHandler.handle(new GetProductByIDQuery(id));
            return View(value);
        }
        public IActionResult DeleteProduct(int id)
        {
            _removeProductCommandHandler.handle(new RemoveProductCommand(id));
            return RedirectToAction(nameof(DefaultController.Index));
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = _getProductUpdateByIdQueryHandler.handle(new GetProductUpdateByIdQuery(id));
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand command)
        {
            _updateProductCommandHandler.handle(command);
            return RedirectToAction(nameof(DefaultController.Index));
        }
    }
}
