#pragma checksum "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ec3dbd183a4ca0dfa9b5caedc06b1a30bb9d7df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(sp20team13finalproject.Views.Account.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(sp20team13finalproject.Views.Account.Views_Account_Login))]
namespace sp20team13finalproject.Views.Account
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ec3dbd183a4ca0dfa9b5caedc06b1a30bb9d7df", @"/Views/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff4d81c00e5c680a43b830d7180b3343e1271f30", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Account\Login.cshtml"
  
    ViewBag.Title = "Log in";

#line default
#line hidden
            BeginContext(61, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(68, 13, false);
#line 6 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Account\Login.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(81, 101, true);
            WriteLiteral(".</h2>\r\n<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <section id=\"loginForm\">\r\n            ");
            EndContext();
            BeginContext(182, 1585, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ec3dbd183a4ca0dfa9b5caedc06b1a30bb9d7df6042", async() => {
                BeginContext(323, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(342, 23, false);
#line 11 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Account\Login.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(365, 99, true);
                WriteLiteral("\r\n                <h4>Use a local account to log in.</h4>\r\n                <hr />\r\n                ");
                EndContext();
                BeginContext(465, 64, false);
#line 14 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Account\Login.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(529, 64, true);
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(594, 70, false);
#line 16 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Account\Login.cshtml"
               Write(Html.LabelFor(m => m.Email, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(664, 71, true);
                WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
                EndContext();
                BeginContext(736, 62, false);
#line 18 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Account\Login.cshtml"
                   Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(798, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(825, 75, false);
#line 19 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Account\Login.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(900, 116, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(1017, 73, false);
#line 23 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Account\Login.cshtml"
               Write(Html.LabelFor(m => m.Password, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
                EndContext();
                BeginContext(1090, 71, true);
                WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
                EndContext();
                BeginContext(1162, 66, false);
#line 25 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Account\Login.cshtml"
                   Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1228, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1255, 78, false);
#line 26 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Account\Login.cshtml"
                   Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1333, 340, true);
                WriteLiteral(@"
                    </div>
                </div>

                <div class=""form-group"">
                    <div class=""col-md-offset-2 col-md-10"">
                        <input type=""submit"" value=""Log in"" class=""btn btn-primary"" />
                    </div>
                </div>
                <p>
                    ");
                EndContext();
                BeginContext(1673, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ec3dbd183a4ca0dfa9b5caedc06b1a30bb9d7df10782", async() => {
                    BeginContext(1698, 22, true);
                    WriteLiteral("Register as a new user");
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
                BeginContext(1724, 36, true);
                WriteLiteral("\r\n                </p>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ReturnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 10 "C:\Users\Josh Spaeth\Documents\GitHub\sp20team13finalproject\sp20team13finalproject\Views\Account\Login.cshtml"
                                                                       WriteLiteral(ViewBag.ReturnUrl);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["ReturnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ReturnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["ReturnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1767, 42, true);
            WriteLiteral("\r\n        </section>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591