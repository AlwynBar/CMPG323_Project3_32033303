using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrdersRepo
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.ToList();
        }

        public Order GetOrderByID(int orderID)
        {
            return _context.Orders.FirstOrDefault(order => order.OrderId == orderID);
        }

        public void CreateOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }
}
