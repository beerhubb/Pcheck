#pragma checksum "C:\PROGRAM_D\งาน\Pcheck\ProjectCheck\Views\Home\det.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "981d69012f279a8d6b533e61165c33973a4d9af1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_det), @"mvc.1.0.view", @"/Views/Home/det.cshtml")]
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
#line 1 "C:\PROGRAM_D\งาน\Pcheck\ProjectCheck\Views\_ViewImports.cshtml"
using ProjectCheck;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PROGRAM_D\งาน\Pcheck\ProjectCheck\Views\_ViewImports.cshtml"
using ProjectCheck.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"981d69012f279a8d6b533e61165c33973a4d9af1", @"/Views/Home/det.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5591ff81c6b69df4553dd49d0364559071db36dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_det : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectCheck.Models.AddAu>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\PROGRAM_D\งาน\Pcheck\ProjectCheck\Views\Home\det.cshtml"
  
    ViewData["Title"] = "det";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>อู่ที่ร่วมรายการ</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\PROGRAM_D\งาน\Pcheck\ProjectCheck\Views\Home\det.cshtml"
       Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\PROGRAM_D\งาน\Pcheck\ProjectCheck\Views\Home\det.cshtml"
       Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\PROGRAM_D\งาน\Pcheck\ProjectCheck\Views\Home\det.cshtml"
       Write(Html.DisplayNameFor(model => model.address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\PROGRAM_D\งาน\Pcheck\ProjectCheck\Views\Home\det.cshtml"
       Write(Html.DisplayFor(model => model.address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\PROGRAM_D\งาน\Pcheck\ProjectCheck\Views\Home\det.cshtml"
       Write(Html.DisplayNameFor(model => model.phon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\PROGRAM_D\งาน\Pcheck\ProjectCheck\Views\Home\det.cshtml"
       Write(Html.DisplayFor(model => model.phon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectCheck.Models.AddAu> Html { get; private set; }
    }
}
#pragma warning restore 1591
