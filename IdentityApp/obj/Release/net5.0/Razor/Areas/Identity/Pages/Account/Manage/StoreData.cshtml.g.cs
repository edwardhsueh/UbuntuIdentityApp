#pragma checksum "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Areas/Identity/Pages/Account/Manage/StoreData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79440dcd9121f545ffe91d6fae1bc60755362729"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage_StoreData), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/StoreData.cshtml")]
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
#line 1 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Areas/Identity/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Areas/Identity/Pages/_ViewImports.cshtml"
using IdentityApp.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Areas/Identity/Pages/_ViewImports.cshtml"
using IdentityApp.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Areas/Identity/Pages/Account/_ViewImports.cshtml"
using IdentityApp.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml"
using IdentityApp.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79440dcd9121f545ffe91d6fae1bc60755362729", @"/Areas/Identity/Pages/Account/Manage/StoreData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9e7d834de3b9571a7a8fc377c1ce21ca40739f2", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ccee0d937a37f1edc2704a7e4de796654785dbd", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfaa105a24fc8c5012f68768dfe3bd12dc3552aa", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_StoreData : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Areas/Identity/Pages/Account/Manage/StoreData.cshtml"
                                                                                                                                                                                                                                                                                                    
    ViewData["ActivePage"] = ManageNavPages.StoreData;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Areas/Identity/Pages/Account/Manage/StoreData.cshtml"
                                                          
    IdentityUser user = await UserManager.GetUserAsync(User);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n<h2>Store Data</h2>\n<table class=\"table table-sm table-bordered table-striped\">\n    <thead>\n        <tr><th>Property</th><th>Value</th></tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 17 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Areas/Identity/Pages/Account/Manage/StoreData.cshtml"
         foreach (var prop in typeof(IdentityUser).GetProperties()) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 19 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Areas/Identity/Pages/Account/Manage/StoreData.cshtml"
                   Write(prop.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 20 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Areas/Identity/Pages/Account/Manage/StoreData.cshtml"
                   Write(prop.GetValue(user));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 22 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Areas/Identity/Pages/Account/Manage/StoreData.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Areas_Identity_Pages_Account_Manage_StoreData> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Identity_Pages_Account_Manage_StoreData> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas_Identity_Pages_Account_Manage_StoreData>)PageContext?.ViewData;
        public Areas_Identity_Pages_Account_Manage_StoreData Model => ViewData.Model;
    }
}
#pragma warning restore 1591
