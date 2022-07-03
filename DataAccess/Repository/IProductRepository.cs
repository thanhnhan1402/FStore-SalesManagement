using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(Product product);
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        Product GetProductByID(int keyword);
        IEnumerable<Product> GetProductsByName(string keyword);
        IEnumerable<Product> GetProductsByUnitPrice(int keyword);
        IEnumerable<Product> GetProductsByUnitsInStock(int keyword);
    }
}
