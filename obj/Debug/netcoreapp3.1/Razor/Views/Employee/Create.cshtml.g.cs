#pragma checksum "D:\Sample\ERPCore\Views\Employee\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d890bd84fb546f24301d4aecb2bb0f540d7b4633"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Create), @"mvc.1.0.view", @"/Views/Employee/Create.cshtml")]
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
#line 1 "D:\Sample\ERPCore\Views\_ViewImports.cshtml"
using ERPCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Sample\ERPCore\Views\_ViewImports.cshtml"
using ERPCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Sample\ERPCore\Views\_ViewImports.cshtml"
using ERPCore.TagHelpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Sample\ERPCore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d890bd84fb546f24301d4aecb2bb0f540d7b4633", @"/Views/Employee/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a94fa627cdcae7a87ea4c19677bcbbd17f57b33e", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ERPCore.ViewModels.EmployeeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
  
    ViewBag.Title = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"col-md-7\">\r\n");
#nullable restore
#line 9 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
                                    
            if (Model.Employee != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
           Write(Html.HiddenFor(model => model.Employee.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
                                                           ;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
           Write(Html.HiddenFor(model => model.Employee.Address.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
                                                                   ;
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>Employee</h2>\r\n            <hr />\r\n");
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 520, "\"", 528, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"alert\" role=\"alert\">\r\n                ");
#nullable restore
#line 22 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
           Write(Html.ValidationSummary(false, "", new { @class = "alert alert-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"row\">\r\n\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 29 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
                   Write(Html.LabelFor(model => model.Employee.FirstName, htmlAttributes: new { @class = "control-label", id = "fname" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"text-danger\">*</span>\r\n                        ");
#nullable restore
#line 31 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
                   Write(Html.EditorFor(model => model.Employee.FirstName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"col-md-6\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 37 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
                   Write(Html.LabelFor(model => model.Employee.LastName, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"text-danger\">*</span>\r\n                        ");
#nullable restore
#line 39 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
                   Write(Html.EditorFor(model => model.Employee.LastName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 45 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
           Write(Html.LabelFor(model => model.Employee.Email, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span class=\"text-danger\">*</span>\r\n                ");
#nullable restore
#line 47 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
           Write(Html.EditorFor(model => model.Employee.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 51 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
           Write(Html.LabelFor(model => model.Employee.Age, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span class=\"text-danger\">*</span>\r\n                ");
#nullable restore
#line 53 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
           Write(Html.EditorFor(model => model.Employee.Age, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 57 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
           Write(Html.LabelFor(model => model.Employee.Gender, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 58 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
           Write(Html.DropDownListFor(model => model.Employee.Gender, Html.GetEnumSelectList<Gender>(), "Gender", htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                <label");
            BeginWriteAttribute("for", " for=\"", 2740, "\"", 2746, 0);
            EndWriteAttribute();
            WriteLiteral(">Department</label> <br />\r\n                ");
#nullable restore
#line 63 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
           Write(Html.ListBoxFor(model => model.SelectedDepartments, Model.AllDepartments, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 68 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
           Write(Html.LabelFor(model => model.Employee.Address.Address1, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span class=\"text-danger\">*</span>\r\n                ");
#nullable restore
#line 70 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
           Write(Html.EditorFor(model => model.Employee.Address.Address1, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 73 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
           Write(Html.LabelFor(model => model.Employee.Address.Address2, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 74 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
           Write(Html.EditorFor(model => model.Employee.Address.Address2, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"row\">\r\n\r\n                <div class=\"col-md-4\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 81 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
                   Write(Html.LabelFor(model => model.Employee.Address.State, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"text-danger\">*</span>\r\n                        ");
#nullable restore
#line 83 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
                   Write(Html.EditorFor(model => model.Employee.Address.State, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"col-md-4\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 89 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
                   Write(Html.LabelFor(model => model.Employee.Address.City, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"text-danger\">*</span>\r\n                        ");
#nullable restore
#line 91 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
                   Write(Html.EditorFor(model => model.Employee.Address.City, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-4\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 96 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
                   Write(Html.LabelFor(model => model.Employee.Address.Zip, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span class=\"text-danger\">*</span>\r\n                        ");
#nullable restore
#line 98 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
                   Write(Html.EditorFor(model => model.Employee.Address.Zip, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <hr />\r\n");
#nullable restore
#line 104 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
            if (Model.Employee is null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group float-right\">\r\n                    <input type=\"submit\" value=\"Create\" onclick=\"goToTop()\" class=\"btn btn-outline-primary\" />\r\n                </div>\r\n");
#nullable restore
#line 109 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group float-right\">\r\n                    <input type=\"submit\" value=\"Update\" onclick=\"goToTop()\" class=\"btn btn-outline-primary\" />\r\n                </div>\r\n");
#nullable restore
#line 115 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n<div>\r\n    ");
#nullable restore
#line 119 "D:\Sample\ERPCore\Views\Employee\Create.cshtml"
Write(Html.ActionLink("« Back to List", "Index", "Employee", htmlAttributes: new { @class = "mx-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<div class=""loading"" id=""loading"">
    <div class=""center"">
        <div class=""spinner-border text-primary"" style=""width: 3rem; height: 3rem;"" role=""status"">
            <span class=""sr-only"">Loading...</span>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        function goToTop() {\r\n            $(\"#fname\").focus();\r\n            $(\"html, body\").animate({ scrollTop: 0 }, \"slow\");\r\n        }\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ERPCore.ViewModels.EmployeeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
