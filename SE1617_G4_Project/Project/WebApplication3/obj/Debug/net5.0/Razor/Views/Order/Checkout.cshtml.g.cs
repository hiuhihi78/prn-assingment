#pragma checksum "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\Order\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bab1b561ae9d1237af20bd0a4222b1796377c7b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Checkout), @"mvc.1.0.view", @"/Views/Order/Checkout.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bab1b561ae9d1237af20bd0a4222b1796377c7b3", @"/Views/Order/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("DoCheckout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\Order\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-7"">
            <h2 class=""text-center"">Products</h2>
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th scope=""col"">Name</th>
                        <th scope=""col"">Quantity</th>
                        <th scope=""col"">Price</th>
                        <th scope=""col"">Discount</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 21 "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\Order\Checkout.cshtml"
                     foreach (Product product in ViewBag.products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td scope=\"row\">");
#nullable restore
#line 24 "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\Order\Checkout.cshtml"
                                       Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td scope=\"row\">");
#nullable restore
#line 25 "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\Order\Checkout.cshtml"
                                       Write(product.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td scope=\"row\">");
#nullable restore
#line 26 "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\Order\Checkout.cshtml"
                                       Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td scope=\"row\">");
#nullable restore
#line 27 "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\Order\Checkout.cshtml"
                                       Write(product.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\Order\Checkout.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n        <div class=\"col-md-5\">\r\n            <h2 class=\"text-center\">Customer\'s Info</h2>\r\n            <div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bab1b561ae9d1237af20bd0a4222b1796377c7b37005", async() => {
                WriteLiteral(@"

                    <div class=""form-group"">
                        <label for=""exampleInputEmail1"">Full name</label>
                        <input type=""text"" class=""form-control"" name=""name"" aria-describedby=""emailHelp"" placeholder=""Enter full name"">
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleInputEmail1"">Phone</label>
                        <input type=""tel"" class=""form-control"" name=""phone"" aria-describedby=""emailHelp"" placeholder=""Enter phone"">
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleInputEmail1"">Address</label>
                        <input type=""text"" class=""form-control"" name=""address"" aria-describedby=""emailHelp"" placeholder=""Enter address"">
                    </div>

                    <input type=""hidden"" name=""totalPrice""");
                BeginWriteAttribute("value", " value=\"", 2209, "\"", 2236, 1);
#nullable restore
#line 52 "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\Order\Checkout.cshtml"
WriteAttributeValue("", 2217, ViewBag.TotalPrice, 2217, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n\r\n                    <h3 class=\"m-t-10 m-b-10\" >Total: ");
#nullable restore
#line 54 "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\Order\Checkout.cshtml"
                                                 Write(ViewBag.TotalPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(" VND</h3>\r\n\r\n                    <button type=\"submit\" class=\"btn btn-primary\">Chechout</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
