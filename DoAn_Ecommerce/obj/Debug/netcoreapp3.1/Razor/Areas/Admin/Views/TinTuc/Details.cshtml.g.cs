#pragma checksum "D:\ASP.NET Core\Do_an_ASP\New folder\New folder\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d3baf98bfdb946d6155c1c540d6106a11f820f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_TinTuc_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/TinTuc/Details.cshtml")]
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
#line 1 "D:\ASP.NET Core\Do_an_ASP\New folder\New folder\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\_ViewImports.cshtml"
using DoAn_Ecommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.NET Core\Do_an_ASP\New folder\New folder\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\_ViewImports.cshtml"
using DoAn_Ecommerce.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d3baf98bfdb946d6155c1c540d6106a11f820f4", @"/Areas/Admin/Views/TinTuc/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8719c0378c4881f70e4506df3efee2bc5a4005f9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_TinTuc_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoAn_Ecommerce.Areas.Admin.Models.TinTucModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ASP.NET Core\Do_an_ASP\New folder\New folder\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>TinTucModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\ASP.NET Core\Do_an_ASP\New folder\New folder\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TieuDe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\ASP.NET Core\Do_an_ASP\New folder\New folder\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Details.cshtml"
       Write(Html.DisplayFor(model => model.TieuDe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\ASP.NET Core\Do_an_ASP\New folder\New folder\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TomTat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\ASP.NET Core\Do_an_ASP\New folder\New folder\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Details.cshtml"
       Write(Html.DisplayFor(model => model.TomTat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\ASP.NET Core\Do_an_ASP\New folder\New folder\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NoiDung));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\ASP.NET Core\Do_an_ASP\New folder\New folder\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Details.cshtml"
       Write(Html.DisplayFor(model => model.NoiDung));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "D:\ASP.NET Core\Do_an_ASP\New folder\New folder\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NgayDang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\ASP.NET Core\Do_an_ASP\New folder\New folder\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Details.cshtml"
       Write(Html.DisplayFor(model => model.NgayDang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "D:\ASP.NET Core\Do_an_ASP\New folder\New folder\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LuotXem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "D:\ASP.NET Core\Do_an_ASP\New folder\New folder\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Details.cshtml"
       Write(Html.DisplayFor(model => model.LuotXem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "D:\ASP.NET Core\Do_an_ASP\New folder\New folder\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TrangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "D:\ASP.NET Core\Do_an_ASP\New folder\New folder\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Details.cshtml"
       Write(Html.DisplayFor(model => model.TrangThai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "D:\ASP.NET Core\Do_an_ASP\New folder\New folder\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HinhAnh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "D:\ASP.NET Core\Do_an_ASP\New folder\New folder\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Details.cshtml"
       Write(Html.DisplayFor(model => model.HinhAnh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "D:\ASP.NET Core\Do_an_ASP\New folder\New folder\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NhanVien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "D:\ASP.NET Core\Do_an_ASP\New folder\New folder\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Details.cshtml"
       Write(Html.DisplayFor(model => model.NhanVien.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d3baf98bfdb946d6155c1c540d6106a11f820f410118", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "D:\ASP.NET Core\Do_an_ASP\New folder\New folder\DoAn_Ecommerce\DoAn_Ecommerce\Areas\Admin\Views\TinTuc\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d3baf98bfdb946d6155c1c540d6106a11f820f412299", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAn_Ecommerce.Areas.Admin.Models.TinTucModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
