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
    public class ProductManageController : Controller
    {
        ShopTestContext context = new ShopTestContext();
        public IActionResult Index(string productName, string raw_priceStart, string raw_priceEnd, int category)
        {
            double priceStart = 0; 
            double priceEnd  = 100000;
            
            if(productName == null)
            {
                productName = "";
            }

            if (raw_priceStart != null && raw_priceEnd != null)
            {
                priceStart = double.Parse(raw_priceStart);
                priceEnd = double.Parse(raw_priceEnd);
                
            }

            if (category == 0)
            {
                ViewBag.products = context.Products.Include(p => p.Category)
                    .Where(p => p.Name.Contains(productName) && p.Price >= priceStart && p.Price <= priceEnd)
                    .ToList();
            }
            else
            {
                ViewBag.products = context.Products.Include(p => p.Category).Where(p => p.Name.Contains(productName) && p.Price >= priceStart && p.Price <= priceEnd && p.CategoryId == category).ToList();
            }


            string staffStr = HttpContext.Session.GetString("staff");
            staff staff = JsonConvert.DeserializeObject<staff>(staffStr);

            ViewBag.staff = staff;

            ViewBag.productName = productName;
            ViewBag.priceStart = priceStart;
            ViewBag.priceEnd = priceEnd;
            ViewBag.categorySelected = category;
            ViewBag.category = context.Categories.ToList();
            return View();
        }

        public IActionResult Edit(int id)
        {
            Product product = context.Products.Include(p => p.Category).Where(p => p.Id == id).FirstOrDefault();

            ViewBag.product = product;

            ViewBag.category = context.Categories.ToList();

            ViewBag.categorySelected = product.Id; 

            return View(product);
        }

        [HttpPost]
        public IActionResult DoEdit(int id,string name, string description, string quantity, string price, string discount, string country, string category)
        {
            Product product = context.Products.Find(id);
            product.Name = name;
            product.Description = description;
            product.Quantity = int.Parse(quantity);
            product.Price = double.Parse(price);
            product.Discount = int.Parse(discount);
            product.Country = country;
            product.CategoryId = int.Parse(category);

            context.SaveChanges();

            return Redirect("Index");
        }


        public IActionResult CreateNewProduct()
        {
            ViewBag.category = context.Categories.ToList();
            return View();
        }

        public IActionResult DoCreateNewProduct(string name, string description, string quantity, string price, string discount, string country, string category)
        {
            Product product = new Product();
            product.Name = name;
            product.Description = description;
            product.Quantity = 0;
            product.Price = double.Parse(price);
            product.Discount = int.Parse(discount);
            product.Country = country;
            product.CategoryId = int.Parse(category);

            context.Products.Add(product);
            context.SaveChanges();
            return Redirect("Index");
        }

        [HttpPost]
        public ContentResult AddNewCategory(string newCategory)
        {
            bool categoryExisted = context.Categories.Where(c => c.Name == newCategory).FirstOrDefault() == null ? false : true;
            if(categoryExisted == false)
            {
                Category category = new Category();
                category.Name = newCategory;
                context.Categories.Add(category);

                context.SaveChanges();

                Category saveCategory = context.Categories.Where(c => c.Name == newCategory).FirstOrDefault();

                return Content("<option value="+ saveCategory.Id + ">"+ saveCategory.Name +"</option>");
            }
            else
            {
                return Content("Category was existed");
            }
        }
    }


   
}
