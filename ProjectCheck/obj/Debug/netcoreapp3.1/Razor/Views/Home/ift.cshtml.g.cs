#pragma checksum "C:\PROGRAM_D\งาน\ProjectCheck\ProjectCheck\Views\Home\ift.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4113033854164cf24fe10df895c44ac6dd4c81b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ift), @"mvc.1.0.view", @"/Views/Home/ift.cshtml")]
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
#line 1 "C:\PROGRAM_D\งาน\ProjectCheck\ProjectCheck\Views\_ViewImports.cshtml"
using ProjectCheck;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PROGRAM_D\งาน\ProjectCheck\ProjectCheck\Views\_ViewImports.cshtml"
using ProjectCheck.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4113033854164cf24fe10df895c44ac6dd4c81b2", @"/Views/Home/ift.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5591ff81c6b69df4553dd49d0364559071db36dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ift : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\PROGRAM_D\งาน\ProjectCheck\ProjectCheck\Views\Home\ift.cshtml"
  
    ViewData["Title"] = "ift";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""container p-3 my-3 bg-dark text-white"">
        <h1 class=""text-center"">ต้องการเพิ่มข้อมูล?</h1>
        <br>
        <div class=""text-center"">
        <a href=""insert"" class=""btn btn-primary"" role=""button"">อะไหล่รถ&รถเข้าใหม่</a>
        <a href=""insertAu"" class=""btn btn-primary"" role=""button"">อู่ที่อยู่ใกล้เคียง</a>
            </div>
    </div>
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
