#pragma checksum "/Users/yangsuyeon/Projects/ATMWebApplication/ATMWebApplication/Views/Customers/Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e157e7ec5a4373c4f779e1e6e5c174bda710c682"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Welcome), @"mvc.1.0.view", @"/Views/Customers/Welcome.cshtml")]
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
#line 1 "/Users/yangsuyeon/Projects/ATMWebApplication/ATMWebApplication/Views/_ViewImports.cshtml"
using ATMWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/yangsuyeon/Projects/ATMWebApplication/ATMWebApplication/Views/_ViewImports.cshtml"
using ATMWebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e157e7ec5a4373c4f779e1e6e5c174bda710c682", @"/Views/Customers/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e58faaaf8cecc93e3ee745ac042daddd43fae02a", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/yangsuyeon/Projects/ATMWebApplication/ATMWebApplication/Views/Customers/Welcome.cshtml"
   ViewBag.Title = "Welcome"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Welcome ");
#nullable restore
#line 3 "/Users/yangsuyeon/Projects/ATMWebApplication/ATMWebApplication/Views/Customers/Welcome.cshtml"
       Write(ViewBag.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<p>\r\n    Name: ");
#nullable restore
#line 6 "/Users/yangsuyeon/Projects/ATMWebApplication/ATMWebApplication/Views/Customers/Welcome.cshtml"
     Write(ViewBag.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    Account Number: ");
#nullable restore
#line 8 "/Users/yangsuyeon/Projects/ATMWebApplication/ATMWebApplication/Views/Customers/Welcome.cshtml"
               Write(ViewBag.AccountNum);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    Balance: ");
#nullable restore
#line 10 "/Users/yangsuyeon/Projects/ATMWebApplication/ATMWebApplication/Views/Customers/Welcome.cshtml"
        Write(ViewBag.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</p>");
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