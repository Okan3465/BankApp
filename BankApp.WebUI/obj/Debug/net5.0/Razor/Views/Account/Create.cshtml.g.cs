#pragma checksum "C:\Users\Okan Karakoç\Documents\GitHub\BankApp\BankApp.WebUI\Views\Account\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63595f2e3828ba20c51b33699c4974eeb6823782"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Create), @"mvc.1.0.view", @"/Views/Account/Create.cshtml")]
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
#line 3 "C:\Users\Okan Karakoç\Documents\GitHub\BankApp\BankApp.WebUI\Views\_ViewImports.cshtml"
using BankApp.WebUI.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63595f2e3828ba20c51b33699c4974eeb6823782", @"/Views/Account/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbd409b461a72c58d73627f854bbacd55455e63d", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationUser>
    {
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
        private global::BankApp.WebUI.TagHelpers.GetAccountCount __BankApp_WebUI_TagHelpers_GetAccountCount;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Okan Karakoç\Documents\GitHub\BankApp\BankApp.WebUI\Views\Account\Create.cshtml"
   
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h3>Hesap Eklenecek Kişinin Bilgileri</h3>\r\n        <p>Kullanıcının Adı : ");
#nullable restore
#line 10 "C:\Users\Okan Karakoç\Documents\GitHub\BankApp\BankApp.WebUI\Views\Account\Create.cshtml"
                         Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Kullanıcının Soyadı : ");
#nullable restore
#line 11 "C:\Users\Okan Karakoç\Documents\GitHub\BankApp\BankApp.WebUI\Views\Account\Create.cshtml"
                            Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>Kullanıcının Aktif Hesap Sayısı :  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getAccountCount", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63595f2e3828ba20c51b33699c4974eeb68237823897", async() => {
            }
            );
            __BankApp_WebUI_TagHelpers_GetAccountCount = CreateTagHelper<global::BankApp.WebUI.TagHelpers.GetAccountCount>();
            __tagHelperExecutionContext.Add(__BankApp_WebUI_TagHelpers_GetAccountCount);
#nullable restore
#line 12 "C:\Users\Okan Karakoç\Documents\GitHub\BankApp\BankApp.WebUI\Views\Account\Create.cshtml"
__BankApp_WebUI_TagHelpers_GetAccountCount.AppUserId = Model.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("app-user-id", __BankApp_WebUI_TagHelpers_GetAccountCount.AppUserId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n    </div>\r\n\r\n    <div class=\"col-6\">\r\n        <h4>Ekleme İşlemi</h4>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
