#pragma checksum "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Areas\Admin\Views\Posts\UnAccepteds.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21540b6169675260a944657dc21c3d6524f1b6a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Posts_UnAccepteds), @"mvc.1.0.view", @"/Areas/Admin/Views/Posts/UnAccepteds.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Posts/UnAccepteds.cshtml", typeof(AspNetCore.Areas_Admin_Views_Posts_UnAccepteds))]
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
#line 1 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Areas\Admin\Views\_ViewImports.cshtml"
using TheBlogger;

#line default
#line hidden
#line 2 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Areas\Admin\Views\_ViewImports.cshtml"
using TheBlogger.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21540b6169675260a944657dc21c3d6524f1b6a3", @"/Areas/Admin/Views/Posts/UnAccepteds.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea58112872f29988f3fafc1d46e67dfa1786489", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Posts_UnAccepteds : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TheBlogger.Models.Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Areas\Admin\Views\Posts\UnAccepteds.cshtml"
  
    ViewData["Title"] = "UnAccepteds";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(157, 1362, true);
            WriteLiteral(@"<div class=""page-header"">
    <div class=""container-fluid"">
        <h2 class=""h5 no-margin-bottom"">Postlarımıza Hoş Geldiniz</h2>
    </div>
</div>
<div class=""col-lg-12"">
    <div class=""block"">
        <div class=""block-body"">
            <section class=""no-padding-top"">
                <div class=""container-fluid"">
                    <div class=""row"">
                        <div class=""col-lg-5"">
                            <div class=""block"">

                            </div>
                        </div>
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th>
                                        Post Başlığı
                                    </th>
                                    <th>
                                        İçerik
                                    </th>
                                    <th>
                                        Tarih
    ");
            WriteLiteral(@"                                </th>
                                    <th>
                                        Post Durumu
                                    </th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 42 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Areas\Admin\Views\Posts\UnAccepteds.cshtml"
                                 foreach (var item in Model.Where(i => i.PostState == 0))
                                {

#line default
#line hidden
            BeginContext(1645, 132, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(1778, 40, false);
#line 46 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Areas\Admin\Views\Posts\UnAccepteds.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.title));

#line default
#line hidden
            EndContext();
            BeginContext(1818, 95, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n");
            EndContext();
#line 49 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Areas\Admin\Views\Posts\UnAccepteds.cshtml"
                                              
                                                string icerik = "";
                                                if (item.content.Length <= 15)
                                                {
                                                    icerik = item.content;
                                                }
                                                else
                                                {
                                                    icerik = item.content.Substring(0, 15);
                                                }
                                            

#line default
#line hidden
            BeginContext(2584, 44, true);
            WriteLiteral("                                            ");
            EndContext();
            BeginContext(2629, 16, false);
#line 60 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Areas\Admin\Views\Posts\UnAccepteds.cshtml"
                                       Write(Html.Raw(icerik));

#line default
#line hidden
            EndContext();
            BeginContext(2645, 142, true);
            WriteLiteral("...\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(2788, 44, false);
#line 63 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Areas\Admin\Views\Posts\UnAccepteds.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.TimeStamp));

#line default
#line hidden
            EndContext();
            BeginContext(2832, 294, true);
            WriteLiteral(@"
                                        </td>
                                        <td>
                                            Onay Bekliyor...
                                        </td>
                                        <td>
                                            ");
            EndContext();
            BeginContext(3126, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21540b6169675260a944657dc21c3d6524f1b6a39005", async() => {
                BeginContext(3171, 6, true);
                WriteLiteral("Onayla");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Areas\Admin\Views\Posts\UnAccepteds.cshtml"
                                                                   WriteLiteral(item.id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3181, 48, true);
            WriteLiteral(" |\r\n                                            ");
            EndContext();
            BeginContext(3229, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21540b6169675260a944657dc21c3d6524f1b6a311426", async() => {
                BeginContext(3276, 3, true);
                WriteLiteral("Sil");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Areas\Admin\Views\Posts\UnAccepteds.cshtml"
                                                                     WriteLiteral(item.id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3283, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 73 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Areas\Admin\Views\Posts\UnAccepteds.cshtml"
                                }

#line default
#line hidden
            BeginContext(3410, 182, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </section>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TheBlogger.Models.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
