using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CA_6b.Models;
using CA_6b.DB;
using PagedList;
using System.Diagnostics;

namespace CA_6b.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index(string sortOrder, int? page, string searchStr = "")
        {
            if (Session["customer"] == null)
                return RedirectToAction("LoginPage", "Home");
            else
            {
                //Retrieve all product from the database and send to the View
                List<Product> products = ProductData.GetAllProducts();
                //if the user enter a keyword to search, products will be filtered, those with matched
                //name and description will be showed
                products = products.Where(p => p.ProductName.ToLower().Contains(searchStr.ToLower())
                                  || p.Description.ToLower().Contains(searchStr.ToLower())).ToList();

                //if the user performs the sorting action, the sorting keyword will be sent to the server.
                //new product list as sorted by that keyword will be sent back to be shown in the View
                switch (sortOrder)
                {
                    case "price_asc":
                        products = products.OrderBy(p => p.Price).ToList();
                        break;
                    case "price_desc":
                        products = products.OrderByDescending(p => p.Price).ToList();
                        break;
                    case "sales_desc":
                        products = products.OrderByDescending(p => p.NumOfSales).ToList();
                        break;
                    case "discount_desc":
                        products = products.OrderByDescending(p => p.Discount).ToList();
                        break;
                    case "release_desc":
                        products = products.OrderByDescending(p => p.ReleaseDate).ToList();
                        break;
                    default:
                        products = products.OrderBy(p => p.ProductId).ToList();
                        break;
                }

                //after the user bought a product, the cart details (as saved in Session) will be sent 
                //to the View using ViewData
                if (Session["cart"] != null)
                {
                    ViewData["cart"] = Session["cart"];
                }
                ViewBag.searchStr = searchStr;
                ViewBag.sortOrder = sortOrder;
                int pageSize = 8;
                int pageNumber = (page ?? 1);
                return View(products.ToPagedList(pageNumber, pageSize));
            }
        }

        public ActionResult ProductDetail(int productId)
        {
            Product product = ProductData.GetProductById(productId);
            ViewData["product"] = product;
            return View();
        }


        public void Buy(int productId, double newPrice)
        {
            //after the user press "Add to cart" button, productId and price (after discounted) will
            //be sent to the server side. If there is no existing cart session, the product will be
            //saved in a new cart session
            if (Session["cart"] == null)
            {
                List<CartItem> cart = new List<CartItem>();
                cart.Add(new CartItem
                {
                    Product = ProductData.find(productId),
                    Quantity = 1,
                    NewPrice = newPrice
                });
                Session["cart"] = cart;
            }
            else
            {
                //if a cart session is already existing, ProductId will be checked 
                List<CartItem> cart = (List<CartItem>)Session["cart"];
                int index = isExit(productId);
                if (index != -1)
                {
                    //if there is a matched ProductId in the existing session, product's quantity will be increased
                    cart[index].Quantity++;
                }
                else
                {
                    //if there is no matched ProductId in the existing session, new Product will be added
                    cart.Add(new CartItem { Product = ProductData.find(productId), Quantity = 1, NewPrice = newPrice });
                }
                Session["cart"] = cart;
            }
        }

        public void Remove(int productId)
        {
            List<CartItem> cart = (List<CartItem>)Session["cart"];
            //find the product in cart session by its ProductId
            int index = isExit(productId);
            cart.RemoveAt(index);
            Session["cart"] = cart;
        }

        public void Change(int productId, int num)
        {
            List<CartItem> cart = (List<CartItem>)Session["cart"];
            //if the user change the quantity, the product will be find by its Id and the old quantity will be
            //replaced by the new one sent from the View
            int index = isExit(productId);
            cart[index].Quantity = num;
            Session["cart"] = cart;
        }

        public ActionResult Cart_Details()
        {
            ViewData["cart"] = Session["cart"];
            return PartialView("_CartDetails");
        }

        public ActionResult Cart_Icon()
        {
            ViewData["cart"] = Session["cart"];
            return PartialView("_CartIcon");
        }

        private int isExit(int productId)
        {
            List<CartItem> cart = (List<CartItem>)Session["cart"];
            for (int i = 0; i < cart.Count(); i++)
            {
                if (cart[i].Product.ProductId.Equals(productId))
                    return i;
            }
            return -1;
        }

        public ActionResult CheckOut()
        {
            List<CartItem> cart = (List<CartItem>)Session["cart"];

            List<Product> products = new List<Product>();
            List<int> quantities = new List<int>();
            List<ActivationCode> codeLists = new List<ActivationCode>();
            for (int i = 0; i < cart.Count(); i++)
            {
                //adding products in the cart to a new list of product
                products.Add(cart[i].Product);
                quantities.Add(cart[i].Quantity);
                int productId = cart[i].Product.ProductId;
                //for each productId, a new list of codes will be generated, with number of elements equal to
                //the quantity of that product
                List<string> codes = new List<string>();
                for (int j = 0; j < cart[i].Quantity; j++)
                {
                    //activation codes for that products will be generated and saved to the list
                    codes.Add(Guid.NewGuid().ToString());
                }
                ActivationCode actCode = new ActivationCode(productId, codes);
                codeLists.Add(actCode);
            }
            OrderDetail orderDetail = new OrderDetail(products, quantities, codeLists);
            Customer customer = (Customer)Session["customer"];
            int customerId = Convert.ToInt32(customer.CustomerId);
            Order order = new Order()
            {
                CustomerId = customerId,
                OrderDate = DateTime.Now,
                OrderDetail = orderDetail
            };
            //order details are saved to the database by OrderData.SaveOrder(order Order) method
            OrderData.SaveOrder(order);
            int orderId = OrderData.GetOrderId(order);
            Session["cart"] = null;
            return RedirectToAction("Index", "Order", new { orderId = orderId });
        }
    }
}