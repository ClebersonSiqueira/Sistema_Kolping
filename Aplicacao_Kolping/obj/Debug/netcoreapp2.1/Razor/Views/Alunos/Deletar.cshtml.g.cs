#pragma checksum "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e70977d5223865a4335d86494435b7e54bcf4e6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alunos_Deletar), @"mvc.1.0.view", @"/Views/Alunos/Deletar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Alunos/Deletar.cshtml", typeof(AspNetCore.Views_Alunos_Deletar))]
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
#line 1 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\_ViewImports.cshtml"
using Aplicacao_Kolping;

#line default
#line hidden
#line 2 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\_ViewImports.cshtml"
using Aplicacao_Kolping.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e70977d5223865a4335d86494435b7e54bcf4e6f", @"/Views/Alunos/Deletar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de31399b4d0fa578009c8352f2bcdedb4b34ce26", @"/Views/_ViewImports.cshtml")]
    public class Views_Alunos_Deletar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Aplicacao_Kolping.Models.Alunos>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Deletar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
  
    ViewData["Title"] = "Deletar";

#line default
#line hidden
            BeginContext(85, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(92, 17, false);
#line 7 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(109, 161, true);
            WriteLiteral("</h2>\r\n\r\n<h3>Tem certeza que deseja deletar este aluno?</h3>\r\n\r\n<div>\r\n    <h4>Aluno</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(271, 40, false);
#line 16 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(311, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(355, 36, false);
#line 19 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(391, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(435, 45, false);
#line 22 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
       Write(Html.DisplayNameFor(model => model.Documento));

#line default
#line hidden
            EndContext();
            BeginContext(480, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(524, 41, false);
#line 25 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
       Write(Html.DisplayFor(model => model.Documento));

#line default
#line hidden
            EndContext();
            BeginContext(565, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(609, 46, false);
#line 28 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
       Write(Html.DisplayNameFor(model => model.Nascimento));

#line default
#line hidden
            EndContext();
            BeginContext(655, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(699, 42, false);
#line 31 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
       Write(Html.DisplayFor(model => model.Nascimento));

#line default
#line hidden
            EndContext();
            BeginContext(741, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(785, 44, false);
#line 34 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(829, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(873, 40, false);
#line 37 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
       Write(Html.DisplayFor(model => model.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(913, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(957, 41, false);
#line 40 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(998, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1042, 37, false);
#line 43 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1079, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1123, 39, false);
#line 46 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
       Write(Html.DisplayNameFor(model => model.Rua));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1206, 35, false);
#line 49 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
       Write(Html.DisplayFor(model => model.Rua));

#line default
#line hidden
            EndContext();
            BeginContext(1241, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1285, 42, false);
#line 52 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
       Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1371, 38, false);
#line 55 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
       Write(Html.DisplayFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1409, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1453, 42, false);
#line 58 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
       Write(Html.DisplayNameFor(model => model.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1495, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1539, 38, false);
#line 61 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
       Write(Html.DisplayFor(model => model.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1577, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1621, 42, false);
#line 64 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
       Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1663, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1707, 38, false);
#line 67 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
       Write(Html.DisplayFor(model => model.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1745, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1789, 39, false);
#line 70 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
       Write(Html.DisplayNameFor(model => model.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(1828, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1872, 35, false);
#line 73 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
       Write(Html.DisplayFor(model => model.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(1907, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1951, 50, false);
#line 76 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
       Write(Html.DisplayNameFor(model => model.DiadePagamento));

#line default
#line hidden
            EndContext();
            BeginContext(2001, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2045, 46, false);
#line 79 "C:\Users\Cleberson\Desktop\C#\Sistema_Kolping\Aplicacao_Kolping\Views\Alunos\Deletar.cshtml"
       Write(Html.DisplayFor(model => model.DiadePagamento));

#line default
#line hidden
            EndContext();
            BeginContext(2091, 32, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    ");
            EndContext();
            BeginContext(2123, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "327cb7d3dd5f4f36ba34b593e6e10d26", async() => {
                BeginContext(2150, 129, true);
                WriteLiteral("\r\n        <input type=\"hidden\" asp-form=\"ID\" />\r\n        <input type=\"submit\" value=\"Deletar\" class=\"btn btn-danger\" />\r\n        ");
                EndContext();
                BeginContext(2279, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efb6185b9d6847ec8fd8d20408f4a442", async() => {
                    BeginContext(2301, 19, true);
                    WriteLiteral("Voltar para a lista");
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
                BeginContext(2324, 6, true);
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
            BeginContext(2337, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Aplicacao_Kolping.Models.Alunos> Html { get; private set; }
    }
}
#pragma warning restore 1591
