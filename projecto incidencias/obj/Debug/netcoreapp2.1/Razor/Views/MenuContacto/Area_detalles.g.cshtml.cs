#pragma checksum "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Area_detalles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c77c557bb41f5cd9fc66839f65e9718581aff32b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MenuContacto_Area_detalles), @"mvc.1.0.view", @"/Views/MenuContacto/Area_detalles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MenuContacto/Area_detalles.cshtml", typeof(AspNetCore.Views_MenuContacto_Area_detalles))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c77c557bb41f5cd9fc66839f65e9718581aff32b", @"/Views/MenuContacto/Area_detalles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60730656c01337fe7e31b1ee4301ecaf7b9c38c1", @"/Views/_ViewImports.cshtml")]
    public class Views_MenuContacto_Area_detalles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<projecto_incidencias.Models.Aula>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Area_detalles.cshtml"
  
    ViewData["Title"] = "Details_Usuario";

#line default
#line hidden
            BeginContext(92, 125, true);
            WriteLiteral("\r\n<h3>Detalles de usuario</h3>\r\n\r\n<div>\r\n    \r\n\r\n\r\n\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n\r\n            ");
            EndContext();
            BeginContext(218, 38, false);
#line 17 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Area_detalles.cshtml"
       Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(256, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(300, 38, false);
#line 20 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Area_detalles.cshtml"
       Write(Html.DisplayFor(model => model.NOMBRE));

#line default
#line hidden
            EndContext();
            BeginContext(338, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(382, 40, false);
#line 23 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Area_detalles.cshtml"
       Write(Html.DisplayNameFor(model => model.AREA));

#line default
#line hidden
            EndContext();
            BeginContext(422, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(466, 43, false);
#line 26 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Area_detalles.cshtml"
       Write(Html.DisplayFor(model => model.DESCRIPCION));

#line default
#line hidden
            EndContext();
            BeginContext(509, 100, true);
            WriteLiteral("\r\n        </dd>\r\n    \r\n        \r\n    </dl>\r\n</div>\r\n\r\n<div>\r\n    <h5>Editar este Contacto</h5>\r\n    ");
            EndContext();
            BeginContext(610, 60, false);
#line 35 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Area_detalles.cshtml"
Write(Html.ActionLink("Click AQUÌ", "Edit", new { id = Model.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(670, 58, true);
            WriteLiteral(" |\r\n    <h5>Ver los contactos referentes a este</h5>\r\n    ");
            EndContext();
            BeginContext(729, 79, false);
#line 37 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Area_detalles.cshtml"
Write(Html.ActionLink("Click AQUÌ", "Detalles_de_Referencias", new { id = Model.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(808, 77, true);
            WriteLiteral(" |\r\n\r\n    <h5>  Quieres borrar alguna referencias de este contacto</h5>\r\n    ");
            EndContext();
            BeginContext(886, 75, false);
#line 40 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Area_detalles.cshtml"
Write(Html.ActionLink(" CLICK AQUI ", "Borrar_Referencia", new { id = Model.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(961, 22, true);
            WriteLiteral("\r\n\r\n\r\n    <br />\r\n    ");
            EndContext();
            BeginContext(983, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "340caaf660f74423953a7741c7a7a492", async() => {
                BeginContext(1005, 12, true);
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
            BeginContext(1021, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<projecto_incidencias.Models.Aula> Html { get; private set; }
    }
}
#pragma warning restore 1591
