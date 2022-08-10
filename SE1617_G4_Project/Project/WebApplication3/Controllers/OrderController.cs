using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Logics;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class OrderController : Controller
    {
        ShopTestContext context = new ShopTestContext();
        ProductManager productManager = new ProductManager();
       
        public IActionResult Index(string search, int category)
        {
            if(search == null)
            {
                search = "";
                
            }

            if (category == 0) 
            {
                this.
                ViewBag.products = productManager.GetAllProduct().Where(p => p.Name.Contains(search)).ToList();
            }
            else
            {
                ViewBag.products = productManager.GetAllProduct().Where(p => p.Name.Contains(search) && p.CategoryId == category).ToList();
            }

            string cartStr = HttpContext.Session.GetString("cart");
            List<Product> cart;
            if (cartStr == null || cartStr == "")
            {
                cart = new List<Product>();
            }
            else
            {
                cart = JsonConvert.DeserializeObject<List<Product>>(cartStr);
            }
            ViewBag.cartOrder = cart.ToList();
            ViewBag.TotalPrice = cart.Select(s => s.Price * s.Quantity - s.Price * s.Quantity * s.Discount / 100).Sum();


            ViewBag.category = context.Categories.ToList();
            ViewBag.search = search;
            ViewBag.categorySelected = category;
            return View();
        }
        

        public IActionResult AddToCart(int id)
        {
            List<Product> cart = new List<Product>();
            string cartStr = HttpContext.Session.GetString("cart");
            if(cartStr == null || cartStr == "")
            {
                cart = new List<Product>();
                Product product = context.Products.Find(id);
                product.Quantity = 1;
                cart.Add(product);
            }
            else
            {
                bool isExisted = false;
                cart = JsonConvert.DeserializeObject<List<Product>>(cartStr);
                foreach(Product product in cart)
                {
                    Product productMain = context.Products.Find(id);
                    if(product.Id == id && product.Quantity < productMain.Quantity)
                    {
                        isExisted = true;
                        product.Quantity = product.Quantity + 1;
                        break;
                    }
                    if(product.Quantity >= productMain.Quantity)
                    {
                        isExisted = true;
                    }
                }
                if(isExisted == false)
                {
                    Product product = context.Products.Find(id);
                    product.Quantity = 1;
                    cart.Add(product);  
                }
            }
            cartStr = JsonConvert.SerializeObject(cart);
            HttpContext.Session.SetString("cart", cartStr);

            return Redirect("Index");
        }

        public IActionResult IncreaseQuantity(int id)
        {
            List<Product> cart = new List<Product>();
            string cartStr = HttpContext.Session.GetString("cart");
            cart = JsonConvert.DeserializeObject<List<Product>>(cartStr);

            foreach (Product product in cart)
            {
                Product productMain = context.Products.Find(id);
                if (product.Id == id && product.Quantity < productMain.Quantity)
                {
                    product.Quantity = product.Quantity + 1;
                    break;
                }
            }

            cartStr = JsonConvert.SerializeObject(cart);
            HttpContext.Session.SetString("cart", cartStr);
            return Redirect("Index");
        }


        public IActionResult DecreaseQuantity(int id)
        {
            List<Product> cart = new List<Product>();
            string cartStr = HttpContext.Session.GetString("cart");
            cart = JsonConvert.DeserializeObject<List<Product>>(cartStr);

            foreach (Product product in cart)
            {
                Product productMain = context.Products.Find(id);
                if (product.Id == id)
                {
                    product.Quantity = product.Quantity - 1;
                    if (product.Quantity == 0)
                    {
                        cart.Remove(product);
                    }
                    break;
                }
                
            }

            cartStr = JsonConvert.SerializeObject(cart);
            HttpContext.Session.SetString("cart", cartStr);
            return Redirect("Index");
        }


        public IActionResult Checkout()
        {
            List<Product> cart = new List<Product>();
            string cartStr = HttpContext.Session.GetString("cart");
            cart = JsonConvert.DeserializeObject<List<Product>>(cartStr);

            ViewBag.products = cart.ToList();
            ViewBag.TotalPrice = cart.Select(s => s.Price * s.Quantity - s.Price * s.Quantity * s.Discount / 100).Sum();

            return View();
        }

        public IActionResult DoCheckout(string name, string phone, string address, string totalPrice)
        {
            List<Product> cart = new List<Product>();
            string cartStr = HttpContext.Session.GetString("cart");
            cart = JsonConvert.DeserializeObject<List<Product>>(cartStr);

            string staffStr = HttpContext.Session.GetString("staff");
            staff staff = JsonConvert.DeserializeObject<staff>(staffStr);

            Order order = new Order();
            order.OrderDate = DateTime.Now;
            order.StaffId = staff.Id;
            order.TotalAmount = double.Parse(totalPrice);
            order.CustomerAddress = address == null ? "" : address;
            order.CustomerName = name == null ? "" : name;
            order.CustomerPhone = phone == null ? "" : phone;
            context.Orders.Add(order);
            context.SaveChanges();

            string raw_orderId = context.Orders.OrderByDescending(o => o.Id).FirstOrDefault().Id.ToString();
            int orderId = int.Parse(raw_orderId);
            foreach (Product product in cart)
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.ProductId = product.Id;
                orderDetail.OrderId = orderId;
                orderDetail.Quantity = product.Quantity;
                orderDetail.SellPrice = product.Price * product.Quantity - product.Price*product.Quantity*product.Discount/100;

                Product productUpdate = context.Products.Find(product.Id);
                productUpdate.Quantity = productUpdate.Quantity - product.Quantity;
                context.SaveChanges();

                context.OrderDetails.Add(orderDetail);
                context.SaveChanges();
            }

            HttpContext.Session.SetString("cart", "");

            TempData["alterSuccess"] = "true";

            return Redirect("Index");

 
        }
    }
}
