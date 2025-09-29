using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadePattern
{
    public class AddOrder
    {
        Context _context = new Context();
        public void AddNewOrder(Order order)
        {
            order.OrderDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
}
