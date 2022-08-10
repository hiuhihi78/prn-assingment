using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HistoryOrderController : Controller
    {
        ShopTestContext context = new ShopTestContext();
        [HttpGet]
        public IActionResult Index(int orderId,string customerInfo, int staffId, string dateStart, string dateEnd)
        {
            List<Order> orders = new List<Order>();
            if (customerInfo == null && orderId == 0 && staffId == 0 && dateStart == null && dateEnd == null)
            {
                orders = context.Orders.Include(p => p.Staff).Where(o => o.OrderDate >= DateTime.Parse("2022-05-30") && o.OrderDate <= DateTime.Now).ToList();
            }
            else
            {
                if (orderId == 0 && staffId == 0)
                {
                    orders = context.Orders.Include(p => p.Staff)
                    .Where(o =>
                    o.OrderDate >= DateTime.Parse(dateStart)
                    && o.OrderDate <= DateTime.Parse(dateEnd)
                    )
                    .ToList();

                }
                else if (orderId != 0 && staffId != 0)
                {
                    orders = context.Orders.Include(p => p.Staff)
                    .Where(o =>
                    o.OrderDate >= DateTime.Parse(dateStart)
                    && o.OrderDate <= DateTime.Parse(dateEnd)
                    && o.Id == orderId
                    && o.StaffId == staffId
                    )
                    .ToList();
                }
                else if (orderId != 0 && staffId == 0)
                {
                    orders = context.Orders.Include(p => p.Staff)
                    .Where(o =>
                    o.OrderDate >= DateTime.Parse(dateStart)
                    && o.OrderDate <= DateTime.Parse(dateEnd)
                    && o.Id == orderId
                    )
                    .ToList();
                }
                else if (orderId == 0 && staffId != 0)
                {
                    orders = context.Orders.Include(p => p.Staff)
                    .Where(o =>
                    o.OrderDate >= DateTime.Parse(dateStart)
                    && o.OrderDate <= DateTime.Parse(dateEnd)
                    && o.StaffId == staffId
                    )
                    .ToList();
                }

                if(customerInfo != "" && customerInfo != null)
                {
                    orders = orders.Where(o => o.CustomerAddress.Contains(customerInfo)
                    || o.CustomerName.Contains(customerInfo)
                    || o.CustomerPhone.Contains(customerInfo)
                    ).ToList();
                }
            }
            orders = orders.OrderByDescending(o => o.Id).ToList();


            string staffStr = HttpContext.Session.GetString("staff");
            staff staff = JsonConvert.DeserializeObject<staff>(staffStr);

            ViewBag.staff = staff;
            ViewBag.orders = orders;
            ViewBag.orderId = orderId;
            ViewBag.customerInfo = customerInfo;
            ViewBag.staffId = staffId;
            ViewBag.dateStart = dateStart;
            ViewBag.dateEnd = dateEnd;
            return View();
        }

        public IActionResult ViewOrderDetail(int id)
        {
            ViewBag.orderdetails = context.OrderDetails.Include(o => o.Product).Where(o => o.OrderId == id).ToList();
            ViewBag.order = context.Orders.Include(o => o.Staff).Where(o => o.Id == id).FirstOrDefault();
            return View();
        }
    }
}



/*
if (orderId != null && staffId != null)
{
    orders = context.Orders.Include(p => p.Staff)
    .Where(o => o.OrderDate >= DateTime.Parse(dateStart)
    && o.OrderDate <= DateTime.Parse(dateEnd)
    && o.CustomerName.Contains(customerInfo)
    && o.Id == orderId
    && o.StaffId == staffId
    )
    .ToList();
}
else if (orderId != null && staffId == null)
{
    orders = context.Orders.Include(p => p.Staff)
    .Where(o => o.OrderDate >= DateTime.Parse(dateStart)
    && o.OrderDate <= DateTime.Parse(dateEnd)
    && o.CustomerName.Contains(customerInfo)
    && o.Id == orderId
    )
    .ToList();
}
else if (orderId == null && staffId != null)
{
    orders = context.Orders.Include(p => p.Staff)
    .Where(o => o.OrderDate >= DateTime.Parse(dateStart)
    && o.OrderDate <= DateTime.Parse(dateEnd)
    && o.CustomerName.Contains(customerInfo)
    && o.StaffId == staffId
    )
    .ToList();
}
*/