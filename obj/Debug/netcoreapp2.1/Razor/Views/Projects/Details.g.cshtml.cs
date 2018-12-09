#pragma checksum "C:\Users\charl\Documents\BuffteksWebsite\Views\Projects\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0241c2b5c36789641946fd3d828f00692fa643cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Details), @"mvc.1.0.view", @"/Views/Projects/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Projects/Details.cshtml", typeof(AspNetCore.Views_Projects_Details))]
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
#line 1 "C:\Users\charl\Documents\BuffteksWebsite\Views\_ViewImports.cshtml"
using BuffteksWebsite;

#line default
#line hidden
#line 2 "C:\Users\charl\Documents\BuffteksWebsite\Views\_ViewImports.cshtml"
using BuffteksWebsite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0241c2b5c36789641946fd3d828f00692fa643cf", @"/Views/Projects/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa45fcdfe59cbc6eb4c5ec57a208b4bd7d61e026", @"/Views/_ViewImports.cshtml")]
    public class Views_Projects_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BuffteksWebsite.Models.ProjectDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteProjectParticipant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\charl\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(94, 122, true);
            WriteLiteral("<br>\n<h3>Details</h3>\n<br>\n<div>\n    <h4>Project:</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(217, 58, false);
#line 14 "C:\Users\charl\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TheProject.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(275, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(316, 54, false);
#line 17 "C:\Users\charl\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.TheProject.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(370, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(411, 65, false);
#line 20 "C:\Users\charl\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TheProject.ProjectDescription));

#line default
#line hidden
            EndContext();
            BeginContext(476, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(517, 61, false);
#line 23 "C:\Users\charl\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
       Write(Html.DisplayFor(model => model.TheProject.ProjectDescription));

#line default
#line hidden
            EndContext();
            BeginContext(578, 409, true);
            WriteLiteral(@"
        </dd>
    </dl>
</div>
<div>
    <h4>
        Participants - Client
    </h4>
    <hr />    
    <table class=""table"">
        <thead>
            <tr>
                    <th>
                        First Name
                    </th>
                    <th>
                        Last Name
                    </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 45 "C:\Users\charl\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
     foreach (var client in Model.ProjectClients) {

#line default
#line hidden
            BeginContext(1039, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(1098, 38, false);
#line 48 "C:\Users\charl\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
               Write(Html.DisplayFor(c => client.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1136, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1201, 37, false);
#line 51 "C:\Users\charl\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
               Write(Html.DisplayFor(c => client.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1302, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a01ee806d434f2db4188a7bdabc49c6", async() => {
                BeginContext(1406, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "C:\Users\charl\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
                                                                WriteLiteral(Model.TheProject.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 54 "C:\Users\charl\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
                                                                                                    WriteLiteral(client.ID);

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
            BeginContext(1416, 181, true);
            WriteLiteral("\n                    <!--<span class=\"text-danger\">TODO: We need to cascade delete members if a project is deleted</span>-->\n                </td>                \n            </tr>\n");
            EndContext();
#line 58 "C:\Users\charl\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1603, 418, true);
            WriteLiteral(@"        </tbody>
    </table>    
</div>
<div>
    <h4>
        Participants - Member
    </h4>
    <hr />    
    <table class=""table"">
        <thead>
            <tr>
                    <th>
                        First Name
                    </th>
                    <th>
                        Last Name
                    </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 80 "C:\Users\charl\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
     foreach (var member in Model.ProjectMembers) {

#line default
#line hidden
            BeginContext(2073, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(2132, 38, false);
#line 83 "C:\Users\charl\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
               Write(Html.DisplayFor(m => member.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(2170, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2235, 37, false);
#line 86 "C:\Users\charl\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
               Write(Html.DisplayFor(m => member.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(2272, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2336, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cae5d505e02b49aab8339fd1a3ac12c0", async() => {
                BeginContext(2440, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 89 "C:\Users\charl\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
                                                                WriteLiteral(Model.TheProject.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 89 "C:\Users\charl\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
                                                                                                    WriteLiteral(member.ID);

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
            BeginContext(2450, 165, true);
            WriteLiteral("\n                    <!--<span class=\"text-danger\">TODO: We need to cascade delete members if a project is deleted</span>-->\n                </td>\n            </tr>\n");
            EndContext();
#line 93 "C:\Users\charl\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(2621, 52, true);
            WriteLiteral("\n        </tbody>\n    </table>    \n</div>\n<div>\n    ");
            EndContext();
            BeginContext(2673, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eae8b88278b647809b63f6b11fe8553d", async() => {
                BeginContext(2730, 4, true);
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
#line 99 "C:\Users\charl\Documents\BuffteksWebsite\Views\Projects\Details.cshtml"
                           WriteLiteral(Model.TheProject.ID);

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
            BeginContext(2738, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(2745, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25a0a7420e0b4fed9dec3582de910ef5", async() => {
                BeginContext(2767, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2783, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BuffteksWebsite.Models.ProjectDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
