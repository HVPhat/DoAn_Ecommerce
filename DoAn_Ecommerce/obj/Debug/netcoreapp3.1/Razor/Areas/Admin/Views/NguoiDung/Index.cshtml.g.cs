#pragma checksum "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a932e41eb4dcf6b088dc69a6c053af57488cbcee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_NguoiDung_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/NguoiDung/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a932e41eb4dcf6b088dc69a6c053af57488cbcee", @"/Areas/Admin/Views/NguoiDung/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8719c0378c4881f70e4506df3efee2bc5a4005f9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_NguoiDung_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoAn_Ecommerce.Areas.Admin.Models.NguoiDungModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
  
    ViewData["Title"] = "Index";
    ViewData["User"] = "active";
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
#line 20 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
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
#line 28 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.TenNguoiDung));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 31 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.NgaySinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 34 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.GioiTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 37 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 40 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.SDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 43 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 46 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.TrangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 49 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
                                   Write(Html.DisplayNameFor(model => model.QuyenHan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 54 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 58 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.TenNguoiDung));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 61 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.NgaySinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 64 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.GioiTinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 67 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 70 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.SDT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 73 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.DiaChi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 76 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.TrangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 79 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.QuyenHan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <button type=\"button\" class=\"btn btn-primary\" id=\"Edit\" data-toggle=\"ajax-modal\" data-target=\"#addUser\" data-url=\"");
#nullable restore
#line 82 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
                                                                                                                                                         Write(Url.Action($"Edit/{item.Id}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"> Edit </button> |\r\n                                            <button type=\"button\" class=\"btn btn-primary\" id=\"Edit\" data-toggle=\"ajax-modal\" data-target=\"#addUser\" data-url=\"");
#nullable restore
#line 83 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
                                                                                                                                                         Write(Url.Action($"Delete/{item.Id}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"> Delete </button> |\r\n                                            <button type=\"button\" class=\"btn btn-primary\" id=\"change\" name=\"change\" data-id=\"");
#nullable restore
#line 84 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
                                                                                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"> Change </button>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 87 "E:\DoAnCuoiKi\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\NguoiDung\Index.cshtml"
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
                url: './api/NguoiDungApi/ChangeUserState/' + id,
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoAn_Ecommerce.Areas.Admin.Models.NguoiDungModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
