#pragma checksum "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d562a5a6b98650c64a2016ef6fc45744022a6c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MenuContacto_Delete_Equipo), @"mvc.1.0.view", @"/Views/MenuContacto/Delete_Equipo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MenuContacto/Delete_Equipo.cshtml", typeof(AspNetCore.Views_MenuContacto_Delete_Equipo))]
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
#line 1 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\_ViewImports.cshtml"
using testx;

#line default
#line hidden
#line 2 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\_ViewImports.cshtml"
using testx.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d562a5a6b98650c64a2016ef6fc45744022a6c0", @"/Views/MenuContacto/Delete_Equipo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60730656c01337fe7e31b1ee4301ecaf7b9c38c1", @"/Views/_ViewImports.cshtml")]
    public class Views_MenuContacto_Delete_Equipo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<projecto_incidencias.Models.Equipo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete_Equipo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
  
    ViewData["Title"] = "Delete_Equipo";

#line default
#line hidden
            BeginContext(94, 112, true);
            WriteLiteral("\r\n<h4>Borrar Equipo</h4>\r\n\r\n\r\n<div>\r\n   \r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(207, 38, false);
#line 15 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(245, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(289, 34, false);
#line 18 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(323, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(367, 42, false);
#line 21 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayNameFor(model => model.NOMBRE));

#line default
#line hidden
            EndContext();
            BeginContext(409, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(453, 38, false);
#line 24 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayFor(model => model.NOMBRE));

#line default
#line hidden
            EndContext();
            BeginContext(491, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(535, 40, false);
#line 27 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayNameFor(model => model.TIPO));

#line default
#line hidden
            EndContext();
            BeginContext(575, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(619, 36, false);
#line 30 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayFor(model => model.TIPO));

#line default
#line hidden
            EndContext();
            BeginContext(655, 44, true);
            WriteLiteral("\r\n        </dd>\r\n         <dt>\r\n            ");
            EndContext();
            BeginContext(700, 40, false);
#line 33 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayNameFor(model => model.AULA));

#line default
#line hidden
            EndContext();
            BeginContext(740, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(784, 36, false);
#line 36 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayFor(model => model.AULA));

#line default
#line hidden
            EndContext();
            BeginContext(820, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(864, 40, false);
#line 39 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayNameFor(model => model.AREA));

#line default
#line hidden
            EndContext();
            BeginContext(904, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(948, 36, false);
#line 42 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayFor(model => model.AREA));

#line default
#line hidden
            EndContext();
            BeginContext(984, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1028, 56, false);
#line 45 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayNameFor(model => model.Fecha_adquisicion_hw));

#line default
#line hidden
            EndContext();
            BeginContext(1084, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1128, 52, false);
#line 48 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayFor(model => model.Fecha_adquisicion_hw));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1224, 44, false);
#line 51 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayNameFor(model => model.garantia));

#line default
#line hidden
            EndContext();
            BeginContext(1268, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1312, 40, false);
#line 54 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayFor(model => model.garantia));

#line default
#line hidden
            EndContext();
            BeginContext(1352, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1396, 52, false);
#line 57 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayNameFor(model => model.ficha_tecnica_hd));

#line default
#line hidden
            EndContext();
            BeginContext(1448, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1492, 48, false);
#line 60 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayFor(model => model.ficha_tecnica_hd));

#line default
#line hidden
            EndContext();
            BeginContext(1540, 44, true);
            WriteLiteral("\r\n        </dd>\r\n         <dt>\r\n            ");
            EndContext();
            BeginContext(1585, 46, false);
#line 63 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayNameFor(model => model.num_provee));

#line default
#line hidden
            EndContext();
            BeginContext(1631, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1675, 42, false);
#line 66 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayFor(model => model.num_provee));

#line default
#line hidden
            EndContext();
            BeginContext(1717, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1761, 48, false);
#line 69 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayNameFor(model => model.licencia_hw ));

#line default
#line hidden
            EndContext();
            BeginContext(1809, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1853, 44, false);
#line 72 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayFor(model => model.licencia_hw ));

#line default
#line hidden
            EndContext();
            BeginContext(1897, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1941, 57, false);
#line 75 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayNameFor(model => model.fecha_instalacion_hw ));

#line default
#line hidden
            EndContext();
            BeginContext(1998, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2042, 53, false);
#line 78 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayFor(model => model.fecha_instalacion_hw ));

#line default
#line hidden
            EndContext();
            BeginContext(2095, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2139, 53, false);
#line 81 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayNameFor(model => model.conectividad_red ));

#line default
#line hidden
            EndContext();
            BeginContext(2192, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2236, 49, false);
#line 84 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Delete_Equipo.cshtml"
       Write(Html.DisplayFor(model => model.conectividad_red ));

#line default
#line hidden
            EndContext();
            BeginContext(2285, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2323, 168, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9014a4725f224209b49110f81ef2eb1d", async() => {
                BeginContext(2356, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2440, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39035431d7cc42cdb126297c8fc4e3c0", async() => {
                    BeginContext(2462, 12, true);
                    WriteLiteral("Back to List");
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
                BeginContext(2478, 6, true);
                WriteLiteral("\r\n    ");
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
            BeginContext(2491, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<projecto_incidencias.Models.Equipo> Html { get; private set; }
    }
}
#pragma warning restore 1591
