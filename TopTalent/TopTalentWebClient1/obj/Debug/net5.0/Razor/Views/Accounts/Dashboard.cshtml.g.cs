#pragma checksum "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Accounts\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22fa0903c59c74c8db31b72b642bd6ba3c851e98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Dashboard), @"mvc.1.0.view", @"/Views/Accounts/Dashboard.cshtml")]
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
#line 1 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Accounts\Dashboard.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22fa0903c59c74c8db31b72b642bd6ba3c851e98", @"/Views/Accounts/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c80432fae546df17eac2f4f0ee492244b3293fe", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Accounts_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("account-logout-tab"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Accounts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("tab"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-selected", new global::Microsoft.AspNetCore.Html.HtmlString("false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 5 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Accounts\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout =
           "~/Views/Shared/_Layout.cshtml";
    List<Booking> bookings = ViewBag.listBooking;
    List<Booking> bookingstalent = ViewBag.listBookingTalent;
    TopTalentWebClient1.ModelView.ChangePasswordViewModel changePassword = new TopTalentWebClient1.ModelView.ChangePasswordViewModel();
    var talentId = Context.Session.GetInt32("TalentId");
    var userId = Context.Session.GetInt32("UserId");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""breadcrumb-area breadcrumb-height"" style=""#e5e5e5"" data-bg-image=""assets/images/breadcrumb/bg/bg-primary.png"">
    <div class=""container h-100"">
        <div class=""row h-100"">
            <div class=""col-lg-12"">
                <div class=""breadcrumb-item"">
                    <h2 class=""breadcrumb-heading"">Dashboard</h2>
                    <ul>
                        <li>
                            <a href=""index.html"">Home <i class=""pe-7s-angle-right""></i></a>
                        </li>
                        <li>My Account</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""account-page-area section-space-y-axis-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <ul class=""nav myaccount-tab-trigger"" id=""account-page-tab"" role=""tablist"">
                    <li class=""nav-item"">
                        <a class=""nav-link active"" id=""acco");
            WriteLiteral(@"unt-dashboard-tab"" data-bs-toggle=""tab"" href=""#account-dashboard"" role=""tab"" aria-controls=""account-dashboard"" aria-selected=""true"">Account Infomation</a>

                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" id=""account-orders-tab"" data-bs-toggle=""tab"" href=""#account-orders"" role=""tab"" aria-controls=""account-orders"" aria-selected=""false"">Booking List</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" id=""account-details-tab"" data-bs-toggle=""tab"" href=""#account-details"" role=""tab"" aria-controls=""account-details"" aria-selected=""false"">Change Password</a>
                    </li>
                    <li class=""nav-item"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22fa0903c59c74c8db31b72b642bd6ba3c851e987954", async() => {
                WriteLiteral("Logout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
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
            WriteLiteral(@"
                    </li>
                </ul>
            </div>
            <div class=""col-lg-9"">
                <div class=""tab-content myaccount-tab-content"" id=""account-page-tab-content"">
                    <div class=""tab-pane fade show active"" id=""account-dashboard"" role=""tabpanel"" aria-labelledby=""account-dashboard-tab"">
                        <div class=""myaccount-dashboard"">
                            <p>
                                Hello <b>");
#nullable restore
#line 59 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Accounts\Dashboard.cshtml"
                                    Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                            </p>\r\n                            <p>\r\n                                ");
#nullable restore
#line 62 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Accounts\Dashboard.cshtml"
                           Write(await Html.PartialAsync("_AccountsInformation.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                        </div>
                    </div>
                    <div class=""tab-pane fade"" id=""account-orders"" role=""tabpanel"" aria-labelledby=""account-orders-tab"">
                        <div class=""myaccount-orders"">
                            <h4 class=""small-title"">Booking of ");
#nullable restore
#line 68 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Accounts\Dashboard.cshtml"
                                                          Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 69 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Accounts\Dashboard.cshtml"
                             if(userId != null){
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Accounts\Dashboard.cshtml"
                           Write(await Html.PartialAsync("_BookingListPartialView.cshtml",bookings));

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Accounts\Dashboard.cshtml"
                                                                                                   
                            }else if(talentId != null){
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Accounts\Dashboard.cshtml"
                           Write(await Html.PartialAsync("_BookingTalentListPartialView.cshtml",bookingstalent));

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Accounts\Dashboard.cshtml"
                                                                                                               
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                           
                        </div>
                    </div>
                    <div class=""tab-pane fade"" id=""account-details"" role=""tabpanel"" aria-labelledby=""account-details-tab"">
                          <h4 class=""small-title"">Change Password of ");
#nullable restore
#line 78 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Accounts\Dashboard.cshtml"
                                                                Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        ");
#nullable restore
#line 79 "D:\top-talent-api\top-talent2\TopTalent\TopTalentWebClient1\Views\Accounts\Dashboard.cshtml"
                   Write(await Html.PartialAsync("_ChangePasswordPartialView", changePassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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