#pragma checksum "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\Prorektor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a36f08010c6d646bbf707e2ef02e430ca4e65cb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prorektor_Index), @"mvc.1.0.view", @"/Views/Prorektor/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a36f08010c6d646bbf707e2ef02e430ca4e65cb7", @"/Views/Prorektor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95d1bc3bbc254e387390222101da229c3da7e82f", @"/Views/_ViewImports.cshtml")]
    public class Views_Prorektor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\Prorektor\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrap "">
    <!-- Page title-->
    <div class=""pt-120 pb-130"">
        <div class=""container"">
            <div class=""row gy-60 align-items-center"">
                <div class=""col-12 col-lg-6"">
                    <div class=""gallery-wrapper pe-lg-70"" data-show=""startbox"">
                        <!-- Image-->
                        <!-- Gallery item--><a class=""gallery-item rounded-4 overflow-hidden""
                                               href=""assets/img/service-1-900x990.jpg"" style=""--img-height: 110%;""
                                               data-img-height><img loading=""lazy"" src=""assets/img/prorektor.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 711, "\"", 717, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-12 col-lg-6\">\r\n");
#nullable restore
#line 20 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\Prorektor\Index.cshtml"
                     foreach (var prorektor in Model.Prorektorlar)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"summary\">\r\n                        <h3 class=\"mb-45\" data-show=\"startbox\">\r\n                            \r\n                            ");
#nullable restore
#line 25 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\Prorektor\Index.cshtml"
                       Write(prorektor.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h3>\r\n                        <p class=\"mb-60\" data-show=\"startbox\" data-show-delay=\"100\">\r\n                           ");
#nullable restore
#line 28 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\Prorektor\Index.cshtml"
                      Write(prorektor.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n");
#nullable restore
#line 31 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\Prorektor\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row gy-40\">\r\n                    <!-- Item-->\r\n");
#nullable restore
#line 34 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\Prorektor\Index.cshtml"
                     foreach (var prorektor in Model.Prorektorlar)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-12 col-lg-6\" data-show=\"startbox\">\r\n                            <ul class=\"list fw-medium font-size-15\">\r\n                                <li class=\"active\">\r\n                                    ");
#nullable restore
#line 39 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\Prorektor\Index.cshtml"
                               Write(prorektor.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </li>\r\n                            </ul>\r\n                        </div>\r\n");
#nullable restore
#line 43 "C:\Users\simar\source\repos\UniversityMs\UniversityMs\Views\Prorektor\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
                    <div class=""mt-45"" data-show=""startbox"">
                        <!-- Button--><a class=""btn btn-accent-1 btn-link btn-clean""
                                         href=""http://bsu.edu.az/az/content/mmmdov_hseyn_mikayl_olu"" target=""_self"">
                            Learn
                            more
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
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