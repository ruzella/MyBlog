#pragma checksum "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8430cbc2feb9406b002963d77c00b62cfbb8ed7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Views\_ViewImports.cshtml"
using TheBlogger.Models;

#line default
#line hidden
#line 2 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Views\_ViewImports.cshtml"
using TheBlogger.ViewModel;

#line default
#line hidden
#line 3 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8430cbc2feb9406b002963d77c00b62cfbb8ed7e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb9cec59b2d3ecdb39aac83137f2a06df15a27a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-3 img-fluid post-thumb d-none d-md-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/blog/blog-post-thumb-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(80, 384, true);
            WriteLiteral(@"
<div class=""main-wrapper"">
    <section class=""cta-section theme-bg-light py-5"">
        <div class=""container text-center"">
            <h2 class=""heading"">The Blogger</h2>
            <div class=""intro"">Blog sayfama hoş geldiniz...</div>


        </div><!--//container-->
    </section>
    <section class=""blog-list px-3 py-5 p-md-5"">
        <div class=""container"">
");
            EndContext();
#line 17 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(521, 106, true);
            WriteLiteral("                <div class=\"item mb-5\">\r\n                    <div class=\"media\">\r\n                        ");
            EndContext();
            BeginContext(627, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8430cbc2feb9406b002963d77c00b62cfbb8ed7e5522", async() => {
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
            EndContext();
            BeginContext(744, 105, true);
            WriteLiteral("\r\n                        <div class=\"media-body\">\r\n                            <h3 class=\"title mb-1\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 849, "\"", 881, 4);
            WriteAttributeValue("", 856, "/", 856, 1, true);
#line 23 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Views\Home\Index.cshtml"
WriteAttributeValue("", 857, item.user, 857, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 867, "/Post/", 867, 6, true);
#line 23 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Views\Home\Index.cshtml"
WriteAttributeValue("", 873, item.id, 873, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(882, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(884, 10, false);
#line 23 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Views\Home\Index.cshtml"
                                                                                  Write(item.title);

#line default
#line hidden
            EndContext();
            BeginContext(894, 81, true);
            WriteLiteral("</a></h3>\r\n                            <div class=\"meta mb-1\"><span class=\"date\">");
            EndContext();
            BeginContext(976, 14, false);
#line 24 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Views\Home\Index.cshtml"
                                                                 Write(item.TimeStamp);

#line default
#line hidden
            EndContext();
            BeginContext(990, 32, true);
            WriteLiteral("</span><span class=\"user-block\">");
            EndContext();
            BeginContext(1023, 18, false);
#line 24 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Views\Home\Index.cshtml"
                                                                                                                Write(item.user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1041, 66, true);
            WriteLiteral("</span></div>\r\n                            <div class=\"intro\">\r\n\r\n");
            EndContext();
#line 27 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Views\Home\Index.cshtml"
                                  
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
            BeginContext(1646, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1679, 16, false);
#line 38 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Views\Home\Index.cshtml"
                           Write(Html.Raw(icerik));

#line default
#line hidden
            EndContext();
            BeginContext(1695, 92, true);
            WriteLiteral("   ...\r\n                            </div>\r\n                            <a class=\"more-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1787, "\"", 1819, 4);
            WriteAttributeValue("", 1794, "/", 1794, 1, true);
#line 40 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Views\Home\Index.cshtml"
WriteAttributeValue("", 1795, item.user, 1795, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1805, "/Post/", 1805, 6, true);
#line 40 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Views\Home\Index.cshtml"
WriteAttributeValue("", 1811, item.id, 1811, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1820, 154, true);
            WriteLiteral(">Daha Fazla &rarr;</a>\r\n                        </div><!--//media-body-->\r\n                    </div><!--//media-->\r\n                </div><!--//item-->\r\n");
            EndContext();
#line 44 "C:\Users\ruzbi\OneDrive\Masaüstü\TheBlogger\TheBlogger\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1989, 63, true);
            WriteLiteral("\r\n\r\n        </div>\r\n    </section>\r\n</div><!--//main-wrapper-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
