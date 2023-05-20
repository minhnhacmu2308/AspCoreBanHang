#pragma checksum "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\ByCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f504be1e1be647afb02db1dbe825fd2abf9811b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ByCategory), @"mvc.1.0.view", @"/Views/Product/ByCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f504be1e1be647afb02db1dbe825fd2abf9811b9", @"/Views/Product/ByCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea085cc8376c448bdc8eeaed957676646c326b6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ByCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\ByCategory.cshtml"
  
    ViewData["Title"] = "Product";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"top-sale \">\r\n    <h3 class=\"mt-3 d-flex justify-content-center\">\r\n        Danh Sách Sản Phẩm ");
#nullable restore
#line 7 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\ByCategory.cshtml"
                      Write(ViewBag.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h3>\r\n    <div class=\"ts-time\">\r\n        <div class=\"ts-product mt-3\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 12 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\ByCategory.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-3 col-6 mb-3\">\r\n                        <div class=\"b-product\">\r\n                            <a class=\"p-a a\"");
            BeginWriteAttribute("href", " href=\"", 514, "\"", 589, 1);
#nullable restore
#line 16 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\ByCategory.cshtml"
WriteAttributeValue("", 521, Url.Action("Detail", "Product", new { productId = item.ProductId }), 521, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <p class=\"p-img\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 684, "\"", 701, 1);
#nullable restore
#line 18 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\ByCategory.cshtml"
WriteAttributeValue("", 690, item.Image, 690, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-avatar img-fluid\" />\r\n                                </p>\r\n                                <p class=\"p-title\">\r\n                                    ");
#nullable restore
#line 21 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\ByCategory.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p class=\"p-newPrice\">\r\n");
#nullable restore
#line 24 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\ByCategory.cshtml"
                                      
                                        int giaKhuyenMai = item.Price - ((item.Price * item.Discount) / 100);
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
#nullable restore
#line 27 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\ByCategory.cshtml"
                               Write(giaKhuyenMai.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <p class=\"p-oldPrice\">\r\n                                    <span class=\"p-include\">\r\n                                        ");
#nullable restore
#line 31 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\ByCategory.cshtml"
                                   Write(item.Price.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </span>\r\n                                    <span class=\"p-bonus\">\r\n                                        ");
#nullable restore
#line 34 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\ByCategory.cshtml"
                                   Write(item.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %\r\n                                    </span>\r\n                                </p>\r\n                            </a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 40 "C:\Users\ADMIN\source\repos\WebBanHangCoreMcv\WebBanHangCoreMcv\Views\Product\ByCategory.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
