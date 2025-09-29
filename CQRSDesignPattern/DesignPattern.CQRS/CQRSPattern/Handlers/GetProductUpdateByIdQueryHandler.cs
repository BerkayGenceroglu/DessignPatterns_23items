using DesignPattern.CQRS.CQRSPattern.Querys;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductUpdateByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductUpdateByIdQueryResult handle(GetProductUpdateByIdQuery query)
        {
            var value = _context.Products.Find(query.Id);
            return new GetProductUpdateByIdQueryResult()
            {
                ProductID = value.ProductID,
                Name = value.Name,
                Price = value.Price,
                Stock = value.Stock,
                Description = value.Description
            };
        }
    }
}
