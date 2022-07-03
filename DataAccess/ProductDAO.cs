using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {
        //singleton pattern
        private static ProductDAO? instance { get; set; }
        private static readonly object instanceLock = new object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Product> GetAllProducts()
        {
            var products = new List<Product>();
            try
            {
                using FStoreASM2Context context = new FStoreASM2Context();
                products = context.Products.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }


        public Product GetProductById(Product product)
        {
            Product? pro;
            try
            {
                using FStoreASM2Context context = new FStoreASM2Context();
                pro = context.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
                if(pro == null)
                {
                    throw new Exception("This product does not exist!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return pro;
        }
        public void InsertProduct(Product product)
        {
            try
            {
                using FStoreASM2Context context = new FStoreASM2Context();
                context.Products.Add(product);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateProduct(Product product)
        {
            try
            {
                using FStoreASM2Context context = new FStoreASM2Context();
                context.Entry<Product>(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteProduct(Product product)
        {
            try
            {
                using FStoreASM2Context context = new FStoreASM2Context();
                var pro = GetProductById(product);
                context.Products.Remove(pro);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Product GetProductByID(int keyword)
        {
            var proList = GetAllProducts();
            var list = proList.Where(p => p.ProductId == keyword);
            return list.FirstOrDefault();
        }
        public IEnumerable<Product> GetProductsByName(string keyword)
        {
            var proList = GetAllProducts();
            var list = proList.Where(p => p.ProductName.ToLower().Contains(keyword.ToLower()));
            return list;
        }
        public IEnumerable<Product> GetProductsByUnitPrice(int keyword)
        {
            var proList = GetAllProducts();
            var list = proList.Where(p => p.UnitPrice == keyword);
            return list;
        }
        public IEnumerable<Product> GetProductsByUnitsInStock(int keyword)
        {
            var proList = GetAllProducts();
            var list = proList.Where(p => p.UnitsInStock == keyword);
            return list;
        }
    }
}
