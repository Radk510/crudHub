#pragma checksum "D:\LEARN\stuffINFO\Front\CrudWebAPIplusMVC\CrudHub\CrudHub.WebClient\Views\Employee\UpdateEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "614de0d551b32dcc29894d79f6b5b3f8b45bb214"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_UpdateEmployee), @"mvc.1.0.view", @"/Views/Employee/UpdateEmployee.cshtml")]
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
#line 1 "D:\LEARN\stuffINFO\Front\CrudWebAPIplusMVC\CrudHub\CrudHub.WebClient\Views\_ViewImports.cshtml"
using CrudHub.WebClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\LEARN\stuffINFO\Front\CrudWebAPIplusMVC\CrudHub\CrudHub.WebClient\Views\_ViewImports.cshtml"
using CrudHub.WebClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"614de0d551b32dcc29894d79f6b5b3f8b45bb214", @"/Views/Employee/UpdateEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ffed847ef70abf26572d584bcec75aee4301917", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_UpdateEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<mvcEmployeeModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\LEARN\stuffINFO\Front\CrudWebAPIplusMVC\CrudHub\CrudHub.WebClient\Views\Employee\UpdateEmployee.cshtml"
  
    ViewData["Title"] = "UpdateEmployee";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Start of CRUD FORMS -->\r\n<div class=\"section-adminPannel-wrapper__createForm\">\r\n    <div class=\"section-adminPannel-wrapper__createForm-title\">\r\n        Update employee\r\n    </div>\r\n");
#nullable restore
#line 11 "D:\LEARN\stuffINFO\Front\CrudWebAPIplusMVC\CrudHub\CrudHub.WebClient\Views\Employee\UpdateEmployee.cshtml"
     using (Html.BeginForm("UpdateEmployee", "Employee", FormMethod.Post, new { @class = "section-adminPannel-wrapper__createForm-form" }))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\LEARN\stuffINFO\Front\CrudWebAPIplusMVC\CrudHub\CrudHub.WebClient\Views\Employee\UpdateEmployee.cshtml"
   Write(Html.HiddenFor(model => model.EmployeeId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\LEARN\stuffINFO\Front\CrudWebAPIplusMVC\CrudHub\CrudHub.WebClient\Views\Employee\UpdateEmployee.cshtml"
   Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { placeholder = "Name" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\LEARN\stuffINFO\Front\CrudWebAPIplusMVC\CrudHub\CrudHub.WebClient\Views\Employee\UpdateEmployee.cshtml"
   Write(Html.ValidationMessageFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\LEARN\stuffINFO\Front\CrudWebAPIplusMVC\CrudHub\CrudHub.WebClient\Views\Employee\UpdateEmployee.cshtml"
   Write(Html.EditorFor(model => model.Position, new { htmlAttributes = new { placeholder = "Position" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\LEARN\stuffINFO\Front\CrudWebAPIplusMVC\CrudHub\CrudHub.WebClient\Views\Employee\UpdateEmployee.cshtml"
   Write(Html.ValidationMessageFor(model => model.Position));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\LEARN\stuffINFO\Front\CrudWebAPIplusMVC\CrudHub\CrudHub.WebClient\Views\Employee\UpdateEmployee.cshtml"
   Write(Html.EditorFor(model => model.Age, new { htmlAttributes = new { placeholder = "Age" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\LEARN\stuffINFO\Front\CrudWebAPIplusMVC\CrudHub\CrudHub.WebClient\Views\Employee\UpdateEmployee.cshtml"
   Write(Html.ValidationMessageFor(model => model.Age));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\LEARN\stuffINFO\Front\CrudWebAPIplusMVC\CrudHub\CrudHub.WebClient\Views\Employee\UpdateEmployee.cshtml"
   Write(Html.EditorFor(model => model.Salary, new { htmlAttributes = new { placeholder = "Salary" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\LEARN\stuffINFO\Front\CrudWebAPIplusMVC\CrudHub\CrudHub.WebClient\Views\Employee\UpdateEmployee.cshtml"
   Write(Html.ValidationMessageFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"section-adminPannel-wrapper__createForm-form-btn\">\r\n            <button class=\"create\" type=\"submit\">Update</button>\r\n            ");
#nullable restore
#line 29 "D:\LEARN\stuffINFO\Front\CrudWebAPIplusMVC\CrudHub\CrudHub.WebClient\Views\Employee\UpdateEmployee.cshtml"
       Write(Html.ActionLink("Cancel", "Index", new { }, new { @class = "cancel" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 31 "D:\LEARN\stuffINFO\Front\CrudWebAPIplusMVC\CrudHub\CrudHub.WebClient\Views\Employee\UpdateEmployee.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<!-- End of CRUD FORMS -->\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "614de0d551b32dcc29894d79f6b5b3f8b45bb2148085", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "614de0d551b32dcc29894d79f6b5b3f8b45bb2149184", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mvcEmployeeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
