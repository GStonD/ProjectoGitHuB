#pragma checksum "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf66cbd5847dcca3302e8f419d6e9c91a54c174c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MenuContacto_Index_Usuarios), @"mvc.1.0.view", @"/Views/MenuContacto/Index_Usuarios.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MenuContacto/Index_Usuarios.cshtml", typeof(AspNetCore.Views_MenuContacto_Index_Usuarios))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf66cbd5847dcca3302e8f419d6e9c91a54c174c", @"/Views/MenuContacto/Index_Usuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60730656c01337fe7e31b1ee4301ecaf7b9c38c1", @"/Views/_ViewImports.cshtml")]
    public class Views_MenuContacto_Index_Usuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<projecto_incidencias.Models.Usuario>>
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
  
    ViewData["Title"] = "Index_Usuarios";

#line default
#line hidden
            BeginContext(109, 32, true);
            WriteLiteral("\r\n<h4>Usuarios</h4>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(141, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdc535cca84744cc8542bef37773bfbc", async() => {
                BeginContext(163, 16, true);
                WriteLiteral("volver al inicio");
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
            BeginContext(183, 140, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n</p>\r\n\r\n\r\n\r\n\r\n\r\n\r\n<h4>Tecnico Externo  </h4>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(324, 38, false);
#line 27 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(362, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(418, 42, false);
#line 30 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.NOMBRE));

#line default
#line hidden
            EndContext();
            BeginContext(460, 56, true);
            WriteLiteral("\r\n            </th>\r\n             <th>\r\n                ");
            EndContext();
            BeginContext(517, 44, false);
#line 33 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.APELLIDO));

#line default
#line hidden
            EndContext();
            BeginContext(561, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(617, 40, false);
#line 36 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.TIPO));

#line default
#line hidden
            EndContext();
            BeginContext(657, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(713, 42, false);
#line 39 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.PUESTO));

#line default
#line hidden
            EndContext();
            BeginContext(755, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(811, 40, false);
#line 42 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.AREA));

#line default
#line hidden
            EndContext();
            BeginContext(851, 85, true);
            WriteLiteral("\r\n            </th>\r\n          \r\n        </tr>\r\n    </thead>\r\n\r\n\r\n\r\n\r\n\r\n    <tbody>\r\n");
            EndContext();
#line 53 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
         foreach (var item in Model)
        {
            if (item.TIPO.Equals("Tecnico Externo"))
            {

#line default
#line hidden
            BeginContext(1054, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1127, 37, false);
#line 59 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1164, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1244, 41, false);
#line 62 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NOMBRE));

#line default
#line hidden
            EndContext();
            BeginContext(1285, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1365, 43, false);
#line 65 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
                   Write(Html.DisplayFor(modelItem => item.APELLIDO));

#line default
#line hidden
            EndContext();
            BeginContext(1408, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1488, 39, false);
#line 68 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TIPO));

#line default
#line hidden
            EndContext();
            BeginContext(1527, 80, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                         ");
            EndContext();
            BeginContext(1608, 41, false);
#line 71 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
                    Write(Html.DisplayFor(modelItem => item.PUESTO));

#line default
#line hidden
            EndContext();
            BeginContext(1649, 104, true);
            WriteLiteral("\r\n                      \r\n                    </td>\r\n                    <td>\r\n                         ");
            EndContext();
            BeginContext(1754, 39, false);
#line 75 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
                    Write(Html.DisplayFor(modelItem => item.AREA));

#line default
#line hidden
            EndContext();
            BeginContext(1793, 120, true);
            WriteLiteral("\r\n                        \r\n                    </td>\r\n                 \r\n                    <td>\r\n                    ");
            EndContext();
            BeginContext(1914, 71, false);
#line 80 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
               Write(Html.ActionLink("Editar usuario", "Edit_usuario", new { id = item.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1985, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2006, 72, false);
#line 81 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
           Write(Html.ActionLink("Borrar usuario", "Delete_usuario", new { id = item.ID}));

#line default
#line hidden
            EndContext();
            BeginContext(2078, 92, true);
            WriteLiteral(" |\r\n          \r\n                        \r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 86 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(2196, 156, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n    </tbody>\r\n</table>\r\n\r\n<h4>Tecnico Interior de ITC</h4>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2353, 38, false);
#line 102 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(2391, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2447, 42, false);
#line 105 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.NOMBRE));

#line default
#line hidden
            EndContext();
            BeginContext(2489, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2545, 44, false);
#line 108 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.APELLIDO));

#line default
#line hidden
            EndContext();
            BeginContext(2589, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2645, 40, false);
#line 111 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.TIPO));

#line default
#line hidden
            EndContext();
            BeginContext(2685, 54, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n               ");
            EndContext();
            BeginContext(2740, 42, false);
#line 114 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
          Write(Html.DisplayNameFor(model => model.PUESTO));

#line default
#line hidden
            EndContext();
            BeginContext(2782, 72, true);
            WriteLiteral("\r\n                \r\n            </th>\r\n            <th>\r\n               ");
            EndContext();
            BeginContext(2855, 40, false);
#line 118 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
          Write(Html.DisplayNameFor(model => model.AREA));

#line default
#line hidden
            EndContext();
            BeginContext(2895, 117, true);
            WriteLiteral("\r\n                \r\n            </th>\r\n           \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 126 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
         foreach (var item in Model)
        {
            if (item.TIPO.Equals("Tecnico Interior de ITC"))
            {

#line default
#line hidden
            BeginContext(3138, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3211, 37, false);
#line 132 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(3248, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3328, 41, false);
#line 135 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NOMBRE));

#line default
#line hidden
            EndContext();
            BeginContext(3369, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3449, 43, false);
#line 138 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
                   Write(Html.DisplayFor(modelItem => item.APELLIDO));

#line default
#line hidden
            EndContext();
            BeginContext(3492, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3572, 39, false);
#line 141 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TIPO));

#line default
#line hidden
            EndContext();
            BeginContext(3611, 78, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n\r\n                     ");
            EndContext();
            BeginContext(3690, 41, false);
#line 145 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
                Write(Html.DisplayFor(modelItem => item.PUESTO));

#line default
#line hidden
            EndContext();
            BeginContext(3731, 107, true);
            WriteLiteral("\r\n                      \r\n                    </td>\r\n                    <td>\r\n\r\n                          ");
            EndContext();
            BeginContext(3839, 39, false);
#line 150 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
                     Write(Html.DisplayFor(modelItem => item.AREA));

#line default
#line hidden
            EndContext();
            BeginContext(3878, 137, true);
            WriteLiteral("\r\n                       \r\n                    </td>\r\n                    \r\n                    <td>\r\n                                   ");
            EndContext();
            BeginContext(4016, 71, false);
#line 155 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
                              Write(Html.ActionLink("Editar usuario", "Edit_usuario", new { id = item.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(4087, 19, true);
            WriteLiteral(" |\r\n               ");
            EndContext();
            BeginContext(4107, 72, false);
#line 156 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
          Write(Html.ActionLink("Borrar usuario", "Delete_usuario", new { id = item.ID}));

#line default
#line hidden
            EndContext();
            BeginContext(4179, 64, true);
            WriteLiteral("  |\r\n       \r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 160 "C:\Users\Gomez\Documents\testx - copia\projecto incidencias\Views\MenuContacto\Index_Usuarios.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(4269, 30, true);
            WriteLiteral("\r\n\r\n    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<projecto_incidencias.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
