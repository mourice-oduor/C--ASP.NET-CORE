#pragma checksum "C:\Users\USER\Desktop\asp.net-core\code\ErrorHandling\ErrorHandling\Views\Shared\ErrorMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c568e70f5032287df32a9e89226918c4c4b2e37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ErrorMessage), @"mvc.1.0.view", @"/Views/Shared/ErrorMessage.cshtml")]
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
#line 1 "C:\Users\USER\Desktop\asp.net-core\code\ErrorHandling\ErrorHandling\Views\_ViewImports.cshtml"
using ErrorHandling;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Desktop\asp.net-core\code\ErrorHandling\ErrorHandling\Views\_ViewImports.cshtml"
using ErrorHandling.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c568e70f5032287df32a9e89226918c4c4b2e37", @"/Views/Shared/ErrorMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0429e6d2e4aa29af35a8700ec385cc7c66f32ee0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ErrorMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Exception>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\USER\Desktop\asp.net-core\code\ErrorHandling\ErrorHandling\Views\Shared\ErrorMessage.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-danger\">I am from this custom error page.</h1>\r\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n");
            WriteLiteral("\r\n\r\n<p><strong>Message :</strong> <code>");
#nullable restore
#line 19 "C:\Users\USER\Desktop\asp.net-core\code\ErrorHandling\ErrorHandling\Views\Shared\ErrorMessage.cshtml"
                               Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code></p>\r\n<p><strong>StackTrace :</strong> <code>");
#nullable restore
#line 20 "C:\Users\USER\Desktop\asp.net-core\code\ErrorHandling\ErrorHandling\Views\Shared\ErrorMessage.cshtml"
                                  Write(Model.StackTrace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code></p>\r\n<p><strong>Source :</strong> <code>");
#nullable restore
#line 21 "C:\Users\USER\Desktop\asp.net-core\code\ErrorHandling\ErrorHandling\Views\Shared\ErrorMessage.cshtml"
                              Write(Model.Source);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code></p>\r\n<p><strong>GetBaseException :</strong> <code>");
#nullable restore
#line 22 "C:\Users\USER\Desktop\asp.net-core\code\ErrorHandling\ErrorHandling\Views\Shared\ErrorMessage.cshtml"
                                        Write(Model.GetBaseException());

#line default
#line hidden
#nullable disable
            WriteLiteral("</code></p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exception> Html { get; private set; }
    }
}
#pragma warning restore 1591
