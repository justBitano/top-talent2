#pragma checksum "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Bookings\DirectPayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56c7dc7e0a4ae2515595dcb6f50d46a4d7e98438"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_DirectPayment), @"mvc.1.0.view", @"/Views/Bookings/DirectPayment.cshtml")]
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
#line 1 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\_ViewImports.cshtml"
using TopTalentWebClient1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\_ViewImports.cshtml"
using TopTalentWebClient1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56c7dc7e0a4ae2515595dcb6f50d46a4d7e98438", @"/Views/Bookings/DirectPayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c80432fae546df17eac2f4f0ee492244b3293fe", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Bookings_DirectPayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:1900px; height:500px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/breadcrumb/bg/bg-primary.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bookings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Payment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<main class=\"main-content\">\r\n \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "56c7dc7e0a4ae2515595dcb6f50d46a4d7e984384756", async() => {
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
            WriteLiteral(@"
<div class=""checkout-area section-space-y-axis-100"">
    <div class=""container"">

        <div class=""row"">
            <div class=""col-lg-6 col-12"">
                <div class=""your-order"">
                    <h3>Your order</h3>
                    <div class=""your-order-table table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th class=""cart-product-name"">Talent</th>
                                    <th class=""cart-product-total"">Price</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr class=""cart_item"">
                                        <td style=""text-align:center""  class=""cart-product-name"">
                                       <strong class=""product-quantity"">
                                                ");
#nullable restore
#line 23 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Bookings\DirectPayment.cshtml"
                                           Write(ViewBag.TalentFullname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </strong>
                                    </td>
                                    <td style=""text-align:center"" class=""cart-product-total""><span class=""amount"">
                                                ");
#nullable restore
#line 27 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Bookings\DirectPayment.cshtml"
                                           Write(ViewBag.TalentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </span></td>
                                </tr>

                            </tbody>
                            <tfoot>
                                <tr class=""order-total"">
                                        <th style =""text-align:center"">Order Total</thstyle>
                                        <td style=""text-align:center"" class=""cart-product-total"">
                                            <span class=""amount"">
                                                    ");
#nullable restore
#line 37 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Bookings\DirectPayment.cshtml"
                                               Write(ViewBag.TalentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </span>
                                        </td>
                                </tr>
                            </tfoot>
                        </table>
                    </div>
                    <div class=""payment-method"">
                        <div class=""payment-accordion"">
                            <div id=""accordion"">
                                <div class=""card"">
                                    <div class=""card-header"" id=""#payment-1"">
                                        <h5 class=""panel-title"">
                                            <a href=""javascript:void(0)""");
            BeginWriteAttribute("class", " class=\"", 2637, "\"", 2645, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-bs-toggle=""collapse"" data-bs-target=""#collapseOne"" aria-expanded=""true"">
                                                Direct Bank Transfer.
                                            </a>
                                        </h5>
                                    </div>
                                    <div id=""collapseOne"" class=""collapse show"" data-bs-parent=""#accordion"">
                                        <div class=""card-body"">
                                            <p>
                                                Make your payment directly into our bank account. Please use your Order
                                                ID as the payment
                                                reference. Your order won’t be shipped until the funds have cleared in
                                                our account.
                                            </p>
                                        </div>
                                    </di");
            WriteLiteral(@"v>
                                </div>
                                <div class=""card"">
                                    <div class=""card-header"" id=""#payment-2"">
                                        <h5 class=""panel-title"">
                                            <a href=""javascript:void(0)"" class=""collapsed"" data-bs-toggle=""collapse"" data-bs-target=""#collapseTwo"" aria-expanded=""false"">
                                                Cheque Payment
                                            </a>
                                        </h5>
                                    </div>
                                    <div id=""collapseTwo"" class=""collapse"" data-bs-parent=""#accordion"">
                                        <div class=""card-body"">
                                            <p>
                                                Make your payment directly into our bank account. Please use your Order
                                                ID as the payment
");
            WriteLiteral(@"                                                reference. Your order won’t be shipped until the funds have cleared in
                                                our account.
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <div class=""card"">
                                    <div class=""card-header"" id=""#payment-3"">
                                        <h5 class=""panel-title"">
                                            <a href=""javascript:void(0)"" class=""collapsed"" data-bs-toggle=""collapse"" data-bs-target=""#collapseThree"" aria-expanded=""false"">
                                                PayPal
                                            </a>
                                        </h5>
                                    </div>
                                    <div id=""collapseThree"" class=""collapse"" data-bs-parent=""");
            WriteLiteral(@"#accordion"">
                                        <div class=""card-body"">
                                            <p>
                                                Make your payment directly into our bank account. Please use your Order
                                                ID as the payment
                                                reference. Your order won’t be shipped until the funds have cleared in
                                                our account.
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""order-button-payment"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56c7dc7e0a4ae2515595dcb6f50d46a4d7e9843813410", async() => {
                WriteLiteral("      <button style=\"background-color:black\" type=\"submit\" class=\"btn btn-custom-size lg-size btn-secondary btn-primary-hover rounded-0\">Check Payment</button");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-bookingId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 107 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Bookings\DirectPayment.cshtml"
                                        WriteLiteral(ViewBag.BookingID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookingId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-bookingId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookingId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 107 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Bookings\DirectPayment.cshtml"
                                                                              WriteLiteral(ViewBag.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Bookings\DirectPayment.cshtml"
                                       WriteLiteral(ViewBag.TalentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["talentId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-talentId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["talentId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n</main>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
