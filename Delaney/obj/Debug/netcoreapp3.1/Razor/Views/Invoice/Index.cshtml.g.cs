#pragma checksum "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d71e2099d6799db1d338ce0ebe9b5791db9be92c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_Index), @"mvc.1.0.view", @"/Views/Invoice/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d71e2099d6799db1d338ce0ebe9b5791db9be92c", @"/Views/Invoice/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9220b3d2aeefdb00411ee6b734caa3415c1fc3cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Delaney.Models.Summary<Delaney.Models.Invoice>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\"container\">\r\n        <h2>Invoice Summary</h2>\r\n        <p>\r\n            ");
#nullable restore
#line 5 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
       Write(Html.ActionLink("Create New", "Edit", null));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </p>
        <div class=""table-responsive"">
            <table id=""table_id""
                   class=""table table-striped"">
                <thead>
                    <tr>
                        <th style=""width:1px; white-space: nowrap;""></th>
                        <th>");
#nullable restore
#line 13 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Selected.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 14 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Selected.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 15 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Selected.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 16 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Selected.PayPalOrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 17 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Selected.PayPalPayerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 21 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
                     if (Model.Models != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
                         foreach (var item in Model.Models)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td style=\"width:1px; white-space: nowrap;\">\r\n");
#nullable restore
#line 27 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
                              
                                string linkEdit = "/Invoice/Edit/" + item.Id;
                                string linkDetail = "/Invoice/Detail/" + item.Id;
                                string linkDelete = "/Invoice/Delete/" + item.Id;
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 1577, "\"", 1593, 1);
#nullable restore
#line 32 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 1584, linkEdit, 1584, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1635, "\"", 1653, 1);
#nullable restore
#line 33 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 1642, linkDetail, 1642, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1698, "\"", 1716, 1);
#nullable restore
#line 34 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
WriteAttributeValue("", 1705, linkDelete, 1705, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                        </td>\r\n\r\n                        <td><span>");
#nullable restore
#line 37 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
                             Write(Html.DisplayFor(modelItem => item.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                        <td><span>");
#nullable restore
#line 38 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
                             Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                        <td><span>");
#nullable restore
#line 39 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
                             Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                        <td><span>");
#nullable restore
#line 40 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
                             Write(Html.DisplayFor(modelItem => item.PayPalOrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                        <td><span>");
#nullable restore
#line 41 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
                             Write(Html.DisplayFor(modelItem => item.PayPalPayerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                    </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <p class=\"text-info\">Count: ");
#nullable restore
#line 48 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
                               Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 49 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
     if (!ViewContext.ModelState.IsValid)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
   Write(Html.ValidationSummary(false, "", new { @class = "text-danger list_Error" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Admin\Downloads\PayPal-Smart-Button-Demo-master\PayPal-Smart-Button-Demo-master\PayPal Smart Button Demo\PayPal Smart Button Demo - App\Delaney\Views\Invoice\Index.cshtml"
                                                                                     
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Delaney.Models.Summary<Delaney.Models.Invoice>> Html { get; private set; }
    }
}
#pragma warning restore 1591
