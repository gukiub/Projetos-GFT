#pragma checksum "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\CasaDeShows\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12534453ad793ec432faa34aaf435bd69975ff0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\CasaDeShows\Views\_ViewImports.cshtml"
using CasaDeShows;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\CasaDeShows\Views\_ViewImports.cshtml"
using CasaDeShows.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12534453ad793ec432faa34aaf435bd69975ff0d", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd284120441de40af995f84d663281a8fcac503e", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CasaDeShows.Models.Eventos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.4.1-COMPLETASSO.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\CasaDeShows\Views\User\Index.cshtml"
  
    ViewData["Title"] = "teste";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\" style=\"background-color: gray;\">\n");
#nullable restore
#line 7 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\CasaDeShows\Views\User\Index.cshtml"
     foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("       <div class=\"card text-center\" style=\"width: 18rem; float: left; margin-left: 5em; margin-top: 3em; margin-bottom: 3em;\">\n        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 359, "\"", 407, 1);
#nullable restore
#line 9 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\CasaDeShows\Views\User\Index.cshtml"
WriteAttributeValue("", 365, Html.DisplayFor(modelItem => item.Imagem), 365, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\n        <div class=\"card-body\">\n        <h3 class=\"card-title text-dark mb-0\">");
#nullable restore
#line 11 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\CasaDeShows\Views\User\Index.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        </div>\n    <ul class=\"list-group list-group-flush\">\n        <li class=\"list-group-item\">Local : ");
#nullable restore
#line 14 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\CasaDeShows\Views\User\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.CasaDeShows.Local));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li class=\"list-group-item\">Ingressos : ");
#nullable restore
#line 15 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\CasaDeShows\Views\User\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Ingressos));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li class=\"list-group-item\">Data: ");
#nullable restore
#line 16 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\CasaDeShows\Views\User\Index.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li class=\"list-group-item\">Preço : ");
#nullable restore
#line 17 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\CasaDeShows\Views\User\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral(" R$</li>\n        <li class=\"list-group-item\">Gênero : ");
#nullable restore
#line 18 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\CasaDeShows\Views\User\Index.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.Genero));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n\n    </ul>\n    <div class=\"card-body\">\n        <a type=\"button\" class=\"btn btn-primary\" id=\"btnComprar\">Comprar</a>\n    </div>\n    </div>\n");
#nullable restore
#line 25 "C:\Users\gu_ki\Desktop\github\Projetos-GFT\C#\AspNet Core\CasaDeShows\Views\User\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12534453ad793ec432faa34aaf435bd69975ff0d7251", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<script type=\"text/javascript\">\n    $(document).ready(function(){\n         $(\"#btnComprar\").click(function() {\n            alert(\"teste\");\n        });\n    });\n\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CasaDeShows.Models.Eventos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
