#pragma checksum "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f907a40be7f37c27be2516bedfa1ac1b5b53a59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SupplyDatums_Details), @"mvc.1.0.view", @"/Views/SupplyDatums/Details.cshtml")]
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
#line 1 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\_ViewImports.cshtml"
using RollOff;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\_ViewImports.cshtml"
using RollOff.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f907a40be7f37c27be2516bedfa1ac1b5b53a59", @"/Views/SupplyDatums/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17d139afa42380cc33b840788e00fd62c3f91c10", @"/Views/_ViewImports.cshtml")]
    public class Views_SupplyDatums_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RollOff.Models.SupplyDatum>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Rolls", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" text-decoration:none; color:white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<center><h2>Employee Details</h2></center>\r\n<hr />\r\n\r\n\r\n   \r\n\r\n<div class=\"container\">\r\n    <div class=\"container m-2 d-inline-block\" style=\"width:40%;\">\r\n        <div class=\"font-weight-bold d-inline-block text-black-50 d-inline-block\">\r\n            ");
#nullable restore
#line 16 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : \r\n        </div> \r\n        <div class=\"font-weight-bold d-inline-block\"> \r\n            ");
#nullable restore
#line 19 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"container m-2 d-inline-block\" style=\"width:40%;\">\r\n        <div class=\"font-weight-bold d-inline-block text-black-50 d-inline-block\">");
#nullable restore
#line 23 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                             Write(Html.DisplayNameFor(model => model.GlobalGroupId));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </div> <div class=\"font-weight-bold d-inline-block\"> ");
#nullable restore
#line 23 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                                                                                                                                       Write(Html.DisplayFor(model => model.GlobalGroupId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"container m-2 d-inline-block\" style=\"width:40%;\">\r\n        <div class=\"font-weight-bold d-inline-block text-black-50 d-inline-block\">");
#nullable restore
#line 26 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                             Write(Html.DisplayNameFor(model => model.EmployeeNo));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </div> <div class=\"font-weight-bold d-inline-block\"> ");
#nullable restore
#line 26 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                                                                                                                                    Write(Html.DisplayFor(model => model.EmployeeNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"container m-2 d-inline-block\" style=\"width:40%;\">\r\n        <div class=\"font-weight-bold d-inline-block text-black-50 d-inline-block\">");
#nullable restore
#line 29 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                             Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </div> <div class=\"font-weight-bold d-inline-block\"> ");
#nullable restore
#line 29 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                                                                                                                              Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"container m-2 d-inline-block\" style=\"width:40%;\">\r\n        <div class=\"font-weight-bold d-inline-block text-black-50 d-inline-block\">");
#nullable restore
#line 32 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                             Write(Html.DisplayNameFor(model => model.LocalGrade));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </div> <div class=\"font-weight-bold d-inline-block\"> ");
#nullable restore
#line 32 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                                                                                                                                    Write(Html.DisplayFor(model => model.LocalGrade));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"container m-2 d-inline-block\" style=\"width:40%;\">\r\n        <div class=\"font-weight-bold d-inline-block text-black-50 d-inline-block\">");
#nullable restore
#line 35 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                             Write(Html.DisplayNameFor(model => model.MainClient));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </div> <div class=\"font-weight-bold d-inline-block\"> ");
#nullable restore
#line 35 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                                                                                                                                    Write(Html.DisplayFor(model => model.MainClient));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"container m-2 d-inline-block\" style=\"width:40%;\">\r\n        <div class=\"font-weight-bold d-inline-block text-black-50 d-inline-block\">");
#nullable restore
#line 38 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                             Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </div> <div class=\"font-weight-bold d-inline-block\"> ");
#nullable restore
#line 38 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                                                                                                                               Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"container m-2 d-inline-block\" style=\"width:40%;\">\r\n        <div class=\"font-weight-bold d-inline-block text-black-50 d-inline-block\">");
#nullable restore
#line 41 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                             Write(Html.DisplayNameFor(model => model.JoiningDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </div> <div class=\"font-weight-bold d-inline-block\"> ");
#nullable restore
#line 41 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                                                                                                                                     Write(Html.DisplayFor(model => model.JoiningDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"container m-2 d-inline-block\" style=\"width:40%;\">\r\n        <div class=\"font-weight-bold d-inline-block text-black-50 d-inline-block\">");
#nullable restore
#line 44 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                             Write(Html.DisplayNameFor(model => model.ProjectCode));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </div> <div class=\"font-weight-bold d-inline-block\"> ");
#nullable restore
#line 44 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                                                                                                                                     Write(Html.DisplayFor(model => model.ProjectCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"container m-2 d-inline-block\" style=\"width:40%;\">\r\n        <div class=\"font-weight-bold d-inline-block text-black-50 d-inline-block\">");
#nullable restore
#line 47 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                             Write(Html.DisplayNameFor(model => model.ProjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </div> <div class=\"font-weight-bold d-inline-block\"> ");
#nullable restore
#line 47 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                                                                                                                                     Write(Html.DisplayFor(model => model.ProjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"container m-2 d-inline-block\" style=\"width:40%;\">\r\n        <div class=\"font-weight-bold d-inline-block text-black-50 d-inline-block\">");
#nullable restore
#line 50 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                             Write(Html.DisplayNameFor(model => model.ProjectStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </div> <div class=\"font-weight-bold d-inline-block\"> ");
#nullable restore
#line 50 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                                                                                                                                          Write(Html.DisplayFor(model => model.ProjectStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"container m-2 d-inline-block\" style=\"width:40%;\">\r\n        <div class=\"font-weight-bold d-inline-block text-black-50 d-inline-block\">");
#nullable restore
#line 53 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                             Write(Html.DisplayNameFor(model => model.ProjectEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </div> <div class=\"font-weight-bold d-inline-block\"> ");
#nullable restore
#line 53 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                                                                                                                                        Write(Html.DisplayFor(model => model.ProjectEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"container m-2 d-inline-block\" style=\"width:40%;\">\r\n        <div class=\"font-weight-bold d-inline-block text-black-50 d-inline-block\">");
#nullable restore
#line 56 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                             Write(Html.DisplayNameFor(model => model.PeopleManagerPerformanceReviewer));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </div> <div class=\"font-weight-bold d-inline-block\"> ");
#nullable restore
#line 56 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                                                                                                                                                          Write(Html.DisplayFor(model => model.PeopleManagerPerformanceReviewer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"container m-2 d-inline-block\" style=\"width:40%;\">\r\n        <div class=\"font-weight-bold d-inline-block text-black-50 d-inline-block\">");
#nullable restore
#line 59 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                             Write(Html.DisplayNameFor(model => model.Practice));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </div> <div class=\"font-weight-bold d-inline-block\"> ");
#nullable restore
#line 59 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                                                                                                                                  Write(Html.DisplayFor(model => model.Practice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"container m-2 d-inline-block\" style=\"width:40%;\">\r\n        <div class=\"font-weight-bold d-inline-block text-black-50 d-inline-block\">");
#nullable restore
#line 62 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                             Write(Html.DisplayNameFor(model => model.PspName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </div> <div class=\"font-weight-bold d-inline-block\"> ");
#nullable restore
#line 62 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                                                                                                                                 Write(Html.DisplayFor(model => model.PspName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"container m-2 d-inline-block\" style=\"width:40%;\">\r\n        <div class=\"font-weight-bold d-inline-block text-black-50 d-inline-block\">");
#nullable restore
#line 65 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                             Write(Html.DisplayNameFor(model => model.NewGlobalPractice));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </div> <div class=\"font-weight-bold d-inline-block\"> ");
#nullable restore
#line 65 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                                                                                                                                           Write(Html.DisplayFor(model => model.NewGlobalPractice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"container m-2 d-inline-block\" style=\"width:40%;\">\r\n        <div class=\"font-weight-bold d-inline-block text-black-50 d-inline-block\">");
#nullable restore
#line 68 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                             Write(Html.DisplayNameFor(model => model.OfficeCity));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : </div> <div class=\"font-weight-bold d-inline-block\"> ");
#nullable restore
#line 68 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                                                                                                                                                    Write(Html.DisplayFor(model => model.OfficeCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"d-flex justify-content-around align-items-center\">\r\n        <button class=\"btn btn-info\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f907a40be7f37c27be2516bedfa1ac1b5b53a5921774", async() => {
                WriteLiteral("Roll Off");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\AMRUTAMK\Documents\Project\RollOff\RollOff\Views\SupplyDatums\Details.cshtml"
                                                          WriteLiteral(Model.EmployeeNo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </button>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f907a40be7f37c27be2516bedfa1ac1b5b53a5924288", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RollOff.Models.SupplyDatum> Html { get; private set; }
    }
}
#pragma warning restore 1591
