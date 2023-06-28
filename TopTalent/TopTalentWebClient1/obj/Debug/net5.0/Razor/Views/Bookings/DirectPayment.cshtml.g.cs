#pragma checksum "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Bookings\DirectPayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38dfddb18da595b208a0c6dc7e9e859bc5fb187b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38dfddb18da595b208a0c6dc7e9e859bc5fb187b", @"/Views/Bookings/DirectPayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c80432fae546df17eac2f4f0ee492244b3293fe", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Bookings_DirectPayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bookings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Payment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""assets/images/breadcrumb/bg/bg-primary.png"">
        <div class=""container h-100"">
        <div class=""row h-100"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb-item"">
                    <h2 class=""breadcrumb-heading"">Top Talent</h2>
                    <ul>
                        <li>
                            <a href=""index.html"">Home <i class=""pe-7s-angle-right""></i></a>
                        </li>
                        <li>Booking</li>
                    </ul>
                    </div>
                </div>
            </div>
        </div>
</div>

<div class=""checkout-area section-space-y-axis-100"">
    <div class=""container"">

        <div class=""row"">
            <div class=""col-lg-6 col-12"">
                <div class=""your-order"">
                    <h3>Your order</h3>
                    <div class=""your-order-table table-responsive"">
     ");
            WriteLiteral(@"                   <table class=""table"">
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
#line 39 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Bookings\DirectPayment.cshtml"
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
#line 43 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Bookings\DirectPayment.cshtml"
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
                                    <th>Order Total</th>
                                    <td><strong><span class=""amount""></span>
                                         ");
#nullable restore
#line 52 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Bookings\DirectPayment.cshtml"
                                    Write(ViewBag.TalentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </strong></td>
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
            BeginWriteAttribute("class", " class=\"", 3035, "\"", 3043, 0);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38dfddb18da595b208a0c6dc7e9e859bc5fb187b11915", async() => {
                WriteLiteral("Check Payment");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-bookingId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Bookings\DirectPayment.cshtml"
                                        WriteLiteral(ViewBag.BookingID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookingId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-bookingId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookingId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Bookings\DirectPayment.cshtml"
                                                                              WriteLiteral(ViewBag.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Bookings\DirectPayment.cshtml"
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
