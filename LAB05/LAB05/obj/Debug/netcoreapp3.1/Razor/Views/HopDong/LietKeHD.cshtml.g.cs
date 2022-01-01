#pragma checksum "D:\C#Code\LAB05\LAB05\Views\HopDong\LietKeHD.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "098e386af2a8aff215f0587c1ceabdf48c35c56a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HopDong_LietKeHD), @"mvc.1.0.view", @"/Views/HopDong/LietKeHD.cshtml")]
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
#line 1 "D:\C#Code\LAB05\LAB05\Views\_ViewImports.cshtml"
using LAB05;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#Code\LAB05\LAB05\Views\_ViewImports.cshtml"
using LAB05.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"098e386af2a8aff215f0587c1ceabdf48c35c56a", @"/Views/HopDong/LietKeHD.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17ed65114d6ac690077e183c863217378e302ced", @"/Views/_ViewImports.cshtml")]
    public class Views_HopDong_LietKeHD : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LAB05.Models.HopDong>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\C#Code\LAB05\LAB05\Views\HopDong\LietKeHD.cshtml"
      
    ViewData["Title"] = "Liệt kê hợp đồng";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-10\">\r\n                <h2>Danh sách hợp đồng của khách hàng ");
#nullable restore
#line 8 "D:\C#Code\LAB05\LAB05\Views\HopDong\LietKeHD.cshtml"
                                                 Write(ViewBag.TenKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 9 "D:\C#Code\LAB05\LAB05\Views\HopDong\LietKeHD.cshtml"
                 if(Model.Count() != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table border=""1"" class=""table table-striped"" style=""width:70%"">
                    <thead>
                        <tr>
                            <th>Mã HD</th>
                            <th>Tên KHD</th>
                            <th>Ngày lập</th>
                            <th>Tổng tiền</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 21 "D:\C#Code\LAB05\LAB05\Views\HopDong\LietKeHD.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 25 "D:\C#Code\LAB05\LAB05\Views\HopDong\LietKeHD.cshtml"
                               Write(item.MaHD);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
#nullable restore
#line 29 "D:\C#Code\LAB05\LAB05\Views\HopDong\LietKeHD.cshtml"
                               Write(item.TenHD);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
#nullable restore
#line 33 "D:\C#Code\LAB05\LAB05\Views\HopDong\LietKeHD.cshtml"
                               Write(item.NgayLap.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <td>\r\n                                    ");
#nullable restore
#line 37 "D:\C#Code\LAB05\LAB05\Views\HopDong\LietKeHD.cshtml"
                               Write(item.TongTien);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 41 "D:\C#Code\LAB05\LAB05\Views\HopDong\LietKeHD.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 44 "D:\C#Code\LAB05\LAB05\Views\HopDong\LietKeHD.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>Khách hàng ");
#nullable restore
#line 47 "D:\C#Code\LAB05\LAB05\Views\HopDong\LietKeHD.cshtml"
                             Write(ViewBag.TenKH);

#line default
#line hidden
#nullable disable
            WriteLiteral(" chưa có hóa đơn nào.</p>\r\n");
#nullable restore
#line 48 "D:\C#Code\LAB05\LAB05\Views\HopDong\LietKeHD.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LAB05.Models.HopDong>> Html { get; private set; }
    }
}
#pragma warning restore 1591
