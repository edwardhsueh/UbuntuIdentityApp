#pragma checksum "/home/azureuser/UbuntuIdentityApp/IdentityApp/Pages/Identity/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d576f89cfdd7a78c1846a337dd73b90995ceffe4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Identity_Index), @"mvc.1.0.razor-page", @"/Pages/Identity/Index.cshtml")]
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
#line 2 "/home/azureuser/UbuntuIdentityApp/IdentityApp/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/azureuser/UbuntuIdentityApp/IdentityApp/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/azureuser/UbuntuIdentityApp/IdentityApp/Pages/_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/azureuser/UbuntuIdentityApp/IdentityApp/Pages/_ViewImports.cshtml"
using IdentityApp.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/azureuser/UbuntuIdentityApp/IdentityApp/Pages/_ViewImports.cshtml"
using IdentityApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d576f89cfdd7a78c1846a337dd73b90995ceffe4", @"/Pages/Identity/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5f026e633664af60c268cd95168897122b821de", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Identity_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/azureuser/UbuntuIdentityApp/IdentityApp/Pages/Identity/Index.cshtml"
  
    ViewData["workflow"] = "Overview";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-sm table-striped table-bordered\">\n    <tbody>\n        <tr><th>Email</th><td>");
#nullable restore
#line 8 "/home/azureuser/UbuntuIdentityApp/IdentityApp/Pages/Identity/Index.cshtml"
                         Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n        <tr><th>Phone</th><td>");
#nullable restore
#line 9 "/home/azureuser/UbuntuIdentityApp/IdentityApp/Pages/Identity/Index.cshtml"
                         Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IdentityApp.Pages.Identity.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IdentityApp.Pages.Identity.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IdentityApp.Pages.Identity.IndexModel>)PageContext?.ViewData;
        public IdentityApp.Pages.Identity.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591