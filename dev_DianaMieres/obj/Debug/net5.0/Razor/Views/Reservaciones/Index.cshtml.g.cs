#pragma checksum "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd7423e48121c28281f9ff6078aaf0f3c35ef69e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservaciones_Index), @"mvc.1.0.view", @"/Views/Reservaciones/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd7423e48121c28281f9ff6078aaf0f3c35ef69e", @"/Views/Reservaciones/Index.cshtml")]
    public class Views_Reservaciones_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<dev_DianaMieres.Models.Reservacione>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Entregado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HoraInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HoraFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdSalaNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Entregado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HoraInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HoraFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdSalaNavigation.IdSala));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2010, "\"", 2033, 1);
#nullable restore
#line 70 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml"
WriteAttributeValue("", 2025, item.Id, 2025, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2086, "\"", 2109, 1);
#nullable restore
#line 71 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml"
WriteAttributeValue("", 2101, item.Id, 2101, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2164, "\"", 2187, 1);
#nullable restore
#line 72 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml"
WriteAttributeValue("", 2179, item.Id, 2179, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 75 "C:\Users\Dmmm\source\repos\dev_DianaMieres\dev_DianaMieres\Views\Reservaciones\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<dev_DianaMieres.Models.Reservacione>> Html { get; private set; }
    }
}
#pragma warning restore 1591
