#pragma checksum "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\DevCard\DevCard_Mvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fcaf7da9669a0c93f90e1c0633926b365794027"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\DevCard\DevCard_Mvc\Views\_ViewImports.cshtml"
using DevCard_Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\DevCard\DevCard_Mvc\Views\_ViewImports.cshtml"
using DevCard_Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fcaf7da9669a0c93f90e1c0633926b365794027", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3de1a09574fcca7cc0cd1ac5dfb072ded2fb18c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\DevCard\DevCard_Mvc\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"about-me-section p-3 p-lg-5 theme-bg-light\">\r\n    <div class=\"container\">\r\n        <div class=\"profile-teaser media flex-column flex-lg-row\">\r\n            <img class=\"profile-image mb-3 mb-lg-0 ml-lg-5 mr-md-0\" src=\"assets/images/me.jpeg\"");
            BeginWriteAttribute("alt", " alt=\"", 299, "\"", 305, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""media-body"">
                <h2 class=""name font-weight-bold mb-1"">حسین عباس آبادی</h2>
                <div class=""tagline mb-3"">برنامه نویس ارشد</div>
                <div class=""bio mb-4"">
                    لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از
                    طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و
                    جوابگوی سوالات پیوسته اهل دنیای موجود طراحی اساسا مورد استفاده قرار گیرد.
                </div>
                <div class=""mb-4"">
                    <a class=""btn btn-primary mr-2 mb-3"" href=""http://www.atriya.com"">
                        <i class=""fas fa-arrow-alt-circle-right ml-2""></i><span class=""d-none d-md-inline"">
                            برو
                            به
                        </span> آتریا
                    </a>
                    <a class=""btn btn-secondary mb-3"" href=""#"">
                        <i class=""fas fa-file-a");
            WriteLiteral("lt ml-2\"></i>\r\n                        <span class=\"d-none d-md-inline\">مشاهده </span> نمونه کارها\r\n                    </a>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n");
#nullable restore
#line 33 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\DevCard\DevCard_Mvc\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Projects"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <hr>\r\n</div>\r\n");
#nullable restore
#line 37 "D:\Danial - Davood\Design website and programing\Asp.netCore\Project\DevCard\DevCard_Mvc\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Articles"));

#line default
#line hidden
#nullable disable
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