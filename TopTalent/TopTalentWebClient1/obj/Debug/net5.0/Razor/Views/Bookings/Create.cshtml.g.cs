#pragma checksum "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Bookings\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d56425fdba8f423d66e8101046d89b42883a0f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_Create), @"mvc.1.0.view", @"/Views/Bookings/Create.cshtml")]
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
#nullable restore
#line 1 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Bookings\Create.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d56425fdba8f423d66e8101046d89b42883a0f8", @"/Views/Bookings/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c80432fae546df17eac2f4f0ee492244b3293fe", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Bookings_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TopTalentWebClient1.Models.Booking>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("checkout-mess"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cols", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("10"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Bookings\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var talentIdSession = Context.Session.GetInt32("TalentId");
    var userIdSession = Context.Session.GetInt32("UserId");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main-content"">
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
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d56425fdba8f423d66e8101046d89b42883a0f87756", async() => {
                WriteLiteral(@"
                    <div class=""checkbox-form"">
                        <h3>Account Details</h3>
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <div class=""checkout-form-list"">
                                    <label>Working day  <span class=""required"">*</span></label>
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9d56425fdba8f423d66e8101046d89b42883a0f88417", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 42 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Bookings\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CreateDate);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-md-12"">
                                <div class=""checkout-form-list"">
                                    <label>Cash (VND) <span class=""required"">*</span></label>
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9d56425fdba8f423d66e8101046d89b42883a0f810550", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 48 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Bookings\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Cash);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""order-notes"">
                                <div class=""checkout-form-list checkout-form-list-2"">
                                    <label>Job description</label>
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d56425fdba8f423d66e8101046d89b42883a0f812672", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 54 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Bookings\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Description);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                            </div>
                               
                                <div class=""form-group"">
                                    <input style=""color:white; background-color:black"" type=""submit""
                                           value=""Create"" class=""btn btn-primary"" />
                                </div>
                                
                              
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
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
#line 83 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Bookings\Create.cshtml"
                                           Write(ViewBag.FullNameTalent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </strong>
                                    </td>
                                    <td style=""text-align:center"" class=""cart-product-total""><span class=""amount"">
                                               ");
#nullable restore
#line 87 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Bookings\Create.cshtml"
                                          Write(ViewBag.PriceTalent);

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
                                        ");
            WriteLiteral("    <a href=\"javascript:void(0)\"");
            BeginWriteAttribute("class", " class=\"", 5268, "\"", 5276, 0);
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
                                
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
</main>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TopTalentWebClient1.Models.Booking> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
