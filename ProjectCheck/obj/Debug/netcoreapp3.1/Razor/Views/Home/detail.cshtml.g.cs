#pragma checksum "C:\PROGRAM_D\งาน\Pcheck\ProjectCheck\Views\Home\detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9be98f39064c31ac5c8ff755b03f737b167356e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_detail), @"mvc.1.0.view", @"/Views/Home/detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9be98f39064c31ac5c8ff755b03f737b167356e5", @"/Views/Home/detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5591ff81c6b69df4553dd49d0364559071db36dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectCheck.Models.insertdata>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\PROGRAM_D\งาน\Pcheck\ProjectCheck\Views\Home\detail.cshtml"
  
    ViewData["Title"] = "detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    body {
        padding: 20px;
        font-family: 'Open Sans', sans-serif;
        background-color: #f7f7f7;
    }

    .lib-panel {
        margin-bottom: 20Px;
    }

        .lib-panel img {
            width: 100%;
            background-color: transparent;
        }

        .lib-panel .row,
        .lib-panel .col-md-6 {
            padding: 0;
            background-color: #FFFFFF;
        }


        .lib-panel .lib-row {
            padding: 0 20px 0 20px;
        }

            .lib-panel .lib-row.lib-header {
                background-color: #FFFFFF;
                font-size: 20px;
                padding: 10px 20px 0 20px;
            }

                .lib-panel .lib-row.lib-header .lib-header-seperator {
                    height: 2px;
                    width: 26px;
                    background-color: #d9d9d9;
                    margin: 7px 0 7px 0;
                }

            .lib-panel .lib-row.lib-desc {
                positi");
            WriteLiteral(@"on: relative;
                height: 100%;
                display: block;
                font-size: 13px;
            }

                .lib-panel .lib-row.lib-desc a {
                    position: absolute;
                    width: 100%;
                    bottom: 10px;
                    left: 20px;
                }

    .row-margin-bottom {
        margin-bottom: 20px;
    }

    .box-shadow {
        -webkit-box-shadow: 0 0 10px 0 rgba(0,0,0,.10);
        box-shadow: 0 0 10px 0 rgba(0,0,0,.10);
    }

    .no-padding {
        padding: 0;
    }
</style>

<div class=""container"">
    <h2>รายละเอียด</h2>
    <hr>
    <div class=""row row-margin-bottom"">
        <div class=""col-md-5 no-padding lib-item"" data-category=""view"">
            <div class=""lib-panel"">
                <div class=""row box-shadow"">
                    <div class=""col-md-6"">
                        <img class=""lib-img-show""");
            BeginWriteAttribute("src", " src=\"", 2106, "\"", 2152, 1);
#nullable restore
#line 83 "C:\PROGRAM_D\งาน\Pcheck\ProjectCheck\Views\Home\detail.cshtml"
WriteAttributeValue("", 2112, Html.DisplayFor(model => model.pictrue), 2112, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"lib-row lib-header\">\r\n                           <b> ");
#nullable restore
#line 87 "C:\PROGRAM_D\งาน\Pcheck\ProjectCheck\Views\Home\detail.cshtml"
                          Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                            <div class=\"lib-header-seperator\"></div>\r\n                        </div>\r\n                        <div class=\"lib-row lib-desc\">\r\n                            ");
#nullable restore
#line 91 "C:\PROGRAM_D\งาน\Pcheck\ProjectCheck\Views\Home\detail.cshtml"
                       Write(Html.DisplayFor(model => model.detail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <div>\r\n                                <h3>ราคา: ");
#nullable restore
#line 93 "C:\PROGRAM_D\งาน\Pcheck\ProjectCheck\Views\Home\detail.cshtml"
                                     Write(Html.DisplayFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            </div>\r\n                        </div>\r\n                        \r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectCheck.Models.insertdata> Html { get; private set; }
    }
}
#pragma warning restore 1591
