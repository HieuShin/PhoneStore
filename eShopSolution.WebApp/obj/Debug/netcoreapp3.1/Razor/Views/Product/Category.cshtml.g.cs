#pragma checksum "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a1ff9883904a901874b42fb3ada6f247cb66968"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Category), @"mvc.1.0.view", @"/Views/Product/Category.cshtml")]
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
#line 1 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using Westwind.AspNetCore.Markdown;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.Utilities.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.ViewModels.Sales;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\_ViewImports.cshtml"
using eShopSolution.WebApp.Controllers.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1ff9883904a901874b42fb3ada6f247cb66968", @"/Views/Product/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f64a4a05cd9c5e4a1fb2d013544676916caa7f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductCategoryViewModel>
    #nullable disable
    {
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
        private global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Category.cshtml"
  
    ViewData["Title"] = Model.Category.Name + (Model.Products.PageIndex == 1 ? "" : " - " + _loc["Page"] + " " + Model.Products.PageIndex);
    ViewData["Description"] = Model.Category.Name + (Model.Products.PageIndex == 1 ? "" : " - " + _loc["Page"] + " " + Model.Products.PageIndex);
    Layout = "~/Views/Shared/_Layout.cshtml";
    var culture = CultureInfo.CurrentCulture;

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul class=\"breadcrumb\">\r\n    <li><a href=\"index.html\">Home</a> <span class=\"divider\">/</span></li>\r\n    <li class=\"active\">Products Name</li>\r\n</ul>\r\n<h3> ");
#nullable restore
#line 14 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Category.cshtml"
Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <small class=\"pull-right\"> 40 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a1ff9883904a901874b42fb3ada6f247cb669685836", async() => {
                WriteLiteral("available products");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </small></h3>\r\n<hr class=\"soft\" />\r\n\r\n<div class=\"tab-content\">\r\n    <div class=\"tab-pane  active\" id=\"blockView\">\r\n            <ul class=\"thumbnails\">\r\n");
#nullable restore
#line 20 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Category.cshtml"
                 for (int i = 0; i < Model.Products.Items.Count; i++)
                {
                    var item = Model.Products.Items[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"span3\">\r\n                        <div class=\"thumbnail\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1228, "\"", 1276, 6);
            WriteAttributeValue("", 1235, "/", 1235, 1, true);
#nullable restore
#line 25 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 1236, culture.Name, 1236, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1249, "/", 1249, 1, true);
#nullable restore
#line 25 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 1250, _loc["products"], 1250, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1267, "/", 1267, 1, true);
#nullable restore
#line 25 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 1268, item.Id, 1268, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 1282, "\"", 1342, 1);
#nullable restore
#line 25 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 1288, Configuration["BaseAddress"] + @item.ThumbnailImage, 1288, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1343, "\"", 1359, 1);
#nullable restore
#line 25 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Category.cshtml"
WriteAttributeValue("", 1349, item.Name, 1349, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n                            <div class=\"caption\">\r\n                                <h5>");
#nullable restore
#line 27 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Category.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 29 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Category.cshtml"
                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                                <h4 style=""text-align:center"">
                                    <a class=""btn"" href=""product_details.html""> <i class=""icon-zoom-in""></i></a>
                                    <a class=""btn"" href=""#"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("localize", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a1ff9883904a901874b42fb3ada6f247cb6696810261", async() => {
                WriteLiteral("Add to");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" <i class=\"icon-shopping-cart\"></i></a>\r\n                                    <a class=\"btn btn-primary\" href=\"#\">");
#nullable restore
#line 34 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Category.cshtml"
                                                                   Write(item.Price.ToString("C", culture));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h4>\r\n                            </div>\r\n                        </div>\r\n                    </li>\r\n");
#nullable restore
#line 39 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Category.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        <hr class=\"soft\" />\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 45 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Product\Category.cshtml"
Write(await Component.InvokeAsync("Pager", Model.Products));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br class=\"clr\" />");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LazZiya.ExpressLocalization.ISharedCultureLocalizer _loc { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductCategoryViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
