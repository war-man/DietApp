#pragma checksum "C:\Users\entra21\source\repos\DietApp\MVCPresentationLayer\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b20fed94366bf2c2ec2d68e61b33e32f4c62e49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\entra21\source\repos\DietApp\MVCPresentationLayer\Views\_ViewImports.cshtml"
using MVCPresentationLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\entra21\source\repos\DietApp\MVCPresentationLayer\Views\_ViewImports.cshtml"
using MVCPresentationLayer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b20fed94366bf2c2ec2d68e61b33e32f4c62e49", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2d5d169d575fa86574904d20d77c9ea194b0ad5", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/profile_small.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle circle-border m-b-md"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/sparkline/jquery.sparkline.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development,Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\entra21\source\repos\DietApp\MVCPresentationLayer\Views\User\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"wrapper wrapper-content animated fadeInRight\">\r\n\r\n    <div class=\"row m-b-lg m-t-lg\">\r\n        <div class=\"col-md-6\">\r\n\r\n            <div class=\"profile-image\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6b20fed94366bf2c2ec2d68e61b33e32f4c62e495487", async() => {
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
            WriteLiteral("\r\n            </div>\r\n            <div class=\"profile-info\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 407, "\"", 415, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div>\r\n                        <h2 class=\"no-margins\">\r\n                            ");
#nullable restore
#line 16 "C:\Users\entra21\source\repos\DietApp\MVCPresentationLayer\Views\User\Index.cshtml"
                       Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <!--User.FindFirst(""Weight"").Value;-->
                        </h2>
                        <small>
                            Perfil
                        </small>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-3"">
            <table class=""table small m-b-xs"">
                <tbody>
                    <tr>
                        <td>
                            <strong>142</strong> Projects
                        </td>
                        <td>
                            <strong>22</strong> Followers
                        </td>

                    </tr>
                    <tr>
                        <td>
                            <strong>61</strong> Comments
                        </td>
                        <td>
                            <strong>54</strong> Articles
                        </td>
                    </tr>
                    <tr>
               ");
            WriteLiteral(@"         <td>
                            <strong>154</strong> Tags
                        </td>
                        <td>
                            <strong>32</strong> Friends
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div class=""col-md-3"">
            <small>Sales in last 24h</small>
            <h2 class=""no-margins"">206 480</h2>
            <div id=""sparkline1""></div>
        </div>


    </div>
    <div class=""row"">

        <div class=""col-lg-3"">

            <div class=""ibox"">
                <div class=""ibox-content"">
                    <h3>");
#nullable restore
#line 71 "C:\Users\entra21\source\repos\DietApp\MVCPresentationLayer\Views\User\Index.cshtml"
                   Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                    <p class=""small"">
                        There are many variations of passages of Lorem Ipsum available, but the majority have
                        suffered alteration in some form, by injected humour, or randomised words which don't.
                        <br />
                        <br />
                        If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't
                        anything embarrassing
                    </p>

                    <p class=""small font-bold"">
                        <span><i class=""fa fa-circle text-navy""></i> Online status</span>
                    </p>

                </div>
            </div>

        </div>
        <div class=""row justify-content-md-center"">
            <div class=""col-lg-10 col-lg-offset-1"">


                <h4 class=""text-center m"">
                    Multiple example with responsive breakpoints
                </h4>



                <div class=""");
            WriteLiteral(@"slick_demo_2"">

                    <div>
                        <div class=""ibox-content"">
                            <h2>Slide 1</h2>
                            <p>
                                Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                                Ipsum has been the industry's standard dummy text ever since the 1500s, when an
                                unknown printer took a galley of type and scrambled it to make a type specimen
                                book. It has survived not only five centuries, but also the leap.
                            </p>
                        </div>
                    </div>
                    <div>
                        <div class=""ibox-content"">
                            <h2>Slide 2</h2>
                            <p>
                                Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                                Ipsum has be");
            WriteLiteral(@"en the industry's standard dummy text ever since the 1500s, when an
                                unknown printer took a galley of type and scrambled it to make a type specimen
                                book. It has survived not only five centuries, but also the leap.
                            </p>
                        </div>
                    </div>
                    <div>
                        <div class=""ibox-content"">
                            <h2>Slide 3</h2>
                            <p>
                                Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                                Ipsum has been the industry's standard dummy text ever since the 1500s, when an
                                unknown printer took a galley of type and scrambled it to make a type specimen
                                book. It has survived not only five centuries, but also the leap.
                            </p>
                    ");
            WriteLiteral(@"    </div>
                    </div>
                    <div>
                        <div class=""ibox-content"">
                            <h2>Slide 4</h2>
                            <p>
                                Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                                Ipsum has been the industry's standard dummy text ever since the 1500s, when an
                                unknown printer took a galley of type and scrambled it to make a type specimen
                                book. It has survived not only five centuries, but also the leap.
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row justify-content-md-center"">
            <div class=""col-lg-10 col-lg-offset-1"">
                <div class=""ibox"">
                    <h4 class=""text-center m"">
                        Animation example wi");
            WriteLiteral(@"th custom speed, ibox title and adoptive height
                    </h4>
                    <div class=""ibox-title"">
                        Example title
                    </div>
                    <div class=""slick_demo_3"">
                        <div>
                            <div class=""ibox-content"">
                                <h2>Slide 1</h2>
                                <p>
                                    Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                                    Ipsum has been the industry's standard dummy text ever since the 1500s, when an
                                    book. It has survived not only five centuries, but also the leap.
                                </p>
                            </div>
                        </div>
                        <div>
                            <div class=""ibox-content"">
                                <h2>Slide 2</h2>
                                ");
            WriteLiteral(@"<p>
                                    Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                                    Ipsum has been the industry's standard dummy text ever since the 1500s, when an
                                    Ipsum has been the industry's standard dummy text ever since the 1500s, when an
                                    unknown printer took a galley of type and scrambled it to make a type specimen
                                    book. It has survived not only five centuries, but also the leap.
                                    Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                                    Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                                    Ipsum has been the industry's standard dummy text ever since the 1500s, when an
                                    unknown printer took a galley of type and scrambled it to m");
            WriteLiteral(@"ake a type specimen
                                    book. It has survived not only five centuries, but also the leap.
                                </p>
                            </div>
                        </div>
                        <div>
                            <div class=""ibox-content"">
                                <h2>Slide 3</h2>
                                <p>
                                    Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                                    Ipsum has been the industry's standard dummy text ever since the 1500s, when an
                                    unknown printer took a galley of type and scrambled it to make a type specimen
                                    book. It has survived not only five centuries, but also the leap.
                                    Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                                    Ipsum has be");
            WriteLiteral(@"en the industry's standard dummy text ever since the 1500s, when an
                                    book. It has survived not only five centuries, but also the leap.
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""col-lg-4 m-b-lg"">
            <div id=""vertical-timeline"" class=""vertical-container light-timeline no-margins"">
                <div class=""vertical-timeline-block"">
                    <div class=""vertical-timeline-icon navy-bg"">
                        <i class=""fa fa-briefcase""></i>
                    </div>

                    <div class=""vertical-timeline-content"">
                        <h2>Meeting</h2>
                        <p>
                            Conference on the sales results for the previous year. Monica please examine sales trends in marketing and products. Below please find the current status ");
            WriteLiteral(@"of the sale.
                        </p>
                        <a href=""#"" class=""btn btn-sm btn-primary""> More info</a>
                        <span class=""vertical-date"">
                            Today <br>
                            <small>Dec 24</small>
                        </span>
                    </div>
                </div>

                <div class=""vertical-timeline-block"">
                    <div class=""vertical-timeline-icon blue-bg"">
                        <i class=""fa fa-file-text""></i>
                    </div>

                    <div class=""vertical-timeline-content"">
                        <h2>Send documents to Mike</h2>
                        <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since.</p>
                        <a href=""#"" class=""btn btn-sm btn-success""> Download document </a>
                        <span class=""vertical-date"">
                  ");
            WriteLiteral(@"          Today <br>
                            <small>Dec 24</small>
                        </span>
                    </div>
                </div>

                <div class=""vertical-timeline-block"">
                    <div class=""vertical-timeline-icon lazur-bg"">
                        <i class=""fa fa-coffee""></i>
                    </div>

                    <div class=""vertical-timeline-content"">
                        <h2>Coffee Break</h2>
                        <p>Go to shop and find some products. Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's. </p>
                        <a href=""#"" class=""btn btn-sm btn-info"">Read more</a>
                        <span class=""vertical-date""> Yesterday <br><small>Dec 23</small></span>
                    </div>
                </div>

                <div class=""vertical-timeline-block"">
                    <div class=""vertical-timeline-icon yellow-bg"">
                 ");
            WriteLiteral(@"       <i class=""fa fa-phone""></i>
                    </div>

                    <div class=""vertical-timeline-content"">
                        <h2>Phone with Jeronimo</h2>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Iusto, optio, dolorum provident rerum aut hic quasi placeat iure tempora laudantium ipsa ad debitis unde? Iste voluptatibus minus veritatis qui ut.</p>
                        <span class=""vertical-date"">Yesterday <br><small>Dec 23</small></span>
                    </div>
                </div>

                <div class=""vertical-timeline-block"">
                    <div class=""vertical-timeline-icon navy-bg"">
                        <i class=""fa fa-comments""></i>
                    </div>

                    <div class=""vertical-timeline-content"">
                        <h2>Chat with Monica and Sandra</h2>
                        <p>Web sites still in their infancy. Various versions have evolved over the years, sometimes by accid");
            WriteLiteral(@"ent, sometimes on purpose (injected humour and the like). </p>
                        <span class=""vertical-date"">Yesterday <br><small>Dec 23</small></span>
                    </div>
                </div>
            </div>

        </div>

    </div>

</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b20fed94366bf2c2ec2d68e61b33e32f4c62e4921358", async() => {
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b20fed94366bf2c2ec2d68e61b33e32f4c62e4921640", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {

            $(""#sparkline1"").sparkline([34, 43, 43, 35, 44, 32, 44, 48], {
                type: 'line',
                width: '100%',
                height: '50',
                lineColor: '#1ab394',
                fillColor: ""transparent""
            });

        });
    </script>
");
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