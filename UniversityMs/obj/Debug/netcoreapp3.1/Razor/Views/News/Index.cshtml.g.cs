#pragma checksum "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\News\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2038a20646ab41559d19aac945dd69ce08c73a96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Index), @"mvc.1.0.view", @"/Views/News/Index.cshtml")]
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
#line 1 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\_ViewImports.cshtml"
using UniversityMs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\_ViewImports.cshtml"
using UniversityMs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2038a20646ab41559d19aac945dd69ce08c73a96", @"/Views/News/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95d1bc3bbc254e387390222101da229c3da7e82f", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\News\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content-wrap \" style=\"padding-top: 40px;\">\r\n    <!-- Page title-->\r\n    <!-- Portfolio section-->\r\n    <div class=\"news\" style=\"padding: 30px;\">\r\n");
#nullable restore
#line 10 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\News\Index.cshtml"
         foreach (var news in Model.Newspages)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4 offset-lg-4 text-center\">\r\n                <h2 class=\"m-0\" data-show=\"startbox\" data-show-delay=\"100\">\r\n                    ");
#nullable restore
#line 14 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\News\Index.cshtml"
               Write(news.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h2>\r\n            </div>\r\n");
#nullable restore
#line 17 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\News\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""py-130 footerPrev"" style=""padding-bottom: 381.75px !important;"">
            <div class=""container"">
                <!-- Isotope-->
                <div class=""isotope"">
                    <div class=""row isotope-grid gy-60"" style=""position: relative; height: 1858.83px;"">
");
#nullable restore
#line 23 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\News\Index.cshtml"
                         foreach (var news in Model.Newspages)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class="" isotope-item col-12"" data-filters=""architecture""
                                 style=""position: absolute; left: 0px; top: 0px;"">
                                <!-- Portfolio-->
                                <div class=""card card-portfolio  card-hover-zoom card-horizontal"">
                                    <a class=""card-img rounded-4 overflow-hidden"" href=""project-single-01.html""
                                       data-img-height="""" style=""--img-height: 86%;"">
                                        <img loading=""lazy""");
            BeginWriteAttribute("src", "\r\n                                             src=\"", 1462, "\"", 1536, 2);
            WriteAttributeValue("", 1514, "assets/img/", 1514, 11, true);
#nullable restore
#line 32 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\News\Index.cshtml"
WriteAttributeValue("", 1525, news.Image, 1525, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1537, "\"", 1543, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </a>\r\n                                    <div class=\"card-body\">\r\n                                        <h4 class=\"service-case-title mb-15\">\r\n                                           ");
#nullable restore
#line 36 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\News\Index.cshtml"
                                      Write(news.Newstitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </h4>\r\n                                        <p class=\"service-case-text font-size-15 mb-30\">\r\n                                            <b>\r\n                                               ");
#nullable restore
#line 40 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\News\Index.cshtml"
                                          Write(news.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </b>\r\n                                        </p>\r\n                                        <p class=\"card-text\">\r\n                                           ");
#nullable restore
#line 44 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\News\Index.cshtml"
                                      Write(news.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 49 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\News\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
