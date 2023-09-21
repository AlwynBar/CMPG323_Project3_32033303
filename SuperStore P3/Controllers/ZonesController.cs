using EcoPower_Logistics.Repository;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace EcoPower_Logistics.Controllers
{
    public class ZonesController : Controller
    {
        private readonly CustomersRepo customersRepo;

        public ZonesController(CustomersRepo customersRepo)
        {
            this.customersRepo = customersRepo;
        }   

        public ActionResult GetCustomer(int customerID)
        {
            var customer = customersRepo.GetCustomerByID(customerID);
            return View(customer);
        }

        [HttpPost]
        public ActionResult CreateCustomer(Customer customer)
        {
            customersRepo.CreateCustomer(customer);
            return RedirectToAction("CustomerCreated");
        }

        public ActionResult UpdateCustomer(Customer customer)
        {
            customersRepo.UpdateCustomer(customer);
            return RedirectToAction("CustomerUpdated");
        }

        public ActionResult DeleteCustomer()
        {
            customersRepo.DeleteCustomer();
            return RedirectToAction("CustomerDeleted");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
