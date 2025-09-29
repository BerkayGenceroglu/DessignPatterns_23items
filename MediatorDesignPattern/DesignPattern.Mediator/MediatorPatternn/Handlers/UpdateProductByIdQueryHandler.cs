using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.MediatorPatternn.Queries;
using DesignPattern.Mediator.MediatorPatternn.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPatternn.Handlers
{
    public class UpdateProductByIdQueryHandler : IRequestHandler<UpdateProductByIdQuery, UpdateProductByIdQueryResult>
    {
        private readonly Context _context;

        public UpdateProductByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<UpdateProductByIdQueryResult> Handle(UpdateProductByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Products.FindAsync(request.Id);
            return new UpdateProductByIdQueryResult()
            {
                ProductId = value!.ProductId,
                ProductName = value.ProductName,
                ProductStock = value.ProductStock,
                ProductStockType = value.ProductStockType,
                ProductPrice = value.ProductPrice,
                ProductCategory = value.ProductCategory
            };
        }
    }
}
