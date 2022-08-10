using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Logics
{
    public class ProductManager
    {
        ShopTestContext context = new ShopTestContext();

        public List<Product> GetAllProduct()
        {
            return context.Products.Include(c => c.Category).ToList();
        }
    }
}
