using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CA_6b.Models;
using CA_6b.DB;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace CA_6b.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index(int orderId)
        {
            if (Session["customer"] == null)
            {
                return RedirectToAction("LoginPage", "Home");
            }
            else
            {
                List<OrderItem> orderList = OrderData.GetOrder(orderId);
                ViewData["order"] = orderList;
                return View();
            }
        }

        public ActionResult OrderHistory(int customerId)
        {
            List<Order> orderHistory = OrderData.GetOrderHistory(customerId);
            ViewData["orderHistory"] = orderHistory;
            return View();
        }

        public ActionResult OrderDetail(int orderId)
        {
            List<OrderItem> orderDetail = OrderData.GetOrder(orderId);
            ViewData["order"] = orderDetail;
            return View("Index");
        }


        public void Download()
        {
            HttpResponse response = System.Web.HttpContext.Current.Response;
            response.ClearContent();
            response.Clear();
            response.ContentType = "text/plain";
            response.AddHeader("Content-Disposition",
                               "attachment; filename= Destiny2.jpg;");
            response.TransmitFile(Server.MapPath("../Images/Destiny2.jpg"));
            response.Flush();
            response.End();
        }
    }


}