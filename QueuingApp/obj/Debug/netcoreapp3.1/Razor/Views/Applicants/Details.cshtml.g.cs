#pragma checksum "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1adf4dd98cdcc979c5740787b57fc42932c1360d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Applicants_Details), @"mvc.1.0.view", @"/Views/Applicants/Details.cshtml")]
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
#line 1 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\_ViewImports.cshtml"
using QueuingApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\_ViewImports.cshtml"
using QueuingApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1adf4dd98cdcc979c5740787b57fc42932c1360d", @"/Views/Applicants/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b86b3bac9baa80975fe53449f3ba7386af19f09a", @"/Views/_ViewImports.cshtml")]
    public class Views_Applicants_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QueuingApp.Models.Applicants>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
  
    ViewData["Title"] = "Applicant Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Applicant Details</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Socialsecuritynumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Socialsecuritynumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayFor(model => model.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EMail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayFor(model => model.EMail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 49 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pets));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pets));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 55 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Smoke));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 58 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Smoke));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 61 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 64 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 67 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 70 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayFor(model => model.PostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 73 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 76 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 79 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 82 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 85 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Introduction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 88 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayFor(model => model.Introduction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 91 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MainEmployment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 94 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayFor(model => model.MainEmployment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 97 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MainIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 100 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayFor(model => model.MainIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral(" SEK/month\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 103 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MainEmployer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 106 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayFor(model => model.MainEmployer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 109 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployerPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 112 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayFor(model => model.EmployerPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 115 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.WorkMunicipality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 118 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
       Write(Html.DisplayFor(model => model.WorkMunicipality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 123 "H:\Container And Cloud\QueuingApp\QueuingApp\Views\Applicants\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { Id = Model.objectId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1adf4dd98cdcc979c5740787b57fc42932c1360d15569", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QueuingApp.Models.Applicants> Html { get; private set; }
    }
}
#pragma warning restore 1591
