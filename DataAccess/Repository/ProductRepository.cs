using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetAllProducts() => ProductDAO.Instance.GetAllProducts();
        public Product GetProductById(Product product) => ProductDAO.Instance.GetProductById(product);
        public void InsertProduct(Product product) => ProductDAO.Instance.InsertProduct(product);
        public void UpdateProduct(Product product) => ProductDAO.Instance.UpdateProduct(product);
        public void DeleteProduct(Product product) => ProductDAO.Instance.DeleteProduct(product);
    }
}
