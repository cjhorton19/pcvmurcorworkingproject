#pragma checksum "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9bcbc8cabccd15793e0a396ceb017348a953897"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OtsAccesses_Index), @"mvc.1.0.view", @"/Views/OtsAccesses/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OtsAccesses/Index.cshtml", typeof(AspNetCore.Views_OtsAccesses_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9bcbc8cabccd15793e0a396ceb017348a953897", @"/Views/OtsAccesses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"084dcbc8277669b30ae3b518d9adf1b4c390f4a3", @"/Views/_ViewImports.cshtml")]
    public class Views_OtsAccesses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PCVTry.Models.OtsAccess>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(83, 25, true);
            WriteLiteral("\n<h2>Index</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(108, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2c75754bc5244c78de4da159d1077da", async() => {
                BeginContext(131, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(145, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(232, 42, false);
#line 16 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Return));

#line default
#line hidden
            EndContext();
            BeginContext(274, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(327, 47, false);
#line 19 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MultiAssign));

#line default
#line hidden
            EndContext();
            BeginContext(374, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(427, 47, false);
#line 22 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeleteOrder));

#line default
#line hidden
            EndContext();
            BeginContext(474, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(527, 46, false);
#line 25 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ToReassign));

#line default
#line hidden
            EndContext();
            BeginContext(573, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(626, 49, false);
#line 28 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RecreateOrder));

#line default
#line hidden
            EndContext();
            BeginContext(675, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(728, 52, false);
#line 31 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AppraisalTagShip));

#line default
#line hidden
            EndContext();
            BeginContext(780, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(833, 54, false);
#line 34 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaintainTagReasons));

#line default
#line hidden
            EndContext();
            BeginContext(887, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(940, 56, false);
#line 37 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaintainClariReasons));

#line default
#line hidden
            EndContext();
            BeginContext(996, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1049, 46, false);
#line 40 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AuditAdmin));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1148, 54, false);
#line 43 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DisputeQueueAccess));

#line default
#line hidden
            EndContext();
            BeginContext(1202, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 49 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1313, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(1360, 41, false);
#line 52 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Return));

#line default
#line hidden
            EndContext();
            BeginContext(1401, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1454, 46, false);
#line 55 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MultiAssign));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1553, 46, false);
#line 58 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DeleteOrder));

#line default
#line hidden
            EndContext();
            BeginContext(1599, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1652, 45, false);
#line 61 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ToReassign));

#line default
#line hidden
            EndContext();
            BeginContext(1697, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1750, 48, false);
#line 64 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RecreateOrder));

#line default
#line hidden
            EndContext();
            BeginContext(1798, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1851, 51, false);
#line 67 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AppraisalTagShip));

#line default
#line hidden
            EndContext();
            BeginContext(1902, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1955, 53, false);
#line 70 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaintainTagReasons));

#line default
#line hidden
            EndContext();
            BeginContext(2008, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2061, 55, false);
#line 73 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaintainClariReasons));

#line default
#line hidden
            EndContext();
            BeginContext(2116, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2169, 45, false);
#line 76 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AuditAdmin));

#line default
#line hidden
            EndContext();
            BeginContext(2214, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2267, 53, false);
#line 79 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DisputeQueueAccess));

#line default
#line hidden
            EndContext();
            BeginContext(2320, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2372, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7752abc7f6e74acb88e368dbfaed0d19", async() => {
                BeginContext(2426, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
                                       WriteLiteral(item.OtsAccessId);

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
            BeginContext(2434, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(2453, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00485fe7511c4cad885d66683cf370db", async() => {
                BeginContext(2510, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
                                          WriteLiteral(item.OtsAccessId);

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
            BeginContext(2521, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(2540, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a351c26f75624bc08da44d1b83a74ab2", async() => {
                BeginContext(2596, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
                                         WriteLiteral(item.OtsAccessId);

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
            BeginContext(2606, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 87 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\OtsAccesses\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2641, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PCVTry.Models.OtsAccess>> Html { get; private set; }
    }
}
#pragma warning restore 1591
