#pragma checksum "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3bf61bd51b88c08c7e949f4c96d4e833f780842"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BpoRolegroups_Index), @"mvc.1.0.view", @"/Views/BpoRolegroups/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BpoRolegroups/Index.cshtml", typeof(AspNetCore.Views_BpoRolegroups_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3bf61bd51b88c08c7e949f4c96d4e833f780842", @"/Views/BpoRolegroups/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"084dcbc8277669b30ae3b518d9adf1b4c390f4a3", @"/Views/_ViewImports.cshtml")]
    public class Views_BpoRolegroups_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PCVTry.Models.BpoRolegroup>>
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
            BeginContext(47, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(86, 25, true);
            WriteLiteral("\n<h2>Index</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(111, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9006562efa140e89f07931f942a9b78", async() => {
                BeginContext(134, 10, true);
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
            BeginContext(148, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(235, 44, false);
#line 16 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bpoadmin));

#line default
#line hidden
            EndContext();
            BeginContext(279, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(332, 46, false);
#line 19 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ContractQc));

#line default
#line hidden
            EndContext();
            BeginContext(378, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(431, 42, false);
#line 22 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FdicQc));

#line default
#line hidden
            EndContext();
            BeginContext(473, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(526, 46, false);
#line 25 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HoldOrders));

#line default
#line hidden
            EndContext();
            BeginContext(572, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(625, 53, false);
#line 28 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MarkOrdersShipped));

#line default
#line hidden
            EndContext();
            BeginContext(678, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(731, 43, false);
#line 31 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QcBasic));

#line default
#line hidden
            EndContext();
            BeginContext(774, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(827, 42, false);
#line 34 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QcPlus));

#line default
#line hidden
            EndContext();
            BeginContext(869, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(922, 48, false);
#line 37 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QcSupervisor));

#line default
#line hidden
            EndContext();
            BeginContext(970, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1023, 45, false);
#line 40 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ViewRules));

#line default
#line hidden
            EndContext();
            BeginContext(1068, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 46 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1179, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(1226, 43, false);
#line 49 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bpoadmin));

#line default
#line hidden
            EndContext();
            BeginContext(1269, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1322, 45, false);
#line 52 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ContractQc));

#line default
#line hidden
            EndContext();
            BeginContext(1367, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1420, 41, false);
#line 55 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FdicQc));

#line default
#line hidden
            EndContext();
            BeginContext(1461, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1514, 45, false);
#line 58 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HoldOrders));

#line default
#line hidden
            EndContext();
            BeginContext(1559, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1612, 52, false);
#line 61 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MarkOrdersShipped));

#line default
#line hidden
            EndContext();
            BeginContext(1664, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1717, 42, false);
#line 64 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QcBasic));

#line default
#line hidden
            EndContext();
            BeginContext(1759, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1812, 41, false);
#line 67 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QcPlus));

#line default
#line hidden
            EndContext();
            BeginContext(1853, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1906, 47, false);
#line 70 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QcSupervisor));

#line default
#line hidden
            EndContext();
            BeginContext(1953, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2006, 44, false);
#line 73 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ViewRules));

#line default
#line hidden
            EndContext();
            BeginContext(2050, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2102, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0c19d70c681a4b09bf3bc757b0d18c5a", async() => {
                BeginContext(2150, 4, true);
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
#line 76 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
                                       WriteLiteral(item.Bpoid);

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
            BeginContext(2158, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(2177, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a28a34093fa248cdb545f949a5fc8a08", async() => {
                BeginContext(2228, 7, true);
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
#line 77 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
                                          WriteLiteral(item.Bpoid);

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
            BeginContext(2239, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(2258, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c734eec323b3482785dc4a882ce5534f", async() => {
                BeginContext(2308, 6, true);
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
#line 78 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
                                         WriteLiteral(item.Bpoid);

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
            BeginContext(2318, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 81 "C:\Users\curti\Desktop\Dev\messageboard\frontend\pcvmurcorworkingproject\PCVTry\Views\BpoRolegroups\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2353, 22, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PCVTry.Models.BpoRolegroup>> Html { get; private set; }
    }
}
#pragma warning restore 1591
