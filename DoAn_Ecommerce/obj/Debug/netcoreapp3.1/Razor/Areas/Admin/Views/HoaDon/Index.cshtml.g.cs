#pragma checksum "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\HoaDon\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58435e5d6acae50d152e4f6790b4bd485a8164a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HoaDon_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/HoaDon/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58435e5d6acae50d152e4f6790b4bd485a8164a2", @"/Areas/Admin/Views/HoaDon/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8719c0378c4881f70e4506df3efee2bc5a4005f9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_HoaDon_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoAn_Ecommerce.Areas.Admin.Models.HoaDonModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\HoaDon\Index.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["HoaDon"] = "active";
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
                        <button type=""button"" class=""btn btn-primary"" data-toggle=""ajax-modal"" data-target=""#addUser"" data-url=""");
#nullable restore
#line 17 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                                                                           Write(Url.Action("Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""> Thêm người dùng</button>
                    </div>

                    <!-- /.card-header -->
                    <div class=""card-body"">
                        <table id=""example2"" class=""table table-bordered table-hover"">
                            <thead>
                                <tr>
                                    <th>
                                        ");
#nullable restore
#line 26 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\HoaDon\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.NgayLapHD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 29 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\HoaDon\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.TrangThaiGiaoHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 32 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\HoaDon\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.TrangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 35 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\HoaDon\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.KH));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th></th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 41 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\HoaDon\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 45 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\HoaDon\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.NgayLapHD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 48 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\HoaDon\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.TrangThaiGiaoHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 51 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\HoaDon\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.TrangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 54 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\HoaDon\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.KH.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <button type=\"button\" class=\"btn btn-primary\" id=\"Edit\" data-toggle=\"ajax-modal\" data-target=\"#addHoadon\" data-url=\"");
#nullable restore
#line 57 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                                                                                                           Write(Url.Action($"Edit/{item.Id}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"> Edit </button> |\r\n                                            <button type=\"button\" class=\"btn btn-primary\" id=\"Edit\" data-toggle=\"ajax-modal\" data-target=\"#addHoadon\" data-url=\"");
#nullable restore
#line 58 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                                                                                                           Write(Url.Action($"Delete/{item.Id}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"> Delete </button> |\r\n                                            <button type=\"button\" class=\"btn btn-primary\" id=\"change\" name=\"change\" data-id=\"");
#nullable restore
#line 59 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"> Change </button>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 62 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\HoaDon\Index.cshtml"
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
</div>
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
                url: './api/HoaDonAPI/ChangeUserState/' + id,
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoAn_Ecommerce.Areas.Admin.Models.HoaDonModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
