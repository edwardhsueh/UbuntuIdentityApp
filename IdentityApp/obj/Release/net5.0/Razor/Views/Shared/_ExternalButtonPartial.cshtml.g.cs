#pragma checksum "/home/azureuser/UbuntuIdentityApp/IdentityApp/Views/Shared/_ExternalButtonPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "501e8cd4bf0479ca98cdd0e8b0c0d8966a60ba84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ExternalButtonPartial), @"mvc.1.0.view", @"/Views/Shared/_ExternalButtonPartial.cshtml")]
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
#line 2 "/home/azureuser/UbuntuIdentityApp/IdentityApp/Views/_ViewImports.cshtml"
using IdentityApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/azureuser/UbuntuIdentityApp/IdentityApp/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/azureuser/UbuntuIdentityApp/IdentityApp/Views/_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"501e8cd4bf0479ca98cdd0e8b0c0d8966a60ba84", @"/Views/Shared/_ExternalButtonPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eb962dd7932ca7e5a70da53a604cc98b00e804c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ExternalButtonPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Microsoft.AspNetCore.Authentication.AuthenticationScheme>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<button type=\"submit\" class=\"btn btn-primary\" name=\"provider\"");
            BeginWriteAttribute("value", " value=\"", 125, "\"", 144, 1);
#nullable restore
#line 2 "/home/azureuser/UbuntuIdentityApp/IdentityApp/Views/Shared/_ExternalButtonPartial.cshtml"
WriteAttributeValue("", 133, Model.Name, 133, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n    <i");
            BeginWriteAttribute("class", " class=\"", 153, "\"", 197, 1);
#nullable restore
#line 3 "/home/azureuser/UbuntuIdentityApp/IdentityApp/Views/Shared/_ExternalButtonPartial.cshtml"
WriteAttributeValue("", 161, $"fab fa-{@Model.Name.ToLower()}", 161, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> \n    ");
#nullable restore
#line 4 "/home/azureuser/UbuntuIdentityApp/IdentityApp/Views/Shared/_ExternalButtonPartial.cshtml"
Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</button>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Microsoft.AspNetCore.Authentication.AuthenticationScheme> Html { get; private set; }
    }
}
#pragma warning restore 1591