#pragma checksum "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\Shop\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bb059b20986ccf9f2739ce2119ca521d3a14e81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_List), @"mvc.1.0.view", @"/Views/Shop/List.cshtml")]
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
#line 1 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\_ViewImports.cshtml"
using MarketingApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\_ViewImports.cshtml"
using MarketingApp.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\_ViewImports.cshtml"
using MarketingApp.WebUI.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\_ViewImports.cshtml"
using MarketingApp.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bb059b20986ccf9f2739ce2119ca521d3a14e81", @"/Views/Shop/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49763ac7f13dc37b45465f2f774ad809d0067199", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");
#nullable restore
#line 5 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\Shop\List.cshtml"
   Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n");
#nullable restore
#line 8 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\Shop\List.cshtml"
         if (Model.Products.Count==0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\Shop\List.cshtml"
       Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\Shop\List.cshtml"
                                                  
        }
        else{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n");
#nullable restore
#line 14 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\Shop\List.cshtml"
                 foreach (var product in Model.Products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4\">\r\n                        ");
#nullable restore
#line 17 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\Shop\List.cshtml"
                   Write(await Html.PartialAsync("_product",product));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 19 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\Shop\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <nav aria-label=\"Page navigation example\">\r\n                      <ul class=\"pagination\">\r\n");
#nullable restore
#line 25 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\Shop\List.cshtml"
                         for (int i = 0; i < Model.PageInfo.TotalPages(); i++)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\Shop\List.cshtml"
                             if (string.IsNullOrEmpty(Model.PageInfo.CurrentCategory))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 1025, "\"", 1089, 2);
            WriteAttributeValue("", 1033, "page-item", 1033, 9, true);
#nullable restore
#line 29 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 1042, Model.PageInfo.CurrentPage==i+1?"active":"", 1043, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1149, "\"", 1176, 2);
            WriteAttributeValue("", 1156, "/ürünler?page=", 1156, 14, true);
#nullable restore
#line 30 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\Shop\List.cshtml"
WriteAttributeValue("", 1170, i+1, 1170, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 30 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\Shop\List.cshtml"
                                                                                 Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </li>\r\n");
#nullable restore
#line 32 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\Shop\List.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li");
            BeginWriteAttribute("class", " class=\"", 1360, "\"", 1424, 2);
            WriteAttributeValue("", 1368, "page-item", 1368, 9, true);
#nullable restore
#line 35 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\Shop\List.cshtml"
WriteAttributeValue(" ", 1377, Model.PageInfo.CurrentPage==i+1?"active":"", 1378, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1484, "\"", 1543, 4);
            WriteAttributeValue("", 1491, "/ürünler/", 1491, 9, true);
#nullable restore
#line 36 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\Shop\List.cshtml"
WriteAttributeValue("", 1500, Model.PageInfo.CurrentCategory, 1500, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1531, "?page=", 1531, 6, true);
#nullable restore
#line 36 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\Shop\List.cshtml"
WriteAttributeValue("", 1537, i+1, 1537, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\Shop\List.cshtml"
                                                                                                                 Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </li>\r\n");
#nullable restore
#line 38 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\Shop\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\Shop\List.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                      </ul>\r\n                    </nav>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 44 "D:\git\.NETCore\MarketingApp\MarketingApp.WebUI\Views\Shop\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n    \r\n");
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
