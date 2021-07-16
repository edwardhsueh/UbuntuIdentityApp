#pragma checksum "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Pages/Identity/_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32308ef19392383a0bd6d5fa90b282003230f1f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Identity__Layout), @"mvc.1.0.view", @"/Pages/Identity/_Layout.cshtml")]
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
#line 2 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Pages/_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Pages/_ViewImports.cshtml"
using IdentityApp.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Pages/_ViewImports.cshtml"
using IdentityApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32308ef19392383a0bd6d5fa90b282003230f1f1", @"/Pages/Identity/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5f026e633664af60c268cd95168897122b821de", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Identity__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_LoginPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Pages/Identity/_Layout.cshtml"
  
    string theme = ViewData["theme"] as string ?? "primary";
    bool showNav = ViewData["showNav"] as bool? ?? true;
    string navPartial = ViewData["navPartial"] as string ?? "_Workflows";
    string workflow = ViewData["workflow"] as string;
    string banner =  ViewData["banner"] as string ?? "User Dashboard";
    bool showHeader = ViewData["showHeader"] as bool? ?? true;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32308ef19392383a0bd6d5fa90b282003230f1f16215", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>Identity App</title>\n    <link href=\"/lib/twitter-bootstrap/css/bootstrap.min.css\" rel=\"stylesheet\" />\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32308ef19392383a0bd6d5fa90b282003230f1f17346", async() => {
                WriteLiteral("\n");
#nullable restore
#line 17 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Pages/Identity/_Layout.cshtml"
     if (showHeader) {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <nav class=""navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3"">
            <div class=""container"">
                <a class=""navbar-brand"">IdentityApp</a>
                <div class=""navbar-collapse collapse d-sm-inline-flex justify-content-between"">
                    <ul class=""navbar-nav flex-grow-1"">
                        <li class=""nav-item"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32308ef19392383a0bd6d5fa90b282003230f1f18277", async() => {
                    WriteLiteral("Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        </li>\n                    </ul>\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32308ef19392383a0bd6d5fa90b282003230f1f110058", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </div>\n            </div>\n        </nav>\n");
#nullable restore
#line 35 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Pages/Identity/_Layout.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <h4");
                BeginWriteAttribute("class", " class=\"", 1543, "\"", 1587, 5);
                WriteAttributeValue("", 1551, "bg-", 1551, 3, true);
#nullable restore
#line 36 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Pages/Identity/_Layout.cshtml"
WriteAttributeValue("", 1554, theme, 1554, 6, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1560, "text-center", 1561, 12, true);
                WriteAttributeValue(" ", 1572, "text-white", 1573, 11, true);
                WriteAttributeValue(" ", 1583, "p-2", 1584, 4, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 36 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Pages/Identity/_Layout.cshtml"
                                                Write(banner);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\n    <div class=\"my-2\">\n        <div class=\"container-fluid\">\n            <div class=\"row\">\n");
#nullable restore
#line 40 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Pages/Identity/_Layout.cshtml"
                 if (showNav) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"col-auto\">\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32308ef19392383a0bd6d5fa90b282003230f1f112847", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Pages/Identity/_Layout.cshtml"
                           WriteLiteral(navPartial);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 42 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Pages/Identity/_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = ((workflow, theme));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    </div>\n");
#nullable restore
#line 44 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Pages/Identity/_Layout.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"col\">\n                    ");
#nullable restore
#line 46 "/home/edwardhsueh/Documents/GitHub/UbuntuIdentityApp/IdentityApp/Pages/Identity/_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
