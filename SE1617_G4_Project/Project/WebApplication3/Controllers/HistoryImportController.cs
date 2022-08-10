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
    public class HistoryImportController : Controller
    {
        ShopTestContext context = new ShopTestContext();
        [HttpGet]
        public IActionResult Index(int importId,  int staffId, string dateStart, string dateEnd)
        {
            List<Import> imports = new List<Import>();
            if (importId == 0 && staffId == 0 && dateStart == null && dateEnd == null)
            {
                imports = context.Imports.Include(p => p.Staff).Where(o => o.ImportDate >= DateTime.Parse("2022-05-30") && o.ImportDate <= DateTime.Now).ToList();
            }
            else
            {
                if (importId == 0 && staffId == 0)
                {
                    imports = context.Imports.Include(p => p.Staff)
                    .Where(o =>
                    o.ImportDate >= DateTime.Parse(dateStart)
                    && o.ImportDate <= DateTime.Parse(dateEnd)
                    )
                    .ToList();

                }
                else if (importId != 0 && staffId != 0)
                {
                    imports = context.Imports.Include(p => p.Staff)
                    .Where(o =>
                    o.ImportDate >= DateTime.Parse(dateStart)
                    && o.ImportDate <= DateTime.Parse(dateEnd)
                    && o.Id == importId
                    && o.StaffId == staffId
                    )
                    .ToList();
                }
                else if (importId != 0 && staffId == 0)
                {
                    imports = context.Imports.Include(p => p.Staff)
                    .Where(o =>
                    o.ImportDate >= DateTime.Parse(dateStart)
                    && o.ImportDate <= DateTime.Parse(dateEnd)
                    && o.Id == importId
                    )
                    .ToList();
                }
                else if (importId == 0 && staffId != 0)
                {
                    imports = context.Imports.Include(p => p.Staff)
                    .Where(o =>
                    o.ImportDate >= DateTime.Parse(dateStart)
                    && o.ImportDate <= DateTime.Parse(dateEnd)
                    && o.StaffId == staffId
                    )
                    .ToList();
                }

              
            }
            imports = imports.OrderByDescending(o => o.Id).ToList();


            string staffStr = HttpContext.Session.GetString("staff");
            staff staff = JsonConvert.DeserializeObject<staff>(staffStr);

            ViewBag.staff = staff;
            ViewBag.imports = imports;
            ViewBag.importId = importId;
            ViewBag.staffId = staffId;
            ViewBag.dateStart = dateStart;
            ViewBag.dateEnd = dateEnd;
            return View();
        }

        public IActionResult ViewImportDetail(int id)
        {
            ViewBag.importdetails = context.ImportDetails.Include(o => o.Product).Where(o => o.ImportId == id).ToList();
            ViewBag.import = context.Orders.Include(o => o.Staff).Where(o => o.Id == id).FirstOrDefault();
            return View();
        }
    }
}
