#pragma checksum "E:\Users\work\Desktop\ProyectoTecnico\mvc\SistemaDeAdministracion\SistemaDeAdministracion\Views\AsignacionDeCursos\ListaDeAsignados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21e10f873ff8f67feca20e579f7c8a5a957e3fac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AsignacionDeCursos_ListaDeAsignados), @"mvc.1.0.view", @"/Views/AsignacionDeCursos/ListaDeAsignados.cshtml")]
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
#line 1 "E:\Users\work\Desktop\ProyectoTecnico\mvc\SistemaDeAdministracion\SistemaDeAdministracion\Views\_ViewImports.cshtml"
using SistemaDeAdministracion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Users\work\Desktop\ProyectoTecnico\mvc\SistemaDeAdministracion\SistemaDeAdministracion\Views\_ViewImports.cshtml"
using SistemaDeAdministracion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21e10f873ff8f67feca20e579f7c8a5a957e3fac", @"/Views/AsignacionDeCursos/ListaDeAsignados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d719c6c1f053534390f9ce4ac4e360eb97f9de97", @"/Views/_ViewImports.cshtml")]
    public class Views_AsignacionDeCursos_ListaDeAsignados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemaDeAdministracion.Models.ViewModels.ReporteAsignacion>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Users\work\Desktop\ProyectoTecnico\mvc\SistemaDeAdministracion\SistemaDeAdministracion\Views\AsignacionDeCursos\ListaDeAsignados.cshtml"
  
    List<SelectListItem> FKcurso = (List<SelectListItem>)ViewBag.Curso;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "E:\Users\work\Desktop\ProyectoTecnico\mvc\SistemaDeAdministracion\SistemaDeAdministracion\Views\AsignacionDeCursos\ListaDeAsignados.cshtml"
 using (Html.BeginForm())
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row m-10\">\r\n        <div class=\"col-md-10\">\r\n\r\n            <div class=\"form-group\">\r\n                <div class=\"control-label col-md-4\">Curso</div>\r\n                <div class=\"col-4\">\r\n                    ");
#nullable restore
#line 15 "E:\Users\work\Desktop\ProyectoTecnico\mvc\SistemaDeAdministracion\SistemaDeAdministracion\Views\AsignacionDeCursos\ListaDeAsignados.cshtml"
               Write(Html.DropDownList("Curso", FKcurso as IEnumerable<SelectListItem>, "Seleccione un curso..", new { id = "normalDropwn", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <span class=\"text-danger\"></span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group col-md-10\">\r\n        <div class=\"col-md-offset-2 col-md-12\">\r\n            <input type=\"submit\" value=\"Buscar\" class=\"btn btn-success\" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 27 "E:\Users\work\Desktop\ProyectoTecnico\mvc\SistemaDeAdministracion\SistemaDeAdministracion\Views\AsignacionDeCursos\ListaDeAsignados.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<table class=""table"">
    <tr>
        <th>
            Id
        </th>
        <th>
            curso
        </th>
        <th>
            año
        </th>
        <th>
            semestre
        </th>
        <th>
            turno
        </th>
        <th>
           profesor
        </th>
        <th>
            alumno
        </th>
    </tr>
");
#nullable restore
#line 55 "E:\Users\work\Desktop\ProyectoTecnico\mvc\SistemaDeAdministracion\SistemaDeAdministracion\Views\AsignacionDeCursos\ListaDeAsignados.cshtml"
     if (Model != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "E:\Users\work\Desktop\ProyectoTecnico\mvc\SistemaDeAdministracion\SistemaDeAdministracion\Views\AsignacionDeCursos\ListaDeAsignados.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "E:\Users\work\Desktop\ProyectoTecnico\mvc\SistemaDeAdministracion\SistemaDeAdministracion\Views\AsignacionDeCursos\ListaDeAsignados.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "E:\Users\work\Desktop\ProyectoTecnico\mvc\SistemaDeAdministracion\SistemaDeAdministracion\Views\AsignacionDeCursos\ListaDeAsignados.cshtml"
               Write(Html.DisplayFor(modelItem => item.Curso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "E:\Users\work\Desktop\ProyectoTecnico\mvc\SistemaDeAdministracion\SistemaDeAdministracion\Views\AsignacionDeCursos\ListaDeAsignados.cshtml"
               Write(Html.DisplayFor(modelItem => item.Anio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "E:\Users\work\Desktop\ProyectoTecnico\mvc\SistemaDeAdministracion\SistemaDeAdministracion\Views\AsignacionDeCursos\ListaDeAsignados.cshtml"
               Write(Html.DisplayFor(modelItem => item.Semestre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 74 "E:\Users\work\Desktop\ProyectoTecnico\mvc\SistemaDeAdministracion\SistemaDeAdministracion\Views\AsignacionDeCursos\ListaDeAsignados.cshtml"
               Write(Html.DisplayFor(modelItem => item.Turno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "E:\Users\work\Desktop\ProyectoTecnico\mvc\SistemaDeAdministracion\SistemaDeAdministracion\Views\AsignacionDeCursos\ListaDeAsignados.cshtml"
               Write(Html.DisplayFor(modelItem => item.Profesor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 80 "E:\Users\work\Desktop\ProyectoTecnico\mvc\SistemaDeAdministracion\SistemaDeAdministracion\Views\AsignacionDeCursos\ListaDeAsignados.cshtml"
               Write(Html.DisplayFor(modelItem => item.Alumno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 83 "E:\Users\work\Desktop\ProyectoTecnico\mvc\SistemaDeAdministracion\SistemaDeAdministracion\Views\AsignacionDeCursos\ListaDeAsignados.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "E:\Users\work\Desktop\ProyectoTecnico\mvc\SistemaDeAdministracion\SistemaDeAdministracion\Views\AsignacionDeCursos\ListaDeAsignados.cshtml"
         

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SistemaDeAdministracion.Models.ViewModels.ReporteAsignacion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
