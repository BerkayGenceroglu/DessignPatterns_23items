using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.MediatorPatternn.Queries;
using DesignPattern.Mediator.MediatorPatternn.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Mediator.MediatorPatternn.Handlers
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetAllProductQueryResult>>
    {
        private readonly Context _context;

        public GetAllProductQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllProductQueryResult>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.Select(x => new GetAllProductQueryResult()
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductPrice = x.ProductPrice,
                ProductStock = x.ProductStock,
                ProductStockType = x.ProductStockType,
                ProductCategory = x.ProductCategory
            }).AsNoTracking().ToListAsync();
        }
    }
}
