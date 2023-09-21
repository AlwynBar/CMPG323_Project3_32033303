using EcoPower_Logistics.Repository;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Reflection;

namespace EcoPower_Logistics.Controllers
{
    public class DevicesController : Controller
    {
        private readonly OrdersRepo ordersRepo;

        public DevicesController(OrdersRepo ordersRepo)
        {
            this.ordersRepo = ordersRepo;
        }

        public ActionResult GetOrder(int orderID)
        {
            var order = ordersRepo.GetOrderByID(orderID);
            
            if(order != null)
            {
                return View(order);
            }
            else
            {
                return NotFound();  
            }
        }

        public ActionResult CreateOrder(Order order)
        {
            ordersRepo.CreateOrder(order);
            return RedirectToAction("OrderCreated");
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
