#pragma checksum "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Web.Mvc.CadastroTarefas\Views\Tarefa\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d5fc0153b638c8207b40b11659827f2d804c55f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tarefa_Cadastrar), @"mvc.1.0.view", @"/Views/Tarefa/Cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tarefa/Cadastrar.cshtml", typeof(AspNetCore.Views_Tarefa_Cadastrar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d5fc0153b638c8207b40b11659827f2d804c55f", @"/Views/Tarefa/Cadastrar.cshtml")]
    public class Views_Tarefa_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 227, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89792a216b6243e894a236ea6d34a570", async() => {
                BeginContext(31, 214, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <title>Page Title</title>\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <link rel=\"stylesheet\" type=\"text/css\" href=\"/wwwroot/css/login.css\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(252, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(254, 1844, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5b5dc29a2e0403197cc516ac30c6c70", async() => {
                BeginContext(260, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 10 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Web.Mvc.CadastroTarefas\Views\Tarefa\Cadastrar.cshtml"
      
        Layout = "MasterPageDeslogado";
    

#line default
#line hidden
                BeginContext(318, 1653, true);
                WriteLiteral(@"    <div class=""container"">
        <header class=""menu"">
            <div class=""menu-select"">
                <h1 class=""titulo-menu"">Cadastrar Tarefa</h1>
            </div>
            <div class=""menu-select sair"">
                <a href=""/Usuario/login"">Sair</a>
            </div>
        </header>

        <main>
            <div class=""main-principal"">
                <form method=""POST"" action=""/Tarefa/Cadastrar"">
                    <label>
                        <input class=""camp-inserir"" type=""text"" name=""nome"" placeholder=""Nome"">
                    </label>

                    <label>
                        <textarea class=""camp-inserir"" name=""descricao"" cols=""20"" rows=""5"" placeholder=""Descição da tarefa""></textarea>
                    </label>

                    <div class=""bottons"">
                        <label>
                        <select class=""botton-envair botton-select"" name=""tipo"">
                            <option value="""">Tipo de Tarefa</option>");
                WriteLiteral(@"
                            <option value=""para fazer"">Para Fazer</option>
                            <option value=""fazendo"">Fazendo</option>
                            <option value=""feito"">Feito</option>
                        </select>
                        </label>

                        <label>
                            <input class=""botton-envair botton-select"" type=""date"" name=""data"">
                        </label>
                    </div>

                    <input class=""botton-envair"" type=""submit"" value=""Cadastrar"">
                    <div class=""mensagem"">
                        ");
                EndContext();
                BeginContext(1972, 16, false);
#line 51 "C:\Users\50473694808\Desktop\C#\Projetos.Web\Senai.Web.Mvc.CadastroTarefas\Views\Tarefa\Cadastrar.cshtml"
                   Write(ViewBag.Mensagem);

#line default
#line hidden
                EndContext();
                BeginContext(1988, 103, true);
                WriteLiteral("\r\n                    </div>\r\n                </form>\r\n            </div>\r\n        </main>\r\n    <div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
