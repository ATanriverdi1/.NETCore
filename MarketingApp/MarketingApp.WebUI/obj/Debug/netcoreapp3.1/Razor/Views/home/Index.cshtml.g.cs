#pragma checksum "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3d857f97849bf155308637f8e60c319c611f39f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_home_Index), @"mvc.1.0.view", @"/Views/home/Index.cshtml")]
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
#line 1 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\_ViewImports.cshtml"
using MarketingApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\_ViewImports.cshtml"
using MarketingApp.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\_ViewImports.cshtml"
using MarketingApp.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\_ViewImports.cshtml"
using MarketingApp.WebUI.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\_ViewImports.cshtml"
using MarketingApp.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\_ViewImports.cshtml"
using MarketingApp.WebUI.ViewModel.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\_ViewImports.cshtml"
using MarketingApp.WebUI.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3d857f97849bf155308637f8e60c319c611f39f", @"/Views/home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62e906d511a825ed9d0b7930e85471fb5839e54c", @"/Views/_ViewImports.cshtml")]
    public class Views_home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\home\Index.cshtml"
Write(await Html.PartialAsync("_header"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 7 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\home\Index.cshtml"
   Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    \r\n");
#nullable restore
#line 10 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\home\Index.cshtml"
     if (Model.Products.Count==0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\home\Index.cshtml"
   Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\home\Index.cshtml"
                                              
    }
    else{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-9\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 17 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\home\Index.cshtml"
                 foreach (var product in Model.Products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4\">\r\n                        ");
#nullable restore
#line 20 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\home\Index.cshtml"
                   Write(await Html.PartialAsync("_product",product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 22 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n");
#nullable restore
#line 25 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    \r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
