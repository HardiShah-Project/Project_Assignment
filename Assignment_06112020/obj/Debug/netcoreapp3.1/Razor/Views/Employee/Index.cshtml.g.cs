#pragma checksum "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6869ef98398830b4177020d07d0658d8a0394085"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#nullable restore
#line 1 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6869ef98398830b4177020d07d0658d8a0394085", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3188605b9247d96386952e977817c885180ca278", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Assignment_06112020.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_EmpDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-md-12\">\r\n");
#nullable restore
#line 13 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
     using (Html.BeginForm("Index", "Employee", FormMethod.Get))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"search\">\r\n            Search By: ");
#nullable restore
#line 16 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
                  Write(Html.RadioButton("searchBy", "Name", true));

#line default
#line hidden
#nullable disable
            WriteLiteral("<text>Name</text>\r\n            ");
#nullable restore
#line 17 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
       Write(Html.RadioButton("searchBy", "Skils"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<text>Skils</text>\r\n            ");
#nullable restore
#line 18 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
       Write(Html.TextBox("search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <input type=\"submit\" value=\"Search\" id=\"submit\" class=\"btn btn-info\" />\r\n        </p>\r\n");
#nullable restore
#line 21 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""shadow-lg p-3 mb-5 bg-white rounded"">
        <a class=""btn btn-primary"" id=""addButton"" href=""/Employee/Create""><i class=""fa fa-plus""></i> Add New</a>
        <div class=""table-responsive"">
            <table class=""table table-striped table-bordered"" style=""width:100%"" ;>
                <thead>
                    <tr class=""link"">
                        <th>
                            ");
#nullable restore
#line 29 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
                       Write(Html.ActionLink("Name", "Index", new { sort = ViewBag.SortByName, searchBy = Context.Request.Query["searchBy"].ToString(), search = Context.Request.Query["search"].ToString() }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 32 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
                       Write(Html.ActionLink("JoiningDate", "Index", new { sort = ViewBag.SortByJoiningDate }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 35 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
                       Write(Html.ActionLink("ReleaseDate", "Index", new { sort = ViewBag.SortByReleaseDate }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 38 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
                       Write(Html.ActionLink("Employee's Skils", "Index", new { sort = ViewBag.SortBySkils, searchBy = Context.Request.Query["searchBy"].ToString(), search = Context.Request.Query["search"].ToString() }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>Edit</th>\r\n                        <th>Delete</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n                <tbody>\r\n");
#nullable restore
#line 46 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
                     if (Model.Count() == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td colspan=\"6\"> Records not found </td>\r\n                        </tr>\r\n");
#nullable restore
#line 51 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("id", " id=\"", 2475, "\"", 2494, 2);
            WriteAttributeValue("", 2480, "row_", 2480, 4, true);
#nullable restore
#line 56 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
WriteAttributeValue("", 2484, item.Code, 2484, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                                <td>\r\n                                    ");
#nullable restore
#line 59 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Name, new { id = "txtName" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 62 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.JoiningDate, new { id = "txtJoiningDate" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 65 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ReleaseDate, new { id = "txtReleaseDate" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 68 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Skils, new { id = "txtSkils" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 3346, "\"", 3378, 2);
            WriteAttributeValue("", 3353, "/Employee/Edit/", 3353, 15, true);
#nullable restore
#line 71 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
WriteAttributeValue("", 3368, item.Code, 3368, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-pencil-square-o fa-2x \"></i></a>\r\n                                </td>\r\n                                <td>\r\n                                    <a class=\"btn btn-danger\" href=\"#\" id=\"ConfirmDelete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3597, "\"", 3632, 3);
            WriteAttributeValue("", 3607, "ConfirmDelete(", 3607, 14, true);
#nullable restore
#line 74 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
WriteAttributeValue("", 3621, item.Code, 3621, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3631, ")", 3631, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-trash-o fa-2x\"></i> </a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 77 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6869ef98398830b4177020d07d0658d8a039408513184", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <input type=\"hidden\" id=\"hiddenId\" />\r\n    ");
#nullable restore
#line 85 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Employee\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new
        {
           page,
           searchBy = Context.Request.Query["searchBy"].ToString(),
           search = Context.Request.Query["search"].ToString(),
           sort = Context.Request.Query["sort"].ToString()
        }), new PagedListRenderOptionsBase()
         {
               Display = PagedListDisplayMode.IfNeeded,
               DisplayPageCountAndCurrentLocation = true,
               DisplayItemSliceAndTotal = true
          }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Assignment_06112020.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
