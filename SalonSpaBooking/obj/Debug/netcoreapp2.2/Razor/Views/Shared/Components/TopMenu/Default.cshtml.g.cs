#pragma checksum "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Shared\Components\TopMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "405d5ca3cfee7837f3e97650b24c54f11f6500db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TopMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TopMenu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_TopMenu_Default))]
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
#line 1 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\_ViewImports.cshtml"
using SalonSpaBooking;

#line default
#line hidden
#line 2 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\_ViewImports.cshtml"
using SalonSpaBooking.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"405d5ca3cfee7837f3e97650b24c54f11f6500db", @"/Views/Shared/Components/TopMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51a18efd22d95d5bde5d9cc34cd1c9220a10f2ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<SalonSpaBooking.Entities.SalonServices>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 388, true);
            WriteLiteral(@"<div class=""collapse navbar-collapse"" id=""navbarsExampleDefault"">
    <ul class=""navbar-nav mr-auto"">
        <li class=""nav-item dropdown"">
            <a class=""nav-link dropdown-toggle"" href=""http://example.com"" id=""dropdown01"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">All Services</a>
            <div class=""dropdown-menu"" aria-labelledby=""dropdown01"">
");
            EndContext();
#line 7 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Shared\Components\TopMenu\Default.cshtml"
                 foreach (var item in Model)
                {
                    var url = item.Url;
                    var target = "_self";

                    if (url.StartsWith("~"))
                    {
                        url = Url.Content(url);
                    }
                    if (item.OpenInNewWindow)
                    {
                        target = "_blank";
                    }

#line default
#line hidden
            BeginContext(871, 49, true);
            WriteLiteral("                    <a class=\"nav-link text-dark\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 920, "\"", 931, 1);
#line 20 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 927, url, 927, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("target", " target=\"", 932, "\"", 948, 1);
#line 20 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 941, target, 941, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(949, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(951, 9, false);
#line 20 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Shared\Components\TopMenu\Default.cshtml"
                                                                          Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(960, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 21 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Shared\Components\TopMenu\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(985, 52, true);
            WriteLiteral("            </div>\r\n        </li>\r\n    </ul>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<SalonSpaBooking.Entities.SalonServices>> Html { get; private set; }
    }
}
#pragma warning restore 1591
