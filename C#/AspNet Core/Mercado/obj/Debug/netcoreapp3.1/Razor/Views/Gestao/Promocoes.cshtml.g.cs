#pragma checksum "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\Mercado\Views\Gestao\Promocoes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44f9cb4d57f6d41e00b6443d7f865d7ff77ac256"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gestao_Promocoes), @"mvc.1.0.view", @"/Views/Gestao/Promocoes.cshtml")]
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
#line 1 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\Mercado\Views\_ViewImports.cshtml"
using Mercado;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\Mercado\Views\_ViewImports.cshtml"
using Mercado.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44f9cb4d57f6d41e00b6443d7f865d7ff77ac256", @"/Views/Gestao/Promocoes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d40bfd8994fc794e897d258c5454dec7f923c2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Gestao_Promocoes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mercado.Models.Promocao>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovaPromocao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gestao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Promocoes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Deletar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\Mercado\Views\Gestao\Promocoes.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Promoções</h2>\n<hr>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44f9cb4d57f6d41e00b6443d7f865d7ff77ac2565597", async() => {
                WriteLiteral("Criar Nova promoção");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<hr>

<script>
    $(document).ready( function () {
        $('#promocoes').DataTable({
            ""info"" : false,
                ""language"": {
                    ""lengthMenu"": ""Mostrando _MENU_ registros por página"",
                    ""zeroRecords"": ""Desculpa, Nada encontrado"",
                    ""info"": ""Mostrando página _PAGE_ de _PAGES_"",
                    ""infoEmpty"": ""Nenhum registro disponível"",
                    ""Search"":        ""Buscar:"",
                    ""paginate"": {
                        ""first"":      ""Primeiro"",
                        ""last"":       ""Ultimo"",
                        ""next"":       ""Próximo"",
                        ""previous"":   ""Anterior""
                        }
                    }
            });
        } );
</script>

<table id=""promocoes"" class=""table table-striped table-bordered"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Produto</th>
            <th>Porcentagem</th>
            <th>Ações</th>
        </tr>");
            WriteLiteral("\n    </thead>\n    <tbody>\n");
#nullable restore
#line 43 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\Mercado\Views\Gestao\Promocoes.cshtml"
         foreach (var promocao in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 46 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\Mercado\Views\Gestao\Promocoes.cshtml"
               Write(promocao.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 47 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\Mercado\Views\Gestao\Promocoes.cshtml"
               Write(promocao.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 48 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\Mercado\Views\Gestao\Promocoes.cshtml"
               Write(promocao.Produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 49 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\Mercado\Views\Gestao\Promocoes.cshtml"
               Write(promocao.Porcentagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\n                <td><a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1541, "\"", 1583, 2);
            WriteAttributeValue("", 1548, "/Gestao/EditarPromocao/", 1548, 23, true);
#nullable restore
#line 50 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\Mercado\Views\Gestao\Promocoes.cshtml"
WriteAttributeValue("", 1571, promocao.Id, 1571, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a> \n                \n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44f9cb4d57f6d41e00b6443d7f865d7ff77ac25610126", async() => {
                WriteLiteral("\n                    <input type=\"hidden\" name=\"id\" id=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1768, "\"", 1788, 1);
#nullable restore
#line 53 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\Mercado\Views\Gestao\Promocoes.cshtml"
WriteAttributeValue("", 1776, promocao.Id, 1776, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                    <button class=\"btn btn-danger\">Deletar</button>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 58 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\Mercado\Views\Gestao\Promocoes.cshtml"
        } 

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mercado.Models.Promocao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
