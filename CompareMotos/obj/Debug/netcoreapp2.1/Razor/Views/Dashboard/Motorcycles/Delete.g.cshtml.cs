#pragma checksum "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bd33c8f1697a5d94f13a920fc76eb18a8e6df0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Motorcycles_Delete), @"mvc.1.0.view", @"/Views/Dashboard/Motorcycles/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Motorcycles/Delete.cshtml", typeof(AspNetCore.Views_Dashboard_Motorcycles_Delete))]
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
#line 1 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\_ViewImports.cshtml"
using CompareMotos;

#line default
#line hidden
#line 2 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\_ViewImports.cshtml"
using CompareMotos.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bd33c8f1697a5d94f13a920fc76eb18a8e6df0b", @"/Views/Dashboard/Motorcycles/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ed1d728ea8edecd6458d1c4c9371f8fc1462d5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Motorcycles_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompareMotos.Models.Motorcycle>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(83, 171, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Motorcycle</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(255, 40, false);
#line 15 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(295, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(339, 36, false);
#line 18 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(375, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(419, 41, false);
#line 21 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(460, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(504, 37, false);
#line 24 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(541, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(585, 50, false);
#line 27 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TypeMotorcycle));

#line default
#line hidden
            EndContext();
            BeginContext(635, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(679, 51, false);
#line 30 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TypeMotorcycle.Name));

#line default
#line hidden
            EndContext();
            BeginContext(730, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(774, 41, false);
#line 33 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(815, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(859, 42, false);
#line 36 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Brand.Name));

#line default
#line hidden
            EndContext();
            BeginContext(901, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(945, 51, false);
#line 39 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ModelMotorcycle));

#line default
#line hidden
            EndContext();
            BeginContext(996, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1040, 52, false);
#line 42 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ModelMotorcycle.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1136, 42, false);
#line 45 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Engine));

#line default
#line hidden
            EndContext();
            BeginContext(1178, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1222, 47, false);
#line 48 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Engine.EngineId));

#line default
#line hidden
            EndContext();
            BeginContext(1269, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1313, 40, false);
#line 51 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Fuel));

#line default
#line hidden
            EndContext();
            BeginContext(1353, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1397, 44, false);
#line 54 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Fuel.Feeding));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1485, 44, false);
#line 57 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Electric));

#line default
#line hidden
            EndContext();
            BeginContext(1529, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1573, 51, false);
#line 60 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Electric.ElectricId));

#line default
#line hidden
            EndContext();
            BeginContext(1624, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1668, 41, false);
#line 63 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Brake));

#line default
#line hidden
            EndContext();
            BeginContext(1709, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1753, 45, false);
#line 66 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Brake.BrakeId));

#line default
#line hidden
            EndContext();
            BeginContext(1798, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1842, 48, false);
#line 69 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Transmission));

#line default
#line hidden
            EndContext();
            BeginContext(1890, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1934, 59, false);
#line 72 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Transmission.TransmissionId));

#line default
#line hidden
            EndContext();
            BeginContext(1993, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2037, 46, false);
#line 75 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Dimensions));

#line default
#line hidden
            EndContext();
            BeginContext(2083, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2127, 55, false);
#line 78 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Dimensions.DimensionsId));

#line default
#line hidden
            EndContext();
            BeginContext(2182, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2220, 217, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74bf744aba184002b5c755580cf31b2e", async() => {
                BeginContext(2246, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2256, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f474c12a5eda4e4ba10990c310f88c97", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 83 "C:\Users\brunno_lorenzoni\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Dashboard\Motorcycles\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MotorcycleId);

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
                BeginContext(2302, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2386, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0bf7b17b2594195b80d700a57c5e4eb", async() => {
                    BeginContext(2408, 12, true);
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
                BeginContext(2424, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2437, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompareMotos.Models.Motorcycle> Html { get; private set; }
    }
}
#pragma warning restore 1591
