#pragma checksum "D:\C#Code\CODE THAM KHẢO\TaQuangHuy_19520113\TaQuangHuy_19520113\Views\SanPham\LietKeCacSanPham.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffeeccfebe8c0cf15a38fbf0c7ab67d2223bec81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPham_LietKeCacSanPham), @"mvc.1.0.view", @"/Views/SanPham/LietKeCacSanPham.cshtml")]
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
#line 1 "D:\C#Code\CODE THAM KHẢO\TaQuangHuy_19520113\TaQuangHuy_19520113\Views\_ViewImports.cshtml"
using TaQuangHuy_19520113;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#Code\CODE THAM KHẢO\TaQuangHuy_19520113\TaQuangHuy_19520113\Views\_ViewImports.cshtml"
using TaQuangHuy_19520113.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffeeccfebe8c0cf15a38fbf0c7ab67d2223bec81", @"/Views/SanPham/LietKeCacSanPham.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df0feba1e7ed1cc528e84bc0a0fbf9344cf1b596", @"/Views/_ViewImports.cshtml")]
    public class Views_SanPham_LietKeCacSanPham : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TaQuangHuy_19520113.Models.SanPham>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\C#Code\CODE THAM KHẢO\TaQuangHuy_19520113\TaQuangHuy_19520113\Views\SanPham\LietKeCacSanPham.cshtml"
  
    ViewData["Title"] = "Liệt kê sản phẩm";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Danh Sách các sản phẩm</h2>\r\n<table border=\"1\">\r\n    <tr>\r\n        <th>Mã SP</th>\r\n        <th>Tên SP</th>\r\n        <th>DVT</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 14 "D:\C#Code\CODE THAM KHẢO\TaQuangHuy_19520113\TaQuangHuy_19520113\Views\SanPham\LietKeCacSanPham.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 18 "D:\C#Code\CODE THAM KHẢO\TaQuangHuy_19520113\TaQuangHuy_19520113\Views\SanPham\LietKeCacSanPham.cshtml"
           Write(item.MaSP);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 22 "D:\C#Code\CODE THAM KHẢO\TaQuangHuy_19520113\TaQuangHuy_19520113\Views\SanPham\LietKeCacSanPham.cshtml"
           Write(item.TenSP);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "D:\C#Code\CODE THAM KHẢO\TaQuangHuy_19520113\TaQuangHuy_19520113\Views\SanPham\LietKeCacSanPham.cshtml"
           Write(item.Dvt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "D:\C#Code\CODE THAM KHẢO\TaQuangHuy_19520113\TaQuangHuy_19520113\Views\SanPham\LietKeCacSanPham.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TaQuangHuy_19520113.Models.SanPham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
