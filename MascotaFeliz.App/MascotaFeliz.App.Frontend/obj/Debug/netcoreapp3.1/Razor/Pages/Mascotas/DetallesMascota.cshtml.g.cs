#pragma checksum "C:\https---github.com-paulorosero55-mascotaFeliz\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\DetallesMascota.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c6aa7c7368fe164bfccb4574d893d5ff4dd4597"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Mascotas.Pages_Mascotas_DetallesMascota), @"mvc.1.0.razor-page", @"/Pages/Mascotas/DetallesMascota.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Mascotas
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
#line 1 "C:\https---github.com-paulorosero55-mascotaFeliz\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c6aa7c7368fe164bfccb4574d893d5ff4dd4597", @"/Pages/Mascotas/DetallesMascota.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Mascotas_DetallesMascota : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ListaMascotas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Datos de la Mascota</h2>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <td>ID Mascota:</td><td>");
#nullable restore
#line 9 "C:\https---github.com-paulorosero55-mascotaFeliz\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\DetallesMascota.cshtml"
                           Write(Model.mascota.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Nombre:</td><td>");
#nullable restore
#line 12 "C:\https---github.com-paulorosero55-mascotaFeliz\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\DetallesMascota.cshtml"
                       Write(Model.mascota.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Color:</td><td>");
#nullable restore
#line 15 "C:\https---github.com-paulorosero55-mascotaFeliz\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\DetallesMascota.cshtml"
                      Write(Model.mascota.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Especie:</td><td>");
#nullable restore
#line 18 "C:\https---github.com-paulorosero55-mascotaFeliz\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\DetallesMascota.cshtml"
                        Write(Model.mascota.Especie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Raza:</td><td>");
#nullable restore
#line 21 "C:\https---github.com-paulorosero55-mascotaFeliz\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\DetallesMascota.cshtml"
                     Write(Model.mascota.Raza);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </tr>\r\n    <tr>\r\n        <td>Propietario:</td><td>");
#nullable restore
#line 24 "C:\https---github.com-paulorosero55-mascotaFeliz\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\DetallesMascota.cshtml"
                            Write(Model.mascota.Dueno.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 24 "C:\https---github.com-paulorosero55-mascotaFeliz\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\DetallesMascota.cshtml"
                                                         Write(Model.mascota.Dueno.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Veterinaario:</td><td>");
#nullable restore
#line 27 "C:\https---github.com-paulorosero55-mascotaFeliz\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\DetallesMascota.cshtml"
                             Write(Model.mascota.Veterinario.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 27 "C:\https---github.com-paulorosero55-mascotaFeliz\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\DetallesMascota.cshtml"
                                                                Write(Model.mascota.Veterinario.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>    \r\n</table>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c6aa7c7368fe164bfccb4574d893d5ff4dd45977060", async() => {
                WriteLiteral("Volver a la lista de Mascotas");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.DetallesMascotaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.DetallesMascotaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.DetallesMascotaModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.DetallesMascotaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
