#pragma checksum "C:\Users\Gomez\Documents\src\Tienda\Views\Menu\Mis_Compras.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73ef090d26a11fcd92205d27dff69518dbe04051"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Mis_Compras), @"mvc.1.0.view", @"/Views/Menu/Mis_Compras.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Menu/Mis_Compras.cshtml", typeof(AspNetCore.Views_Menu_Mis_Compras))]
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
#line 1 "C:\Users\Gomez\Documents\src\Tienda\Views\_ViewImports.cshtml"
using Tienda;

#line default
#line hidden
#line 2 "C:\Users\Gomez\Documents\src\Tienda\Views\_ViewImports.cshtml"
using Tienda.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73ef090d26a11fcd92205d27dff69518dbe04051", @"/Views/Menu/Mis_Compras.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24fca49c8f0bf6cf6a935b0c46c3432348e3faf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Mis_Compras : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Tienda.Controllers.Productos.CreateCompra>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Gomez\Documents\src\Tienda\Views\Menu\Mis_Compras.cshtml"
  
    ViewData["Title"] = "Mis_Compras";

#line default
#line hidden
            BeginContext(112, 127, true);
            WriteLiteral("\r\n<h2> Mis Compras </h2>\r\n\r\n<p>\r\n\r\n</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(240, 38, false);
#line 17 "C:\Users\Gomez\Documents\src\Tienda\Views\Menu\Mis_Compras.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(278, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(334, 48, false);
#line 20 "C:\Users\Gomez\Documents\src\Tienda\Views\Menu\Mis_Compras.cshtml"
           Write(Html.DisplayNameFor(model => model.Precio_Venta));

#line default
#line hidden
            EndContext();
            BeginContext(382, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(438, 54, false);
#line 23 "C:\Users\Gomez\Documents\src\Tienda\Views\Menu\Mis_Compras.cshtml"
           Write(Html.DisplayNameFor(model => model.Total_con_Impuesto));

#line default
#line hidden
            EndContext();
            BeginContext(492, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(548, 42, false);
#line 26 "C:\Users\Gomez\Documents\src\Tienda\Views\Menu\Mis_Compras.cshtml"
           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(590, 146, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n              Usuario\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\Gomez\Documents\src\Tienda\Views\Menu\Mis_Compras.cshtml"
         foreach (var item in Model)
        {
            if (item.Role.Equals(User.Identity.Name.ToString()))
            {


#line default
#line hidden
            BeginContext(868, 50, true);
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(919, 37, false);
#line 43 "C:\Users\Gomez\Documents\src\Tienda\Views\Menu\Mis_Compras.cshtml"
           Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(956, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1012, 47, false);
#line 46 "C:\Users\Gomez\Documents\src\Tienda\Views\Menu\Mis_Compras.cshtml"
           Write(Html.DisplayFor(modelItem => item.Precio_Venta));

#line default
#line hidden
            EndContext();
            BeginContext(1059, 56, true);
            WriteLiteral("\r\n            </td>C\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1116, 53, false);
#line 49 "C:\Users\Gomez\Documents\src\Tienda\Views\Menu\Mis_Compras.cshtml"
           Write(Html.DisplayFor(modelItem => item.Total_con_Impuesto));

#line default
#line hidden
            EndContext();
            BeginContext(1169, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1225, 41, false);
#line 52 "C:\Users\Gomez\Documents\src\Tienda\Views\Menu\Mis_Compras.cshtml"
           Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1266, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1322, 39, false);
#line 55 "C:\Users\Gomez\Documents\src\Tienda\Views\Menu\Mis_Compras.cshtml"
           Write(Html.DisplayFor(modelItem => item.Role));

#line default
#line hidden
            EndContext();
            BeginContext(1361, 61, true);
            WriteLiteral("\r\n            </td>\r\n      \r\n           \r\n\r\n\r\n        </tr>\r\n");
            EndContext();
#line 62 "C:\Users\Gomez\Documents\src\Tienda\Views\Menu\Mis_Compras.cshtml"

            }

        }

#line default
#line hidden
            BeginContext(1452, 34, true);
            WriteLiteral("    </tbody>\r\n\r\n\r\n\r\n\r\n\r\n</table>\r\n");
            EndContext();
            BeginContext(1487, 70, false);
#line 73 "C:\Users\Gomez\Documents\src\Tienda\Views\Menu\Mis_Compras.cshtml"
Write(Html.ActionLink("Ir a Productos de Marvel ", "Create_Marvel_Products"));

#line default
#line hidden
            EndContext();
            BeginContext(1557, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1560, 61, false);
#line 74 "C:\Users\Gomez\Documents\src\Tienda\Views\Menu\Mis_Compras.cshtml"
Write(Html.ActionLink("Ir a Productos de DC", "Create_DC_Products"));

#line default
#line hidden
            EndContext();
            BeginContext(1621, 9, true);
            WriteLiteral(" \r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Tienda.Controllers.Productos.CreateCompra>> Html { get; private set; }
    }
}
#pragma warning restore 1591