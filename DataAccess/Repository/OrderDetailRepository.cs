using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    internal class OrderDetailRepository : IOrderDetailRepository
    {
        public IEnumerable<OrderDetail> GetOrderDetails() => OrderDetailDAO.Instance.GetOrderDetails();
        public OrderDetail GetOrderDetailByID(OrderDetail orderDetail) => OrderDetailDAO.Instance.GetOrderDetailByID(orderDetail);
        public void InsertOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.InsertOrderDetail(orderDetail);
        public void UpdateOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.UpdateOrderDetail(orderDetail);
        public void DeleteOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.DeleteOrderDetail(orderDetail);
        
    }
}
