using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO
    {
        private static OrderDAO instance { get; set; }
        private static readonly object instanceLock = new object();
        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Order> GetOrderList()
        {
            var Order = new List<Order>();
            try
            {
                using FStoreASM2Context fStore = new FStoreASM2Context();
                Order = fStore.Orders.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Order;
        }

        public IEnumerable<Order> GetStatistics(DateTime orderDate, DateTime shippedDate)
        {
            var statistics = new List<Order>();
            try
            {
                using FStoreASM2Context fStore = new FStoreASM2Context();
                statistics = fStore.Orders.Where(o => o.OrderDate >= orderDate && o.ShippedDate <= shippedDate).ToList();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return statistics;
        }

        public IEnumerable<Order> GetSortedOrderList()
        {
            var Order = new List<Order>();
            try
            {
                using FStoreASM2Context fStore = new FStoreASM2Context();
                Order = fStore.Orders.OrderByDescending(o => o.OrderDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Order;
        }
        public IEnumerable<Order> GetHistory(int memberId)
        {
            var history = new List<Order>();
            try
            {
                using FStoreASM2Context fStore = new FStoreASM2Context();
                history = fStore.Orders.Where(o => o.MemberId == memberId)
                    .Include(d => d.OrderDetails)
                    .ToList();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return history;
        }
        public Order GetOrderByID(Order order)
        {
            Order? ord;
            try
            {
                using FStoreASM2Context context = new();
                ord = context.Orders.SingleOrDefault(o => o.OrderId == order.OrderId);
                if (ord == null)
                {
                    throw new Exception("This Order does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ord;
        }
        public void InsertOrder(Order order)
        {
            try
            {
                using FStoreASM2Context Context = new FStoreASM2Context();
                Context.Orders.Add(order);
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateOrder(Order order)
        {
            try
            {
                using FStoreASM2Context Context = new FStoreASM2Context();
                Context.Entry<Order>(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteOrder(Order order)
        {
            try
            {
                using FStoreASM2Context Context = new FStoreASM2Context();
                //find Order by id
                var ord = GetOrderByID(order);
                Context.Orders.Remove(ord);
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

