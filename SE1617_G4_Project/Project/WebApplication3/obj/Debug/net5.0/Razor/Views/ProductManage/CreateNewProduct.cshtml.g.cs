#pragma checksum "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\ProductManage\CreateNewProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "704e58292e57ef34a8d66c07a143287235396a7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductManage_CreateNewProduct), @"mvc.1.0.view", @"/Views/ProductManage/CreateNewProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"704e58292e57ef34a8d66c07a143287235396a7c", @"/Views/ProductManage/CreateNewProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductManage_CreateNewProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("DoCreateNewProduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\ProductManage\CreateNewProduct.cshtml"
  
    ViewData["Title"] = "CreateNewProduct";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <h1 class=\"text-center m-b-50\">Creat new product</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "704e58292e57ef34a8d66c07a143287235396a7c4966", async() => {
                WriteLiteral("\r\n\r\n\r\n        <div class=\"form-group row\">\r\n            <label");
                BeginWriteAttribute("for", " for=\"", 320, "\"", 326, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""col-sm-2 col-form-label"">Name</label>
            <div class=""col-sm-10"">
                <input type=""text"" name=""name"" id=""name"" class=""form-control"">
            </div>
        </div>

        <div class=""form-group row"">
            <label");
                BeginWriteAttribute("for", " for=\"", 585, "\"", 591, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""col-sm-2 col-form-label"">Description</label>
            <div class=""col-sm-10"">
                <textarea class=""form-control"" name=""description"" id=""description"" form=""addForm"" rows=""3""></textarea>
            </div>
        </div>

        <div class=""form-group row"">
            <label");
                BeginWriteAttribute("for", " for=\"", 897, "\"", 903, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""col-sm-2 col-form-label"">Price</label>
            <div class=""col-sm-10"">
                <input type=""number"" class=""form-control"" min=""0"" name=""price"" value=""0"">
            </div>
        </div>

        <div class=""form-group row"">
            <label");
                BeginWriteAttribute("for", " for=\"", 1174, "\"", 1180, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""col-sm-2 col-form-label"">Discount</label>
            <div class=""col-sm-10"">
                <input type=""text"" class=""form-control"" name=""discount"" min=""0"" max=""100"" value=""0"">
            </div>
        </div>

        <div class=""form-group row"">
            <label");
                BeginWriteAttribute("for", " for=\"", 1465, "\"", 1471, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""col-sm-2 col-form-label"">Country</label>
            <div class=""col-sm-10"">
                <input type=""text"" class=""form-control"" name=""country"" id=""country"">
            </div>
        </div>

        <div class=""form-group row"">
            <label");
                BeginWriteAttribute("for", " for=\"", 1739, "\"", 1745, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"col-sm-2 col-form-label\">Category</label>\r\n            <div class=\"col-sm-3\">\r\n                <select name=\"category\" class=\"form-control\" id=\"category\">\r\n");
#nullable restore
#line 51 "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\ProductManage\CreateNewProduct.cshtml"
                     foreach (Category category in ViewBag.Category)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\ProductManage\CreateNewProduct.cshtml"
                         if (category.Id == ViewBag.categorySelected)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "704e58292e57ef34a8d66c07a143287235396a7c8523", async() => {
#nullable restore
#line 55 "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\ProductManage\CreateNewProduct.cshtml"
                                                             Write(category.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\ProductManage\CreateNewProduct.cshtml"
                               WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\ProductManage\CreateNewProduct.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "704e58292e57ef34a8d66c07a143287235396a7c11178", async() => {
#nullable restore
#line 59 "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\ProductManage\CreateNewProduct.cshtml"
                                                    Write(category.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\ProductManage\CreateNewProduct.cshtml"
                               WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\ProductManage\CreateNewProduct.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Admin\Desktop\prn-assingment\SE1617_G4_Project\Project\WebApplication3\Views\ProductManage\CreateNewProduct.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\"col-sm-1\">\r\n                <button type=\"button\" class=\"btn-increase\" data-toggle=\"modal\" data-target=\"#addNewCategory\">+</button>\r\n            </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <div class=""form-group row"">
        <div class=""col-sm-5""></div>
        <div class=""col-sm-1"">
            <button type=""submit"" class=""btn btn-primary m-center"" data-toggle=""modal"" data-target=""#saveAdd"">Save</button>
        </div>
        <div class=""col-sm-1"">
            <button type=""submit"" class=""btn btn-primary m-center"" onclick=""window.history.go(-1)"">Cancel</button>
        </div>
        <div class=""col-sm-5""></div>
    </div>



    <div class=""modal fade"" id=""saveAdd"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Add new product</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
           ");
            WriteLiteral(@"     </div>
                <div class=""modal-body"">
                    Are you sure?
                </div>
                <i id=""alter"" style=""color:red""></i>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-primary"" onclick=""submitForm()"">Save changes</button>
                    <button type=""button"" class=""btn btn-secondary"" onclick=""document.getElementById('alter').innerHTML = ''"" data-dismiss=""modal"">Close</button>
                </div>
            </div>
        </div>
    </div>


    <div class=""modal fade"" id=""addNewCategory"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel1"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel1"">Add new product</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
  ");
            WriteLiteral(@"                      <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label for=""newCategory"">New category</label>
                        <input type=""text"" class=""form-control"" name=""newCategory"" id=""newCategory"" placeholder=""Enter new category name""");
            BeginWriteAttribute("required", " required=\"", 5119, "\"", 5130, 0);
            EndWriteAttribute();
            WriteLiteral(@"> 
                    </div>
                </div>
                <i id=""alter"" style=""color:red""></i>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"" onclick=""handleSaveCategory();"" >Save changes</button>
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                </div>
            </div>
        </div>
    </div>



</div>




<script>
    function submitForm() {
        if (document.getElementById('name').value != """" && document.getElementById('country').value != """"
            && document.getElementById('description').value != """")
        {
            document.getElementById('addForm').submit();
        } else {
            document.getElementById('alter').innerHTML = ""You must input all feild!"";
        }
    }

    function handleSaveCategory() {

        var category = document.getElementById('newCategory').value;
        var se");
            WriteLiteral(@"lectCategory = document.getElementById('category');
        $.ajax({
            url: '/ProductManage/AddNewCategory',
            type: 'POST',
            data: {
                newCategory: category
            },
            success: function (response) {
                if (response == ""Category was existed"") {
                    alert('The category name was existed!');
                } else {
                    selectCategory.innerHTML += response;
                    alert(""Add new category success!"");
                }
            },
            error: function () {
                alert('Faild');
            }
        });

    }
</script>

");
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
