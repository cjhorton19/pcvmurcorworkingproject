#pragma checksum "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserRequirements\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "874b8a0a91748d7bf7fe065997cac0979848f062"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserRequirements_Details), @"mvc.1.0.view", @"/Views/UserRequirements/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserRequirements/Details.cshtml", typeof(AspNetCore.Views_UserRequirements_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"874b8a0a91748d7bf7fe065997cac0979848f062", @"/Views/UserRequirements/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"084dcbc8277669b30ae3b518d9adf1b4c390f4a3", @"/Views/_ViewImports.cshtml")]
    public class Views_UserRequirements_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PCVTry.Models.UserRequirements>
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
            BeginContext(38, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserRequirements\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(79, 122, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>UserRequirements</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(202, 44, false);
#line 14 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserRequirements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FloorNum));

#line default
#line hidden
            EndContext();
            BeginContext(246, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(287, 40, false);
#line 17 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserRequirements\Details.cshtml"
       Write(Html.DisplayFor(model => model.FloorNum));

#line default
#line hidden
            EndContext();
            BeginContext(327, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(368, 43, false);
#line 20 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserRequirements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CubeNum));

#line default
#line hidden
            EndContext();
            BeginContext(411, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(452, 39, false);
#line 23 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserRequirements\Details.cshtml"
       Write(Html.DisplayFor(model => model.CubeNum));

#line default
#line hidden
            EndContext();
            BeginContext(491, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(532, 42, false);
#line 26 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserRequirements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DidNum));

#line default
#line hidden
            EndContext();
            BeginContext(574, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(615, 38, false);
#line 29 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserRequirements\Details.cshtml"
       Write(Html.DisplayFor(model => model.DidNum));

#line default
#line hidden
            EndContext();
            BeginContext(653, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(694, 43, false);
#line 32 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserRequirements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DualMon));

#line default
#line hidden
            EndContext();
            BeginContext(737, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(778, 39, false);
#line 35 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserRequirements\Details.cshtml"
       Write(Html.DisplayFor(model => model.DualMon));

#line default
#line hidden
            EndContext();
            BeginContext(817, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(858, 43, false);
#line 38 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserRequirements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RemoAcc));

#line default
#line hidden
            EndContext();
            BeginContext(901, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(942, 39, false);
#line 41 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserRequirements\Details.cshtml"
       Write(Html.DisplayFor(model => model.RemoAcc));

#line default
#line hidden
            EndContext();
            BeginContext(981, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1022, 43, false);
#line 44 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserRequirements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RemoLap));

#line default
#line hidden
            EndContext();
            BeginContext(1065, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1106, 39, false);
#line 47 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserRequirements\Details.cshtml"
       Write(Html.DisplayFor(model => model.RemoLap));

#line default
#line hidden
            EndContext();
            BeginContext(1145, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1186, 42, false);
#line 50 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserRequirements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mobile));

#line default
#line hidden
            EndContext();
            BeginContext(1228, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1269, 38, false);
#line 53 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserRequirements\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mobile));

#line default
#line hidden
            EndContext();
            BeginContext(1307, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1348, 46, false);
#line 56 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserRequirements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1394, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1435, 42, false);
#line 59 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserRequirements\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1477, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1518, 44, false);
#line 62 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserRequirements\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1562, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1603, 40, false);
#line 65 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserRequirements\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1643, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1685, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "241d621453d442d5a45bc08ac9ccdc75", async() => {
                BeginContext(1738, 4, true);
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
#line 70 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserRequirements\Details.cshtml"
                           WriteLiteral(Model.UserReqId);

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
            BeginContext(1746, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1753, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f92e530092a45e38fe4ad195898ee1e", async() => {
                BeginContext(1775, 12, true);
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
            BeginContext(1791, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PCVTry.Models.UserRequirements> Html { get; private set; }
    }
}
#pragma warning restore 1591
