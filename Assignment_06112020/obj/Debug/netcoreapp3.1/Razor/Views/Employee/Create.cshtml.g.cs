#pragma checksum "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57df37c7bab8673e15ef359380ba78e68d974541"
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
#line 1 "D:\Training\Assignment_06112020\Assignment_06112020\Views\_ViewImports.cshtml"
using Assignment_06112020;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Training\Assignment_06112020\Assignment_06112020\Views\_ViewImports.cshtml"
using Assignment_06112020.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57df37c7bab8673e15ef359380ba78e68d974541", @"/Views/Employee/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3188605b9247d96386952e977817c885180ca278", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Assignment_06112020.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        ");
#nullable restore
#line 14 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Create.cshtml"
   Write(Html.HiddenFor(model => model.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 15 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"col-md-10\">\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 19 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Create.cshtml"
           Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Create.cshtml"
           Write(Html.TextBoxFor(model => model.Name, new { @class = "form-control", @id = "txtName" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-md-10\">\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 27 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Create.cshtml"
           Write(Html.LabelFor(model => model.JoiningDate, htmlAttributes: new { @class = "control-label " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 28 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Create.cshtml"
           Write(Html.TextBoxFor(model => model.JoiningDate, new { @class = "form-control datepicker", @id = "txtJoiningDate" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span class=\"input-group-addon\" style=\"margin-left:872px;margin-top:-26px;\"><i class=\"fa fa-calendar\"></i></span>\r\n                ");
#nullable restore
#line 30 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.JoiningDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"col-md-10\">\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 36 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Create.cshtml"
           Write(Html.LabelFor(model => model.ReleaseDate, htmlAttributes: new { @class = "control-label " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 37 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Create.cshtml"
           Write(Html.TextBoxFor(model => model.ReleaseDate, new { @class = "form-control datepicker", @id = "txtReleaseDate" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 38 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.JoiningDate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <span class=""input-group-addon"" style=""margin-left:872px;margin-top:-26px;""><i class=""fa fa-calendar""></i></span>
            </div>
        </div>

        <div class=""col-md-10"">
            <div class=""form-group"">
                ");
#nullable restore
#line 45 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Create.cshtml"
           Write(Html.LabelFor(model => model.Skils, htmlAttributes: new { @class = "control-label " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 46 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Create.cshtml"
           Write(Html.DropDownListFor(m => m.Skils, new SelectList(Model.SkilList.Items, "SkilName", "SkilName"), new { @class = "form-control ", @id = "txtSkils" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                ");
#nullable restore
#line 48 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Skils, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Submit"" id=""submit1"" class=""btn btn-primary"" />
            </div>
        </div>
    </div>
");
#nullable restore
#line 57 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assignment_06112020.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
