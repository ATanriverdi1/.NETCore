#pragma checksum "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\CategoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b75875a98198f8a871b3b5a17d7f1a38d8f3d175"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CategoryList), @"mvc.1.0.view", @"/Views/Admin/CategoryList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b75875a98198f8a871b3b5a17d7f1a38d8f3d175", @"/Views/Admin/CategoryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62e906d511a825ed9d0b7930e85471fb5839e54c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CategoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("badge badge-primary mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/DeleteCategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Admin Products</h1>\r\n<hr>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b75875a98198f8a871b3b5a17d7f1a38d8f3d1756723", async() => {
                WriteLiteral("Yeni Kategori Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table class=\"table table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <td style=\"width: 30px;\">Id</td>\r\n            <td>Name</td>\r\n            <td style=\"width: 150px;\"></td>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 16 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\CategoryList.cshtml"
         if (Model.Categories.Count > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\CategoryList.cshtml"
             foreach (var item in Model.Categories)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 21 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\CategoryList.cshtml"
                   Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\CategoryList.cshtml"
                   Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 688, "\"", 730, 2);
            WriteAttributeValue("", 695, "/admin/kategoriler/", 695, 19, true);
#nullable restore
#line 24 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\CategoryList.cshtml"
WriteAttributeValue("", 714, item.CategoryId, 714, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm mr-2\">Edit</a>\r\n                        \r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b75875a98198f8a871b3b5a17d7f1a38d8f3d17510085", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"categoryId\"");
                BeginWriteAttribute("value", " value=\"", 972, "\"", 996, 1);
#nullable restore
#line 27 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\CategoryList.cshtml"
WriteAttributeValue("", 980, item.CategoryId, 980, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 33 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\CategoryList.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\CategoryList.cshtml"
             
        }
        else
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\CategoryList.cshtml"
       Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
