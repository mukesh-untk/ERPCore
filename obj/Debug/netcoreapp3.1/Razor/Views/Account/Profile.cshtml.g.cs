#pragma checksum "D:\Sample\ERPCore\Views\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c237358330c5ffe83fb0071ef3dba6d6dd12252a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c237358330c5ffe83fb0071ef3dba6d6dd12252a", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a94fa627cdcae7a87ea4c19677bcbbd17f57b33e", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IdentityUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Account/Profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\Sample\ERPCore\Views\Account\Profile.cshtml"
  
    ViewBag.Title = "Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row profile"">
    <div class=""col-md-3 bcolor"">
        <div class=""profile-sidebar mt-2"">
            <!-- SIDEBAR USERPIC -->
            <div class=""profile-userpic text-center"">
                <img src=""https://api.adorable.io/avatars/285/abott@adorable.png"" class=""img-responsive""");
            BeginWriteAttribute("alt", " alt=\"", 363, "\"", 369, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            <!-- END SIDEBAR USERPIC -->\r\n            <!-- SIDEBAR USER TITLE -->\r\n            <div class=\"profile-usertitle\">\r\n                <div class=\"profile-usertitle-name\">\r\n                   ");
#nullable restore
#line 16 "D:\Sample\ERPCore\Views\Account\Profile.cshtml"
              Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"profile-usertitle-job\">\r\n                   \r\n                </div>\r\n            </div>\r\n            <!-- END SIDEBAR USER TITLE -->\r\n            <!-- SIDEBAR BUTTONS -->\r\n");
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-9 bcolor\">\r\n        <div class=\"profile-content mt-2\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 1203, "\"", 1211, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"alert\" role=\"alert\">\r\n                ");
#nullable restore
#line 34 "D:\Sample\ERPCore\Views\Account\Profile.cshtml"
           Write(Html.ValidationSummary(false, "", new { @class = "alert alert-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            Profile\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c237358330c5ffe83fb0071ef3dba6d6dd12252a6059", async() => {
                WriteLiteral("\r\n\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 40 "D:\Sample\ERPCore\Views\Account\Profile.cshtml"
               Write(Html.LabelFor(model => model.UserName, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <span class=\"text-danger\">*</span>\r\n                    ");
#nullable restore
#line 42 "D:\Sample\ERPCore\Views\Account\Profile.cshtml"
               Write(Html.EditorFor(model => model.UserName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 46 "D:\Sample\ERPCore\Views\Account\Profile.cshtml"
               Write(Html.LabelFor(model => model.PhoneNumber, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <span class=\"text-danger\">*</span>\r\n                    ");
#nullable restore
#line 48 "D:\Sample\ERPCore\Views\Account\Profile.cshtml"
               Write(Html.EditorFor(model => model.PhoneNumber, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 52 "D:\Sample\ERPCore\Views\Account\Profile.cshtml"
               Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 53 "D:\Sample\ERPCore\Views\Account\Profile.cshtml"
               Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control", disabled = "disabled" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group float-right\">\r\n                    <input type=\"submit\" value=\"Update\" class=\"btn btn-outline-primary\" />\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
