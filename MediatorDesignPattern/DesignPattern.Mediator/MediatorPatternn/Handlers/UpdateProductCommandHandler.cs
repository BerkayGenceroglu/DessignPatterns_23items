using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.MediatorPatternn.Commands;
using MediatR;

namespace DesignPattern.Mediator.MediatorPatternn.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Products.FindAsync(request.ProductId);
            value!.ProductName = request.ProductName;
            value.ProductStock = request.ProductStock;
            value.ProductStockType = request.ProductStockType;
            value.ProductPrice = request.ProductPrice;
            value.ProductCategory = request.ProductCategory;
            await _context.SaveChangesAsync();
        }
    }
}
