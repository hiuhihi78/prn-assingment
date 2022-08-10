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
    public class AccountManage : Controller
    {
        ShopTestContext context = new ShopTestContext();
        
        public IActionResult Index(string id, string username, int role)
        {
            List<staff> staffs = new List<staff>();        

            if (username == null && id == null && role == null)
            {
                staffs = context.staff.ToList();
            }
            else
            {
                if(username == null)
                {
                    username = "";
                }
                if(role == 0)
                {
                    if(id != null)
                    {
                        staffs = context.staff.Where(s => s.Id == int.Parse(id)).ToList();
                    }
                    else
                    {
                        staffs = context.staff.Where(s => s.Fullname.Contains(username)).ToList();
                    }
                }
                else
                {
                    bool isManager = role == 1 ? true : false;
                    if (id != null)
                    {
                        staffs = context.staff.Where(s => s.Id == int.Parse(id) && s.Fullname.Contains(username) && s.IsManager == isManager).ToList();
                    }
                    else
                    {
                        staffs = context.staff.Where(s => s.Fullname.Contains(username) && s.IsManager == isManager).ToList();
                    }
                }
            }


            string staffStr = HttpContext.Session.GetString("staff");
            staff staff = JsonConvert.DeserializeObject<staff>(staffStr);

            ViewBag.staffCurrent = staff;
            ViewBag.staffs = staffs;
            ViewBag.id = id;
            ViewBag.username = username;
            ViewBag.roleSelected = role;
            return View();
        }

        public IActionResult Edit(int id)
        {
            staff staff = context.staff.Where(s => s.Id == id).FirstOrDefault();

            ViewBag.roleSelected = staff.Id;

            return View(staff);
        }

        public IActionResult Detail(int id)
        {
            staff staff = context.staff.Where(s => s.Id == id).FirstOrDefault();
            return View(staff);
        }

        
        public ContentResult DoActivateAccount(int id)
        {
            staff staff = context.staff.Find(id);
            staff.Status = !staff.Status;
            context.staff.Update(staff);
            context.SaveChanges();
            string content = "<button class='"+(staff.Status == true ? "btn btn-success" : "btn btn-danger") 
                + "' onclick='openModal("+staff.Id+ ")' data-toggle='modal' data-target='#active'>"+
                (staff.Status == true ? "Activate" : "Deactivate") + "</button>";
            return Content(content);
        }


        public IActionResult CreateNewAccount()
        {
            return View();
        }

        public IActionResult DoCreatNewAccount(string username, string password, string fullname, string phone, string address, int role, string status)
        {
            bool isManager = role == 1 ? true : false;
            staff staff = new staff()
            {
                Username = username,
                Password = password,
                Fullname = fullname,
                Phone = phone,
                Address = address,
                IsManager = isManager,
                Status = status == "activate"
            };

            context.staff.Add(staff);
            context.SaveChanges();
            return Redirect("Index");
        }

    }
}
