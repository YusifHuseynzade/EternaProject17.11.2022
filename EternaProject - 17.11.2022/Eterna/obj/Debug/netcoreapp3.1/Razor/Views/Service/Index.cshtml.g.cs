#pragma checksum "C:\Users\DELL\Desktop\EternaProject\Eterna\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2abf574249453eecc510ddaf403cc2c903d2e2e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
#line 1 "C:\Users\DELL\Desktop\EternaProject\Eterna\Views\_ViewImports.cshtml"
using Eterna.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Desktop\EternaProject\Eterna\Views\_ViewImports.cshtml"
using Eterna.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2abf574249453eecc510ddaf403cc2c903d2e2e4", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e84cce85c4d1c3e71e7258db048fa07384d91ec", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "service", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/skills-img.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<main id=""main"">

    <!-- ======= Breadcrumbs ======= -->
    <section id=""breadcrumbs"" class=""breadcrumbs"">
        <div class=""container"">

            <ol>
                <li><a href=""index.html"">Home</a></li>
                <li>Services</li>
            </ol>
            <h2>Services</h2>

        </div>
    </section><!-- End Breadcrumbs -->
    <!-- ======= Services Section ======= -->
    <section id=""services"" class=""services"">
        <div class=""container"">

            <div class=""row"">

");
#nullable restore
#line 23 "C:\Users\DELL\Desktop\EternaProject\Eterna\Views\Service\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6 d-flex align-items-stretch mb-4\">\r\n                        <div class=\"icon-box\">\r\n                            <div class=\"icon\">");
#nullable restore
#line 27 "C:\Users\DELL\Desktop\EternaProject\Eterna\Views\Service\Index.cshtml"
                                         Write(Html.Raw(item.Icon));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2abf574249453eecc510ddaf403cc2c903d2e2e46189", async() => {
#nullable restore
#line 28 "C:\Users\DELL\Desktop\EternaProject\Eterna\Views\Service\Index.cshtml"
                                                                                                    Write(item.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\DELL\Desktop\EternaProject\Eterna\Views\Service\Index.cshtml"
                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\r\n                            <p>");
#nullable restore
#line 29 "C:\Users\DELL\Desktop\EternaProject\Eterna\Views\Service\Index.cshtml"
                          Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 32 "C:\Users\DELL\Desktop\EternaProject\Eterna\Views\Service\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>

        </div>
    </section><!-- End Services Section -->
    <!-- ======= Our Skills Section ======= -->
    <section id=""skills"" class=""skills"">
        <div class=""container"">

            <div class=""section-title"">
                <h2>Our Skills</h2>
                <p>Magnam dolores commodi suscipit. Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate. Et nemo qui impedit suscipit alias ea. Quia fugiat sit in iste officiis commodi quidem hic quas.</p>
            </div>

            <div class=""row"">
                <div class=""col-lg-6"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2abf574249453eecc510ddaf403cc2c903d2e2e410036", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""col-lg-6 pt-4 pt-lg-0 content"">
                    <h3>Voluptatem dignissimos provident quasi corporis voluptates</h3>
                    <p class=""fst-italic"">
                        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt direna past reda
                    </p>

                    <div class=""skills-content"">

                        <div class=""progress"">
                            <span class=""skill"">HTML <i class=""val"">100%</i></span>
                            <div class=""progress-bar-wrap"">
                                <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                        </div>

                        <div class=""progress"">
                            <span class=""skill"">CSS <i class=""val"">90%</i></span>
                            <div class=""progress-bar-w");
            WriteLiteral(@"rap"">
                                <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""90"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                        </div>

                        <div class=""progress"">
                            <span class=""skill"">JavaScript <i class=""val"">75%</i></span>
                            <div class=""progress-bar-wrap"">
                                <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                        </div>

                        <div class=""progress"">
                            <span class=""skill"">Photoshop <i class=""val"">55%</i></span>
                            <div class=""progress-bar-wrap"">
                                <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""55"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                  ");
            WriteLiteral("      </div>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </section><!-- End Our Skills Section -->\r\n\r\n</main><!-- End #main -->\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
