#pragma checksum "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b73ecec9f3d68d052e00979ba565ca32b76c3ec5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicles_Delete), @"mvc.1.0.view", @"/Views/Vehicles/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vehicles/Delete.cshtml", typeof(AspNetCore.Views_Vehicles_Delete))]
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
#line 1 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\_ViewImports.cshtml"
using mobile.mk;

#line default
#line hidden
#line 2 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\_ViewImports.cshtml"
using mobile.mk.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b73ecec9f3d68d052e00979ba565ca32b76c3ec5", @"/Views/Vehicles/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62481d1cd29f2d062415c40e6ed7dbd2a48329fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicles_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<mobile.WebModels.VehicleViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(86, 252, true);
            WriteLiteral("\r\n    <div class=\"container jumbotron\">\r\n\r\n        <h1>Delete</h1>\r\n        <h4>Are you sure you want to delete this vehicle?</h4>\r\n        <hr />\r\n        <div>\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(339, 41, false);
#line 15 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
            EndContext();
            BeginContext(380, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(466, 36, false);
#line 18 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Make));

#line default
#line hidden
            EndContext();
            BeginContext(502, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(587, 41, false);
#line 21 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
            EndContext();
            BeginContext(628, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(714, 37, false);
#line 24 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Model));

#line default
#line hidden
            EndContext();
            BeginContext(751, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(836, 44, false);
#line 27 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(880, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(966, 40, false);
#line 30 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1006, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(1091, 40, false);
#line 33 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(1131, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1217, 36, false);
#line 36 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(1253, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(1338, 44, false);
#line 39 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Fueltype));

#line default
#line hidden
            EndContext();
            BeginContext(1382, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1468, 40, false);
#line 42 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Fueltype));

#line default
#line hidden
            EndContext();
            BeginContext(1508, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(1593, 49, false);
#line 45 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.CubicCapacity));

#line default
#line hidden
            EndContext();
            BeginContext(1642, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1728, 45, false);
#line 48 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayFor(model => model.CubicCapacity));

#line default
#line hidden
            EndContext();
            BeginContext(1773, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(1858, 41, false);
#line 51 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Power));

#line default
#line hidden
            EndContext();
            BeginContext(1899, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1985, 37, false);
#line 54 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Power));

#line default
#line hidden
            EndContext();
            BeginContext(2022, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(2107, 43, false);
#line 57 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.GearBox));

#line default
#line hidden
            EndContext();
            BeginContext(2150, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(2236, 39, false);
#line 60 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayFor(model => model.GearBox));

#line default
#line hidden
            EndContext();
            BeginContext(2275, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(2360, 43, false);
#line 63 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Mileage));

#line default
#line hidden
            EndContext();
            BeginContext(2403, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(2489, 39, false);
#line 66 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Mileage));

#line default
#line hidden
            EndContext();
            BeginContext(2528, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(2613, 41, false);
#line 69 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2654, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(2740, 37, false);
#line 72 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2777, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(2862, 44, false);
#line 75 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(2906, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(2992, 40, false);
#line 78 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(3032, 84, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
            EndContext();
            BeginContext(3117, 54, false);
#line 81 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.VehicleDescription));

#line default
#line hidden
            EndContext();
            BeginContext(3171, 85, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(3257, 50, false);
#line 84 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
               Write(Html.DisplayFor(model => model.VehicleDescription));

#line default
#line hidden
            EndContext();
            BeginContext(3307, 58, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n\r\n            ");
            EndContext();
            BeginContext(3365, 237, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b73ecec9f3d68d052e00979ba565ca32b76c3ec515627", async() => {
                BeginContext(3390, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(3408, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b73ecec9f3d68d052e00979ba565ca32b76c3ec516028", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 89 "C:\Users\Mazen\Desktop\mobile\mobile 4.1\mobile.mk\Views\Vehicles\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3444, 99, true);
                WriteLiteral("\r\n                <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n                ");
                EndContext();
                BeginContext(3543, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b73ecec9f3d68d052e00979ba565ca32b76c3ec517950", async() => {
                    BeginContext(3565, 12, true);
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
                BeginContext(3581, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3602, 32, true);
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mobile.WebModels.VehicleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
