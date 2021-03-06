using A_StateOnline.Core.Contracts;
using A_StateOnline.Core.Models;
using A_StateOnline.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_StateOnline.Services
{
    public class OrderService : IOrderService
    {
        IRepository<Order> orderContext;
        public OrderService(IRepository<Order> OrderContext)
        {
            this.orderContext = OrderContext;
        }

        public void CreateOrder(Order baseOrde, List<CartItemVM> cartItems)
        {
           foreach(var item in cartItems)
            {
                baseOrde.OrderItems.Add(new OrderItem()
                {
                    ProductId = item.Id,
                    Image = item.Image,
                    Price = item.Price,
                    ProductName = item.ProductName,
                    Quantity = item.Quantity
                });
            }
            orderContext.Insert(baseOrde);
            orderContext.Commit();
        }
        public List<Order> GetOrdersList()
        {
            return orderContext.Collection().ToList();
        }
        public Order GetOrder(string Id)
        {
            return orderContext.Find(Id);
        }
        public void UpdateOrder(Order updatedOrder)
        {
            orderContext.Update(updatedOrder);
            orderContext.Commit();
        }

    }
}
