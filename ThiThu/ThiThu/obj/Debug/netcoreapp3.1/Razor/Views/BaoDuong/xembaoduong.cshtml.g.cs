#pragma checksum "D:\C#Code\ThiThu\ThiThu\Views\BaoDuong\xembaoduong.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a94b8a0f03a0d03f3d63d42b845e55649874aef8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BaoDuong_xembaoduong), @"mvc.1.0.view", @"/Views/BaoDuong/xembaoduong.cshtml")]
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
#line 1 "D:\C#Code\ThiThu\ThiThu\Views\_ViewImports.cshtml"
using ThiThu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#Code\ThiThu\ThiThu\Views\_ViewImports.cshtml"
using ThiThu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a94b8a0f03a0d03f3d63d42b845e55649874aef8", @"/Views/BaoDuong/xembaoduong.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6953c13de9e7aa9511410f0307b7f7be753fedd", @"/Views/_ViewImports.cshtml")]
    public class Views_BaoDuong_xembaoduong : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a94b8a0f03a0d03f3d63d42b845e55649874aef83423", async() => {
                WriteLiteral("\r\n    Ngày giờ nhận xe <input type=\"date\" name=\"NgayNhan\"");
                BeginWriteAttribute("value", " value=\"", 270, "\"", 308, 1);
#nullable restore
#line 7 "D:\C#Code\ThiThu\ThiThu\Views\BaoDuong\xembaoduong.cshtml"
WriteAttributeValue("", 278, ViewBag.baoduonginfo.NgayNhan, 278, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    Ngày giờ trả xe <input type=\"date\" name=\"NgayTra\"");
                BeginWriteAttribute("value", " value=\"", 365, "\"", 402, 1);
#nullable restore
#line 8 "D:\C#Code\ThiThu\ThiThu\Views\BaoDuong\xembaoduong.cshtml"
WriteAttributeValue("", 373, ViewBag.baoduonginfo.NgayTra, 373, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    Số km <input type=\"text\" name=\"SoKM\"");
                BeginWriteAttribute("value", " value=\"", 446, "\"", 480, 1);
#nullable restore
#line 9 "D:\C#Code\ThiThu\ThiThu\Views\BaoDuong\xembaoduong.cshtml"
WriteAttributeValue("", 454, ViewBag.baoduonginfo.SoKM, 454, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    Nội dung <input type=\"text\" name=\"NoiDung\"");
                BeginWriteAttribute("value", " value=\"", 530, "\"", 567, 1);
#nullable restore
#line 10 "D:\C#Code\ThiThu\ThiThu\Views\BaoDuong\xembaoduong.cshtml"
WriteAttributeValue("", 538, ViewBag.baoduonginfo.NoiDung, 538, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <input type=\"submit\" value=\"Cập nhật\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 144, "/BaoDuong/suabaoduong?MaBD=", 144, 27, true);
#nullable restore
#line 6 "D:\C#Code\ThiThu\ThiThu\Views\BaoDuong\xembaoduong.cshtml"
AddHtmlAttributeValue("", 171, ViewBag.baoduonginfo.MaBD, 171, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
