using DesignPattern.CQRS.CQRSPattern.Querys;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductByIDQueryResult handle(GetProductByIDQuery query)
        {
            var value = _context.Products.Find(query.Id);
            return new GetProductByIDQueryResult()
            {
                Name = value.Name,
                ProductID = value.ProductID,
                Stock = value.Stock,
                Price = value.Price,
            };
        }
    }
}
