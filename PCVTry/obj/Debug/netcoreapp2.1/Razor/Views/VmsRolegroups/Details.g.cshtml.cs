#pragma checksum "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a7412481c562cb49e3fed2ce3dfe9b37e288c7c"
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
#line 1 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\_ViewImports.cshtml"
using PCVTry;

#line default
#line hidden
#line 2 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\_ViewImports.cshtml"
using PCVTry.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a7412481c562cb49e3fed2ce3dfe9b37e288c7c", @"/Views/VmsRolegroups/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"084dcbc8277669b30ae3b518d9adf1b4c390f4a3", @"/Views/_ViewImports.cshtml")]
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
            BeginContext(34, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(75, 118, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>VmsRolegroup</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(194, 48, false);
#line 14 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AccountGroup));

#line default
#line hidden
            EndContext();
            BeginContext(242, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(283, 44, false);
#line 17 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.AccountGroup));

#line default
#line hidden
            EndContext();
            BeginContext(327, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(368, 48, false);
#line 20 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdminSupport));

#line default
#line hidden
            EndContext();
            BeginContext(416, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(457, 44, false);
#line 23 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdminSupport));

#line default
#line hidden
            EndContext();
            BeginContext(501, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(542, 44, false);
#line 26 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Assignor));

#line default
#line hidden
            EndContext();
            BeginContext(586, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(627, 40, false);
#line 29 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.Assignor));

#line default
#line hidden
            EndContext();
            BeginContext(667, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(708, 43, false);
#line 32 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Auditor));

#line default
#line hidden
            EndContext();
            BeginContext(751, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(792, 39, false);
#line 35 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.Auditor));

#line default
#line hidden
            EndContext();
            BeginContext(831, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(872, 51, false);
#line 38 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CliServiDeptMgr));

#line default
#line hidden
            EndContext();
            BeginContext(923, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(964, 47, false);
#line 41 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.CliServiDeptMgr));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1052, 49, false);
#line 44 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CliServiGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1101, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1142, 45, false);
#line 47 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.CliServiGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1187, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1228, 51, false);
#line 50 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CommercialGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1279, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1320, 47, false);
#line 53 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.CommercialGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1367, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1408, 48, false);
#line 56 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ContractorQc));

#line default
#line hidden
            EndContext();
            BeginContext(1456, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1497, 44, false);
#line 59 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.ContractorQc));

#line default
#line hidden
            EndContext();
            BeginContext(1541, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1582, 43, false);
#line 62 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Itgroup));

#line default
#line hidden
            EndContext();
            BeginContext(1625, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1666, 39, false);
#line 65 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.Itgroup));

#line default
#line hidden
            EndContext();
            BeginContext(1705, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1746, 59, false);
#line 68 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProcessingShippingGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1805, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1846, 55, false);
#line 71 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProcessingShippingGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1901, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1942, 52, false);
#line 74 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QcsupervisorLead));

#line default
#line hidden
            EndContext();
            BeginContext(1994, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2035, 48, false);
#line 77 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.QcsupervisorLead));

#line default
#line hidden
            EndContext();
            BeginContext(2083, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2124, 38, false);
#line 80 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Qc));

#line default
#line hidden
            EndContext();
            BeginContext(2162, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2203, 34, false);
#line 83 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.Qc));

#line default
#line hidden
            EndContext();
            BeginContext(2237, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2278, 46, false);
#line 86 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SalesGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2324, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2365, 42, false);
#line 89 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.SalesGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2407, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2448, 47, false);
#line 92 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StatusGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2495, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2536, 43, false);
#line 95 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.StatusGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2579, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2620, 56, false);
#line 98 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VendorRelationsGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2676, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2717, 52, false);
#line 101 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
       Write(Html.DisplayFor(model => model.VendorRelationsGroup));

#line default
#line hidden
            EndContext();
            BeginContext(2769, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(2811, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27c7cbce6a8b41b1baa9106bea7a9710", async() => {
                BeginContext(2869, 4, true);
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
#line 106 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\VmsRolegroups\Details.cshtml"
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
            BeginContext(2877, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(2884, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a83218fa93d4c22909e42fc01f602a1", async() => {
                BeginContext(2906, 12, true);
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
            BeginContext(2922, 8, true);
            WriteLiteral("\n</div>\n");
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
