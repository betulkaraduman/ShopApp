#pragma checksum "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbb008c1dd6ec8b6914bf1a320a4fed7f4908fac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CategorydEdit), @"mvc.1.0.view", @"/Views/Admin/CategorydEdit.cshtml")]
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
#line 3 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\_ViewImports.cshtml"
using shopApp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\_ViewImports.cshtml"
using ShopApp.webui.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\_ViewImports.cshtml"
using ShopApp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\_ViewImports.cshtml"
using ShopApp.webui.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\_ViewImports.cshtml"
using ShopApp.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbb008c1dd6ec8b6914bf1a320a4fed7f4908fac", @"/Views/Admin/CategorydEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13e6dc519139fcf709e69879a701421b63aaea5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CategorydEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-sm-2 col-form-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CategorydEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/deleteFromCategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2 class=\"h4\">Edit Category</h2>\r\n<hr>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbb008c1dd6ec8b6914bf1a320a4fed7f4908fac8526", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbb008c1dd6ec8b6914bf1a320a4fed7f4908fac8796", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 7 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 306, "\"", 323, 1);
#nullable restore
#line 8 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
WriteAttributeValue("", 314, Model.Id, 314, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <div class=\"form-group row\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbb008c1dd6ec8b6914bf1a320a4fed7f4908fac10951", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 10 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

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
                WriteLiteral("\r\n                <div class=\"col-sm-10\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bbb008c1dd6ec8b6914bf1a320a4fed7f4908fac12600", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 12 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

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
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbb008c1dd6ec8b6914bf1a320a4fed7f4908fac14415", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 13 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

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
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group row\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbb008c1dd6ec8b6914bf1a320a4fed7f4908fac16183", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 18 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
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
                WriteLiteral("\r\n                <div class=\"col-sm-10\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbb008c1dd6ec8b6914bf1a320a4fed7f4908fac17831", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 20 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Url);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbb008c1dd6ec8b6914bf1a320a4fed7f4908fac19452", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 21 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Url);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
            </div>

            <div class=""form-group row"">
                <div class=""col-sm-10 offset-sm-2"">
                    <button type=""submit"" class=""btn btn-primary"">Update Category</button>
                </div>
            </div>
            <div id=""products"">
");
#nullable restore
#line 31 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
               for (int i = 0; i < Model.Products.Count; i++)
              {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1440, "\"", 1462, 3);
                WriteAttributeValue("", 1447, "Products[", 1447, 9, true);
#nullable restore
#line 33 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
WriteAttributeValue("", 1456, i, 1456, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1458, "].Id", 1458, 4, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1463, "\"", 1493, 1);
#nullable restore
#line 33 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
WriteAttributeValue("", 1471, Model.Products[@i].Id, 1471, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1533, "\"", 1561, 3);
                WriteAttributeValue("", 1540, "Products[", 1540, 9, true);
#nullable restore
#line 34 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
WriteAttributeValue("", 1549, i, 1549, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1551, "].ImageUrl", 1551, 10, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1562, "\"", 1598, 1);
#nullable restore
#line 34 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
WriteAttributeValue("", 1570, Model.Products[@i].ImageUrl, 1570, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1638, "\"", 1662, 3);
                WriteAttributeValue("", 1645, "Products[", 1645, 9, true);
#nullable restore
#line 35 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
WriteAttributeValue("", 1654, i, 1654, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1656, "].Name", 1656, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1663, "\"", 1695, 1);
#nullable restore
#line 35 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
WriteAttributeValue("", 1671, Model.Products[@i].Name, 1671, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1735, "\"", 1760, 3);
                WriteAttributeValue("", 1742, "Products[", 1742, 9, true);
#nullable restore
#line 36 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
WriteAttributeValue("", 1751, i, 1751, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1753, "].Price", 1753, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1761, "\"", 1794, 1);
#nullable restore
#line 36 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
WriteAttributeValue("", 1769, Model.Products[@i].Price, 1769, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1834, "\"", 1860, 3);
                WriteAttributeValue("", 1841, "Products[", 1841, 9, true);
#nullable restore
#line 37 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
WriteAttributeValue("", 1850, i, 1850, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1852, "].IsHome", 1852, 8, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1861, "\"", 1906, 1);
#nullable restore
#line 37 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
WriteAttributeValue("", 1869, Model.Products[@i].IsHome.ToString(), 1869, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 1946, "\"", 1976, 3);
                WriteAttributeValue("", 1953, "Products[", 1953, 9, true);
#nullable restore
#line 38 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
WriteAttributeValue("", 1962, i, 1962, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1964, "].IsApproved", 1964, 12, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1977, "\"", 2026, 1);
#nullable restore
#line 38 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
WriteAttributeValue("", 1985, Model.Products[@i].IsApproved.ToString(), 1985, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 39 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
              }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
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
      <div class=""row"">
        <div class=""col-md-12"">
          <table class=""table table-bordered table-sm"">
            <thead>
             <tr>
                <th style=""width:40px"">ID</th>
                <th style=""width:180px"">Image</th>
                <th>Name</th>
                <th style=""width:20px"">Price</th>
                <th style=""width:120px"">Home Page</th>
                <th style=""width:20px"">Approved</th>
                <th style=""width:200px""></th>
            </tr>
           </thead>
           <tbody>
");
#nullable restore
#line 59 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
               if (Model.Products.Count() != 0)
               {
                 

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
                  foreach (var item in Model.Products)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <tr>\r\n                    <td>");
#nullable restore
#line 64 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bbb008c1dd6ec8b6914bf1a320a4fed7f4908fac30587", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2921, "~/img/", 2921, 6, true);
#nullable restore
#line 65 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
AddHtmlAttributeValue("", 2927, item.ImageUrl, 2927, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 66 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 67 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"text-align:center;\">\r\n");
#nullable restore
#line 69 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
                         if (item.IsHome)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fas fa-check-circle\"></i>\r\n");
#nullable restore
#line 72 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fas fa-times-circle\"></i>\r\n");
#nullable restore
#line 76 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td style=\"text-align:center;\">\r\n");
#nullable restore
#line 79 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
                         if (item.IsApproved)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fas fa-check-circle\"></i>\r\n");
#nullable restore
#line 82 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fas fa-times-circle\"></i>\r\n");
#nullable restore
#line 86 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3882, "\"", 3913, 2);
            WriteAttributeValue("", 3889, "/admin/products/", 3889, 16, true);
#nullable restore
#line 89 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
WriteAttributeValue("", 3905, item.Id, 3905, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\">Update</a>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbb008c1dd6ec8b6914bf1a320a4fed7f4908fac35283", async() => {
                WriteLiteral("\r\n                         <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 4119, "\"", 4135, 1);
#nullable restore
#line 91 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
WriteAttributeValue("", 4127, item.Id, 4127, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                         <input type=\"hidden\" name=\"CategoryId\"");
                BeginWriteAttribute("value", " value=\"", 4202, "\"", 4219, 1);
#nullable restore
#line 92 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
WriteAttributeValue("", 4210, Model.Id, 4210, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                         <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("                        \r\n                    </td>\r\n                   </tr>\r\n");
#nullable restore
#line 97 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
                 
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
               Write(await Html.PartialAsync("_noProduct"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Admin\CategorydEdit.cshtml"
                                                          
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script src=\"/modules/jquery-validation/dist/jquery.validate.min.js\"></script>\r\n    <script src=\"/modules/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.min.js\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
