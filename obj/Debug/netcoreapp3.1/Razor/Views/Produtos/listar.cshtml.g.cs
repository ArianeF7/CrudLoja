#pragma checksum "C:\Users\AAFA\Desktop\CrudLoja\Views\Produtos\listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "195e6010c98823323abd2388a47d8fefd03226cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_listar), @"mvc.1.0.view", @"/Views/Produtos/listar.cshtml")]
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
#line 1 "C:\Users\AAFA\Desktop\CrudLoja\Views\_ViewImports.cshtml"
using CrudLoja;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AAFA\Desktop\CrudLoja\Views\_ViewImports.cshtml"
using CrudLoja.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"195e6010c98823323abd2388a47d8fefd03226cc", @"/Views/Produtos/listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aff530fec794e934f17714630c36dae1f580bae7", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CrudLoja.Models.Produto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h2>Todos os Produtos</h2>    \r\n</div>\r\n\r\n<a href=\"/Produtos/Cadastrar\" class=\"btn btn-success\">Novo prdouto</a>\r\n<hr>\r\n");
#nullable restore
#line 10 "C:\Users\AAFA\Desktop\CrudLoja\Views\Produtos\listar.cshtml"
 foreach (var produto in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5>Nome: ");
#nullable restore
#line 12 "C:\Users\AAFA\Desktop\CrudLoja\Views\Produtos\listar.cshtml"
         Write(produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <h5>Cor: ");
#nullable restore
#line 13 "C:\Users\AAFA\Desktop\CrudLoja\Views\Produtos\listar.cshtml"
        Write(produto.Cor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <h5>Quantidade: ");
#nullable restore
#line 14 "C:\Users\AAFA\Desktop\CrudLoja\Views\Produtos\listar.cshtml"
               Write(produto.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <h5>Valor: ");
#nullable restore
#line 15 "C:\Users\AAFA\Desktop\CrudLoja\Views\Produtos\listar.cshtml"
          Write(produto.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 390, "\"", 425, 2);
            WriteAttributeValue("", 397, "/Produtos/Editar/", 397, 17, true);
#nullable restore
#line 16 "C:\Users\AAFA\Desktop\CrudLoja\Views\Produtos\listar.cshtml"
WriteAttributeValue("", 414, produto.Id, 414, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Editar</a>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 466, "\"", 502, 2);
            WriteAttributeValue("", 473, "/Produtos/Deletar/", 473, 18, true);
#nullable restore
#line 17 "C:\Users\AAFA\Desktop\CrudLoja\Views\Produtos\listar.cshtml"
WriteAttributeValue("", 491, produto.Id, 491, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Deletar</a>\r\n    <hr>\r\n");
#nullable restore
#line 19 "C:\Users\AAFA\Desktop\CrudLoja\Views\Produtos\listar.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CrudLoja.Models.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591