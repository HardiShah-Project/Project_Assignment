#pragma checksum "D:\Training\Assignment_06112020\Assignment_06112020\Views\Project\_Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7858840f9e965e28d1ed6a525b49ab6f2e0c4a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project__Delete), @"mvc.1.0.view", @"/Views/Project/_Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7858840f9e965e28d1ed6a525b49ab6f2e0c4a3", @"/Views/Project/_Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3188605b9247d96386952e977817c885180ca278", @"/Views/_ViewImports.cshtml")]
    public class Views_Project__Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""modal fade"" id=""MyModal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <a href=""#"" class=""close"" style=""margin-right:-469px;"" data-dismiss=""modal"">&times;</a>
                <h4 class=""modal-title"" style=""margin-right:99px;"">Delete Employee's Project Record</h4>
            </div>
            <div class=""modal-body"">
                <h4>Are You Sure?You Want To Delete This Record.</h4>
            </div>
            <div class=""modal-footer"">
                <a href=""#"" class=""btn btn-default"" data-dismiss=""modal"">Cancel</a>
                <a href=""#"" class=""btn btn-success"" onclick=""DeleteEmpProject()"">Confirm</a>
            </div>
        </div>
    </div>
</div>");
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