#pragma checksum "D:\C#Code\CODE THAM KHẢO\firstWeb\firstWeb\Views\Khoa\InsertKhoa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ac98102659d9794816a82030fea2b7e32fb0bc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Khoa_InsertKhoa), @"mvc.1.0.view", @"/Views/Khoa/InsertKhoa.cshtml")]
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
#line 1 "D:\C#Code\CODE THAM KHẢO\firstWeb\firstWeb\Views\_ViewImports.cshtml"
using firstWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\C#Code\CODE THAM KHẢO\firstWeb\firstWeb\Views\Khoa\InsertKhoa.cshtml"
using firstWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ac98102659d9794816a82030fea2b7e32fb0bc1", @"/Views/Khoa/InsertKhoa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea9515439e0332af4f526c5f2070991c3ff06d3a", @"/Views/_ViewImports.cshtml")]
    public class Views_Khoa_InsertKhoa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Khoa>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\C#Code\CODE THAM KHẢO\firstWeb\firstWeb\Views\Khoa\InsertKhoa.cshtml"
  
    ViewData["Title"] = "Thông tin lấy được từ form";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\C#Code\CODE THAM KHẢO\firstWeb\firstWeb\Views\Khoa\InsertKhoa.cshtml"
  
    /*
    <p>Mã khoa:@Model.MaKhoa</p>
    <p>Tên khoa:@Model.TenKhoa</p>
    */

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 11 "D:\C#Code\CODE THAM KHẢO\firstWeb\firstWeb\Views\Khoa\InsertKhoa.cshtml"
  Write(ViewData["ThongBao"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Khoa> Html { get; private set; }
    }
}
#pragma warning restore 1591
