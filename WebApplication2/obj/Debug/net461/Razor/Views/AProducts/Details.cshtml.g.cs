#pragma checksum "D:\ClothingStore\Clothing-Store\WebApplication2\Views\AProducts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "143a1b3beba9302636f8dc9ed4e777e53763f635"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AProducts_Details), @"mvc.1.0.view", @"/Views/AProducts/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AProducts/Details.cshtml", typeof(AspNetCore.Views_AProducts_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"143a1b3beba9302636f8dc9ed4e777e53763f635", @"/Views/AProducts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_AProducts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.Models.ViewModels.Admin.Entities.AProducts>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 79, true);
            WriteLiteral("\r\n    <div class=\"product-details\">\r\n        <h4>Details</h4>\r\n        <hr />\r\n");
            EndContext();
#line 6 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\AProducts\Details.cshtml"
         if (Model.choosenProduct.id != 0)
        {

#line default
#line hidden
            BeginContext(201, 89, true);
            WriteLiteral("            <dl class=\"row\">\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(291, 55, false);
#line 10 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\AProducts\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.choosenProduct.name));

#line default
#line hidden
            EndContext();
            BeginContext(346, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(432, 51, false);
#line 13 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\AProducts\Details.cshtml"
               Write(Html.DisplayFor(model => model.choosenProduct.name));

#line default
#line hidden
            EndContext();
            BeginContext(483, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(568, 59, false);
#line 16 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\AProducts\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.choosenProduct.supplier));

#line default
#line hidden
            EndContext();
            BeginContext(627, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(713, 55, false);
#line 19 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\AProducts\Details.cshtml"
               Write(Html.DisplayFor(model => model.choosenProduct.supplier));

#line default
#line hidden
            EndContext();
            BeginContext(768, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(853, 58, false);
#line 22 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\AProducts\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.choosenProduct.summary));

#line default
#line hidden
            EndContext();
            BeginContext(911, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(997, 54, false);
#line 25 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\AProducts\Details.cshtml"
               Write(Html.DisplayFor(model => model.choosenProduct.summary));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(1136, 62, false);
#line 28 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\AProducts\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.choosenProduct.description));

#line default
#line hidden
            EndContext();
            BeginContext(1198, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1284, 58, false);
#line 31 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\AProducts\Details.cshtml"
               Write(Html.DisplayFor(model => model.choosenProduct.description));

#line default
#line hidden
            EndContext();
            BeginContext(1342, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(1427, 56, false);
#line 34 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\AProducts\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.choosenProduct.price));

#line default
#line hidden
            EndContext();
            BeginContext(1483, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1569, 52, false);
#line 37 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\AProducts\Details.cshtml"
               Write(Html.DisplayFor(model => model.choosenProduct.price));

#line default
#line hidden
            EndContext();
            BeginContext(1621, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(1706, 59, false);
#line 40 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\AProducts\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.choosenProduct.category));

#line default
#line hidden
            EndContext();
            BeginContext(1765, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1851, 55, false);
#line 43 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\AProducts\Details.cshtml"
               Write(Html.DisplayFor(model => model.choosenProduct.category));

#line default
#line hidden
            EndContext();
            BeginContext(1906, 44, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n");
            EndContext();
#line 46 "D:\ClothingStore\Clothing-Store\WebApplication2\Views\AProducts\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1961, 12, true);
            WriteLiteral("\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication2.Models.ViewModels.Admin.Entities.AProducts> Html { get; private set; }
    }
}
#pragma warning restore 1591
