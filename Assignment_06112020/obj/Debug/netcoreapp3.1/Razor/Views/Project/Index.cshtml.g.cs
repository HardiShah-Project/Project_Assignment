#pragma checksum "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40ab220e7771e0de32f276d3d2bc75fec2b5a1d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Index), @"mvc.1.0.view", @"/Views/Project/Index.cshtml")]
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
#line 1 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40ab220e7771e0de32f276d3d2bc75fec2b5a1d5", @"/Views/Project/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3188605b9247d96386952e977817c885180ca278", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Assignment_06112020.Models.EmpProject>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 6 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_ProjectLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 12 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
     using (Html.BeginForm("Index", "Project", FormMethod.Get))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"search\">\r\n            Search By: ");
#nullable restore
#line 15 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
                  Write(Html.RadioButton("searchBy", "Name", true));

#line default
#line hidden
#nullable disable
            WriteLiteral("<text>Name</text>\r\n            ");
#nullable restore
#line 16 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
       Write(Html.RadioButton("searchBy", "Technologies"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<text>Technologies</text>\r\n            ");
#nullable restore
#line 17 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
       Write(Html.TextBox("search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <input type=\"submit\" value=\"Search\" id=\"submit\" class=\"btn btn-info\" />\r\n        </p>\r\n");
#nullable restore
#line 20 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""col-md-12"">
        <div class=""shadow-lg p-3 mb-5 bg-white rounded"" id=""shadow"">
            <a class=""btn btn-primary"" id=""addButton"" href=""/Project/Create""><i class=""fa fa-plus""></i> Add New</a>
            <div class=""table-responsive"">
                <table class=""table table-striped table-bordered"" style=""width:100%"" ;>
                    <thead>
                        <tr class=""link"">
                            <th>
                                ");
#nullable restore
#line 29 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
                           Write(Html.ActionLink("Name", "Index", new { sort = ViewBag.SortByName, searchBy = Context.Request.Query["searchBy"].ToString(), search = Context.Request.Query["search"].ToString() }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 32 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
                           Write(Html.ActionLink("StartDate", "Index", new { sort = ViewBag.SortByStartDate }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 35 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
                           Write(Html.ActionLink("EndDate", "Index", new { sort = ViewBag.SortByEndDate }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 38 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
                           Write(Html.ActionLink("Technologies", "Index", new { sort = ViewBag.SortByTechnologies, searchBy = Context.Request.Query["searchBy"].ToString(), search = Context.Request.Query["search"].ToString() }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </th>\r\n                            <th>Edit</th>\r\n                            <th>Delete</th>\r\n                        </tr>\r\n                    </thead>\r\n\r\n                    <tbody>\r\n");
#nullable restore
#line 46 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
                         if (Model.Count() == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td colspan=\"6\"> Records not found </td>\r\n                            </tr>\r\n");
#nullable restore
#line 51 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
                        }
                        else
                        {
                            foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr");
            BeginWriteAttribute("id", " id=\"", 2636, "\"", 2655, 2);
            WriteAttributeValue("", 2641, "row_", 2641, 4, true);
#nullable restore
#line 56 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
WriteAttributeValue("", 2645, item.Code, 2645, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 58 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Name, new { id = "txtName" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 61 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.StartDate, new { id = "txtStartDate" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 64 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.EndDate, new { id = "txtEndDate" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 67 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Technologies, new { id = "txtTechnologies" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 3563, "\"", 3594, 2);
            WriteAttributeValue("", 3570, "/Project/Edit/", 3570, 14, true);
#nullable restore
#line 70 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
WriteAttributeValue("", 3584, item.Code, 3584, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-pencil-square-o fa-2x \"></i></a>\r\n                                    </td>\r\n                                    <td>\r\n                                        <a class=\"btn btn-danger\" href=\"#\" id=\"Confirmdelete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3825, "\"", 3860, 3);
            WriteAttributeValue("", 3835, "Confirmdelete(", 3835, 14, true);
#nullable restore
#line 73 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
WriteAttributeValue("", 3849, item.Code, 3849, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3859, ")", 3859, 1, true);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fa fa-trash-o fa-2x\"></i> </a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 76 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n\r\n                </table>\r\n            </div>\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "40ab220e7771e0de32f276d3d2bc75fec2b5a1d513047", async() => {
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
            WriteLiteral("\r\n        <input type=\"hidden\" id=\"hiddenId\" />\r\n        ");
#nullable restore
#line 85 "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\Index.cshtml"
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
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Assignment_06112020.Models.EmpProject>> Html { get; private set; }
    }
}
#pragma warning restore 1591
