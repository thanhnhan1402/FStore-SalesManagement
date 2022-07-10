using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrderList();
        Order GetOrderByID(Order Order);
        void InsertOrder(Order Order);
        void UpdateOrder(Order Order);
        void DeleteOrder(Order Order);
        IEnumerable<Order> GetStatistics(DateTime orderDate, DateTime shippedDate);
        public IEnumerable<Order> GetSortedOrderList();
        public IEnumerable<Order> GetHistory(int memberId);
    }
}
