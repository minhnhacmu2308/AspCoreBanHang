#pragma checksum "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fbde4bd68e024aeb9ffa7c100be6bada482859e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
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
#line 1 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\_ViewImports.cshtml"
using WebBanHangCoreMcv;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\_ViewImports.cshtml"
using WebBanHangCoreMcv.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fbde4bd68e024aeb9ffa7c100be6bada482859e", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea085cc8376c448bdc8eeaed957676646c326b6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-sale"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Image/sale-avatar.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-laza"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Image/lazamall.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"product-detail\">\r\n    <h3 class=\"text-center my-3\">\r\n        ");
#nullable restore
#line 4 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\Detail.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h3>\r\n    <div class=\"pd-main\">\r\n        <div class=\"pd-box\">\r\n            <div class=\"b-img\">\r\n                <img class=\"img-avatar\"");
            BeginWriteAttribute("src", " src=\"", 242, "\"", 260, 1);
#nullable restore
#line 9 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\Detail.cshtml"
WriteAttributeValue("", 248, Model.Image, 248, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n        <div class=\"box-main\">\r\n            <div class=\"bm-sale\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7fbde4bd68e024aeb9ffa7c100be6bada482859e5535", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div class=\"sale-t\">\r\n                    Bắt đầu vào <b>00:00:00 ngày 11 tháng 11</b>\r\n                </div>\r\n            </div>\r\n            <div class=\"laza\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7fbde4bd68e024aeb9ffa7c100be6bada482859e6858", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"pd-title\">\r\n                ");
#nullable restore
#line 23 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\Detail.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <div class=""pd-like"">
                <i class=""fa fa-star""></i>
                <i class=""fa fa-star""></i>
                <i class=""fa fa-star""></i>
                <i class=""fa fa-star""></i>
                <i class=""fa fa-star""></i>
                <a class=""l-fb c-blue"" href=""#"">15 đánh giá</a>
            </div>
            <div class=""pd-trademark"">
                <span class=""td-t c-gray"">
                    Thương hiệu:   ");
#nullable restore
#line 35 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\Detail.cshtml"
                              Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </div>\r\n");
#nullable restore
#line 38 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\Detail.cshtml"
              
                int giaKhuyenMai = @Model.Price - ((@Model.Price * @Model.Discount) / 100);
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"pd-price\">\r\n                <span class=\"td-t c-gray\">\r\n                    Giá khuyến mãi:\r\n                </span>\r\n                ");
#nullable restore
#line 45 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\Detail.cshtml"
           Write(giaKhuyenMai.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <p class=""p-oldPrice"">
                <span class=""td-t c-gray"">
                    Giá cửa hàng:
                </span>
                <span class=""p-include"" style=""text-decoration:line-through"">
                    ");
#nullable restore
#line 52 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\Detail.cshtml"
               Write(Model.Price.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </p>\r\n            <div class=\"pd-format\">\r\n                <span class=\"td-t c-gray\">\r\n                    Khuyến mãi:\r\n                </span>\r\n                <a class=\"fm-a\" href=\"#\">\r\n                    ");
#nullable restore
#line 60 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\Detail.cshtml"
               Write(Model.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" %
                </a>
            </div>
            <div class=""pd-buy"">
                <a class=""b-other"" href=""#"">
                    Mua ngay
                </a>
                <a class=""b-shopping"" href=""#"">
                    Thêm vào giỏ hàng
                </a>
            </div>
        </div>
    </div>

    <div class=""pd-description"">
        <h3 class=""my-3"">
            Mô tả sản phẩm
        </h3>
        <h4 class=""text-center"">
            ");
#nullable restore
#line 79 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\Detail.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h4>\r\n        <p>\r\n            ");
#nullable restore
#line 82 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\Detail.cshtml"
       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n</div>\r\n\r\n<!-- ProductForYou -->\r\n<div class=\"top-sale \">\r\n    <h3 class=\"mt-3\">\r\n        Sản phẩm liên quan\r\n    </h3>\r\n    <div class=\"ts-time\">\r\n        <div class=\"ts-product mt-3\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 95 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\Detail.cshtml"
                 foreach (var item in ViewBag.ProductRelated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-3 col-6 mb-3\">\r\n                        <div class=\"b-product\">\r\n                            <a class=\"p-a a\"");
            BeginWriteAttribute("href", " href=\"", 3222, "\"", 3297, 1);
#nullable restore
#line 99 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\Detail.cshtml"
WriteAttributeValue("", 3229, Url.Action("Detail", "Product", new { productId = item.ProductId }), 3229, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <p class=\"p-img\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 3392, "\"", 3409, 1);
#nullable restore
#line 101 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\Detail.cshtml"
WriteAttributeValue("", 3398, item.Image, 3398, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-avatar img-fluid\" />\r\n                                </p>\r\n                                <p class=\"p-title\">\r\n                                    ");
#nullable restore
#line 104 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\Detail.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p class=\"p-newPrice\">\r\n");
#nullable restore
#line 107 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\Detail.cshtml"
                                      
                                        int giaKhuyenMai1 = item.Price - ((item.Price * item.Discount) / 100);
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
#nullable restore
#line 110 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\Detail.cshtml"
                               Write(giaKhuyenMai1.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p class=\"p-oldPrice\">\r\n                                    <span class=\"p-include\">\r\n                                        ");
#nullable restore
#line 114 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\Detail.cshtml"
                                   Write(item.Price.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </span>\r\n                                    <span class=\"p-bonus\">\r\n                                        ");
#nullable restore
#line 117 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\Detail.cshtml"
                                   Write(item.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %\r\n                                    </span>\r\n                                </p>\r\n                            </a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 123 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
