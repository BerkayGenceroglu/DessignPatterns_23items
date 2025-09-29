using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadePattern
{
    public class UpdateProductStock
    {
        Context _context = new Context();
        public void UpdateStock(int id,int amount)
        {
            var value = _context.Products.Find(id);
            value!.ProductStock -= amount;
            _context.SaveChanges();
        }
    }
}
