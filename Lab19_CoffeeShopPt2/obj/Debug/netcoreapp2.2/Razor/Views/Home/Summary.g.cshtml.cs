#pragma checksum "C:\Users\Deno\Documents\Grand Circus\Labs\Lab19_CoffeeShopPt2\Lab19_CoffeeShopPt2\Views\Home\Summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "715df4aa37335ba7b3354c9df42a83cc87eed91d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Summary), @"mvc.1.0.view", @"/Views/Home/Summary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Summary.cshtml", typeof(AspNetCore.Views_Home_Summary))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"715df4aa37335ba7b3354c9df42a83cc87eed91d", @"/Views/Home/Summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0549e1595385fcd884e5be7a2485d7496cf5f70", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lab19_CoffeeShopPt2.Models.RegisterUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab19_CoffeeShopPt2\Lab19_CoffeeShopPt2\Views\Home\Summary.cshtml"
  
    ViewData["Title"] = "Summary";

#line default
#line hidden
            BeginContext(45, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(114, 214, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>UserName</th>\r\n        <th>First Name</th>\r\n        <th>Birthday</th>\r\n        <th>Drink of Choice</th>\r\n        <th>Email</th>\r\n        <th>Password</th>\r\n    </tr>\r\n");
            EndContext();
#line 20 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab19_CoffeeShopPt2\Lab19_CoffeeShopPt2\Views\Home\Summary.cshtml"
     foreach (var user in Model)
    {

#line default
#line hidden
            BeginContext(369, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(400, 13, false);
#line 23 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab19_CoffeeShopPt2\Lab19_CoffeeShopPt2\Views\Home\Summary.cshtml"
           Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(413, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(437, 14, false);
#line 24 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab19_CoffeeShopPt2\Lab19_CoffeeShopPt2\Views\Home\Summary.cshtml"
           Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(451, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(475, 18, false);
#line 25 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab19_CoffeeShopPt2\Lab19_CoffeeShopPt2\Views\Home\Summary.cshtml"
           Write(user.Birthday.Date);

#line default
#line hidden
            EndContext();
            BeginContext(493, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(517, 10, false);
#line 26 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab19_CoffeeShopPt2\Lab19_CoffeeShopPt2\Views\Home\Summary.cshtml"
           Write(user.Drink);

#line default
#line hidden
            EndContext();
            BeginContext(527, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(551, 10, false);
#line 27 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab19_CoffeeShopPt2\Lab19_CoffeeShopPt2\Views\Home\Summary.cshtml"
           Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(561, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(585, 13, false);
#line 28 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab19_CoffeeShopPt2\Lab19_CoffeeShopPt2\Views\Home\Summary.cshtml"
           Write(user.Password);

#line default
#line hidden
            EndContext();
            BeginContext(598, 36, true);
            WriteLiteral("</td>\r\n            \r\n        </tr>\r\n");
            EndContext();
#line 31 "C:\Users\Deno\Documents\Grand Circus\Labs\Lab19_CoffeeShopPt2\Lab19_CoffeeShopPt2\Views\Home\Summary.cshtml"
    }

#line default
#line hidden
            BeginContext(641, 314, true);
            WriteLiteral(@"</table>

<style>
    .pizza {
        font-size: larger;
        background-color: aliceblue;
        text-align: center;
        background-size: contain;
    }

        .pizza input {
            margin-right: 8em;
        }

    2
    .pizza label {
        position: absolute;
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lab19_CoffeeShopPt2.Models.RegisterUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
