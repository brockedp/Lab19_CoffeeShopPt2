#pragma checksum "C:\Users\Deno\Documents\Grand Circus\Labs\Lab19_CoffeeShopPt2\Lab19_CoffeeShopPt2\Views\Home\UserInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "454f55b85cb21f93fd6c7a60fdaa31450bc43e17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserInfo), @"mvc.1.0.view", @"/Views/Home/UserInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UserInfo.cshtml", typeof(AspNetCore.Views_Home_UserInfo))]
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
#line 1 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab19_CoffeeShopPt2\Lab19_CoffeeShopPt2\Views\_ViewImports.cshtml"
using Lab19_CoffeeShopPt2;

#line default
#line hidden
#line 2 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab19_CoffeeShopPt2\Lab19_CoffeeShopPt2\Views\_ViewImports.cshtml"
using Lab19_CoffeeShopPt2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"454f55b85cb21f93fd6c7a60fdaa31450bc43e17", @"/Views/Home/UserInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0549e1595385fcd884e5be7a2485d7496cf5f70", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab19_CoffeeShopPt2.Models.RegisterUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab19_CoffeeShopPt2\Lab19_CoffeeShopPt2\Views\Home\UserInfo.cshtml"
  
    ViewData["Title"] = "UserInfo";

#line default
#line hidden
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(96, 233, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>UserName</th>\r\n        <th>First Name</th>\r\n        <th>Birthday</th>\r\n        <th>Drink of Choice</th>\r\n        <th>Email</th>\r\n        \r\n    </tr>\r\n    \r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(330, 14, false);
#line 19 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab19_CoffeeShopPt2\Lab19_CoffeeShopPt2\Views\Home\UserInfo.cshtml"
           Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(344, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(368, 15, false);
#line 20 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab19_CoffeeShopPt2\Lab19_CoffeeShopPt2\Views\Home\UserInfo.cshtml"
           Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(383, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(407, 19, false);
#line 21 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab19_CoffeeShopPt2\Lab19_CoffeeShopPt2\Views\Home\UserInfo.cshtml"
           Write(Model.Birthday.Date);

#line default
#line hidden
            EndContext();
            BeginContext(426, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(450, 11, false);
#line 22 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab19_CoffeeShopPt2\Lab19_CoffeeShopPt2\Views\Home\UserInfo.cshtml"
           Write(Model.Drink);

#line default
#line hidden
            EndContext();
            BeginContext(461, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(485, 11, false);
#line 23 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab19_CoffeeShopPt2\Lab19_CoffeeShopPt2\Views\Home\UserInfo.cshtml"
           Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(496, 56, true);
            WriteLiteral("</td>\r\n            \r\n\r\n        </tr>\r\n    \r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab19_CoffeeShopPt2.Models.RegisterUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
