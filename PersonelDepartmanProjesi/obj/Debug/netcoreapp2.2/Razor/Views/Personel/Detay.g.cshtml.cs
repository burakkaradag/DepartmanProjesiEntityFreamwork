#pragma checksum "C:\Users\pc\source\repos\PersonelDepartmanProjesi\PersonelDepartmanProjesi\Views\Personel\Detay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51287d586bacac5eadb9ead04cb2215a01bab256"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personel_Detay), @"mvc.1.0.view", @"/Views/Personel/Detay.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Personel/Detay.cshtml", typeof(AspNetCore.Views_Personel_Detay))]
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
#line 1 "C:\Users\pc\source\repos\PersonelDepartmanProjesi\PersonelDepartmanProjesi\Views\_ViewImports.cshtml"
using PersonelDepartmanProjesi;

#line default
#line hidden
#line 2 "C:\Users\pc\source\repos\PersonelDepartmanProjesi\PersonelDepartmanProjesi\Views\_ViewImports.cshtml"
using PersonelDepartmanProjesi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51287d586bacac5eadb9ead04cb2215a01bab256", @"/Views/Personel/Detay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50665103c87c9a8dbd293bd8f535405a3c6b20b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Personel_Detay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonelDepartmanProjesi.Models.PersonelModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\pc\source\repos\PersonelDepartmanProjesi\PersonelDepartmanProjesi\Views\Personel\Detay.cshtml"
  
    ViewData["Title"] = "Detay";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(144, 129, true);
            WriteLiteral("\r\n<h1>Detay</h1>\r\n\r\n<div>\r\n    <h4>Ogrenciler</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(274, 47, false);
#line 15 "C:\Users\pc\source\repos\PersonelDepartmanProjesi\PersonelDepartmanProjesi\Views\Personel\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.Personel.Id));

#line default
#line hidden
            EndContext();
            BeginContext(321, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(383, 43, false);
#line 18 "C:\Users\pc\source\repos\PersonelDepartmanProjesi\PersonelDepartmanProjesi\Views\Personel\Detay.cshtml"
       Write(Html.DisplayFor(model => model.Personel.Id));

#line default
#line hidden
            EndContext();
            BeginContext(426, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(487, 47, false);
#line 21 "C:\Users\pc\source\repos\PersonelDepartmanProjesi\PersonelDepartmanProjesi\Views\Personel\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.Personel.Ad));

#line default
#line hidden
            EndContext();
            BeginContext(534, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(596, 43, false);
#line 24 "C:\Users\pc\source\repos\PersonelDepartmanProjesi\PersonelDepartmanProjesi\Views\Personel\Detay.cshtml"
       Write(Html.DisplayFor(model => model.Personel.Ad));

#line default
#line hidden
            EndContext();
            BeginContext(639, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(700, 50, false);
#line 27 "C:\Users\pc\source\repos\PersonelDepartmanProjesi\PersonelDepartmanProjesi\Views\Personel\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.Personel.Soyad));

#line default
#line hidden
            EndContext();
            BeginContext(750, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(812, 46, false);
#line 30 "C:\Users\pc\source\repos\PersonelDepartmanProjesi\PersonelDepartmanProjesi\Views\Personel\Detay.cshtml"
       Write(Html.DisplayFor(model => model.Personel.Soyad));

#line default
#line hidden
            EndContext();
            BeginContext(858, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(919, 53, false);
#line 33 "C:\Users\pc\source\repos\PersonelDepartmanProjesi\PersonelDepartmanProjesi\Views\Personel\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.Personel.Bolum.Ad));

#line default
#line hidden
            EndContext();
            BeginContext(972, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1034, 49, false);
#line 36 "C:\Users\pc\source\repos\PersonelDepartmanProjesi\PersonelDepartmanProjesi\Views\Personel\Detay.cshtml"
       Write(Html.DisplayFor(model => model.Personel.Bolum.Ad));

#line default
#line hidden
            EndContext();
            BeginContext(1083, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1131, 68, false);
#line 41 "C:\Users\pc\source\repos\PersonelDepartmanProjesi\PersonelDepartmanProjesi\Views\Personel\Detay.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1199, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1207, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51287d586bacac5eadb9ead04cb2215a01bab2568091", async() => {
                BeginContext(1229, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(1245, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonelDepartmanProjesi.Models.PersonelModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
