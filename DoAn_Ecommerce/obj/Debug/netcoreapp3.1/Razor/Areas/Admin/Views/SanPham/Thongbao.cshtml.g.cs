#pragma checksum "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\SanPham\Thongbao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac378feafcc11b9069cf06a6c6b7e6853059d2f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SanPham_Thongbao), @"mvc.1.0.view", @"/Areas/Admin/Views/SanPham/Thongbao.cshtml")]
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
#line 1 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\_ViewImports.cshtml"
using DoAn_Ecommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\_ViewImports.cshtml"
using DoAn_Ecommerce.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac378feafcc11b9069cf06a6c6b7e6853059d2f1", @"/Areas/Admin/Views/SanPham/Thongbao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8719c0378c4881f70e4506df3efee2bc5a4005f9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SanPham_Thongbao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<div class=""modal fade"" id=""addSanPham"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title""></h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">
                    <span>X</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div><h1>Thành công!</h1></div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
            </div>  
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        suscess = true;\r\n\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
