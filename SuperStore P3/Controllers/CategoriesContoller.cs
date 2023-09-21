using EcoPower_Logistics.Repository;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace EcoPower_Logistics.Controllers
{
    public class CategoriesContoller : Controller
    {
        private readonly ProductsRepo productsRepo;
        public IActionResult Index()
        {
            return View();
        }

        public CategoriesContoller(ProductsRepo product)
        {
            productsRepo = product;
        }

        public ActionResult GetProduct(int productId)
        {
            var product = productsRepo.GetProductByID(productId);
            return View(product);
        }

        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            productsRepo.CreateProduct(product);
            return RedirectToAction("ProductCreated");
        }

        public ActionResult UpdateProduct(Product product)
        {
            productsRepo.UpdateProduct(product);
            return RedirectToAction("ProductUpdated");
        }

        public ActionResult DeleteProduct(Product product)
        {
            productsRepo.DeleteProduct();
            return RedirectToAction("ProductDeleted");
        }
    }
}
