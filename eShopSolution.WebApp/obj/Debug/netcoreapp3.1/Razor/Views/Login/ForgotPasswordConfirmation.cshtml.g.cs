#pragma checksum "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Login\ForgotPasswordConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14196247f21ec3c996587e77f96ad9bcb1b497f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_ForgotPasswordConfirmation), @"mvc.1.0.view", @"/Views/Login/ForgotPasswordConfirmation.cshtml")]
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
#nullable restore
#line 1 "D:\Ky8_Fall2023\PRN231\ElectroPhoneStore\eShopSolution.WebApp\Views\Login\ForgotPasswordConfirmation.cshtml"
using eShopSolution.ViewModels.System.Users;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14196247f21ec3c996587e77f96ad9bcb1b497f6", @"/Views/Login/ForgotPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f64a4a05cd9c5e4a1fb2d013544676916caa7f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Login_ForgotPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ForgotPasswordViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>

    /******************************************
    35. Login page
    ******************************************/
    .account-login {
        display: inline-block;
        width: 100%;
    }

        .account-login h4 {
            font-weight: 600;
            font-size: 15px;
        }

    .register-benefits h5 {
        font-weight: 600;
        font-size: 13px;
    }

    .box-authentication {
        display: inline-block;
        width: 48%;
        float: left;
    }

        .box-authentication > h3 {
            margin-bottom: 15px;
        }

        .box-authentication label {
            margin-top: 10px;
            margin-bottom: 2px;
        }

        .box-authentication .forgot-pass {
            margin-top: 15px;
        }

        .box-authentication input, .box-authentication textarea {
            border-radius: 3px;
            border: 1px solid #e8e6e2;
            -webkit-box-shadow: inherit;
            box-shadow: inherit;
  ");
            WriteLiteral(@"          width: 50%;
        }

        .box-authentication .button {
            margin-top: 15px;
        }

    button.button {
        display: inline-block;
        border: 0;
        background: #444;
        padding: 6px 16px;
        font-size: 12px;
        border: 1px solid #444;
        font-weight: 500;
        text-align: center;
        white-space: nowrap;
        color: #fff;
        font-weight: normal;
        transition: all 0.3s linear;
        -moz-transition: all 0.3s linear;
        -webkit-transition: all 0.3s linear;
        border-radius: 3px;
    }

        button.button:hover {
            background: #e83f33;
            border: 1px solid #e83f33;
            transition: all 0.3s linear;
            -moz-transition: all 0.3s linear;
            -webkit-transition: all 0.3s linear;
            color: #fff
        }

    button span {
        text-transform: uppercase;
        font-weight: 500;
        letter-spacing: 0.5px;
    }

    .box-a");
            WriteLiteral(@"uthentication .required {
        color: #ff0000;
        padding-left: 3px;
    }

    .box-authentication .inline input {
        width: auto;
    }

    .register-benefits {
        margin-top: 12px;
    }
</style>

<!-- BREADCRUMB -->
<div id=""breadcrumb"" class=""section"">
    <!-- container -->
    <div class=""container"">
        <!-- row -->
        <div class=""row"">
            <div class=""col-md-12"">
                <ul class=""breadcrumb-tree"">
                    <li><a href=""/"">Trang chủ</a></li>
                    <li> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14196247f21ec3c996587e77f96ad9bcb1b497f68434", async() => {
                WriteLiteral("Đăng nhập");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                    <li class=""active"">Khôi phục mật khẩu</li>
                </ul>
            </div>
        </div>
        <!-- /row -->
    </div>
    <!-- /container -->
</div>
<!-- /BREADCRUMB -->

<section class=""main-container col1-layout"">
    <div class=""main container"">
        <div class=""page-content"">
            <div class=""row"">
                <div class=""col-md-5"">
                    <div class=""alert alert-success"" role=""alert"">
                        Đã gửi link khôi phục mật khẩu
                    </div>
                    <p>Nếu email quý khách vừa nhập có đã đăng ký trong hệ thống cửa hàng rồi. Xin mời quý khách kiểm tra hòm thư để nhận link khôi phục mật khẩu.</p>
                </div>
            </div>
        </div>
    </div>
</section>
");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForgotPasswordViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
