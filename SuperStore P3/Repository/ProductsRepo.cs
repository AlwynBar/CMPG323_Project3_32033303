using Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class ProductsRepo
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public ProductsRepo(SuperStoreContext context)
        {
            _context = context;
        }

        public Product GetProductByID(int productId)
        {
            return _context.Products.FirstOrDefault(p => p.ProductId == productId);
        }

        public void CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        internal void DeleteProduct()
        {
            throw new NotImplementedException();
        }
    }
}
