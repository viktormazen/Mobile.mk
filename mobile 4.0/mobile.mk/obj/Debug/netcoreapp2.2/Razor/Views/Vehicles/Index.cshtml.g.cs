#pragma checksum "C:\Users\Mazen\Desktop\mobile\mobile 4.0\mobile.mk\Views\Vehicles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73c027ab91807bc6717887ba9c85090b177c5cc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicles_Index), @"mvc.1.0.view", @"/Views/Vehicles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vehicles/Index.cshtml", typeof(AspNetCore.Views_Vehicles_Index))]
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
#line 1 "C:\Users\Mazen\Desktop\mobile\mobile 4.0\mobile.mk\Views\_ViewImports.cshtml"
using mobile.mk;

#line default
#line hidden
#line 2 "C:\Users\Mazen\Desktop\mobile\mobile 4.0\mobile.mk\Views\_ViewImports.cshtml"
using mobile.mk.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73c027ab91807bc6717887ba9c85090b177c5cc6", @"/Views/Vehicles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62481d1cd29f2d062415c40e6ed7dbd2a48329fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<mobile.WebModels.VehicleViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Vehicles"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-link btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-link btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mazen\Desktop\mobile\mobile 4.0\mobile.mk\Views\Vehicles\Index.cshtml"
   
    if (ViewBag.RenderActions == null)
    {
        ViewBag.RenderActions = false;
    }

    bool test = User.IsInRole("customer");
    bool test2 = User.Identity.IsAuthenticated;

#line default
#line hidden
            BeginContext(254, 251, true);
            WriteLiteral("\r\n<br />\r\n    <div class=\"container jumbotron\">\r\n        <div class=\"row p-2\">\r\n            <div class=\"col-4\">\r\n                <h1>Shop new & used cars, compare models, sell your car & more at mobile.mk</h1>\r\n                <br />\r\n                ");
            EndContext();
            BeginContext(505, 843, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73c027ab91807bc6717887ba9c85090b177c5cc66469", async() => {
                BeginContext(543, 798, true);
                WriteLiteral(@"

                    <br />
                    <div class=""form-check-inline"">
                        <h4>Make</h4>   <input class=""form-control-sm p-1"" id=""searchBy"" name=""searchBy"" type=""radio"" value=""Make"" checked=""checked"">
                    </div>
                    <div class=""form-check-inline"">
                        <h4>Model</h4>   <input class=""form-control-sm p-1"" id=""searchBy"" name=""searchBy"" type=""radio"" value=""Model"">
                    </div>
                    
                    <input class=""form-control"" id=""search"" name=""search"" type=""text"" value="""" placeholder=""Please Insert Car Make or Model"">
                    <br />
                    <button type=""submit"" value=""Search"" class=""btn btn-warning""><h5>Search</h5></button>

                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1348, 340, true);
            WriteLiteral(@"
            </div>
            <div class=""col-5"">
                <img src=""https://image.cnbcfm.com/api/v1/image/105451982-1536942698662gettyimages-503375934.jpeg?v=1563289233&w=678&h=381"" alt=""cars"" />
            </div>
        </div>
    </div>


    <br />



    <div class=""container p-4"">
        <div class=""row"">
");
            EndContext();
#line 48 "C:\Users\Mazen\Desktop\mobile\mobile 4.0\mobile.mk\Views\Vehicles\Index.cshtml"
             foreach (var item in Model)
            {
                //string imgBase64 = Convert.ToBase64String(item.Images.ToList()[0].ImageBytes);
                //string imgSrc = $"data:image/jpeg;base64,{imgBase64}";
                //string imgSrc = $"data:image/jpeg;base64,{item.Images.ToList()[0].ImageString}";
                var images = item.Images.ToList();
                string firstImage;
                if (images.FirstOrDefault() == null)
                {
                    firstImage = "";
                }
                else
                {
                    firstImage = images.FirstOrDefault().Image;
                }
                string imgSrc = $"data:image/jpeg;base64, {firstImage}";


#line default
#line hidden
            BeginContext(2436, 70, true);
            WriteLiteral("                <div class=\"card col-4 p-2\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2506, "\"", 2519, 1);
#line 66 "C:\Users\Mazen\Desktop\mobile\mobile 4.0\mobile.mk\Views\Vehicles\Index.cshtml"
WriteAttributeValue("", 2512, imgSrc, 2512, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2520, 30, true);
            WriteLiteral(" width=\"345\" height=\"250\" />\r\n");
            EndContext();
            BeginContext(2800, 95, true);
            WriteLiteral("                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\"><b>");
            EndContext();
            BeginContext(2896, 9, false);
#line 70 "C:\Users\Mazen\Desktop\mobile\mobile 4.0\mobile.mk\Views\Vehicles\Index.cshtml"
                                             Write(item.Make);

#line default
#line hidden
            EndContext();
            BeginContext(2905, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2907, 10, false);
#line 70 "C:\Users\Mazen\Desktop\mobile\mobile 4.0\mobile.mk\Views\Vehicles\Index.cshtml"
                                                        Write(item.Model);

#line default
#line hidden
            EndContext();
            BeginContext(2917, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2919, 9, false);
#line 70 "C:\Users\Mazen\Desktop\mobile\mobile 4.0\mobile.mk\Views\Vehicles\Index.cshtml"
                                                                    Write(item.Year);

#line default
#line hidden
            EndContext();
            BeginContext(2928, 160, true);
            WriteLiteral("</b></h5>\r\n                    </div>\r\n                    <ul class=\"list-group\">\r\n\r\n\r\n\r\n                        <li class=\"list-group-item\"><b>Fuel Type: </b>");
            EndContext();
            BeginContext(3089, 13, false);
#line 76 "C:\Users\Mazen\Desktop\mobile\mobile 4.0\mobile.mk\Views\Vehicles\Index.cshtml"
                                                                 Write(item.Fueltype);

#line default
#line hidden
            EndContext();
            BeginContext(3102, 82, true);
            WriteLiteral("</li>\r\n                        <li class=\"list-group-item\"><b>Cubic Capacity: </b>");
            EndContext();
            BeginContext(3185, 18, false);
#line 77 "C:\Users\Mazen\Desktop\mobile\mobile 4.0\mobile.mk\Views\Vehicles\Index.cshtml"
                                                                      Write(item.CubicCapacity);

#line default
#line hidden
            EndContext();
            BeginContext(3203, 73, true);
            WriteLiteral("</li>\r\n                        <li class=\"list-group-item\"><b>Power: </b>");
            EndContext();
            BeginContext(3277, 10, false);
#line 78 "C:\Users\Mazen\Desktop\mobile\mobile 4.0\mobile.mk\Views\Vehicles\Index.cshtml"
                                                             Write(item.Power);

#line default
#line hidden
            EndContext();
            BeginContext(3287, 76, true);
            WriteLiteral("</li>\r\n                        <li class=\"list-group-item\"><b>Location: </b>");
            EndContext();
            BeginContext(3364, 13, false);
#line 79 "C:\Users\Mazen\Desktop\mobile\mobile 4.0\mobile.mk\Views\Vehicles\Index.cshtml"
                                                                Write(item.Location);

#line default
#line hidden
            EndContext();
            BeginContext(3377, 82, true);
            WriteLiteral("</li>\r\n                        <li class=\"list-group-item\"><b>Description: </b><i>");
            EndContext();
            BeginContext(3460, 23, false);
#line 80 "C:\Users\Mazen\Desktop\mobile\mobile 4.0\mobile.mk\Views\Vehicles\Index.cshtml"
                                                                      Write(item.VehicleDescription);

#line default
#line hidden
            EndContext();
            BeginContext(3483, 78, true);
            WriteLiteral("</i></li>\r\n                        <li class=\"list-group-item \"><h5><b>Price: ");
            EndContext();
            BeginContext(3562, 10, false);
#line 81 "C:\Users\Mazen\Desktop\mobile\mobile 4.0\mobile.mk\Views\Vehicles\Index.cshtml"
                                                              Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(3572, 94, true);
            WriteLiteral(" Eur</b></h5></li>\r\n                    </ul>\r\n\r\n                    <div class=\"card-body\">\r\n");
            EndContext();
#line 85 "C:\Users\Mazen\Desktop\mobile\mobile 4.0\mobile.mk\Views\Vehicles\Index.cshtml"
                         if (ViewBag.RenderActions && User.Identity.IsAuthenticated && User.IsInRole("customer"))
                        {

#line default
#line hidden
            BeginContext(3808, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(3836, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73c027ab91807bc6717887ba9c85090b177c5cc615553", async() => {
                BeginContext(3915, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 87 "C:\Users\Mazen\Desktop\mobile\mobile 4.0\mobile.mk\Views\Vehicles\Index.cshtml"
                                                                                     WriteLiteral(item.Id);

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
            BeginContext(3923, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3953, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73c027ab91807bc6717887ba9c85090b177c5cc618037", async() => {
                BeginContext(4034, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 88 "C:\Users\Mazen\Desktop\mobile\mobile 4.0\mobile.mk\Views\Vehicles\Index.cshtml"
                                                                                       WriteLiteral(item.Id);

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
            BeginContext(4044, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 89 "C:\Users\Mazen\Desktop\mobile\mobile 4.0\mobile.mk\Views\Vehicles\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4073, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(4097, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73c027ab91807bc6717887ba9c85090b177c5cc620770", async() => {
                BeginContext(4179, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 90 "C:\Users\Mazen\Desktop\mobile\mobile 4.0\mobile.mk\Views\Vehicles\Index.cshtml"
                                                                                    WriteLiteral(item.Id);

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
            BeginContext(4190, 54, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 93 "C:\Users\Mazen\Desktop\mobile\mobile 4.0\mobile.mk\Views\Vehicles\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(4259, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<mobile.WebModels.VehicleViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591