#pragma checksum "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserTables\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "971c0af31ab58a35dd0a22cc4a8150074fae849b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserTables_Details), @"mvc.1.0.view", @"/Views/UserTables/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserTables/Details.cshtml", typeof(AspNetCore.Views_UserTables_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"971c0af31ab58a35dd0a22cc4a8150074fae849b", @"/Views/UserTables/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"084dcbc8277669b30ae3b518d9adf1b4c390f4a3", @"/Views/_ViewImports.cshtml")]
    public class Views_UserTables_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PCVTry.Models.UserTable>
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
            BeginContext(31, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserTables\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(72, 115, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>UserTable</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(188, 44, false);
#line 14 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserTables\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(232, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(273, 40, false);
#line 17 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserTables\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(313, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(354, 45, false);
#line 20 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserTables\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(399, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(440, 41, false);
#line 23 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserTables\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(481, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(522, 46, false);
#line 26 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserTables\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
            EndContext();
            BeginContext(568, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(609, 42, false);
#line 29 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserTables\Details.cshtml"
       Write(Html.DisplayFor(model => model.Department));

#line default
#line hidden
            EndContext();
            BeginContext(651, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(692, 42, false);
#line 32 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserTables\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Office));

#line default
#line hidden
            EndContext();
            BeginContext(734, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(775, 38, false);
#line 35 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserTables\Details.cshtml"
       Write(Html.DisplayFor(model => model.Office));

#line default
#line hidden
            EndContext();
            BeginContext(813, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(854, 47, false);
#line 38 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserTables\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ManagerName));

#line default
#line hidden
            EndContext();
            BeginContext(901, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(942, 43, false);
#line 41 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserTables\Details.cshtml"
       Write(Html.DisplayFor(model => model.ManagerName));

#line default
#line hidden
            EndContext();
            BeginContext(985, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1026, 45, false);
#line 44 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserTables\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsManager));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1112, 41, false);
#line 47 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserTables\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsManager));

#line default
#line hidden
            EndContext();
            BeginContext(1153, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1194, 45, false);
#line 50 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserTables\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateStart));

#line default
#line hidden
            EndContext();
            BeginContext(1239, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1280, 41, false);
#line 53 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserTables\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateStart));

#line default
#line hidden
            EndContext();
            BeginContext(1321, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1362, 43, false);
#line 56 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserTables\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateEnd));

#line default
#line hidden
            EndContext();
            BeginContext(1405, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1446, 39, false);
#line 59 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserTables\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateEnd));

#line default
#line hidden
            EndContext();
            BeginContext(1485, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1527, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9deeb1920914113aa8e554cc17d9f59", async() => {
                BeginContext(1577, 4, true);
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
#line 64 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\UserTables\Details.cshtml"
                           WriteLiteral(Model.UserId);

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
            BeginContext(1585, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1592, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd23b05af8224532ae894bb2d618b760", async() => {
                BeginContext(1614, 12, true);
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
            BeginContext(1630, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PCVTry.Models.UserTable> Html { get; private set; }
    }
}
#pragma warning restore 1591
