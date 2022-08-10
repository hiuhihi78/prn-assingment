using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    
    public class PublicController : Controller
    {

        ShopTestContext context = new ShopTestContext();
        [AllowAnonymous]
        public IActionResult Index()
        {
            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            string staffStr = HttpContext.Session.GetString("staff");
            if (staffStr == "" || staffStr == null)
            {
                ViewBag.username = TempData["username"];
                ViewBag.alter = TempData["alter"];
                return View();
            }
            return Redirect("../Home/Index");

        }

        
        [HttpPost]
        public IActionResult DoLogin(string username, string password)
        {
            staff staff = context.staff.Where(s => s.Username == username && s.Password == password).FirstOrDefault();

            if(staff == null)
            {
                TempData["alter"] = "Login faild";
                TempData["username"] = username;
                HttpContext.Session.SetString("staff", "");
                return RedirectToAction("Login");
            }
            else
            {
                string satffStr = JsonConvert.SerializeObject(staff);
                HttpContext.Session.SetString("staff", satffStr);

                TempData["alter"] = "";
                TempData["username"] = "";

                if(staff.Status == false)
                {
                    TempData["alter"] = "Account has been banned!";
                    TempData["username"] = username;
                    HttpContext.Session.SetString("staff", "");
                    return RedirectToAction("Login");
                }

                return Redirect("../Home/Index");
            }
        }

        public IActionResult Logout(string username, string password)
        {
            HttpContext.Session.SetString("staff", "");
            HttpContext.Session.SetString("cart", "");
            HttpContext.Session.SetString("cartImport", "");
            return Redirect("Login");
        }
    }
}
