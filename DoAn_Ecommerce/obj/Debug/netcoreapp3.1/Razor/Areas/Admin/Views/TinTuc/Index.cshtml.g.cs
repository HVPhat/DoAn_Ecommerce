#pragma checksum "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fef64efda8d63d6c80c001b3e0df59c036d5f1d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_TinTuc_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/TinTuc/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fef64efda8d63d6c80c001b3e0df59c036d5f1d0", @"/Areas/Admin/Views/TinTuc/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8719c0378c4881f70e4506df3efee2bc5a4005f9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_TinTuc_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoAn_Ecommerce.Areas.Admin.Models.TinTucModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["TinTuc"] = "active";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div id=""PlaceHolderHere""></div>
<!-- Main content -->
<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <button type=""button"" class=""btn btn-primary"" data-toggle=""ajax-modal"" data-target=""#addtintuc"" data-url=""");
#nullable restore
#line 18 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
                                                                                                                             Write(Url.Action("Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""> Thêm Tin Tức</button>
                    </div>
                    <!-- /.card-header -->
                    <div class=""card-body"">
                        <table id=""example2"" class=""table table-bordered table-hover"">
                            <thead>
                                <tr>
                                    <th>
                                        ");
#nullable restore
#line 26 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.TieuDe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 29 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.TomTat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 32 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.NoiDung));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 35 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.NgayDang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 38 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.LuotXem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 41 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.TrangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 44 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.HinhAnh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 47 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.NhanVien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th></th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 53 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 57 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.TieuDe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 60 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.TomTat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 63 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.NoiDung));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 66 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.NgayDang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 69 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.LuotXem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 72 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.TrangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fef64efda8d63d6c80c001b3e0df59c036d5f1d011828", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3792, "~/images/pro/", 3792, 13, true);
#nullable restore
#line 75 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
AddHtmlAttributeValue("", 3805, Html.DisplayFor(modelItem => item.HinhAnh), 3805, 43, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 78 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.NhanVien.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <button type=\"button\" class=\"btn btn-primary\" id=\"Edit\" data-toggle=\"ajax-modal\" data-target=\"#addtintuc\" data-url=\"");
#nullable restore
#line 81 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
                                                                                                                                                           Write(Url.Action($"Edit/{item.Id}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"> Edit </button> |\r\n                                            <button type=\"button\" class=\"btn btn-primary\" id=\"Edit\" data-toggle=\"ajax-modal\" data-target=\"#addtintuc\" data-url=\"");
#nullable restore
#line 82 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
                                                                                                                                                           Write(Url.Action($"Delete/{item.Id}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"> Delete </button> |\r\n                                            <button type=\"button\" class=\"btn btn-primary\" id=\"change\" name=\"change\" data-id=\"");
#nullable restore
#line 83 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
                                                                                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"> Change </button>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 86 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
            </div>
            <!-- /.col -->
        </div>
        <!-- /.row -->
    </div>
    <!-- /.container-fluid -->
</section>
<!-- /.content -->
<!-- Modal -->
<div class=""modal fade"" id=""myModal"" role=""dialog"">
    <div class=""modal-dialog"">

        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4>Thông báo</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>
            <div class=""modal-body"">
                <p id=""error""></p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
            </div>
        </div>

    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $('button[name = change]').click(function () {
            var id = ($(this).attr('data-id'));
            $.ajax({
                method: 'GET',
                url: './api/TinTucApi/ChangeStates/' + id,
            }).done(function (mgs) {
                $(""#error"").html(""Cập nhật trạng thái thành công"");
                $('#myModal').modal(""show"");
            });
        });
        $(""#myModal"").on(""hidden.bs.modal"", function () {
            // put your default event here
            location.reload(true);
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoAn_Ecommerce.Areas.Admin.Models.TinTucModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
