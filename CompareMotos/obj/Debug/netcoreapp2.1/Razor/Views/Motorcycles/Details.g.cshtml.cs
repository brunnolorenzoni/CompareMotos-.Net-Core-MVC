#pragma checksum "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12ae452addee44c15a14d09b6720440a11cc77dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Motorcycles_Details), @"mvc.1.0.view", @"/Views/Motorcycles/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Motorcycles/Details.cshtml", typeof(AspNetCore.Views_Motorcycles_Details))]
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
#line 1 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\_ViewImports.cshtml"
using CompareMotos;

#line default
#line hidden
#line 2 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\_ViewImports.cshtml"
using CompareMotos.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12ae452addee44c15a14d09b6720440a11cc77dc", @"/Views/Motorcycles/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ed1d728ea8edecd6458d1c4c9371f8fc1462d5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Motorcycles_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompareMotos.Models.Motorcycle>
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 124, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Motorcycle</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(209, 40, false);
#line 14 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(249, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(293, 36, false);
#line 17 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
            EndContext();
            BeginContext(329, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(373, 41, false);
#line 20 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(414, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(458, 37, false);
#line 23 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(495, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(539, 42, false);
#line 26 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Length));

#line default
#line hidden
            EndContext();
            BeginContext(581, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(625, 38, false);
#line 29 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Length));

#line default
#line hidden
            EndContext();
            BeginContext(663, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(707, 41, false);
#line 32 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Width));

#line default
#line hidden
            EndContext();
            BeginContext(748, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(792, 37, false);
#line 35 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Width));

#line default
#line hidden
            EndContext();
            BeginContext(829, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(873, 42, false);
#line 38 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Height));

#line default
#line hidden
            EndContext();
            BeginContext(915, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(959, 38, false);
#line 41 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Height));

#line default
#line hidden
            EndContext();
            BeginContext(997, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1041, 42, false);
#line 44 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
            EndContext();
            BeginContext(1083, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1127, 38, false);
#line 47 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Weight));

#line default
#line hidden
            EndContext();
            BeginContext(1165, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1209, 50, false);
#line 50 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TypeMotorcycle));

#line default
#line hidden
            EndContext();
            BeginContext(1259, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1303, 51, false);
#line 53 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml"
       Write(Html.DisplayFor(model => model.TypeMotorcycle.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1354, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1398, 41, false);
#line 56 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(1439, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1483, 42, false);
#line 59 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Brand.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1525, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1569, 51, false);
#line 62 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ModelMotorcycle));

#line default
#line hidden
            EndContext();
            BeginContext(1620, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1664, 52, false);
#line 65 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml"
       Write(Html.DisplayFor(model => model.ModelMotorcycle.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1716, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1760, 48, false);
#line 68 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Displacement));

#line default
#line hidden
            EndContext();
            BeginContext(1808, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1852, 59, false);
#line 71 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Displacement.DisplacementId));

#line default
#line hidden
            EndContext();
            BeginContext(1911, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1958, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6bc6a5dc2d04a1986b547d52ead82a2", async() => {
                BeginContext(2014, 4, true);
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
#line 76 "C:\Users\Brunno\Desktop\git\CompareMotos-.Net-Core-MVC\CompareMotos\Views\Motorcycles\Details.cshtml"
                           WriteLiteral(Model.MotorcycleId);

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
            BeginContext(2022, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2030, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58e40afcfa9348b0b01e8cf459d2b7e1", async() => {
                BeginContext(2052, 12, true);
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
            BeginContext(2068, 10, true);
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
