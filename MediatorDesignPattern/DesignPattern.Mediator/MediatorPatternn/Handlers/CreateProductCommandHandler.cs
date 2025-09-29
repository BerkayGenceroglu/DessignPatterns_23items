using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.MediatorPatternn.Commands;
using MediatR;

namespace DesignPattern.Mediator.MediatorPatternn.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var newValue = new Product()
            {
                ProductName = request.ProductName,
                ProductPrice = request.ProductPrice,
                ProductStock = request.ProductStock,
                ProductStockType = request.ProductStockType,
                ProductCategory = request.ProductCategory
            };
          _context.Products.Add(newValue);
          await _context.SaveChangesAsync();
        }
    }
}
