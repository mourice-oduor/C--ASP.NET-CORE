#pragma checksum "C:\Users\USER\Desktop\asp.net-core\code\16.ViewComponents\ViewComponents\Views\Shared\Components\ProductSummary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6a45d1be67aa0091478fc91625b799775a9dc07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProductSummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProductSummary/Default.cshtml")]
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
#line 1 "C:\Users\USER\Desktop\asp.net-core\code\16.ViewComponents\ViewComponents\Views\_ViewImports.cshtml"
using ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Desktop\asp.net-core\code\16.ViewComponents\ViewComponents\Views\_ViewImports.cshtml"
using ViewComponents.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6a45d1be67aa0091478fc91625b799775a9dc07", @"/Views/Shared/Components/ProductSummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dedcea600fc6ed40525e8f8b6d5616ea251b170e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ProductSummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewComponents.Models.ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\USER\Desktop\asp.net-core\code\16.ViewComponents\ViewComponents\Views\Shared\Components\ProductSummary\Default.cshtml"
  
    ViewData["Title"] = "Default";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Default</h1>\r\n\r\n<div>\r\n    <h4>ProductViewModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\USER\Desktop\asp.net-core\code\16.ViewComponents\ViewComponents\Views\Shared\Components\ProductSummary\Default.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductsCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\USER\Desktop\asp.net-core\code\16.ViewComponents\ViewComponents\Views\Shared\Components\ProductSummary\Default.cshtml"
       Write(Html.DisplayFor(model => model.ProductsCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\USER\Desktop\asp.net-core\code\16.ViewComponents\ViewComponents\Views\Shared\Components\ProductSummary\Default.cshtml"
       Write(Html.DisplayNameFor(model => model.StockWorth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\USER\Desktop\asp.net-core\code\16.ViewComponents\ViewComponents\Views\Shared\Components\ProductSummary\Default.cshtml"
       Write(Html.DisplayFor(model => model.StockWorth));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewComponents.Models.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
