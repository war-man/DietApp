#pragma checksum "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\ASPNET_Core_2_1_Full_Project\ASPNET_Core_2_1\Views\Graphs\Sparkline.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14bdca9e657d37c6f2fc7b46c1584e549b460fb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Graphs_Sparkline), @"mvc.1.0.view", @"/Views/Graphs/Sparkline.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Graphs/Sparkline.cshtml", typeof(AspNetCore.Views_Graphs_Sparkline))]
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
#line 1 "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\ASPNET_Core_2_1_Full_Project\ASPNET_Core_2_1\Views\_ViewImports.cshtml"
using ASPNET_Core_2_1;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14bdca9e657d37c6f2fc7b46c1584e549b460fb8", @"/Views/Graphs/Sparkline.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf3ab1a3ff43760fcc2127914d0c3d050c712654", @"/Views/_ViewImports.cshtml")]
    public class Views_Graphs_Sparkline : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/sparkline/jquery.sparkline.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development,Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\ASPNET_Core_2_1_Full_Project\ASPNET_Core_2_1\Views\Graphs\Sparkline.cshtml"
  
    ViewData["Title"] = "Sparkline";

#line default
#line hidden
            BeginContext(43, 216, true);
            WriteLiteral("\n<div class=\"row wrapper border-bottom white-bg page-heading\">\n    <div class=\"col-lg-10\">\n        <h2>Sparkline Charts</h2>\n        <ol class=\"breadcrumb\">\n            <li class=\"breadcrumb-item\">\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 259, "\"", 306, 1);
#line 11 "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\ASPNET_Core_2_1_Full_Project\ASPNET_Core_2_1\Views\Graphs\Sparkline.cshtml"
WriteAttributeValue("", 266, Url.Action("Dashboard_1", "Dashboards"), 266, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(307, 7528, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>Graphs</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Sparkline Charts</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>
<div class=""wrapper wrapper-content animated fadeInDown"">

    <div class=""row"">
        <div class=""col-lg-5"">
            <div class=""jumbotron"">
                <h1>Sparkline</h1>
                <p>It's another graet library for inline graphics visualization.</p>
                <p>
                    <a href=""http://omnipotent.net/jquery.sparkline"" target=""_blank"" class=""btn btn-primary btn-lg"" role=""button"">Learn more about Sparkline</a>
                </p>
            </div>
        </div>
        <div class=""col-lg-7"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Sparkline Charts <small>With custom colors.</small></h5>
                    <div class=");
            WriteLiteral(@"""ibox-tools"">
                        <a class=""close-link"">
                            <i class=""fa fa-times""></i>
                        </a>
                    </div>
                </div>
                <div>
                    <table class=""table table-bordered white-bg"">
                        <thead>
                            <tr>
                                <th>Graph</th>
                                <th>Type</th>
                            </tr>
                        </thead>

                        <tbody>
                            <tr>
                                <td>
                                    <span id=""sparkline1""></span>
                                </td>
                                <td>
                                    Inline line chart
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span id=""sparkline2""></span>
         ");
            WriteLiteral(@"                       </td>
                                <td>
                                    Bar chart
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span id=""sparkline3""></span>
                                </td>
                                <td>
                                    Pie chart
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span id=""sparkline4""></span>
                                </td>
                                <td>
                                    Long inline chart
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span id=""sparkline5""></span>
                                </td>
");
            WriteLiteral(@"                                <td>
                                    Tristate chart
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span id=""sparkline6""></span>
                                </td>
                                <td>
                                    Discrete chart
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-4"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Custom pie size example</h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                        <a class=""dr");
            WriteLiteral(@"opdown-toggle"" data-toggle=""dropdown"" href=""#"">
                            <i class=""fa fa-wrench""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 1</a>
                            </li>
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 2</a>
                            </li>
                        </ul>
                        <a class=""close-link"">
                            <i class=""fa fa-times""></i>
                        </a>
                    </div>
                </div>
                <div class=""ibox-content text-center h-200"">
                    <span id=""sparkline7""></span>
                </div>
            </div>
        </div>
        <div class=""col-lg-4"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Custom bar ");
            WriteLiteral(@"size example</h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                            <i class=""fa fa-wrench""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 1</a>
                            </li>
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 2</a>
                            </li>
                        </ul>
                        <a class=""close-link"">
                            <i class=""fa fa-times""></i>
                        </a>
                    </div>
                </div>
                <div class=""ibox-content text-center h-200"">
       ");
            WriteLiteral(@"             <span id=""sparkline8""></span>
                </div>
            </div>
        </div>
        <div class=""col-lg-4"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Custom line size example</h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                            <i class=""fa fa-wrench""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 1</a>
                            </li>
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 2</a>
                            </li>
                        </ul>
          ");
            WriteLiteral(@"              <a class=""close-link"">
                            <i class=""fa fa-times""></i>
                        </a>
                    </div>
                </div>
                <div class=""ibox-content text-center h-200"">
                    <span id=""sparkline9""></span>
                </div>
            </div>
        </div>

    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7853, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(7858, 143, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e169eee0dac64c40950816d873cde235", async() => {
                    BeginContext(7910, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(7919, 63, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d0a0bc822ba46c7b4e8b8705b89757c", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(7982, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8001, 2198, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {

            $(""#sparkline1"").sparkline([34, 43, 43, 35, 44, 32, 44, 52, 25], {
                type: 'line',
                lineColor: '#17997f',
                fillColor: '#1ab394',
            });
            $(""#sparkline2"").sparkline([5, 6, 7, 2, 0, -4, -2, 4], {
                type: 'bar',
                barColor: '#1ab394',
                negBarColor: '#c6c6c6'
            });

            $(""#sparkline3"").sparkline([1, 1, 2], {
                type: 'pie',
                sliceColors: ['#1ab394', '#b3b3b3', '#e4f0fb']
            });

            $(""#sparkline4"").sparkline([34, 43, 43, 35, 44, 32, 15, 22, 46, 33, 86, 54, 73, 53, 12, 53, 23, 65, 23, 63, 53, 42, 34, 56, 76, 15, 54, 23, 44], {
                type: 'line',
                lineColor: '#17997f',
                fillColor: '#ffffff',
            });

            $(""#sparkline5"").sparkline([1, 1, 0, 1, -1, -1, 1, -1, 0, 0, 1, 1], {
                type: 'trist");
                WriteLiteral(@"ate',
                posBarColor: '#1ab394',
                negBarColor: '#bfbfbf'
            });


            $(""#sparkline6"").sparkline([4, 6, 7, 7, 4, 3, 2, 1, 4, 4, 5, 6, 3, 4, 5, 8, 7, 6, 9, 3, 2, 4, 1, 5, 6, 4, 3, 7,], {
                type: 'discrete',
                lineColor: '#1ab394'
            });

            $(""#sparkline7"").sparkline([52, 12, 44], {
                type: 'pie',
                height: '150px',
                sliceColors: ['#1ab394', '#b3b3b3', '#e4f0fb']
            });

            $(""#sparkline8"").sparkline([5, 6, 7, 2, 0, 4, 2, 4, 5, 7, 2, 4, 12, 14, 4, 2, 14, 12, 7], {
                type: 'bar',
                barWidth: 8,
                height: '150px',
                barColor: '#1ab394',
                negBarColor: '#c6c6c6'
            });

            $(""#sparkline9"").sparkline([34, 43, 43, 35, 44, 32, 15, 22, 46, 33, 86, 54, 73, 53, 12, 53, 23, 65, 23, 63, 53, 42, 34, 56, 76, 15, 54, 23, 44], {
                type: 'line',
                lineWidth: 1,
 ");
                WriteLiteral("               height: \'150px\',\n                lineColor: \'#17997f\',\n                fillColor: \'#ffffff\',\n            });\n        });\n    </script>\n");
                EndContext();
            }
            );
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