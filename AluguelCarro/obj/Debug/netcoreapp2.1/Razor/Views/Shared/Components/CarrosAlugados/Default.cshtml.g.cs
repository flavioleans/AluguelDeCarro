#pragma checksum "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Shared\Components\CarrosAlugados\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d11772140c3dfae2980481ff536390d8c0f5e262"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CarrosAlugados_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CarrosAlugados/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CarrosAlugados/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CarrosAlugados_Default))]
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
#line 1 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\_ViewImports.cshtml"
using AluguelCarro;

#line default
#line hidden
#line 2 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\_ViewImports.cshtml"
using AluguelCarro.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d11772140c3dfae2980481ff536390d8c0f5e262", @"/Views/Shared/Components/CarrosAlugados/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d2238d675ed3ec8fac612f13c4b1dbea016e2f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CarrosAlugados_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AluguelCarro.Models.Aluguel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 23, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n");
            EndContext();
#line 5 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Shared\Components\CarrosAlugados\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(113, 124, true);
            WriteLiteral("        <div class=\"col-4\">\r\n            <div class=\"cartoes\">\r\n                <div class=\"card\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 237, "\"", 272, 1);
#line 10 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Shared\Components\CarrosAlugados\Default.cshtml"
WriteAttributeValue("", 243, Url.Content(item.Carro.Foto), 243, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(273, 128, true);
            WriteLiteral(" class=\"card-img-top img-fluid\" />\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
            EndContext();
            BeginContext(402, 16, false);
#line 12 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Shared\Components\CarrosAlugados\Default.cshtml"
                                          Write(item.Carro.Marca);

#line default
#line hidden
            EndContext();
            BeginContext(418, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(422, 15, false);
#line 12 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Shared\Components\CarrosAlugados\Default.cshtml"
                                                              Write(item.Carro.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(437, 35, true);
            WriteLiteral("</h5>\r\n                        <h5>");
            EndContext();
            BeginContext(473, 11, false);
#line 13 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Shared\Components\CarrosAlugados\Default.cshtml"
                       Write(item.Inicio);

#line default
#line hidden
            EndContext();
            BeginContext(484, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(488, 8, false);
#line 13 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Shared\Components\CarrosAlugados\Default.cshtml"
                                      Write(item.Fim);

#line default
#line hidden
            EndContext();
            BeginContext(496, 72, true);
            WriteLiteral("</h5>\r\n                        <h5><span class=\"badge badge-success\">R$ ");
            EndContext();
            BeginContext(569, 15, false);
#line 14 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Shared\Components\CarrosAlugados\Default.cshtml"
                                                            Write(item.PrecoTotal);

#line default
#line hidden
            EndContext();
            BeginContext(584, 105, true);
            WriteLiteral(",00</span></h5>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 19 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Shared\Components\CarrosAlugados\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(696, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AluguelCarro.Models.Aluguel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
