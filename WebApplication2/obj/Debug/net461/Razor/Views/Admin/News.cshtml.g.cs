#pragma checksum "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc8dcc917438a6e4055d70fcbda006f7bae256af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_News), @"mvc.1.0.view", @"/Views/Admin/News.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/News.cshtml", typeof(AspNetCore.Views_Admin_News))]
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
#line 1 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#line 2 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc8dcc917438a6e4055d70fcbda006f7bae256af", @"/Views/Admin/News.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_News : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.Models.ViewModels.Admin.ANews>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "News", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-aId", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Promotion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-func", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-func", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-func", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
  
    ViewData["Title"] = "Admins";

#line default
#line hidden
            BeginContext(96, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(101, 13, false);
#line 5 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
Write(ViewBag.count);

#line default
#line hidden
            EndContext();
            BeginContext(114, 77, true);
            WriteLiteral("</h1>\r\n\r\n<h1>Admins</h1>\r\n\r\n<table>\r\n    <thead>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(191, 390, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc8dcc917438a6e4055d70fcbda006f7bae256af6566", async() => {
                BeginContext(233, 217, true);
                WriteLiteral("\r\n                <div>\r\n                    <p>\r\n                        Find type name:   <input type=\"text\" name=\"search\" />\r\n                        <input type=\"submit\" value=\"Search\" />\r\n                        ");
                EndContext();
                BeginContext(450, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc8dcc917438a6e4055d70fcbda006f7bae256af7180", async() => {
                    BeginContext(489, 17, true);
                    WriteLiteral("Back to Full List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-aId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["aId"] = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(510, 64, true);
                WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(581, 66, true);
            WriteLiteral("\r\n        </div>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(648, 22, false);
#line 24 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
           Write(Html.DisplayName("Id"));

#line default
#line hidden
            EndContext();
            BeginContext(670, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(726, 25, false);
#line 27 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
           Write(Html.DisplayName("Admin"));

#line default
#line hidden
            EndContext();
            BeginContext(751, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(807, 27, false);
#line 30 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
           Write(Html.DisplayName("Created"));

#line default
#line hidden
            EndContext();
            BeginContext(834, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(890, 27, false);
#line 33 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
           Write(Html.DisplayName("Content"));

#line default
#line hidden
            EndContext();
            BeginContext(917, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(973, 24, false);
#line 36 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
           Write(Html.DisplayName("Type"));

#line default
#line hidden
            EndContext();
            BeginContext(997, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 41 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
         foreach (var ad in Model.news)
        {

#line default
#line hidden
            BeginContext(1112, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1151, 35, false);
#line 44 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
               Write(Html.DisplayFor(modelItem => ad.id));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 29, true);
            WriteLiteral("</td>\r\n\r\n                <td>");
            EndContext();
            BeginContext(1216, 38, false);
#line 46 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
               Write(Html.DisplayFor(modelItem => ad.admin));

#line default
#line hidden
            EndContext();
            BeginContext(1254, 29, true);
            WriteLiteral("</td>\r\n\r\n                <td>");
            EndContext();
            BeginContext(1284, 40, false);
#line 48 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
               Write(Html.DisplayFor(modelItem => ad.created));

#line default
#line hidden
            EndContext();
            BeginContext(1324, 29, true);
            WriteLiteral("</td>\r\n\r\n                <td>");
            EndContext();
            BeginContext(1354, 40, false);
#line 50 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
               Write(Html.DisplayFor(modelItem => ad.content));

#line default
#line hidden
            EndContext();
            BeginContext(1394, 29, true);
            WriteLiteral("</td>\r\n\r\n                <td>");
            EndContext();
            BeginContext(1424, 37, false);
#line 52 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
               Write(Html.DisplayFor(modelItem => ad.type));

#line default
#line hidden
            EndContext();
            BeginContext(1461, 54, true);
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(1515, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc8dcc917438a6e4055d70fcbda006f7bae256af15012", async() => {
                BeginContext(1583, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-func", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["func"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
                                                            WriteLiteral(ad.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1594, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1608, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc8dcc917438a6e4055d70fcbda006f7bae256af17880", async() => {
                BeginContext(1673, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-func", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["func"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
                                                         WriteLiteral(ad.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1681, 19, true);
            WriteLiteral("\r\n\r\n        </td>\r\n");
            EndContext();
#line 60 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
    }

#line default
#line hidden
            BeginContext(1707, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 63 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
     for (int i = 1; i <= ViewBag.totalPage; i++)
    {

#line default
#line hidden
            BeginContext(1797, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1805, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc8dcc917438a6e4055d70fcbda006f7bae256af21291", async() => {
                BeginContext(1849, 1, false);
#line 65 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
                                              Write(i);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-PageId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
                                   WriteLiteral(i);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PageId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-PageId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PageId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1854, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 66 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
    }

#line default
#line hidden
            BeginContext(1863, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1867, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc8dcc917438a6e4055d70fcbda006f7bae256af23976", async() => {
                BeginContext(1912, 6, true);
                WriteLiteral("Create");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-func", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["func"] = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1922, 41, true);
            WriteLiteral("\r\n    <h1>Admin Details</h1>\r\n    <div>\r\n");
            EndContext();
#line 70 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
         if (Model.choosenNews.id != 0)
        {

#line default
#line hidden
            BeginContext(2015, 89, true);
            WriteLiteral("            <dl class=\"row\">\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(2105, 50, false);
#line 74 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
               Write(Html.DisplayNameFor(model => Model.choosenNews.id));

#line default
#line hidden
            EndContext();
            BeginContext(2155, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(2241, 46, false);
#line 77 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
               Write(Html.DisplayFor(model => Model.choosenNews.id));

#line default
#line hidden
            EndContext();
            BeginContext(2287, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(2372, 53, false);
#line 80 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
               Write(Html.DisplayNameFor(model => Model.choosenNews.admin));

#line default
#line hidden
            EndContext();
            BeginContext(2425, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(2510, 49, false);
#line 83 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
               Write(Html.DisplayFor(model => Model.choosenNews.admin));

#line default
#line hidden
            EndContext();
            BeginContext(2559, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(2645, 55, false);
#line 86 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
               Write(Html.DisplayNameFor(model => Model.choosenNews.created));

#line default
#line hidden
            EndContext();
            BeginContext(2700, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(2785, 51, false);
#line 89 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
               Write(Html.DisplayFor(model => Model.choosenNews.created));

#line default
#line hidden
            EndContext();
            BeginContext(2836, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(2922, 55, false);
#line 92 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
               Write(Html.DisplayNameFor(model => Model.choosenNews.content));

#line default
#line hidden
            EndContext();
            BeginContext(2977, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(3062, 51, false);
#line 95 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
               Write(Html.DisplayFor(model => Model.choosenNews.content));

#line default
#line hidden
            EndContext();
            BeginContext(3113, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(3199, 52, false);
#line 98 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
               Write(Html.DisplayNameFor(model => Model.choosenNews.type));

#line default
#line hidden
            EndContext();
            BeginContext(3251, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(3336, 48, false);
#line 101 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
               Write(Html.DisplayFor(model => Model.choosenNews.type));

#line default
#line hidden
            EndContext();
            BeginContext(3384, 44, true);
            WriteLiteral("\r\n                </dt>\r\n            </dl>\r\n");
            EndContext();
#line 104 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
        }

#line default
#line hidden
            BeginContext(3439, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 106 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
     if (ViewBag.isCreation == "Create" || ViewBag.isCreation == "Edit")
    {
        

#line default
#line hidden
#line 108 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
         using (Html.BeginForm("News"))
        {

#line default
#line hidden
            BeginContext(3584, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(3596, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cc8dcc917438a6e4055d70fcbda006f7bae256af31515", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#line 110 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.editedNews.id);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3643, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3658, 38, false);
#line 111 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
       Write(Html.LabelFor(m => m.editedNews.admin));

#line default
#line hidden
            EndContext();
            BeginContext(3711, 40, false);
#line 112 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
       Write(Html.TextBoxFor(m => m.editedNews.admin));

#line default
#line hidden
            EndContext();
            BeginContext(3766, 40, false);
#line 113 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
       Write(Html.LabelFor(m => m.editedNews.created));

#line default
#line hidden
            EndContext();
            BeginContext(3821, 42, false);
#line 114 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
       Write(Html.TextBoxFor(m => m.editedNews.created));

#line default
#line hidden
            EndContext();
            BeginContext(3878, 40, false);
#line 115 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
       Write(Html.LabelFor(m => m.editedNews.content));

#line default
#line hidden
            EndContext();
            BeginContext(3933, 42, false);
#line 116 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
       Write(Html.TextBoxFor(m => m.editedNews.content));

#line default
#line hidden
            EndContext();
            BeginContext(3990, 37, false);
#line 117 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
       Write(Html.LabelFor(m => m.editedNews.type));

#line default
#line hidden
            EndContext();
            BeginContext(4042, 39, false);
#line 118 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
       Write(Html.TextBoxFor(m => m.editedNews.type));

#line default
#line hidden
            EndContext();
            BeginContext(4083, 32, true);
            WriteLiteral("            <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4115, "\"", 4142, 1);
#line 119 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
WriteAttributeValue("", 4123, ViewBag.isCreation, 4123, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4143, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 120 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
        }

#line default
#line hidden
#line 120 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\Admin\News.cshtml"
         
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication2.Models.ViewModels.Admin.ANews> Html { get; private set; }
    }
}
#pragma warning restore 1591
