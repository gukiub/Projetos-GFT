#pragma checksum "C:\Users\gu_ki\Desktop\CasaDeShows\Views\Home\Contatos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8c0d75563feb10330930928f5f4926c246a56c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contatos), @"mvc.1.0.view", @"/Views/Home/Contatos.cshtml")]
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
#line 1 "C:\Users\gu_ki\Desktop\CasaDeShows\Views\_ViewImports.cshtml"
using CasaDeShows;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gu_ki\Desktop\CasaDeShows\Views\_ViewImports.cshtml"
using CasaDeShows.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8c0d75563feb10330930928f5f4926c246a56c6", @"/Views/Home/Contatos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd284120441de40af995f84d663281a8fcac503e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contatos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-contact contact_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("contact_process.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\gu_ki\Desktop\CasaDeShows\Views\Home\Contatos.cshtml"
  
   Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
<section class=""breadcrumb breadcrumb_bg"">
    <div class=""container"">
      <div class=""row"">
        <div class=""col-lg-12"">
          <div class=""breadcrumb_iner text-center"">
            <div class=""breadcrumb_iner_item"">
              <h2>Contato</h2>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  <!-- breadcrumb start-->

  <!-- ================ contact section start ================= -->
  <section class=""contact-section section_padding"">
    <div class=""container"">
      <div class=""d-none d-sm-block mb-5 pb-4"">
        <div id=""map"" style=""height: 480px;""></div>
        <script>
          function initMap() {
            var uluru = {
              lat: -25.363,
              lng: 131.044
            };
            var grayStyles = [{
                featureType: ""all"",
                stylers: [{
                    saturation: -90
                  },
                  {
                    lightness: 50
                  }
        ");
            WriteLiteral(@"        ]
              },
              {
                elementType: 'labels.text.fill',
                stylers: [{
                  color: '#ccdee9'
                }]
              }
            ];
            var map = new google.maps.Map(document.getElementById('map'), {
              center: {
                lat: -31.197,
                lng: 150.744
              },
              zoom: 9,
              styles: grayStyles,
              scrollwheel: false
            });
          }
        </script>
        <script
          src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyDpfS1oRGreGSBU5HHjMmQ3o5NLw7VdJ6I&callback=initMap"">
        </script>
      </div>

      <div class=""row"">
        <div class=""col-12"">
          <h2 class=""contact-title"">Fique em contato</h2>
        </div>
        <div class=""col-lg-8"">
          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8c0d75563feb10330930928f5f4926c246a56c67001", async() => {
                WriteLiteral(@"
            <div class=""row"">
              <div class=""col-12"">
                <div class=""form-group"">

                  <textarea class=""form-control w-100"" name=""message"" id=""message"" cols=""30"" rows=""9""
                    onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'Digite sua mensagem'""
                    placeholder='Digite sua mensagem'></textarea>
                </div>
              </div>
              <div class=""col-sm-6"">
                <div class=""form-group"">
                  <input class=""form-control"" name=""name"" id=""name"" type=""text"" onfocus=""this.placeholder = ''""
                    onblur=""this.placeholder = 'Digite seu Nome'"" placeholder='Digite seu Nome'>
                </div>
              </div>
              <div class=""col-sm-6"">
                <div class=""form-group"">
                  <input class=""form-control"" name=""email"" id=""email"" type=""email"" onfocus=""this.placeholder = ''""
                    onblur=""this.placeholder = 'Digite seu endereço de email'""");
                WriteLiteral(@" placeholder='Digite seu endereço de email'>
                </div>
              </div>
              <div class=""col-12"">
                <div class=""form-group"">
                  <input class=""form-control"" name=""subject"" id=""subject"" type=""text"" onfocus=""this.placeholder = ''""
                    onblur=""this.placeholder = 'Digite o assunto'"" placeholder='Digite o assunto'>
                </div>
              </div>
            </div>
            <div class=""form-group mt-3"">
              <button type=""submit"" class=""button-contactForm btn_1 rounded"">Enviar mensagem </button>
            </div>
          ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""col-lg-4"">
          <div class=""media contact-info"">
            <span class=""contact-info__icon""><i class=""ti-home""></i></span>
            <div class=""media-body"">
              <h3>Buttonwood, California.</h3>
              <p>Rosemead, CA 91770</p>
            </div>
          </div>
          <div class=""media contact-info"">
            <span class=""contact-info__icon""><i class=""ti-tablet""></i></span>
            <div class=""media-body"">
              <h3>00 (440) 9865 562</h3>
              <p>Segunda a sexta das 7 as 19</p>
            </div>
          </div>
          <div class=""media contact-info"">
            <span class=""contact-info__icon""><i class=""ti-email""></i></span>
            <div class=""media-body"">
              <h3>support@Music.com</h3>
              <p>Mande-nos sugestões!</p>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
  </div>");
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
