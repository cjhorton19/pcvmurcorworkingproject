#pragma checksum "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b233ea911be2b6a568ee557ba1255765fead72b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VmsRolegroups_Details), @"mvc.1.0.view", @"/Views/VmsRolegroups/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/VmsRolegroups/Details.cshtml", typeof(AspNetCore.Views_VmsRolegroups_Details))]
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
#line 1 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\_ViewImports.cshtml"
using PCVTry;

#line default
#line hidden
#line 2 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\_ViewImports.cshtml"
using PCVTry.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b233ea911be2b6a568ee557ba1255765fead72b", @"/Views/VmsRolegroups/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69dc469ac0f93126037a0bcfc88d15baf964f9d3", @"/Views/_ViewImports.cshtml")]
    public class Views_VmsRolegroups_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PCVTry.Models.VmsRolegroup>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(80, 126, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>VmsRolegroup</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(207, 48, false);
#line 14 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AccountGroup));

#line default
#line hidden
            EndContext();
            BeginContext(255, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(299, 44, false);
#line 17 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.AccountGroup));

#line default
#line hidden
            EndContext();
            BeginContext(343, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(387, 48, false);
#line 20 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdminSupport));

#line default
#line hidden
            EndContext();
            BeginContext(435, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(479, 44, false);
#line 23 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdminSupport));

#line default
#line hidden
            EndContext();
            BeginContext(523, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(567, 44, false);
#line 26 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Assignor));

#line default
#line hidden
            EndContext();
            BeginContext(611, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(655, 40, false);
#line 29 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.Assignor));

#line default
#line hidden
            EndContext();
            BeginContext(695, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(739, 43, false);
#line 32 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Auditor));

#line default
#line hidden
            EndContext();
            BeginContext(782, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(826, 39, false);
#line 35 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.Auditor));

#line default
#line hidden
            EndContext();
            BeginContext(865, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(909, 51, false);
#line 38 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CliServiDeptMgr));

#line default
#line hidden
            EndContext();
            BeginContext(960, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1004, 47, false);
#line 41 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.CliServiDeptMgr));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1095, 49, false);
#line 44 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CliServiGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1144, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1188, 45, false);
#line 47 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.CliServiGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1233, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1277, 51, false);
#line 50 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CommercialGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1328, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1372, 47, false);
#line 53 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.CommercialGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1463, 48, false);
#line 56 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ContractorQc));

#line default
#line hidden
            EndContext();
            BeginContext(1511, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1555, 44, false);
#line 59 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.ContractorQc));

#line default
#line hidden
            EndContext();
            BeginContext(1599, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1643, 43, false);
#line 62 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Itgroup));

#line default
#line hidden
            EndContext();
            BeginContext(1686, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1730, 39, false);
#line 65 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.Itgroup));

#line default
#line hidden
            EndContext();
            BeginContext(1769, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1813, 59, false);
#line 68 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProcessingShippingGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1872, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1916, 55, false);
#line 71 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProcessingShippingGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1971, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2015, 52, false);
#line 74 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QcsupervisorLead));

#line default
#line hidden
            EndContext();
            BeginContext(2067, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2111, 48, false);
#line 77 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.QcsupervisorLead));

#line default
#line hidden
            EndContext();
            BeginContext(2159, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2203, 38, false);
#line 80 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Qc));

#line default
#line hidden
            EndContext();
            BeginContext(2241, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2285, 34, false);
#line 83 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.Qc));

#line default
#line hidden
            EndContext();
            BeginContext(2319, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2363, 46, false);
#line 86 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SalesGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2409, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2453, 42, false);
#line 89 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.SalesGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2495, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2539, 47, false);
#line 92 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StatusGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2586, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2630, 43, false);
#line 95 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.StatusGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2673, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2717, 56, false);
#line 98 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VendorRelationsGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2773, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2817, 52, false);
#line 101 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.VendorRelationsGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2869, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2916, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "458c50c441f44dd5be48368ea6e223b7", async() => {
                BeginContext(2974, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 106 "C:\Users\lil-v\Documents\GitHub\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
                           WriteLiteral(Model.VmsroleGroupId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2982, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2990, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "241fb7abff994fe1a2928e70dc875fde", async() => {
                BeginContext(3012, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3028, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PCVTry.Models.VmsRolegroup> Html { get; private set; }
    }
}
#pragma warning restore 1591
