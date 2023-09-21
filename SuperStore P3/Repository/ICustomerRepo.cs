using Models;

namespace EcoPower_Logistics.Repository
{
    public interface ICustomerRepo : IGenericRepo<Customer>
    {
        Customer GetMostRecentCustomer();
    }
}
