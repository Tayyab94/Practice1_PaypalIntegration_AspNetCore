#pragma checksum "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d49a081115430212aff13c157b421549e657408f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Delete), @"mvc.1.0.view", @"/Views/Product/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d49a081115430212aff13c157b421549e657408f", @"/Views/Product/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9220b3d2aeefdb00411ee6b734caa3415c1fc3cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Delaney.Models.Product>
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
            WriteLiteral("<div class=\"container\">\r\n\r\n    <h2>Delete Product</h2>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d49a081115430212aff13c157b421549e657408f3644", async() => {
                WriteLiteral("\r\n        <h3>Are you sure you?</h3>\r\n\r\n        <div class=\"grid_auto_1fr\">\r\n\r\n        <!-- Description -->\r\n        <div>");
#nullable restore
#line 13 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
        Write(Html.DisplayNameFor(x => x.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        <div>");
#nullable restore
#line 14 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
        Write(Html.DisplayFor(x => x.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n        <!-- Name -->\r\n        <div>");
#nullable restore
#line 17 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
        Write(Html.DisplayNameFor(x => x.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        <div>");
#nullable restore
#line 18 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
        Write(Html.DisplayFor(x => x.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n        <!-- Price -->\r\n        <div>");
#nullable restore
#line 21 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
        Write(Html.DisplayNameFor(x => x.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        <div>");
#nullable restore
#line 22 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
        Write(Html.DisplayFor(x => x.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n        <!-- Quantity -->\r\n        <div>");
#nullable restore
#line 25 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
        Write(Html.DisplayNameFor(x => x.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        <div>");
#nullable restore
#line 26 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
        Write(Html.DisplayFor(x => x.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n        <!-- BacketString -->\r\n        <div>");
#nullable restore
#line 29 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
        Write(Html.DisplayNameFor(x => x.BacketString));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        <div>");
#nullable restore
#line 30 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
        Write(Html.DisplayFor(x => x.BacketString));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n        <!-- Created Date -->\r\n        <div>");
#nullable restore
#line 33 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
        Write(Html.DisplayNameFor(x => x.CreatedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        <div>");
#nullable restore
#line 34 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
        Write(Html.DisplayFor(x => x.CreatedDateString));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n        <div>");
#nullable restore
#line 36 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
        Write(Html.DisplayNameFor(x => x.GUID));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>      \r\n        <div>");
#nullable restore
#line 37 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
        Write(Html.DisplayFor(x => x.GUID));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 40 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
     if (!ViewContext.ModelState.IsValid)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
   Write(Html.ValidationSummary(false,
                                "",
                                new { @class = "text-danger list_Error" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
                                                                          
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <!-- Buttons -->
        <button formaction=""/Product/Delete""
                formmethod=""post""
                type=""submit""
                class=""btn btn-secondary"">Delete</button>
        <button formaction=""/Product/Cancel""
                formmethod=""post""
                type=""submit""
                class=""btn btn-secondary"">Cancel</button>

        ");
#nullable restore
#line 57 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
   Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 58 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
   Write(Html.HiddenFor(x => x.BacketId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 59 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
   Write(Html.HiddenFor(x => x.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 60 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
   Write(Html.HiddenFor(x => x.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 61 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
   Write(Html.HiddenFor(x => x.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 62 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
   Write(Html.HiddenFor(x => x.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 63 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
   Write(Html.HiddenFor(x => x.CreatedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 64 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
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
#line 69 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Product\Delete.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Delaney.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591