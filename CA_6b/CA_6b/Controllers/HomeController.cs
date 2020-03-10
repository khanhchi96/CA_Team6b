using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CA_6b.Models;
using CA_6b.DB;
namespace CA_6b.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("LoginPage");
        }


        public ActionResult Login(Customer customer)
        {
            //check if username is valid in the database
            if (CustomerData.GetPassword(customer.Username) != null)
            {
                //if username is valid, check if password is matched
                if (CustomerData.IsPasswordValid(customer.Password, CustomerData.GetPassword(customer.Username)))
                {    
                    //if username and password are valid, save customer info to a session and redirect
                    //customer to the product gallery page
                    Session["customer"] = CustomerData.GetCustomer(customer.Username);
                    return RedirectToAction("Index", "Product");
                }
                ViewBag.errorMessage = "Wrong password. Please try again";
                return View("LoginPage");
            }
            //if username is not valid, show the error message "Invalid username"
            ViewBag.errorMessage = "Invalid username";
            return View("LoginPage");
        }

        public ActionResult LoginPage()
        {
            return View();
        }


        public ActionResult LogOff()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult ViewPurchases(int customerId)
        {
            return RedirectToAction("OrderHistory", "Order", new { customerId = customerId });
        }
    }
}