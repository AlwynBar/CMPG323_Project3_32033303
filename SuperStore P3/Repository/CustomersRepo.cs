using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class CustomersRepo : GenericRepo<Customer>, ICustomerRepo
    {
        public CustomersRepo(SuperStoreContext _context) : base(_context)
        {

        }

        public Customer GetMostRecentCustomer()
        {
            return _context.Customers.OrderByDescending(customer => customer.CustomerId).FirstOrDefault();
        }

        public Customer GetCustomerByID(int customerID)
        {
            return GetMostRecentCustomer();
        }

        public void CreateCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            _context.Update(customer);
        }

        public void DeleteCustomer(int customerID)
        {
            _context.Remove(customerID);
        }

        internal void DeleteCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
