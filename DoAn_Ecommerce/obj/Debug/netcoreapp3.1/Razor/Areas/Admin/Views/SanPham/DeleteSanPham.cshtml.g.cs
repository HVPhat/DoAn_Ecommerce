#pragma checksum "C:\Users\ad\OneDrive\Desktop\Đồ Án ASP.NET\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\SanPham\DeleteSanPham.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e57b8899720d1503feedab0fcf7a904c2d004a36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SanPham_DeleteSanPham), @"mvc.1.0.view", @"/Areas/Admin/Views/SanPham/DeleteSanPham.cshtml")]
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
#line 1 "C:\Users\ad\OneDrive\Desktop\Đồ Án ASP.NET\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\_ViewImports.cshtml"
using DoAn_Ecommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ad\OneDrive\Desktop\Đồ Án ASP.NET\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\_ViewImports.cshtml"
using DoAn_Ecommerce.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e57b8899720d1503feedab0fcf7a904c2d004a36", @"/Areas/Admin/Views/SanPham/DeleteSanPham.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8719c0378c4881f70e4506df3efee2bc5a4005f9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SanPham_DeleteSanPham : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SanPhamModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""modal fade"" id=""addSanPham"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title""> Are you sure you want to delete this?</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">
                    <span>X</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div>
                    <dl class=""row"">
                        <dt class=""col-sm-2"">
                            ");
#nullable restore
#line 16 "C:\Users\ad\OneDrive\Desktop\Đồ Án ASP.NET\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\SanPham\DeleteSanPham.cshtml"
                       Write(Html.DisplayNameFor(model => model.TenSanPham));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 19 "C:\Users\ad\OneDrive\Desktop\Đồ Án ASP.NET\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\SanPham\DeleteSanPham.cshtml"
                       Write(Html.DisplayFor(model => model.TenSanPham));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 22 "C:\Users\ad\OneDrive\Desktop\Đồ Án ASP.NET\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\SanPham\DeleteSanPham.cshtml"
                       Write(Html.DisplayNameFor(model => model.HinhAnh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 25 "C:\Users\ad\OneDrive\Desktop\Đồ Án ASP.NET\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\SanPham\DeleteSanPham.cshtml"
                       Write(Html.DisplayFor(model => model.HinhAnh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 28 "C:\Users\ad\OneDrive\Desktop\Đồ Án ASP.NET\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\SanPham\DeleteSanPham.cshtml"
                       Write(Html.DisplayNameFor(model => model.SoLuongTon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 31 "C:\Users\ad\OneDrive\Desktop\Đồ Án ASP.NET\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\SanPham\DeleteSanPham.cshtml"
                       Write(Html.DisplayFor(model => model.SoLuongTon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 34 "C:\Users\ad\OneDrive\Desktop\Đồ Án ASP.NET\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\SanPham\DeleteSanPham.cshtml"
                       Write(Html.DisplayNameFor(model => model.Gia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 37 "C:\Users\ad\OneDrive\Desktop\Đồ Án ASP.NET\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\SanPham\DeleteSanPham.cshtml"
                       Write(Html.DisplayFor(model => model.Gia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 40 "C:\Users\ad\OneDrive\Desktop\Đồ Án ASP.NET\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\SanPham\DeleteSanPham.cshtml"
                       Write(Html.DisplayNameFor(model => model.Mota));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 43 "C:\Users\ad\OneDrive\Desktop\Đồ Án ASP.NET\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\SanPham\DeleteSanPham.cshtml"
                       Write(Html.DisplayFor(model => model.Mota));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 46 "C:\Users\ad\OneDrive\Desktop\Đồ Án ASP.NET\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\SanPham\DeleteSanPham.cshtml"
                       Write(Html.DisplayNameFor(model => model.TrangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 49 "C:\Users\ad\OneDrive\Desktop\Đồ Án ASP.NET\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\SanPham\DeleteSanPham.cshtml"
                       Write(Html.DisplayFor(model => model.TrangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
#nullable restore
#line 52 "C:\Users\ad\OneDrive\Desktop\Đồ Án ASP.NET\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\SanPham\DeleteSanPham.cshtml"
                       Write(Html.DisplayNameFor(model => model.LoaiSanPham));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 55 "C:\Users\ad\OneDrive\Desktop\Đồ Án ASP.NET\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\SanPham\DeleteSanPham.cshtml"
                       Write(Html.DisplayFor(model => model.LoaiSanPham.TenLoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                    </dl>\r\n                </div>\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e57b8899720d1503feedab0fcf7a904c2d004a3610752", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e57b8899720d1503feedab0fcf7a904c2d004a3611031", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 62 "C:\Users\ad\OneDrive\Desktop\Đồ Án ASP.NET\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\SanPham\DeleteSanPham.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <button type=\"button\" class=\"btn btn-primary\" data-dismiss=\"modal\">Close</button>\r\n                    <button type=\"button\" class=\"btn btn-danger\" data-save=\"modal\">Delete</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SanPhamModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
