#pragma checksum "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9e4f1c43a94615cc7a2b1b172fe0946d8b1a88d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9e4f1c43a94615cc7a2b1b172fe0946d8b1a88d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51a18efd22d95d5bde5d9cc34cd1c9220a10f2ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SalonSpaBooking.BusinessLayer.ViewModels.ServicesPlanViewModels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(117, 57, true);
            WriteLiteral("\r\n<div class=\"text-right\" style=\"margin-top:10px;\">\r\n    ");
            EndContext();
            BeginContext(175, 99, false);
#line 7 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
Write(Html.ActionLink("Salon Appointment", "SalonAppointment", "Home", new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(274, 186, true);
            WriteLiteral("\r\n</div>\r\n<div class=\"text-center\" style=\"margin-top:10px;\">\r\n    <h4>Search Salon Services</h4>\r\n</div>\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>");
            EndContext();
            BeginContext(461, 36, false);
#line 15 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.PlanName));

#line default
#line hidden
            EndContext();
            BeginContext(497, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(521, 33, false);
#line 16 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Title));

#line default
#line hidden
            EndContext();
            BeginContext(554, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(578, 39, false);
#line 17 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Description));

#line default
#line hidden
            EndContext();
            BeginContext(617, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(641, 33, false);
#line 18 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.Price));

#line default
#line hidden
            EndContext();
            BeginContext(674, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(698, 37, false);
#line 19 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(m => m.ServiceId));

#line default
#line hidden
            EndContext();
            BeginContext(735, 78, true);
            WriteLiteral("</th>\r\n            <th>Action</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 24 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
         if (Model.PageCount() == 0)
        {

#line default
#line hidden
            BeginContext(862, 133, true);
            WriteLiteral("            <tr>\r\n                <td style=\"color:red;\" colspan=\"12\">\r\n                    Records not found |\r\n                    ");
            EndContext();
            BeginContext(996, 86, false);
#line 29 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
               Write(Html.ActionLink("Go To Home", "Index", "Medicine", new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(1082, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 32 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
        }
        else
        {
            

#line default
#line hidden
#line 35 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
             foreach (var product in Model.PaginatedServicesPlan())
            {

#line default
#line hidden
            BeginContext(1246, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(1269, 16, false);
#line 38 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
       Write(product.PlanName);

#line default
#line hidden
            EndContext();
            BeginContext(1285, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1305, 13, false);
#line 39 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
       Write(product.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1318, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1338, 19, false);
#line 40 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
       Write(product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1357, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1377, 87, false);
#line 41 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
       Write(product.Price.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("hi-IN")));

#line default
#line hidden
            EndContext();
            BeginContext(1464, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1484, 17, false);
#line 42 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
       Write(product.ServiceId);

#line default
#line hidden
            EndContext();
            BeginContext(1501, 33, true);
            WriteLiteral("</td>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1535, 106, false);
#line 44 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
       Write(Html.ActionLink("Details", "Details", "Home", new { PlanId = product.PlanId, @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(1641, 28, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 47 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#line 47 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1695, 49, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<ul class=\"pagination\">\r\n");
            EndContext();
#line 52 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
     for (int i = 1; i <= Model.PageCount(); i++)
    {

#line default
#line hidden
            BeginContext(1802, 11, true);
            WriteLiteral("        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1813, "\"", 1881, 1);
#line 54 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
WriteAttributeValue("", 1821, i == Model.CurrentPage ? "page-item active" : "page-item", 1821, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1882, 35, true);
            WriteLiteral(">\r\n            <a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1917, "\"", 1962, 1);
#line 55 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
WriteAttributeValue("", 1924, Url.Action("Index", new { page = i }), 1924, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1963, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1965, 1, false);
#line 55 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
                                                                          Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1966, 21, true);
            WriteLiteral("</a>\r\n        </li>\r\n");
            EndContext();
#line 57 "D:\IIHT\Task-13\InMemory\SalonSpaBooking\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1994, 7, true);
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SalonSpaBooking.BusinessLayer.ViewModels.ServicesPlanViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
