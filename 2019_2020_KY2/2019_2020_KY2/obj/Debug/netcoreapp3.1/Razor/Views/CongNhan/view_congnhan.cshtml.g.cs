#pragma checksum "D:\C#Code\2019_2020_KY2\2019_2020_KY2\Views\CongNhan\view_congnhan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebff2692ad1117bfc529065f18a7e426c27904aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CongNhan_view_congnhan), @"mvc.1.0.view", @"/Views/CongNhan/view_congnhan.cshtml")]
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
#line 1 "D:\C#Code\2019_2020_KY2\2019_2020_KY2\Views\_ViewImports.cshtml"
using _2019_2020_KY2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#Code\2019_2020_KY2\2019_2020_KY2\Views\_ViewImports.cshtml"
using _2019_2020_KY2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebff2692ad1117bfc529065f18a7e426c27904aa", @"/Views/CongNhan/view_congnhan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76662ceaeb8de4b0b16be4e62f363d922a89ac18", @"/Views/_ViewImports.cshtml")]
    public class Views_CongNhan_view_congnhan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("Mã công nhân\r\n<input type=\"text\" name=\"MaCongNhan\" placeholder=\"CN01\"");
            BeginWriteAttribute("value", " value=\"", 199, "\"", 237, 2);
#nullable restore
#line 7 "D:\C#Code\2019_2020_KY2\2019_2020_KY2\Views\CongNhan\view_congnhan.cshtml"
WriteAttributeValue(" ", 207, ViewBag.CongNhan.MaCongNhan, 208, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 236, "", 237, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\nTên công nhân\r\n<input type=\"text\" name=\"TenCongNhan\" placeholder=\"Nguyễn Xuân Tùng\"");
            BeginWriteAttribute("value", " value=\"", 326, "\"", 365, 2);
#nullable restore
#line 9 "D:\C#Code\2019_2020_KY2\2019_2020_KY2\Views\CongNhan\view_congnhan.cshtml"
WriteAttributeValue(" ", 334, ViewBag.CongNhan.TenCongNhan, 335, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 364, "", 365, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\nGiới tính\r\n");
#nullable restore
#line 11 "D:\C#Code\2019_2020_KY2\2019_2020_KY2\Views\CongNhan\view_congnhan.cshtml"
 if (ViewBag.CongNhan.GioiTinh == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"checkbox\" name=\"GioiTinh\" checked />\r\n");
#nullable restore
#line 14 "D:\C#Code\2019_2020_KY2\2019_2020_KY2\Views\CongNhan\view_congnhan.cshtml"
}
else{

#line default
#line hidden
#nullable disable
            WriteLiteral("<input type=\"checkbox\" name=\"GioiTinh\" />");
#nullable restore
#line 16 "D:\C#Code\2019_2020_KY2\2019_2020_KY2\Views\CongNhan\view_congnhan.cshtml"
                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("Năm sinh\r\n<input type=\"text\" name=\"NamSinh\" placeholder=\"2000\"");
            BeginWriteAttribute("value", " value=\"", 597, "\"", 632, 2);
#nullable restore
#line 18 "D:\C#Code\2019_2020_KY2\2019_2020_KY2\Views\CongNhan\view_congnhan.cshtml"
WriteAttributeValue(" ", 605, ViewBag.CongNhan.NamSinh, 606, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 631, "", 632, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\nNước về\r\n<input type=\"text\" name=\"NuocVe\" placeholder=\"Mỹ\"");
            BeginWriteAttribute("value", " value=\"", 696, "\"", 730, 2);
#nullable restore
#line 20 "D:\C#Code\2019_2020_KY2\2019_2020_KY2\Views\CongNhan\view_congnhan.cshtml"
WriteAttributeValue(" ", 704, ViewBag.CongNhan.NuocVe, 705, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 729, "", 730, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n\r\n");
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
