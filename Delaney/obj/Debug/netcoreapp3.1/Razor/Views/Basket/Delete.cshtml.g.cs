#pragma checksum "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa9966e5b33595ae7f434abacee7432ea5610984"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Delete), @"mvc.1.0.view", @"/Views/Basket/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa9966e5b33595ae7f434abacee7432ea5610984", @"/Views/Basket/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9220b3d2aeefdb00411ee6b734caa3415c1fc3cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Delaney.Models.Basket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n\r\n    <h2>Delete Basket</h2>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa9966e5b33595ae7f434abacee7432ea56109843637", async() => {
                WriteLiteral("\r\n        <h3>Are you sure you?</h3>\r\n\r\n        <div class=\"grid_auto_1fr\">\r\n\r\n            <!-- CurrencyCode -->\r\n            <div>");
#nullable restore
#line 13 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Delete.cshtml"
            Write(Html.DisplayNameFor(x => x.CurrencyCode));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div>");
#nullable restore
#line 14 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Delete.cshtml"
            Write(Html.DisplayFor(x => x.CurrencyCode));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n            <!-- CurrencySymbol -->\r\n            <div>");
#nullable restore
#line 17 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Delete.cshtml"
            Write(Html.DisplayNameFor(x => x.CurrencySymbol));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div>");
#nullable restore
#line 18 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Delete.cshtml"
            Write(Html.DisplayFor(x => x.CurrencySymbol));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n            <!-- Discount -->\r\n            <div>");
#nullable restore
#line 21 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Delete.cshtml"
            Write(Html.DisplayNameFor(x => x.Discount));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div>");
#nullable restore
#line 22 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Delete.cshtml"
            Write(Html.DisplayFor(x => x.Discount));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n            <!-- Created Date -->\r\n            <div>");
#nullable restore
#line 25 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Delete.cshtml"
            Write(Html.DisplayNameFor(x => x.CreatedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div>");
#nullable restore
#line 26 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Delete.cshtml"
            Write(Html.DisplayFor(x => x.CreatedDateString));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n            <div>");
#nullable restore
#line 28 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Delete.cshtml"
            Write(Html.DisplayNameFor(x => x.GUID));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div>");
#nullable restore
#line 29 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Delete.cshtml"
            Write(Html.DisplayFor(x => x.GUID));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        </div>\r\n\r\n");
#nullable restore
#line 32 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Delete.cshtml"
         if (!ViewContext.ModelState.IsValid)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Delete.cshtml"
       Write(Html.ValidationSummary(false,
                                    "",
                                    new { @class = "text-danger list_Error" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Delete.cshtml"
                                                                              
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <!-- Buttons -->
        <button formaction=""/Basket/Delete""
                formmethod=""post""
                type=""submit""
                class=""btn btn-secondary"">
            Delete
        </button>
        <button formaction=""/Basket/Cancel""
                formmethod=""post""
                type=""submit""
                class=""btn btn-secondary"">
            Cancel
        </button>

        ");
#nullable restore
#line 53 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Delete.cshtml"
   Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 54 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Delete.cshtml"
   Write(Html.HiddenFor(x => x.CurrencyCode));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 55 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Delete.cshtml"
   Write(Html.HiddenFor(x => x.CurrencySymbol));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 56 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Delete.cshtml"
   Write(Html.HiddenFor(x => x.Discount));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 57 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Delete.cshtml"
   Write(Html.HiddenFor(x => x.CreatedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 58 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Delete.cshtml"
   Write(Html.HiddenFor(x => x.GUID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n    <div>\r\n        <p class=\"delaney-link-pager\">");
#nullable restore
#line 63 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Delete.cshtml"
                                 Write(Html.ActionLink("Back to List", ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Delaney.Models.Basket> Html { get; private set; }
    }
}
#pragma warning restore 1591
