#pragma checksum "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f22c1fe0e4138443ba6c391d054461c5782fa67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditCategory), @"mvc.1.0.view", @"/Views/Admin/EditCategory.cshtml")]
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
#nullable restore
#line 10 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\_ViewImports.cshtml"
using MarketingApp.WebUI.Models.identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\_ViewImports.cshtml"
using MarketingApp.WebUI.Models.Cart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\_ViewImports.cshtml"
using MarketingApp.WebUI.Models.Order;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f22c1fe0e4138443ba6c391d054461c5782fa67", @"/Views/Admin/EditCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71f0db4e6df593abb03f8a406c1e4395bb808269", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminCategoryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/DeleteProductFromCategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"//cdn.datatables.net/1.10.22/css/jquery.dataTables.min.css\">\r\n");
            }
            );
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n<div class=\"col-md-4\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f22c1fe0e4138443ba6c391d054461c5782fa678872", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f22c1fe0e4138443ba6c391d054461c5782fa679138", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 11 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        \r\n        <input type=\"hidden\" name=\"CategoryId\"");
                BeginWriteAttribute("value", " value=\"", 390, "\"", 415, 1);
#nullable restore
#line 13 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 398, Model.CategoryId, 398, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n        <div class=\"form-row\">\r\n            <div class=\"form-group col-md-6\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f22c1fe0e4138443ba6c391d054461c5782fa6711351", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 17 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CategoryName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3f22c1fe0e4138443ba6c391d054461c5782fa6712865", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 18 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CategoryName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f22c1fe0e4138443ba6c391d054461c5782fa6714461", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 19 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CategoryName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div> \r\n        </div>\r\n\r\n        <div class=\"form-row\">\r\n            <div class=\"form-group col-md-6\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f22c1fe0e4138443ba6c391d054461c5782fa6716264", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 25 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Url);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3f22c1fe0e4138443ba6c391d054461c5782fa6717769", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 26 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Url);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f22c1fe0e4138443ba6c391d054461c5782fa6719356", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 27 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Url);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <button type=\"submit\" class=\"btn btn-primary\">Kaydet</button>\r\n\r\n        <div id=\"products\">\r\n");
#nullable restore
#line 34 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
             for (int i = 0; i < Model.Products.Count; i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name = \"", 1263, "\"", 1294, 3);
                WriteAttributeValue("", 1272, "Products[", 1272, 9, true);
#nullable restore
#line 36 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1281, i, 1281, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1283, "].ProductId", 1283, 11, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value = \"", 1295, "\"", 1334, 1);
#nullable restore
#line 36 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1305, Model.Products[@i].ProductId, 1305, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name = \"", 1374, "\"", 1404, 3);
                WriteAttributeValue("", 1383, "Products[", 1383, 9, true);
#nullable restore
#line 37 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1392, i, 1392, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1394, "].ImageUrl", 1394, 10, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value = \"", 1405, "\"", 1443, 1);
#nullable restore
#line 37 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1415, Model.Products[@i].ImageUrl, 1415, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name = \"", 1483, "\"", 1516, 3);
                WriteAttributeValue("", 1492, "Products[", 1492, 9, true);
#nullable restore
#line 38 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1501, i, 1501, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1503, "].ProductName", 1503, 13, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value = \"", 1517, "\"", 1558, 1);
#nullable restore
#line 38 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1527, Model.Products[@i].ProductName, 1527, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name = \"", 1598, "\"", 1632, 3);
                WriteAttributeValue("", 1607, "Products[", 1607, 9, true);
#nullable restore
#line 39 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1616, i, 1616, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1618, "].ProductPrice", 1618, 14, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value = \"", 1633, "\"", 1675, 1);
#nullable restore
#line 39 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1643, Model.Products[@i].ProductPrice, 1643, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name = \"", 1715, "\"", 1747, 3);
                WriteAttributeValue("", 1724, "Products[", 1724, 9, true);
#nullable restore
#line 40 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1733, i, 1733, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1735, "].IsApproved", 1735, 12, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value = \"", 1748, "\"", 1799, 1);
#nullable restore
#line 40 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1758, Model.Products[@i].IsApproved.ToString(), 1758, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name = \"", 1839, "\"", 1871, 3);
                WriteAttributeValue("", 1848, "Products[", 1848, 9, true);
#nullable restore
#line 41 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1857, i, 1857, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1859, "].IsHomePage", 1859, 12, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value = \"", 1872, "\"", 1923, 1);
#nullable restore
#line 41 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 1882, Model.Products[@i].IsHomePage.ToString(), 1882, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 42 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<div class=""col-md-8"">
    <table id=""productTable"" class=""table table-bordered"">
        <thead>
            <tr>
                <td style=""width: 30px;"">Id</td>
                <td style=""width: 100px;"">Image</td>
                <td>Name</td>
                <td style=""width: 40px;"">Price</td>
                <td style=""width: 20px;"">IsApproved</td>
                <td style=""width: 20px;"">IsHomePage</td>
                <td style=""width: 250px;""></td>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 60 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
             if (Model.Products.Count > 0)
            {
        
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
                 foreach (var item in Model.Products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 66 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
                       Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3f22c1fe0e4138443ba6c391d054461c5782fa6730223", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2762, "~/images/", 2762, 9, true);
#nullable restore
#line 67 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
AddHtmlAttributeValue("", 2771, item.ImageUrl, 2771, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 68 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
                       Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 69 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
                       Write(item.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 71 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
                             if (item.IsApproved)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fas fa-check-circle\"></i>\r\n");
#nullable restore
#line 74 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
                            }
                            else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fas fa-times-circle\"></i>\r\n");
#nullable restore
#line 77 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 80 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
                             if (item.IsHomePage)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fas fa-check-circle\"></i>\r\n");
#nullable restore
#line 83 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fas fa-times-circle\"></i>\r\n");
#nullable restore
#line 87 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3756, "\"", 3793, 2);
            WriteAttributeValue("", 3763, "/admin/ürünler/", 3763, 15, true);
#nullable restore
#line 90 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 3778, item.ProductId, 3778, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm mb-1\">Edit</a>\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f22c1fe0e4138443ba6c391d054461c5782fa6734904", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"ProductId\"");
                BeginWriteAttribute("value", " value=\"", 4029, "\"", 4052, 1);
#nullable restore
#line 93 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 4037, item.ProductId, 4037, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <input type=\"hidden\" name=\"categoryId\"");
                BeginWriteAttribute("value", " value=\"", 4126, "\"", 4151, 1);
#nullable restore
#line 94 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
WriteAttributeValue("", 4134, Model.CategoryId, 4134, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <button type=\"submit\" class=\"btn btn-danger btn-sm\">DeleteCategory</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 100 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
                 
        
            }
            else
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "D:\git\.NETCore\MarketingApp\marketingapp.webui\Views\Admin\EditCategory.cshtml"
           Write(await Html.PartialAsync("_noproduct"));

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n        \r\n</div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""/modules/jquery-validation/dist/jquery.validate.min.js""></script>
    <script src=""/modules/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.min.js""></script>
    <script src=""//cdn.datatables.net/1.10.22/js/jquery.dataTables.min.js""></script>
    <script>
        $(document).ready( function () {
            $('#productTable').DataTable();
        } );
    </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminCategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
