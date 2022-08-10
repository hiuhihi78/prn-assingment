using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Filters
{
    public class AccountFilter : ActionFilterAttribute
    {
        private List<string> allowAnonymous = new List<string>();
        private List<string> allowManager = new List<string>();


        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            allowAnonymous.Add("/Public/Login");
            allowAnonymous.Add("/Public/Logout");
            allowAnonymous.Add("/Public/DoLogin");

            allowManager.Add("/ProductManage/Edit");
            allowManager.Add("/ProductManage/CreateNewProduct");
            allowManager.Add("/ProductManage/CreateNewCategory");
            allowManager.Add("/AccountManage/Index");
            allowManager.Add("/AccountManage/CreateNewAccount");
            allowManager.Add("/AccountManage/Detail");


            var url = filterContext.HttpContext.Request.Path.Value;

            bool isAllow = false;
            foreach(string urlFilter in allowAnonymous)
            {
                if (urlFilter.Contains(url)) isAllow = true;
            }

            bool isAllowManager = true;
            foreach (string urlFilter in allowManager)
            {
                if (urlFilter.Contains(url)) isAllowManager = false;
            }


            if (isAllow == false)
            {

                string staffStr = filterContext.HttpContext.Session.GetString("staff");
                if (staffStr == null)
                {
                    filterContext.Result = new RedirectResult("/Public/Login");
                    return;
                }

                staff staff = JsonConvert.DeserializeObject<staff>(staffStr);
                if (staff == null)
                {
                    filterContext.Result = new RedirectResult("/Public/Login");
                    return;
                }

                if (staff.IsManager == false && isAllowManager == false)
                {
                    filterContext.Result = new RedirectResult("/Home/Index");
                    return;
                }
                //filterContext.HttpContext.Response.Headers.Add("dwqa", url);
            }
        }
    }
}
