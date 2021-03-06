using A_StateOnline.Core.Contracts;
using A_StateOnline.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A_StateOnline.UI.Controllers
{
    public class OrderController : Controller
    {
        IOrderService orderService;
        public OrderController(IOrderService OrderService)
        {
            this.orderService = OrderService;
        }
        public ActionResult Index()
        {
            List<Order> orders = orderService.GetOrdersList();
            return View(orders);
        }
        public ActionResult UpdateOrder(string Id)
        {
            Order order = orderService.GetOrder(Id);
            return View(order);
        }
        [HttpPost]
        public ActionResult UpdateOrder(Order updatedOrder, string Id)
        {
            Order order = orderService.GetOrder(Id);
            order.OrderStatus = updatedOrder.OrderStatus;
            orderService.UpdateOrder(order);
            return RedirectToAction("Index");
        }
    }
}