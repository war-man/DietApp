#pragma checksum "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\DietSystem\DietApp\MVCPresentationLayer\Views\Shared\_Navigation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d69de73959c1c2413bfe41f8c17bbea29a3dc03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Navigation), @"mvc.1.0.view", @"/Views/Shared/_Navigation.cshtml")]
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
#line 1 "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\DietSystem\DietApp\MVCPresentationLayer\Views\_ViewImports.cshtml"
using MVCPresentationLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\DietSystem\DietApp\MVCPresentationLayer\Views\_ViewImports.cshtml"
using MVCPresentationLayer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d69de73959c1c2413bfe41f8c17bbea29a3dc03", @"/Views/Shared/_Navigation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2d5d169d575fa86574904d20d77c9ea194b0ad5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Navigation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/profile_small.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/logo_Icon_small.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""navbar-default navbar-static-side"" role=""navigation"">
    <div class=""sidebar-collapse"">
        <ul class=""nav metismenu"" id=""side-menu"">
            <li class=""nav-header"">
                <div class=""dropdown profile-element"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5d69de73959c1c2413bfe41f8c17bbea29a3dc034927", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <a data-toggle=\"dropdown\" class=\"dropdown-toggle\" href=\"#\">\r\n                        <span class=\"block m-t-xs font-bold\">");
#nullable restore
#line 8 "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\DietSystem\DietApp\MVCPresentationLayer\Views\Shared\_Navigation.cshtml"
                                                        Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        <span class=""text-muted text-xs block"">Perfil <b class=""caret""></b></span>
                    </a>
                    <ul class=""dropdown-menu animated fadeInRight m-t-xs"" style=""position: absolute; top: 91px; left: 0px; will-change: top, left;"">
                        <li><a class=""dropdown-item"" href=""#"">Sair</a></li>
                    </ul>
                </div>
                <div class=""logo-element"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5d69de73959c1c2413bfe41f8c17bbea29a3dc037073", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </li>\r\n            <li");
            BeginWriteAttribute("class", " class=\"", 1096, "\"", 1157, 1);
#nullable restore
#line 19 "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\DietSystem\DietApp\MVCPresentationLayer\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1104, Html.IsSelected(controller: "Home", action: "Index"), 1104, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1179, "\"", 1214, 1);
#nullable restore
#line 20 "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\DietSystem\DietApp\MVCPresentationLayer\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1186, Url.Action("Index", "Home"), 1186, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-user\"></i> <span class=\"nav-label\"></span>Perfil<span class=\"label label-primary float-right\">Início</span></a>\r\n            </li>\r\n\r\n");
#nullable restore
#line 23 "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\DietSystem\DietApp\MVCPresentationLayer\Views\Shared\_Navigation.cshtml"
              if (User.FindFirst("Role").Value == "Admin")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li");
            BeginWriteAttribute("class", " class=\"", 1468, "\"", 1530, 1);
#nullable restore
#line 25 "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\DietSystem\DietApp\MVCPresentationLayer\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1476, Html.IsSelected(controller: "Meal", action: "Insert"), 1476, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1560, "\"", 1596, 1);
#nullable restore
#line 26 "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\DietSystem\DietApp\MVCPresentationLayer\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1567, Url.Action("Insert", "Meal"), 1567, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-user\"></i> <span class=\"nav-label\"></span>Refeições<span class=\"label label-danger float-right\">Admin</span></a>\r\n                    </li>\r\n                    <li");
            BeginWriteAttribute("class", " class=\"", 1778, "\"", 1839, 1);
#nullable restore
#line 28 "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\DietSystem\DietApp\MVCPresentationLayer\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1786, Html.IsSelected(controller: "User", action: "Users"), 1786, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1869, "\"", 1904, 1);
#nullable restore
#line 29 "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\DietSystem\DietApp\MVCPresentationLayer\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1876, Url.Action("Users", "User"), 1876, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-user\"></i> <span class=\"nav-label\"></span>Usuários<span class=\"label label-danger float-right\">Admin</span></a>\r\n                    </li>\r\n");
#nullable restore
#line 31 "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\DietSystem\DietApp\MVCPresentationLayer\Views\Shared\_Navigation.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n</nav>");
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
