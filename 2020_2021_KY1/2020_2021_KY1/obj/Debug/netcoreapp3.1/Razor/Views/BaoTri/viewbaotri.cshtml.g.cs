#pragma checksum "D:\C#Code\2020_2021_KY1\2020_2021_KY1\Views\BaoTri\viewbaotri.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "134b3d82d58fa453f867e5ea35d273079e7411a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BaoTri_viewbaotri), @"mvc.1.0.view", @"/Views/BaoTri/viewbaotri.cshtml")]
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
#line 1 "D:\C#Code\2020_2021_KY1\2020_2021_KY1\Views\_ViewImports.cshtml"
using _2020_2021_KY1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#Code\2020_2021_KY1\2020_2021_KY1\Views\_ViewImports.cshtml"
using _2020_2021_KY1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"134b3d82d58fa453f867e5ea35d273079e7411a9", @"/Views/BaoTri/viewbaotri.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eb48cdcee86e0cec9a5e67b456a2f98238d7744", @"/Views/_ViewImports.cshtml")]
    public class Views_BaoTri_viewbaotri : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/BaoTri/updatebaotri"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\C#Code\2020_2021_KY1\2020_2021_KY1\Views\BaoTri\viewbaotri.cshtml"
  
    ViewData["Title"] = "Xem th??ng tin b???o tr??";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "134b3d82d58fa453f867e5ea35d273079e7411a94030", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    M?? thi???t b??? <input type=\"text\" name=\"MaThietBi\"");
                BeginWriteAttribute("value", " value=\"", 228, "\"", 261, 1);
#nullable restore
#line 7 "D:\C#Code\2020_2021_KY1\2020_2021_KY1\Views\BaoTri\viewbaotri.cshtml"
WriteAttributeValue("", 236, ViewBag.BaoTri.MaThietBi, 236, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n    M?? c??n h??? <input type=\"text\" name=\"MaCanHo\"");
                BeginWriteAttribute("value", " value=\"", 320, "\"", 351, 1);
#nullable restore
#line 8 "D:\C#Code\2020_2021_KY1\2020_2021_KY1\Views\BaoTri\viewbaotri.cshtml"
WriteAttributeValue("", 328, ViewBag.BaoTri.MaCanHo, 328, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n    L???n s???a <input type=\"text\" name=\"LanThu\"");
                BeginWriteAttribute("value", " value=\"", 407, "\"", 437, 1);
#nullable restore
#line 9 "D:\C#Code\2020_2021_KY1\2020_2021_KY1\Views\BaoTri\viewbaotri.cshtml"
WriteAttributeValue("", 415, ViewBag.BaoTri.LanThu, 415, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n    Ng??y s???a <input type=\"date\" name=\"NgayBaoTri\"");
                BeginWriteAttribute("value", " value=\"", 498, "\"", 555, 1);
#nullable restore
#line 10 "D:\C#Code\2020_2021_KY1\2020_2021_KY1\Views\BaoTri\viewbaotri.cshtml"
WriteAttributeValue("", 506, ViewBag.BaoTri.NgayBaoTri.ToString("yyyy-MM-dd"), 506, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n    <input type=\"hidden\" name=\"MaNhanVien\"");
                BeginWriteAttribute("value", " value=\"", 609, "\"", 643, 1);
#nullable restore
#line 11 "D:\C#Code\2020_2021_KY1\2020_2021_KY1\Views\BaoTri\viewbaotri.cshtml"
WriteAttributeValue("", 617, ViewBag.BaoTri.MaNhanVien, 617, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n    <input type=\"submit\" value=\"Update\" />\r\n\r\n");
                WriteLiteral("    <input type=\"hidden\" name=\"MaNhanVien_Old\"");
                BeginWriteAttribute("value", " value=\"", 768, "\"", 802, 1);
#nullable restore
#line 15 "D:\C#Code\2020_2021_KY1\2020_2021_KY1\Views\BaoTri\viewbaotri.cshtml"
WriteAttributeValue("", 776, ViewBag.BaoTri.MaNhanVien, 776, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n    <input type=\"hidden\" name=\"MaCanHo_Old\"");
                BeginWriteAttribute("value", " value=\"", 857, "\"", 888, 1);
#nullable restore
#line 16 "D:\C#Code\2020_2021_KY1\2020_2021_KY1\Views\BaoTri\viewbaotri.cshtml"
WriteAttributeValue("", 865, ViewBag.BaoTri.MaCanHo, 865, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n    <input type=\"hidden\" name=\"MaThietBi_Old\"");
                BeginWriteAttribute("value", " value=\"", 945, "\"", 978, 1);
#nullable restore
#line 17 "D:\C#Code\2020_2021_KY1\2020_2021_KY1\Views\BaoTri\viewbaotri.cshtml"
WriteAttributeValue("", 953, ViewBag.BaoTri.MaThietBi, 953, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n    <input type=\"hidden\" name=\"LanThu_Old\"");
                BeginWriteAttribute("value", " value=\"", 1032, "\"", 1062, 1);
#nullable restore
#line 18 "D:\C#Code\2020_2021_KY1\2020_2021_KY1\Views\BaoTri\viewbaotri.cshtml"
WriteAttributeValue("", 1040, ViewBag.BaoTri.LanThu, 1040, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
