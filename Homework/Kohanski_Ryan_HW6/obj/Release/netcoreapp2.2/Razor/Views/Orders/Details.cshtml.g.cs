#pragma checksum "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26e5624577df46bbf726aee68f301b3c494b0aa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Kohanski_Ryan_HW6.Views.Orders.Views_Orders_Details), @"mvc.1.0.view", @"/Views/Orders/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Details.cshtml", typeof(Kohanski_Ryan_HW6.Views.Orders.Views_Orders_Details))]
namespace Kohanski_Ryan_HW6.Views.Orders
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\_ViewImports.cshtml"
using Kohanski_Ryan_HW6.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26e5624577df46bbf726aee68f301b3c494b0aa3", @"/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"892c859570c5dff8aabf50ecb31b0ecb2a192b4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kohanski_Ryan_HW6.Models.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Orders\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 192, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Order</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <!-- should we have a name on here? and a full name? -->\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(277, 47, false);
#line 15 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderNumber));

#line default
#line hidden
            EndContext();
            BeginContext(324, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(386, 43, false);
#line 18 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderNumber));

#line default
#line hidden
            EndContext();
            BeginContext(429, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(473, 50, false);
#line 21 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(523, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(567, 46, false);
#line 24 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(613, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(674, 45, false);
#line 27 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(719, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(781, 41, false);
#line 30 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(822, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(883, 46, false);
#line 33 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderNotes));

#line default
#line hidden
            EndContext();
            BeginContext(929, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(991, 42, false);
#line 36 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderNotes));

#line default
#line hidden
            EndContext();
            BeginContext(1033, 242, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<h5>Products on this Order</h5>\r\n<table class=\"table table-primary\">\r\n    <tr>\r\n        <th>Product Name</th>\r\n        <th>Price</th>\r\n        <th>Quantity</th>\r\n        <th>Extended Price</th>\r\n    </tr>\r\n");
            EndContext();
#line 48 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Orders\Details.cshtml"
     foreach (OrderDetail od in Model.OrderDetails)
    {

#line default
#line hidden
            BeginContext(1335, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1366, 52, false);
#line 51 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Orders\Details.cshtml"
           Write(Html.DisplayFor(ModelItem => od.Product.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1418, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1442, 45, false);
#line 52 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Orders\Details.cshtml"
           Write(Html.DisplayFor(ModelItem => od.ProductPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1487, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1511, 46, false);
#line 53 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Orders\Details.cshtml"
           Write(Html.DisplayFor(ModelItem => od.OrderQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(1557, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1581, 46, false);
#line 54 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Orders\Details.cshtml"
           Write(Html.DisplayFor(ModelItem => od.ExtendedPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1627, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 56 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Orders\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1656, 248, true);
            WriteLiteral("</table>\r\n\r\n<h5>Order Summary</h5>\r\n<table class=\"table table-sm table-bordered\" style=\"width:30%\">\r\n    <tr>\r\n        <th colspan=\"2\" style=\"text-align:center\">Order Summary</th>\r\n    </tr>\r\n    <tr>\r\n        <td>Order Subtotal:</td>\r\n        <td>");
            EndContext();
            BeginContext(1905, 45, false);
#line 66 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderSubtotal));

#line default
#line hidden
            EndContext();
            BeginContext(1950, 69, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Sales Tax:</td>\r\n        <td>");
            EndContext();
            BeginContext(2020, 40, false);
#line 70 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.SalesTax));

#line default
#line hidden
            EndContext();
            BeginContext(2060, 71, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Order Total:</td>\r\n        <td>");
            EndContext();
            BeginContext(2132, 42, false);
#line 74 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderTotal));

#line default
#line hidden
            EndContext();
            BeginContext(2174, 41, true);
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n</table>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2215, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26e5624577df46bbf726aee68f301b3c494b0aa311353", async() => {
                BeginContext(2266, 4, true);
                WriteLiteral("Edit");
                EndContext();
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
#line 79 "C:\Users\Ryan\Desktop\MIS 333K\Kohanski_Ryan_HW6\Views\Orders\Details.cshtml"
                           WriteLiteral(Model.OrderID);

#line default
#line hidden
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
            EndContext();
            BeginContext(2274, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2282, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26e5624577df46bbf726aee68f301b3c494b0aa313677", async() => {
                BeginContext(2304, 12, true);
                WriteLiteral("Back to List");
                EndContext();
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
            EndContext();
            BeginContext(2320, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kohanski_Ryan_HW6.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591