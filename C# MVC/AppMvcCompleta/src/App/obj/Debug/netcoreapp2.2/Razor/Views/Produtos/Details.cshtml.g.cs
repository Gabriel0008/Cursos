#pragma checksum "D:\Cursos\Atividades\C# MVC\AppMvcCompleta\src\App\Views\Produtos\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "92794a99c0878cfec64b1cf4e827392e7465085a350ca7368bac8a3695f39d4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_Details), @"mvc.1.0.view", @"/Views/Produtos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produtos/Details.cshtml", typeof(AspNetCore.Views_Produtos_Details))]
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
#line 1 "D:\Cursos\Atividades\C# MVC\AppMvcCompleta\src\App\Views\_ViewImports.cshtml"
using App;

#line default
#line hidden
#line 2 "D:\Cursos\Atividades\C# MVC\AppMvcCompleta\src\App\Views\_ViewImports.cshtml"
using App.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"92794a99c0878cfec64b1cf4e827392e7465085a350ca7368bac8a3695f39d4a", @"/Views/Produtos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"17b51186480762055cc655f44d5f18c60f331098a8ea6dd26c528c5b8479ec11", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.ViewModels.ProdutoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 300px; height: 300px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Cursos\Atividades\C# MVC\AppMvcCompleta\src\App\Views\Produtos\Details.cshtml"
  
    ViewData["Title"] = "Detalhe do Produto - " + Model.Nome;

#line default
#line hidden
            BeginContext(112, 32, true);
            WriteLiteral("\r\n<h4 style=\"padding-top: 50px\">");
            EndContext();
            BeginContext(145, 17, false);
#line 7 "D:\Cursos\Atividades\C# MVC\AppMvcCompleta\src\App\Views\Produtos\Details.cshtml"
                         Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(162, 72, true);
            WriteLiteral("</h4>\r\n<hr />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            EndContext();
            BeginContext(234, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "92794a99c0878cfec64b1cf4e827392e7465085a350ca7368bac8a3695f39d4a5295", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 244, "~/imagens/", 244, 10, true);
#line 12 "D:\Cursos\Atividades\C# MVC\AppMvcCompleta\src\App\Views\Produtos\Details.cshtml"
AddHtmlAttributeValue("", 254, Model.Imagem, 254, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "D:\Cursos\Atividades\C# MVC\AppMvcCompleta\src\App\Views\Produtos\Details.cshtml"
AddHtmlAttributeValue("", 274, Model.Imagem, 274, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(327, 90, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <dl>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(418, 48, false);
#line 17 "D:\Cursos\Atividades\C# MVC\AppMvcCompleta\src\App\Views\Produtos\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.FornecedorId));

#line default
#line hidden
            EndContext();
            BeginContext(466, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(522, 47, false);
#line 20 "D:\Cursos\Atividades\C# MVC\AppMvcCompleta\src\App\Views\Produtos\Details.cshtml"
           Write(Html.DisplayFor(model => model.Fornecedor.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(569, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(625, 40, false);
#line 23 "D:\Cursos\Atividades\C# MVC\AppMvcCompleta\src\App\Views\Produtos\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(665, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(721, 36, false);
#line 26 "D:\Cursos\Atividades\C# MVC\AppMvcCompleta\src\App\Views\Produtos\Details.cshtml"
           Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(757, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(813, 45, false);
#line 29 "D:\Cursos\Atividades\C# MVC\AppMvcCompleta\src\App\Views\Produtos\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(858, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(914, 41, false);
#line 32 "D:\Cursos\Atividades\C# MVC\AppMvcCompleta\src\App\Views\Produtos\Details.cshtml"
           Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(955, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1011, 41, false);
#line 35 "D:\Cursos\Atividades\C# MVC\AppMvcCompleta\src\App\Views\Produtos\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1108, 25, false);
#line 38 "D:\Cursos\Atividades\C# MVC\AppMvcCompleta\src\App\Views\Produtos\Details.cshtml"
           Write(Model.Valor.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 56, true);
            WriteLiteral(";\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1190, 48, false);
#line 41 "D:\Cursos\Atividades\C# MVC\AppMvcCompleta\src\App\Views\Produtos\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.DataCadastro));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1294, 44, false);
#line 44 "D:\Cursos\Atividades\C# MVC\AppMvcCompleta\src\App\Views\Produtos\Details.cshtml"
           Write(Html.DisplayFor(model => model.DataCadastro));

#line default
#line hidden
            EndContext();
            BeginContext(1338, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1394, 41, false);
#line 47 "D:\Cursos\Atividades\C# MVC\AppMvcCompleta\src\App\Views\Produtos\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Ativo));

#line default
#line hidden
            EndContext();
            BeginContext(1435, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1491, 48, false);
#line 50 "D:\Cursos\Atividades\C# MVC\AppMvcCompleta\src\App\Views\Produtos\Details.cshtml"
           Write(Html.DisplayFor(model => model.Fornecedor.Ativo));

#line default
#line hidden
            EndContext();
            BeginContext(1539, 44, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n        ");
            EndContext();
            BeginContext(1583, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92794a99c0878cfec64b1cf4e827392e7465085a350ca7368bac8a3695f39d4a12521", async() => {
                BeginContext(1650, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "D:\Cursos\Atividades\C# MVC\AppMvcCompleta\src\App\Views\Produtos\Details.cshtml"
                                                    WriteLiteral(Model.Id);

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
            BeginContext(1660, 106, true);
            WriteLiteral(" |\r\n        <a class=\"btn btn-info\" href=\"javascript:window.history.back()\">Voltar</a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.ViewModels.ProdutoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
