#pragma checksum "C:\Users\Desenvolvimento-02\Desktop\Dev\HandsWork\src\App\Views\Produtos\_ListaProdutos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebe197e2e85c2182437858c3fd0a2fa539c73440"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos__ListaProdutos), @"mvc.1.0.view", @"/Views/Produtos/_ListaProdutos.cshtml")]
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
#line 1 "C:\Users\Desenvolvimento-02\Desktop\Dev\HandsWork\src\App\Views\_ViewImports.cshtml"
using App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Desenvolvimento-02\Desktop\Dev\HandsWork\src\App\Views\Produtos\_ListaProdutos.cshtml"
using App.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebe197e2e85c2182437858c3fd0a2fa539c73440", @"/Views/Produtos/_ListaProdutos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb66e1bc724abc87aa845ae534bd1318213bdfd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos__ListaProdutos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<App.ProdutoViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<table class=\"table table-hover\">\n    <thead class=\"thead-dark\">\n        <tr>\n            <th>\n                ");
#nullable restore
#line 8 "C:\Users\Desenvolvimento-02\Desktop\Dev\HandsWork\src\App\Views\Produtos\_ListaProdutos.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 11 "C:\Users\Desenvolvimento-02\Desktop\Dev\HandsWork\src\App\Views\Produtos\_ListaProdutos.cshtml"
           Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 14 "C:\Users\Desenvolvimento-02\Desktop\Dev\HandsWork\src\App\Views\Produtos\_ListaProdutos.cshtml"
           Write(Html.DisplayNameFor(model => model.Ativo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 20 "C:\Users\Desenvolvimento-02\Desktop\Dev\HandsWork\src\App\Views\Produtos\_ListaProdutos.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 24 "C:\Users\Desenvolvimento-02\Desktop\Dev\HandsWork\src\App\Views\Produtos\_ListaProdutos.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 27 "C:\Users\Desenvolvimento-02\Desktop\Dev\HandsWork\src\App\Views\Produtos\_ListaProdutos.cshtml"
               Write(item.Valor.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 30 "C:\Users\Desenvolvimento-02\Desktop\Dev\HandsWork\src\App\Views\Produtos\_ListaProdutos.cshtml"
               Write(Html.Raw(this.StatusPedido(item.Ativo)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td class=\"text-right\">\n                    <a class=\"btn btn-warning\" asp-controller=\"Produtos\" asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 978, "\"", 1001, 1);
#nullable restore
#line 33 "C:\Users\Desenvolvimento-02\Desktop\Dev\HandsWork\src\App\Views\Produtos\_ListaProdutos.cshtml"
WriteAttributeValue("", 993, item.Id, 993, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><spam class=\"fa fa-search\"></spam> </a>\n                    <a disable-by-claim-name=\"Produto\" disable-by-claim-value=\"Editar\" class=\"btn btn-info\" asp-controller=\"Produtos\" asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1194, "\"", 1217, 1);
#nullable restore
#line 34 "C:\Users\Desenvolvimento-02\Desktop\Dev\HandsWork\src\App\Views\Produtos\_ListaProdutos.cshtml"
WriteAttributeValue("", 1209, item.Id, 1209, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><spam class=\"fa fa-pencil-alt\"></spam> </a>\n                    <a supress-by-claim-name=\"Produto\" supress-by-claim-value=\"Excluir\" class=\"btn btn-danger\" asp-controller=\"Produtos\" asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1419, "\"", 1442, 1);
#nullable restore
#line 35 "C:\Users\Desenvolvimento-02\Desktop\Dev\HandsWork\src\App\Views\Produtos\_ListaProdutos.cshtml"
WriteAttributeValue("", 1434, item.Id, 1434, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><spam class=\"fa fa-trash\"></spam> </a>\n                </td>\n            </tr>\n");
#nullable restore
#line 38 "C:\Users\Desenvolvimento-02\Desktop\Dev\HandsWork\src\App\Views\Produtos\_ListaProdutos.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<App.ProdutoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
