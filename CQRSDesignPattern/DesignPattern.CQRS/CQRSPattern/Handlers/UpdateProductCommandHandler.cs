using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void handle(UpdateProductCommand command)
        {
            var value = _context.Products.Find(command.ProductID);
            value.Name = command.Name;
            value.Price = command.Price;
            value.Stock = command.Stock;
            value.Description = command.Description;
            value.Status = true;
            _context.SaveChanges();
        }
    }
}
