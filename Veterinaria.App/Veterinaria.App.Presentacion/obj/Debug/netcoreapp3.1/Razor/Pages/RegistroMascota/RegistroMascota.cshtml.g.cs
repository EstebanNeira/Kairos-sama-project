#pragma checksum "C:\Users\esteb\OneDrive\Documents\Veterinaria.App\Veterinaria.App\Veterinaria.App.Presentacion\Pages\RegistroMascota\RegistroMascota.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc72778b157bc05518f2860d96f4fe7c9210096f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Veterinaria.App.Presentacion.Pages.RegistroMascota.Pages_RegistroMascota_RegistroMascota), @"mvc.1.0.razor-page", @"/Pages/RegistroMascota/RegistroMascota.cshtml")]
namespace Veterinaria.App.Presentacion.Pages.RegistroMascota
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
#line 1 "C:\Users\esteb\OneDrive\Documents\Veterinaria.App\Veterinaria.App\Veterinaria.App.Presentacion\Pages\_ViewImports.cshtml"
using Veterinaria.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc72778b157bc05518f2860d96f4fe7c9210096f", @"/Pages/RegistroMascota/RegistroMascota.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0b5ca209e941241f3a7d6f6fefe42ca98442af", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RegistroMascota_RegistroMascota : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>
    <img src=""Veterinaria.App\Veterinaria.App.Presentacion\wwwroot\img\Logotipo2.png"" alt=""logo"" width=""120"" height=""120"">
</h1>


<div class=""accordion"" id=""accordionExample"">

    <div class=""card"">
        <div class=""card-header"" id=""headingOne"">
            <h2 class=""mb-0"">
                <button class=""btn btn-link btn-block text-left"" type=""button"" data-toggle=""collapse""
                    data-target=""#collapseMisMascotas"" aria-expanded=""true"" aria-controls=""collapseMisMascotas"">
                    Mis Mascotas
                </button>
            </h2>
        </div>

        <div id=""collapseMisMascotas"" class=""collapse show"" aria-labelledby=""headingOne""
            data-parent=""#accordionExample"">
            <div class=""card-body"">
                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th scope=""col"">#</th>
                            <th scope=""col"">Nombre</th>
                   ");
            WriteLiteral("         <th scope=\"col\">Tipo</th>\r\n                            <th scope=\"col\">Raza</th>\r\n                            <th scope=\"col\">Edad</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\esteb\OneDrive\Documents\Veterinaria.App\Veterinaria.App\Veterinaria.App.Presentacion\Pages\RegistroMascota\RegistroMascota.cshtml"
                         foreach (Mascota m in Model.listaMascotas)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
#nullable restore
#line 51 "C:\Users\esteb\OneDrive\Documents\Veterinaria.App\Veterinaria.App\Veterinaria.App.Presentacion\Pages\RegistroMascota\RegistroMascota.cshtml"
                                           Write(m.Index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 52 "C:\Users\esteb\OneDrive\Documents\Veterinaria.App\Veterinaria.App\Veterinaria.App.Presentacion\Pages\RegistroMascota\RegistroMascota.cshtml"
                               Write(m.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 53 "C:\Users\esteb\OneDrive\Documents\Veterinaria.App\Veterinaria.App\Veterinaria.App.Presentacion\Pages\RegistroMascota\RegistroMascota.cshtml"
                               Write(m.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 54 "C:\Users\esteb\OneDrive\Documents\Veterinaria.App\Veterinaria.App\Veterinaria.App.Presentacion\Pages\RegistroMascota\RegistroMascota.cshtml"
                               Write(m.Raza);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 55 "C:\Users\esteb\OneDrive\Documents\Veterinaria.App\Veterinaria.App\Veterinaria.App.Presentacion\Pages\RegistroMascota\RegistroMascota.cshtml"
                               Write(m.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 57 "C:\Users\esteb\OneDrive\Documents\Veterinaria.App\Veterinaria.App\Veterinaria.App.Presentacion\Pages\RegistroMascota\RegistroMascota.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                    </tbody>
                </table>
            </div>
        </div>

    </div>

    <div class=""card"">
        <div class=""card-header"" id=""headingOne"">
            <h2 class=""mb-0"">
                <button class=""btn btn-link btn-block text-left"" type=""button"" data-toggle=""collapse""
                    data-target=""#collapseAgregar"" aria-expanded=""true"" aria-controls=""collapseAgregar"">
                    Agregar Mascotas
                </button>
            </h2>
        </div>

        <div id=""collapseAgregar"" class=""collapse"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
            <div class=""card-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc72778b157bc05518f2860d96f4fe7c9210096f8883", async() => {
                WriteLiteral(@"
                    <div class=""container"">

                        <div class=""row"">
                            <div class=""col -xl"">
                                <div class=""form-group"">
                                    <label for=""id-mascota-nombre"">Nombre</label>
                                    <input type=""text"" class=""form-control"" id=""id-mascota-nombre""
                                        aria-describedby=""id-message-nombre"">
                                </div>
                            </div>
                            <div class=""col -xl"">
                                <div class=""form-group"">
                                    <label for=""id-mascota-tipo"">Tipo</label>
                                    <select id=""id-mascota-tipo"" class=""custom-select"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc72778b157bc05518f2860d96f4fe7c9210096f10022", async() => {
                    WriteLiteral("Elige...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc72778b157bc05518f2860d96f4fe7c9210096f11402", async() => {
                    WriteLiteral("Perro");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc72778b157bc05518f2860d96f4fe7c9210096f12665", async() => {
                    WriteLiteral("Gato");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc72778b157bc05518f2860d96f4fe7c9210096f13927", async() => {
                    WriteLiteral("Ave");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </select>
                                </div>
                            </div>
                        </div>

                        <div class=""row"">
                            <div class=""col -md"">
                                <div class=""form-group"">
                                    <label for=""id-veterinario-telefono"">Raza</label>
                                    <input type=""text"" class=""form-control"" id=""id-mascota-raza""
                                        aria-describedby=""id-message-raza"">
                                </div>
                            </div>
                            <div class=""col -md"">
                                <div class=""form-group"">
                                    <label for=""id-mascota-edad"">Fecha de nacimiento</label>
                                    <input type=""date"" class=""form-control"" id=""id-mascota-edad""
                                        aria-describedby=""id-message-edad""");
                WriteLiteral(@">
                                </div>
                            </div>
                            <div class=""col -6"">
                                <div class=""form-group"">
                                    <label for=""id-mascota-genero"">Género</label>
                                    <select id=""id-mascota-genero"" class=""custom-select"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc72778b157bc05518f2860d96f4fe7c9210096f16646", async() => {
                    WriteLiteral("Elige...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc72778b157bc05518f2860d96f4fe7c9210096f18026", async() => {
                    WriteLiteral("Macho");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc72778b157bc05518f2860d96f4fe7c9210096f19289", async() => {
                    WriteLiteral("Hembra");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </select>
                                </div>
                            </div>
                        </div>

                        <div class=""row"">
                            <div class=""col -md"">
                                <div class=""form-group"">
                                    <label for=""id-mascota-peso"">Peso (kg)</label>
                                    <input type=""number"" class=""form-control"" id=""id-mascota-peso""
                                        aria-describedby=""id-message-peso"">
                                </div>
                            </div>
                            <div class=""col -md"">
                                <div class=""form-group"">
                                    <label for=""id-mascota-tamaño"">Tamaño</label>
                                    <input type=""number"" class=""form-control"" id=""id-mascota-tamaño""
                                        aria-describedby=""id-message-tamaño"">
   ");
                WriteLiteral(@"                             </div>
                            </div>
                            <div class=""col -md"">
                                <div class=""form-group"">
                                    <label for=""id-mascota-color"">Color</label>
                                    <input type=""text"" class=""form-control"" id=""id-mascota-color""
                                        aria-describedby=""id-message-color"">
                                </div>
                            </div>

                        </div>

                        <div class=""row"">
                            <div class=""input-group"">
                                <span class=""input-group-text"">Detalles de Cuidado</span>
                                <textarea class=""form-control"" aria-label=""DetalleCuidado""></textarea>
                            </div>
                        </div>

                        <div class=""row"">
                            <div class=""col -xl"">
               ");
                WriteLiteral(@"                 <div class=""form-group"">
                                    <small id=""id-message-foto"" class=""form-text text-muted"">Agrega una
                                        foto de
                                        tu
                                        mascota.</small>
                                    <div class=""input-group mb-3"">
                                        <label class=""input-group-text"" for=""inputGroupFile01"">Upload</label>
                                        <input type=""file"" class=""form-control"" id=""inputGroupFile01"">
                                    </div>
                                </div>
                            </div>
                            <div class=""col self-align-center"">
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox"" id=""id-mascota-esterilizado"">
                                    <label class=""form-check-label"" for=""id-mascota-");
                WriteLiteral(@"esterilizado"">Estirilizado</label>
                                </div>
                            </div>
                        </div>

                        <div class=""d-flex justify-content-xl-start"">
                            <button type=""submit"" class=""btn btn-primary"">Aceptar</button>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Veterinaria.App.Presentacion.Pages.RegistroMascotaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.RegistroMascotaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.RegistroMascotaModel>)PageContext?.ViewData;
        public Veterinaria.App.Presentacion.Pages.RegistroMascotaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591