using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        //singleton pattern
        private static OrderDetailDAO instance { get; set; }
        private static readonly object instanceLock = new object();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<OrderDetail> GetOrderDetails()
        {
            var ordDetail = new List<OrderDetail>();
            try
            {
                using FStoreASM2Context context = new();
                ordDetail = context.OrderDetails.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ordDetail;
        }
        public OrderDetail GetOrderDetailByID(OrderDetail orderDetail)
        {
            OrderDetail? ordDetail;
            try
            {
                using FStoreASM2Context context = new();
                ordDetail = context.OrderDetails.SingleOrDefault(ord => ord.OrderId == orderDetail.OrderId);
                if(orderDetail == null)
                {
                    throw new Exception("This order detail does not exist!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ordDetail;
        }
        public void InsertOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                using FStoreASM2Context context = new();
                context.OrderDetails.Add(orderDetail);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                using FStoreASM2Context context = new();
                context.Entry<OrderDetail>(orderDetail).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                using FStoreASM2Context context = new();
                var ordd = GetOrderDetailByID(orderDetail);
                context.OrderDetails.Remove(ordd);
                context.SaveChanges();
            }
            catch (Exception ex)
            {   
                throw new Exception(ex.Message);
            }
        }
    }
}
