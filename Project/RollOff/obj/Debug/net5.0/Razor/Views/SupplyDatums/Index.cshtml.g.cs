#pragma checksum "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e6efc2aab42d1f57e6bcc63c34eeb97fd24e5aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SupplyDatums_Index), @"mvc.1.0.view", @"/Views/SupplyDatums/Index.cshtml")]
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
#line 1 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\_ViewImports.cshtml"
using RollOff;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\_ViewImports.cshtml"
using RollOff.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e6efc2aab42d1f57e6bcc63c34eeb97fd24e5aa", @"/Views/SupplyDatums/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17d139afa42380cc33b840788e00fd62c3f91c10", @"/Views/_ViewImports.cshtml")]
    public class Views_SupplyDatums_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RollOff.Models.SupplyDatum>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Rolls", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e6efc2aab42d1f57e6bcc63c34eeb97fd24e5aa4894", async() => {
                WriteLiteral("\r\n    <p>\r\n        <input type=\"search\" placeholder=\"Enter Global group Id or Employee Name or Email\"");
                BeginWriteAttribute("value", " value=\"", 320, "\"", 351, 1);
#nullable restore
#line 14 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
WriteAttributeValue("", 328, ViewData["GetDetails"], 328, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n               name=\"EmpSearch\" style=\"width:500px;\" />\r\n        <input type=\"submit\" value=\"Search\" class=\"btn btn-primary\" />\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e6efc2aab42d1f57e6bcc63c34eeb97fd24e5aa5805", async() => {
                    WriteLiteral("Back to list");
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
                WriteLiteral("\r\n    </p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""container ml-0 p-0 d-inline-block"" style=""width:60vw; height:60vh; overflow:scroll;"">
    
        <table class=""table-sm"" >
            <thead class=""sticky-top bg-dark text-light "">
                <tr>
                    <th>
                        ");
#nullable restore
#line 26 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 29 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.GlobalGroupId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 32 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.EmployeeNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 35 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 38 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.LocalGrade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 41 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.MainClient));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 44 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 47 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.JoiningDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 50 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProjectCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 53 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 56 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProjectStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 59 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProjectEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 62 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.PeopleManagerPerformanceReviewer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 65 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Practice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 68 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.PspName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 71 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.NewGlobalPractice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 74 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.OfficeCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 80 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 84 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 87 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.GlobalGroupId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 90 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.EmployeeNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 93 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 96 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LocalGrade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 99 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.MainClient));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 102 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 105 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.JoiningDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 108 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ProjectCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 111 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ProjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 114 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ProjectStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 117 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ProjectEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 120 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PeopleManagerPerformanceReviewer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 123 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Practice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 126 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PspName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 129 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.NewGlobalPractice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 132 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.OfficeCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e6efc2aab42d1f57e6bcc63c34eeb97fd24e5aa21724", async() => {
                WriteLiteral("RollOff");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 138 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                                                                            WriteLiteral(item.GlobalGroupId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 141 "C:\Users\AMRUTAMK\Documents\ASP.NET Core\RollOff\RollOff\Views\SupplyDatums\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n \r\n    </div>\r\n");
            WriteLiteral("   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RollOff.Models.SupplyDatum>> Html { get; private set; }
    }
}
#pragma warning restore 1591
