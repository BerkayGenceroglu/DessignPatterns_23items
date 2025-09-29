using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadePattern
{
    public class OrderFacade
    {
        Order order = new Order();
        OrderDetail orderDetail = new OrderDetail();
        AddOrder addOrder = new AddOrder();
        AddOrderDetail addOrderDetail = new AddOrderDetail();
        UpdateProductStock UpdateProductStock = new UpdateProductStock();
        Context context = new Context();
        public void CompleteOrder(int customerId,int productId,int productCount,decimal productUnitPrice)
        {
            void AddOrderProcess()
            {
                order.CustomerId = customerId;
                addOrder.AddNewOrder(order);
            }

            AddOrderProcess();
            var lastOrder = context.Orders
            .OrderByDescending(x => x.OrderId)
            .FirstOrDefault();
            orderDetail.OrderId = lastOrder!.OrderId;
            orderDetail.ProductId = productId;
            orderDetail.CustomerId = customerId;
            orderDetail.ProductCount = productCount;
            orderDetail.ProductUnitPrice = productUnitPrice;
            orderDetail.ProductUnitTotalPrice = productCount * productUnitPrice;
            addOrderDetail.AddNewOrderDetail(orderDetail);

            UpdateProductStock.UpdateStock(productId, productCount);

            context.SaveChanges();
        }
    }
}
