#pragma checksum "C:\Users\Administrator\service-fabric-mesh\src\todolistapp\WebFrontEnd\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2a0d73ca75e08b403414ff6a87ce1a225ac6026"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebFrontEnd.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(WebFrontEnd.Pages.Pages_Index), null)]
namespace WebFrontEnd.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Administrator\service-fabric-mesh\src\todolistapp\WebFrontEnd\Pages\_ViewImports.cshtml"
using WebFrontEnd;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2a0d73ca75e08b403414ff6a87ce1a225ac6026", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a515bc4757ee3c308bfbba12dcca2ffaa04e90a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Administrator\service-fabric-mesh\src\todolistapp\WebFrontEnd\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 239, true);
            WriteLiteral("\r\n<div>\r\n    <table class=\"table-bordered\">\r\n        <thead>\r\n            <tr>\r\n                <th>Description</th>\r\n                <th>Category</th>\r\n                <th>Done?</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 17 "C:\Users\Administrator\service-fabric-mesh\src\todolistapp\WebFrontEnd\Pages\Index.cshtml"
             foreach (var item in Model.Items)
            {

#line default
#line hidden
            BeginContext(373, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(412, 16, false);
#line 20 "C:\Users\Administrator\service-fabric-mesh\src\todolistapp\WebFrontEnd\Pages\Index.cshtml"
               Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(428, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(456, 13, false);
#line 21 "C:\Users\Administrator\service-fabric-mesh\src\todolistapp\WebFrontEnd\Pages\Index.cshtml"
               Write(item.Category);

#line default
#line hidden
            EndContext();
            BeginContext(469, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(497, 14, false);
#line 22 "C:\Users\Administrator\service-fabric-mesh\src\todolistapp\WebFrontEnd\Pages\Index.cshtml"
               Write(item.Completed);

#line default
#line hidden
            EndContext();
            BeginContext(511, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 24 "C:\Users\Administrator\service-fabric-mesh\src\todolistapp\WebFrontEnd\Pages\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(552, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
