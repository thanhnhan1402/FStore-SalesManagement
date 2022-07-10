using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public IEnumerable<Order> GetOrderList() => OrderDAO.Instance.GetOrderList();
        public Order GetOrderByID(Order order) => OrderDAO.Instance.GetOrderByID(order);
        public void InsertOrder(Order order) => OrderDAO.Instance.InsertOrder(order);
        public void UpdateOrder(Order order) => OrderDAO.Instance.UpdateOrder(order);
        public void DeleteOrder(Order order) => OrderDAO.Instance.DeleteOrder(order);
        public IEnumerable<Order> GetStatistics(DateTime orderDate, DateTime shippedDate)
        => OrderDAO.Instance.GetStatistics(orderDate, shippedDate);
        public IEnumerable<Order> GetSortedOrderList() => OrderDAO.Instance.GetSortedOrderList();
        public IEnumerable<Order> GetHistory(int memberId) => OrderDAO.Instance.GetHistory(memberId);
    }
}
