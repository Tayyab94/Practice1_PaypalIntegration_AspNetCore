#pragma checksum "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0c1258bb65f2fdb1dbc3bb6d5f473b92c1bac94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Edit), @"mvc.1.0.view", @"/Views/Basket/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0c1258bb65f2fdb1dbc3bb6d5f473b92c1bac94", @"/Views/Basket/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9220b3d2aeefdb00411ee6b734caa3415c1fc3cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Delaney.Models.Basket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h2>Edit Basket</h2>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0c1258bb65f2fdb1dbc3bb6d5f473b92c1bac943623", async() => {
                WriteLiteral("\r\n\r\n        <!-- Form Basket -->\r\n        <div class=\"grid_auto_1fr\">\r\n\r\n            <!-- Date -->\r\n            ");
#nullable restore
#line 13 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Edit.cshtml"
       Write(Html.LabelFor(x => x.DateDisplayed));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input id=\"DateDisplayed\"\r\n                   class=\"form-control\"\r\n                   name=\"DateDisplayed\"\r\n                   type=\"text\"\r\n                   readonly");
                BeginWriteAttribute("value", "\r\n                   value=\"", 468, "\"", 516, 1);
#nullable restore
#line 19 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Edit.cshtml"
WriteAttributeValue("", 496, Model.DateDisplayed, 496, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n            <!-- CurrencyCode Input -->\r\n            ");
#nullable restore
#line 22 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Edit.cshtml"
       Write(Html.LabelFor(x => x.CurrencyCode));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input class=\"form-control\"\r\n                   name=\"CurrencyCode\"\r\n                   type=\"text\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 723, "\"", 770, 1);
#nullable restore
#line 26 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Edit.cshtml"
WriteAttributeValue("", 751, Model.CurrencyCode, 751, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n            <!-- CurrencySymbol Input -->\r\n            ");
#nullable restore
#line 29 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Edit.cshtml"
       Write(Html.LabelFor(x => x.CurrencySymbol));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input class=\"form-control\"\r\n                   name=\"CurrencyCode\"\r\n                   type=\"text\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 981, "\"", 1030, 1);
#nullable restore
#line 33 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Edit.cshtml"
WriteAttributeValue("", 1009, Model.CurrencySymbol, 1009, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n            <!-- Discount Input -->\r\n            ");
#nullable restore
#line 36 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Edit.cshtml"
       Write(Html.LabelFor(x => x.Discount));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input class=\"form-control\"\r\n                   name=\"Discount\"\r\n                   type=\"text\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 1225, "\"", 1268, 1);
#nullable restore
#line 40 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Edit.cshtml"
WriteAttributeValue("", 1253, Model.Discount, 1253, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n            <!-- GUID Input -->\r\n            ");
#nullable restore
#line 43 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Edit.cshtml"
       Write(Html.LabelFor(x => x.GUID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input class=\"form-control\"\r\n                   name=\"{property pascal}\"\r\n                   type=\"text\"\r\n                   readonly");
                BeginWriteAttribute("value", "\r\n                   value=\"", 1493, "\"", 1532, 1);
#nullable restore
#line 48 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Edit.cshtml"
WriteAttributeValue("", 1521, Model.GUID, 1521, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n\r\n");
#nullable restore
#line 51 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Edit.cshtml"
     if (!ViewContext.ModelState.IsValid)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Edit.cshtml"
   Write(Html.ValidationSummary(false, "", new { @class = "text-danger list_Error" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Edit.cshtml"
                                                                                     
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <!-- Buttons -->
        <button formaction=""/Basket/Edit""
                formmethod=""post""
                type=""submit""
                class=""btn btn-secondary"">Save</button>
        <button formaction=""/Basket/Cancel""
                formmethod=""post""
                type=""submit""
                class=""btn btn-secondary"">Cancel</button>

        ");
#nullable restore
#line 65 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Edit.cshtml"
   Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 66 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Edit.cshtml"
   Write(Html.HiddenFor(x => x.CreatedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 67 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Edit.cshtml"
   Write(Html.HiddenFor(x => x.GUID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
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
            WriteLiteral("\r\n\r\n\r\n    <div>\r\n        ");
#nullable restore
#line 73 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Basket\Edit.cshtml"
   Write(Html.ActionLink("Back to List", ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<script>\r\n    $(\'.input-group.date\').datepicker({\r\n            format: \'yyyy-mm-dd\'\r\n         });\r\n</script>");
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
