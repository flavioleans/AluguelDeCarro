#pragma checksum "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Carros\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01f2d3e0a761f8e119a70d86d045fe5936c8de63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carros_Index), @"mvc.1.0.view", @"/Views/Carros/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Carros/Index.cshtml", typeof(AspNetCore.Views_Carros_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01f2d3e0a761f8e119a70d86d045fe5936c8de63", @"/Views/Carros/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d2238d675ed3ec8fac612f13c4b1dbea016e2f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Carros_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AluguelCarro.Models.Carro>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Carros", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Novo carro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Alugar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Alugueis", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ModalExclusao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Carros\Index.cshtml"
  
    ViewData["Title"] = "Carros cadastrados";

    var controller = "Carros";

#line default
#line hidden
            BeginContext(137, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Carros\Index.cshtml"
 if (User.IsInRole("Administrador"))
{

#line default
#line hidden
            BeginContext(180, 102, true);
            WriteLiteral("    <h3 class=\"titulos\">\r\n        <i class=\"fas fa-car fa-lg\"></i> Carros Cadastrados &nbsp;\r\n        ");
            EndContext();
            BeginContext(282, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b459fd2e02b48428f15f62337b0883f", async() => {
                BeginContext(434, 58, true);
                WriteLiteral("\r\n            <i class=\"fas fa-plus-circle\"></i>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(496, 13, true);
            WriteLiteral("\r\n    </h3>\r\n");
            EndContext();
#line 17 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Carros\Index.cshtml"

}
else
{

#line default
#line hidden
            BeginContext(523, 105, true);
            WriteLiteral("    <h3 class=\"titulos\">\r\n        <i class=\"fas fa-car fa-lg\"></i> Carros disponíveis &nbsp;\r\n    </h3>\r\n");
            EndContext();
#line 24 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Carros\Index.cshtml"

}

#line default
#line hidden
            BeginContext(633, 23, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n");
            EndContext();
#line 29 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Carros\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(697, 124, true);
            WriteLiteral("        <div class=\"col-4\">\r\n            <div class=\"cartoes\">\r\n                <div class=\"card\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 821, "\"", 850, 1);
#line 34 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Carros\Index.cshtml"
WriteAttributeValue("", 827, Url.Content(item.Foto), 827, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(851, 128, true);
            WriteLiteral(" class=\"card-img-top img-fluid\" />\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
            EndContext();
            BeginContext(980, 10, false);
#line 36 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Carros\Index.cshtml"
                                          Write(item.Marca);

#line default
#line hidden
            EndContext();
            BeginContext(990, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(994, 9, false);
#line 36 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Carros\Index.cshtml"
                                                        Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1003, 74, true);
            WriteLiteral("</h5>\r\n                        <h5><span class=\"badge badge-secondary\">R$ ");
            EndContext();
            BeginContext(1078, 16, false);
#line 37 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Carros\Index.cshtml"
                                                              Write(item.PrecoDiaria);

#line default
#line hidden
            EndContext();
            BeginContext(1094, 92, true);
            WriteLiteral(",00</span></h5>\r\n                    </div>\r\n                    <div class=\"card-footer\">\r\n");
            EndContext();
#line 40 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Carros\Index.cshtml"
                         if (User.IsInRole("Administrador"))
                        {

#line default
#line hidden
            BeginContext(1275, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1303, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5de81657b7ee4fe5a950d1c17c5e61d3", async() => {
                BeginContext(1406, 9, true);
                WriteLiteral("Atualizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Carros\Index.cshtml"
                                                                           WriteLiteral(item.CarroId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1419, 32, true);
            WriteLiteral("\r\n                            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1451, "\"", 1522, 9);
            WriteAttributeValue("", 1461, "ConfirmarExclusao(", 1461, 18, true);
#line 43 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Carros\Index.cshtml"
WriteAttributeValue("", 1479, item.CarroId, 1479, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 1492, ",", 1492, 1, true);
            WriteAttributeValue(" ", 1493, "\'", 1494, 2, true);
#line 43 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Carros\Index.cshtml"
WriteAttributeValue("", 1495, item.Nome, 1495, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1505, "\',", 1505, 2, true);
            WriteAttributeValue(" ", 1507, "\'", 1508, 2, true);
#line 43 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Carros\Index.cshtml"
WriteAttributeValue("", 1509, controller, 1509, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 1520, "\')", 1520, 2, true);
            EndWriteAttribute();
            BeginContext(1523, 45, true);
            WriteLiteral(" class=\"btn btn-outline-danger\">Excluir</a>\r\n");
            EndContext();
#line 44 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Carros\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1652, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1680, 182, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bf771bf30144438814c82aaf0dcb7fc", async() => {
                BeginContext(1844, 14, true);
                WriteLiteral("Alugar veículo");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-CarroId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Carros\Index.cshtml"
                                                                                    WriteLiteral(item.CarroId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CarroId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-CarroId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CarroId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 47 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Carros\Index.cshtml"
                                                                                                                          WriteLiteral(item.PrecoDiaria);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PrecoDiaria"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-PrecoDiaria", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PrecoDiaria"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1862, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 48 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Carros\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1891, 88, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 53 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\Slides\Avançado\0127-ProjetoAluguelCarros\AluguelCarro\AluguelCarro\Views\Carros\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1986, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
            BeginContext(1996, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8ddc6bb1342e4d2f811f0755e1f6932b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2029, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2056, 721, true);
                WriteLiteral(@"
    <script>
        $(function () {
            $('[data-toggle=""tooltip""]').tooltip();
        })

        function ConfirmarExclusao(id, nome, controller) {
            $("".Nome"").html(nome);
            $("".modal"").modal(""show"");
            $("".btnExcluir"").on('click', function () {
                var url = ""/"" + controller + ""/Delete/"";

                $.ajax({
                    method: ""POST"",
                    url: url,
                    data: { id: id },
                    success: function () {
                        alert(""Registro excluído"");
                        location.reload();
                    }
                })
            })
        }
    </script>

");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AluguelCarro.Models.Carro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
