#pragma checksum "C:\Users\bitstudent\Documents\EFCoreNewDatabase-Authentication-Authorization\Views\RoleAdmin\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05f1d8ecabe6b93d553089993e8ed8fd4bff8f30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EFCoreNewDatabase.Views.RoleAdmin.Views_RoleAdmin_Edit), @"mvc.1.0.view", @"/Views/RoleAdmin/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RoleAdmin/Edit.cshtml", typeof(EFCoreNewDatabase.Views.RoleAdmin.Views_RoleAdmin_Edit))]
namespace EFCoreNewDatabase.Views.RoleAdmin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\bitstudent\Documents\EFCoreNewDatabase-Authentication-Authorization\Views\RoleAdmin\Edit.cshtml"
using EFCoreNewDatabase.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05f1d8ecabe6b93d553089993e8ed8fd4bff8f30", @"/Views/RoleAdmin/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3950cf549984b9c4e031ae308af9d792868be5af", @"/Views/_ViewImports.cshtml")]
    public class Views_RoleAdmin_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleEditModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\bitstudent\Documents\EFCoreNewDatabase-Authentication-Authorization\Views\RoleAdmin\Edit.cshtml"
  
    Layout = "_AdminLayout";

#line default
#line hidden
            BeginContext(92, 73, true);
            WriteLiteral("\r\n<div class=\"bg-primary m-1 p-1 text-white\"><h4>Edit Role</h4></div>\r\n\r\n");
            EndContext();
            BeginContext(165, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05f1d8ecabe6b93d553089993e8ed8fd4bff8f305489", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 9 "C:\Users\bitstudent\Documents\EFCoreNewDatabase-Authentication-Authorization\Views\RoleAdmin\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(225, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(229, 1570, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05f1d8ecabe6b93d553089993e8ed8fd4bff8f307220", async() => {
                BeginContext(267, 42, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"roleName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 309, "\"", 333, 1);
#line 12 "C:\Users\bitstudent\Documents\EFCoreNewDatabase-Authentication-Authorization\Views\RoleAdmin\Edit.cshtml"
WriteAttributeValue("", 317, Model.Role.Name, 317, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(334, 43, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"roleId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 377, "\"", 399, 1);
#line 13 "C:\Users\bitstudent\Documents\EFCoreNewDatabase-Authentication-Authorization\Views\RoleAdmin\Edit.cshtml"
WriteAttributeValue("", 385, Model.Role.Id, 385, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(400, 56, true);
                WriteLiteral(" />\r\n\r\n    <h6 class=\"bg-success p-1 text-white\">Add To ");
                EndContext();
                BeginContext(457, 15, false);
#line 15 "C:\Users\bitstudent\Documents\EFCoreNewDatabase-Authentication-Authorization\Views\RoleAdmin\Edit.cshtml"
                                            Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(472, 58, true);
                WriteLiteral("</h6>\r\n    <table class=\"table table-bordered table-sm\">\r\n");
                EndContext();
#line 17 "C:\Users\bitstudent\Documents\EFCoreNewDatabase-Authentication-Authorization\Views\RoleAdmin\Edit.cshtml"
         if (Model.NonMembers.Count() == 0)
        {

#line default
#line hidden
                BeginContext(586, 65, true);
                WriteLiteral("            <tr><td colspan=\"2\">All Users Are Members</td></tr>\r\n");
                EndContext();
#line 20 "C:\Users\bitstudent\Documents\EFCoreNewDatabase-Authentication-Authorization\Views\RoleAdmin\Edit.cshtml"
        }
        else
        {
            

#line default
#line hidden
#line 23 "C:\Users\bitstudent\Documents\EFCoreNewDatabase-Authentication-Authorization\Views\RoleAdmin\Edit.cshtml"
             foreach (AppUser user in Model.NonMembers)
            {

#line default
#line hidden
                BeginContext(759, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(806, 13, false);
#line 26 "C:\Users\bitstudent\Documents\EFCoreNewDatabase-Authentication-Authorization\Views\RoleAdmin\Edit.cshtml"
                   Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(819, 95, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        <input type=\"checkbox\" name=\"IdsToAdd\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 914, "\"", 930, 1);
#line 28 "C:\Users\bitstudent\Documents\EFCoreNewDatabase-Authentication-Authorization\Views\RoleAdmin\Edit.cshtml"
WriteAttributeValue("", 922, user.Id, 922, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(931, 55, true);
                WriteLiteral(" />\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 31 "C:\Users\bitstudent\Documents\EFCoreNewDatabase-Authentication-Authorization\Views\RoleAdmin\Edit.cshtml"
            }

#line default
#line hidden
#line 31 "C:\Users\bitstudent\Documents\EFCoreNewDatabase-Authentication-Authorization\Views\RoleAdmin\Edit.cshtml"
             
        }

#line default
#line hidden
                BeginContext(1012, 69, true);
                WriteLiteral("    </table>\r\n\r\n    <h6 class=\"bg-danger p-1 text-white\">Remove From ");
                EndContext();
                BeginContext(1082, 15, false);
#line 35 "C:\Users\bitstudent\Documents\EFCoreNewDatabase-Authentication-Authorization\Views\RoleAdmin\Edit.cshtml"
                                                Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1097, 58, true);
                WriteLiteral("</h6>\r\n    <table class=\"table table-bordered table-sm\">\r\n");
                EndContext();
#line 37 "C:\Users\bitstudent\Documents\EFCoreNewDatabase-Authentication-Authorization\Views\RoleAdmin\Edit.cshtml"
         if (Model.Members.Count() == 0)
        {

#line default
#line hidden
                BeginContext(1208, 64, true);
                WriteLiteral("            <tr><td colspan=\"2\">No Users Are Members</td></tr>\r\n");
                EndContext();
#line 40 "C:\Users\bitstudent\Documents\EFCoreNewDatabase-Authentication-Authorization\Views\RoleAdmin\Edit.cshtml"
        }
        else
        {
            

#line default
#line hidden
#line 43 "C:\Users\bitstudent\Documents\EFCoreNewDatabase-Authentication-Authorization\Views\RoleAdmin\Edit.cshtml"
             foreach (AppUser user in Model.Members)
            {

#line default
#line hidden
                BeginContext(1377, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(1424, 13, false);
#line 46 "C:\Users\bitstudent\Documents\EFCoreNewDatabase-Authentication-Authorization\Views\RoleAdmin\Edit.cshtml"
                   Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(1437, 98, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        <input type=\"checkbox\" name=\"IdsToDelete\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1535, "\"", 1551, 1);
#line 48 "C:\Users\bitstudent\Documents\EFCoreNewDatabase-Authentication-Authorization\Views\RoleAdmin\Edit.cshtml"
WriteAttributeValue("", 1543, user.Id, 1543, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1552, 55, true);
                WriteLiteral(" />\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 51 "C:\Users\bitstudent\Documents\EFCoreNewDatabase-Authentication-Authorization\Views\RoleAdmin\Edit.cshtml"
            }

#line default
#line hidden
#line 51 "C:\Users\bitstudent\Documents\EFCoreNewDatabase-Authentication-Authorization\Views\RoleAdmin\Edit.cshtml"
             
        }

#line default
#line hidden
                BeginContext(1633, 91, true);
                WriteLiteral("    </table>\r\n    <button type=\"submit\" class=\"btn btn-outline-primary\">Save</button>\r\n    ");
                EndContext();
                BeginContext(1724, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05f1d8ecabe6b93d553089993e8ed8fd4bff8f3014543", async() => {
                    BeginContext(1780, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1790, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1799, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleEditModel> Html { get; private set; }
    }
}
#pragma warning restore 1591