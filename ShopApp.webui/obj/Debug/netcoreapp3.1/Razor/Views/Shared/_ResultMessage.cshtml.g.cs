#pragma checksum "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Shared\_ResultMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49a968bd043be781c50195e980bf0f58649a0ded"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ResultMessage), @"mvc.1.0.view", @"/Views/Shared/_ResultMessage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49a968bd043be781c50195e980bf0f58649a0ded", @"/Views/Shared/_ResultMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13e6dc519139fcf709e69879a701421b63aaea5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ResultMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlertMessage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 81, "\"", 117, 3);
            WriteAttributeValue("", 89, "alert", 89, 5, true);
            WriteAttributeValue(" ", 94, "alert-", 95, 7, true);
#nullable restore
#line 4 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Shared\_ResultMessage.cshtml"
WriteAttributeValue("", 101, Model.AlertType, 101, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <h4 class=\"alert-title\">");
#nullable restore
#line 5 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Shared\_ResultMessage.cshtml"
                               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <p>");
#nullable restore
#line 6 "C:\Users\MONSTER\Desktop\DotNet\ShopApp\ShopApp.webui\Views\Shared\_ResultMessage.cshtml"
          Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlertMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
