#pragma checksum "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4c18da051ea7476a62bec82101d9756204d37f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_Edit), @"mvc.1.0.view", @"/Views/Invoice/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4c18da051ea7476a62bec82101d9756204d37f6", @"/Views/Invoice/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9220b3d2aeefdb00411ee6b734caa3415c1fc3cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Delaney.Models.Invoice>
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
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h2>Edit Invoice</h2>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4c18da051ea7476a62bec82101d9756204d37f63630", async() => {
                WriteLiteral("\r\n\r\n        <!-- Form Invoice -->\r\n        <div class=\"grid_auto_1fr\">\r\n\r\n            <!-- Date -->\r\n            ");
#nullable restore
#line 13 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
       Write(Html.LabelFor(x => x.DateDisplayed));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input id=\"DateDisplayed\"\r\n                   class=\"form-control\"\r\n                   name=\"DateDisplayed\"\r\n                   type=\"text\"\r\n                   readonly");
                BeginWriteAttribute("value", "\r\n                   value=\"", 471, "\"", 519, 1);
#nullable restore
#line 19 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
WriteAttributeValue("", 499, Model.DateDisplayed, 499, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n\r\n            <!-- Number Input -->\r\n            ");
#nullable restore
#line 23 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
       Write(Html.LabelFor(x => x.Number));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input class=\"form-control\"\r\n                   name=\"Number\"\r\n                   type=\"text\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 710, "\"", 751, 1);
#nullable restore
#line 27 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
WriteAttributeValue("", 738, Model.Number, 738, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n            <!-- Prefix Input -->\r\n            ");
#nullable restore
#line 30 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
       Write(Html.LabelFor(x => x.Prefix));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input class=\"form-control\"\r\n                   name=\"Prefix\"\r\n                   type=\"text\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 940, "\"", 981, 1);
#nullable restore
#line 34 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
WriteAttributeValue("", 968, Model.Prefix, 968, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n            <!-- FirstName Input -->\r\n            ");
#nullable restore
#line 37 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
       Write(Html.LabelFor(x => x.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input class=\"form-control\"\r\n                   name=\"FirstName\"\r\n                   type=\"text\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 1179, "\"", 1223, 1);
#nullable restore
#line 41 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
WriteAttributeValue("", 1207, Model.FirstName, 1207, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n            <!-- MiddleName Input -->\r\n            ");
#nullable restore
#line 44 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
       Write(Html.LabelFor(x => x.MiddleName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input class=\"form-control\"\r\n                   name=\"MiddleName\"\r\n                   type=\"text\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 1424, "\"", 1469, 1);
#nullable restore
#line 48 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
WriteAttributeValue("", 1452, Model.MiddleName, 1452, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n            <!-- LastName Input -->\r\n            ");
#nullable restore
#line 51 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
       Write(Html.LabelFor(x => x.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input class=\"form-control\"\r\n                   name=\"LastName\"\r\n                   type=\"text\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 1664, "\"", 1707, 1);
#nullable restore
#line 55 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
WriteAttributeValue("", 1692, Model.LastName, 1692, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n            <!-- Suffix Input -->\r\n            ");
#nullable restore
#line 58 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
       Write(Html.LabelFor(x => x.Suffix));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input class=\"form-control\"\r\n                   name=\"Suffix\"\r\n                   type=\"text\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 1896, "\"", 1937, 1);
#nullable restore
#line 62 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
WriteAttributeValue("", 1924, Model.Suffix, 1924, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n            <!-- Email Input -->\r\n            ");
#nullable restore
#line 65 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
       Write(Html.LabelFor(x => x.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input class=\"form-control\"\r\n                   name=\"Email\"\r\n                   type=\"text\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 2123, "\"", 2163, 1);
#nullable restore
#line 69 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
WriteAttributeValue("", 2151, Model.Email, 2151, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n            <!-- Address1 Input -->\r\n            ");
#nullable restore
#line 72 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
       Write(Html.LabelFor(x => x.Address1));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input class=\"form-control\"\r\n                   name=\"Address1\"\r\n                   type=\"text\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 2358, "\"", 2401, 1);
#nullable restore
#line 76 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
WriteAttributeValue("", 2386, Model.Address1, 2386, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n            <!-- Address2 Input -->\r\n            ");
#nullable restore
#line 79 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
       Write(Html.LabelFor(x => x.Address2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input class=\"form-control\"\r\n                   name=\"Address2\"\r\n                   type=\"text\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 2596, "\"", 2639, 1);
#nullable restore
#line 83 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
WriteAttributeValue("", 2624, Model.Address2, 2624, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n            <!-- Address3 Input -->\r\n            ");
#nullable restore
#line 86 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
       Write(Html.LabelFor(x => x.Address3));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input class=\"form-control\"\r\n                   name=\"Address3\"\r\n                   type=\"text\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 2834, "\"", 2877, 1);
#nullable restore
#line 90 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
WriteAttributeValue("", 2862, Model.Address3, 2862, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n            <!-- Address4 Input -->\r\n            ");
#nullable restore
#line 93 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
       Write(Html.LabelFor(x => x.Address4));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input class=\"form-control\"\r\n                   name=\"Address4\"\r\n                   type=\"text\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 3072, "\"", 3115, 1);
#nullable restore
#line 97 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
WriteAttributeValue("", 3100, Model.Address4, 3100, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n            <!-- Address5 Input -->\r\n            ");
#nullable restore
#line 100 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
       Write(Html.LabelFor(x => x.Address5));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input class=\"form-control\"\r\n                   name=\"Address5\"\r\n                   type=\"text\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 3310, "\"", 3353, 1);
#nullable restore
#line 104 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
WriteAttributeValue("", 3338, Model.Address5, 3338, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n            <!-- PostCode Input -->\r\n            ");
#nullable restore
#line 107 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
       Write(Html.LabelFor(x => x.PostCode));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input class=\"form-control\"\r\n                   name=\"PostCode\"\r\n                   type=\"text\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 3548, "\"", 3591, 1);
#nullable restore
#line 111 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
WriteAttributeValue("", 3576, Model.PostCode, 3576, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n            <!-- CountryCode Input -->\r\n            ");
#nullable restore
#line 114 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
       Write(Html.LabelFor(x => x.CountryCode));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input class=\"form-control\"\r\n                   name=\"CountryCode\"\r\n                   type=\"text\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 3795, "\"", 3841, 1);
#nullable restore
#line 118 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
WriteAttributeValue("", 3823, Model.CountryCode, 3823, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n            <!-- PayPalOrderId Input -->\r\n            ");
#nullable restore
#line 121 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
       Write(Html.LabelFor(x => x.PayPalOrderId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input class=\"form-control\"\r\n                   name=\"PayPalOrderId\"\r\n                   type=\"text\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 4051, "\"", 4099, 1);
#nullable restore
#line 125 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
WriteAttributeValue("", 4079, Model.PayPalOrderId, 4079, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n            <!-- PayPalPayerId Input -->\r\n            ");
#nullable restore
#line 128 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
       Write(Html.LabelFor(x => x.PayPalPayerId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <input class=\"form-control\"\r\n                   name=\"PayPalPayerId\"\r\n                   type=\"text\"");
                BeginWriteAttribute("value", "\r\n                   value=\"", 4309, "\"", 4357, 1);
#nullable restore
#line 132 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
WriteAttributeValue("", 4337, Model.PayPalPayerId, 4337, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n\r\n");
#nullable restore
#line 135 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
     if (!ViewContext.ModelState.IsValid)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
   Write(Html.ValidationSummary(false, "", new { @class = "text-danger list_Error" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 137 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
                                                                                     
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <!-- Buttons -->
        <button formaction=""/Invoice/Edit""
                formmethod=""post""
                type=""submit""
                class=""btn btn-secondary"">Save</button>
        <button formaction=""/Invoice/Cancel""
                formmethod=""post""
                type=""submit""
                class=""btn btn-secondary"">Cancel</button>

        ");
#nullable restore
#line 149 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
   Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 150 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
   Write(Html.HiddenFor(x => x.CreatedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 151 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
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
#line 157 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Delaney.Models.Invoice> Html { get; private set; }
    }
}
#pragma warning restore 1591
