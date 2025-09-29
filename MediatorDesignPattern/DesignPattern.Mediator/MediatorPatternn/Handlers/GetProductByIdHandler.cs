using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.MediatorPatternn.Queries;
using DesignPattern.Mediator.MediatorPatternn.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPatternn.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResult>
    {
        private readonly Context _context;

        public GetProductByIdHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _context.Products.FindAsync(request.Id);
            return new GetProductByIdQueryResult()
            {
                ProductId = value!.ProductId,
                ProductName = value.ProductName,
                ProductStock = value.ProductStock
            };
            //.Result = senkron bekletir, await = asenkron bekler.
        }
    }
}
