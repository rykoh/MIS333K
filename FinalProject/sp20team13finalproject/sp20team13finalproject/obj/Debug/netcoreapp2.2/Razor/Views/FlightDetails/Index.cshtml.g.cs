#pragma checksum "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82cac3695a58421d642ef9106956bd78b2d86258"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(sp20team13finalproject.Views.FlightDetails.Views_FlightDetails_Index), @"mvc.1.0.view", @"/Views/FlightDetails/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FlightDetails/Index.cshtml", typeof(sp20team13finalproject.Views.FlightDetails.Views_FlightDetails_Index))]
namespace sp20team13finalproject.Views.FlightDetails
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\_ViewImports.cshtml"
using sp20team13finalproject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82cac3695a58421d642ef9106956bd78b2d86258", @"/Views/FlightDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff4d81c00e5c680a43b830d7180b3343e1271f30", @"/Views/_ViewImports.cshtml")]
    public class Views_FlightDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<sp20team13finalproject.Models.FlightDetail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(107, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(136, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82cac3695a58421d642ef9106956bd78b2d862584842", async() => {
                BeginContext(159, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(173, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(266, 45, false);
#line 16 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FlightNum));

#line default
#line hidden
            EndContext();
            BeginContext(311, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(367, 40, false);
#line 19 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(407, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(463, 50, false);
#line 22 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Flight.DepCity));

#line default
#line hidden
            EndContext();
            BeginContext(513, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(569, 54, false);
#line 25 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Flight.ArrivalCity));

#line default
#line hidden
            EndContext();
            BeginContext(623, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(679, 41, false);
#line 28 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pilot));

#line default
#line hidden
            EndContext();
            BeginContext(720, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(776, 43, false);
#line 31 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CoPilot));

#line default
#line hidden
            EndContext();
            BeginContext(819, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(875, 51, false);
#line 34 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FlightAttendant));

#line default
#line hidden
            EndContext();
            BeginContext(926, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(982, 44, false);
#line 37 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BaseFare));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1082, 48, false);
#line 40 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.flightStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 46 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1248, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1297, 44, false);
#line 49 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FlightNum));

#line default
#line hidden
            EndContext();
            BeginContext(1341, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1397, 39, false);
#line 52 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1436, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1492, 49, false);
#line 55 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Flight.DepCity));

#line default
#line hidden
            EndContext();
            BeginContext(1541, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1597, 53, false);
#line 58 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Flight.ArrivalCity));

#line default
#line hidden
            EndContext();
            BeginContext(1650, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1706, 40, false);
#line 61 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pilot));

#line default
#line hidden
            EndContext();
            BeginContext(1746, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1802, 42, false);
#line 64 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CoPilot));

#line default
#line hidden
            EndContext();
            BeginContext(1844, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1900, 50, false);
#line 67 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FlightAttendant));

#line default
#line hidden
            EndContext();
            BeginContext(1950, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2006, 43, false);
#line 70 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BaseFare));

#line default
#line hidden
            EndContext();
            BeginContext(2049, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2105, 47, false);
#line 73 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.flightStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2152, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2207, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82cac3695a58421d642ef9106956bd78b2d8625814962", async() => {
                BeginContext(2264, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
                                       WriteLiteral(item.FlightDetailID);

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
            BeginContext(2272, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2292, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82cac3695a58421d642ef9106956bd78b2d8625817357", async() => {
                BeginContext(2352, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
                                          WriteLiteral(item.FlightDetailID);

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
            BeginContext(2363, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2383, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82cac3695a58421d642ef9106956bd78b2d8625819758", async() => {
                BeginContext(2442, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
                                         WriteLiteral(item.FlightDetailID);

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
            BeginContext(2452, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 81 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\FlightDetails\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2491, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<sp20team13finalproject.Models.FlightDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
