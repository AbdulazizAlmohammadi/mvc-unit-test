#pragma checksum "D:\Developing\Tuwaiq\unitTesting\Projects\mvc-unit-test\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\EzzRestaurant\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "863eba73bc97387121342b3ca2ddc0fc6a46abcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 1 "D:\Developing\Tuwaiq\unitTesting\Projects\mvc-unit-test\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\EzzRestaurant\Views\_ViewImports.cshtml"
using EzzRestaurant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Developing\Tuwaiq\unitTesting\Projects\mvc-unit-test\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\EzzRestaurant\Views\_ViewImports.cshtml"
using EzzRestaurant.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"863eba73bc97387121342b3ca2ddc0fc6a46abcb", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cba069cdf966acd37fd9b421a878de2cb9c65fb3", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\Developing\Tuwaiq\unitTesting\Projects\mvc-unit-test\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\EzzRestaurant\Views\Products\Index.cshtml"
  

    string bgImage = "/pexels-lumn.jpg";
    var products = (List<ProductModel>) ViewData["Products"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("class", " class=\"", 120, "\"", 128, 0);
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 129, "\"", 225, 11);
            WriteAttributeValue("", 137, "background:", 137, 11, true);
            WriteAttributeValue(" ", 148, "url(", 149, 5, true);
#nullable restore
#line 7 "D:\Developing\Tuwaiq\unitTesting\Projects\mvc-unit-test\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\EzzRestaurant\Views\Products\Index.cshtml"
WriteAttributeValue("", 153, bgImage, 153, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 161, ")", 161, 1, true);
            WriteAttributeValue(" ", 162, "no-repeat", 163, 10, true);
            WriteAttributeValue(" ", 172, "center", 173, 7, true);
            WriteAttributeValue(" ", 179, "center;", 180, 8, true);
            WriteAttributeValue(" ", 187, "background-size:", 188, 17, true);
            WriteAttributeValue(" ", 204, "cover;", 205, 7, true);
            WriteAttributeValue(" ", 211, "height:", 212, 8, true);
            WriteAttributeValue(" ", 219, "800px", 220, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"text-center\" style=\"height: 800px; background-color: rgba(0,0,0,0.5); \">\r\n        <nav class=\"navbar navbar-expand-sm navbar-toggleable-sm navbar-dark mb-3\">\r\n            <div class=\"container\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "863eba73bc97387121342b3ca2ddc0fc6a46abcb7294", async() => {
                WriteLiteral("Ezz Restaurant");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target="".navbar-collapse"" aria-controls=""navbarSupportedContent""
                        aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""navbar-collapse collapse d-sm-inline-flex justify-content-between"">
                    <ul class=""navbar-nav flex-grow-1"">
                        <li class=""nav-item"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "863eba73bc97387121342b3ca2ddc0fc6a46abcb9520", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "863eba73bc97387121342b3ca2ddc0fc6a46abcb11274", async() => {
                WriteLiteral("Categories");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n                        <li class=\"nav-item\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "863eba73bc97387121342b3ca2ddc0fc6a46abcb13035", async() => {
                WriteLiteral("Products");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        <div style="" height:100%; display:flex; flex-direction:column;justify-content: center"">
            <h1 class=""display-4"" style=""color: white; font-size: 120px; font-weight: bold; font-family: Pattaya,serif;"">Products</h1>
            
        </div>
    </div>
</div>

<div class=""Homebody container "">
    <div class=""row"">
");
#nullable restore
#line 40 "D:\Developing\Tuwaiq\unitTesting\Projects\mvc-unit-test\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\EzzRestaurant\Views\Products\Index.cshtml"
     foreach (var product in products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-4 \">\r\n           \r\n            <div class=\"category-card box-shadow\"");
            BeginWriteAttribute("style", " style=\"", 2221, "\"", 2265, 4);
            WriteAttributeValue("", 2229, "background-image:", 2229, 17, true);
            WriteAttributeValue(" ", 2246, "url(", 2247, 5, true);
#nullable restore
#line 44 "D:\Developing\Tuwaiq\unitTesting\Projects\mvc-unit-test\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\EzzRestaurant\Views\Products\Index.cshtml"
WriteAttributeValue("", 2251, product.img, 2251, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2263, ");", 2263, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"category-body\" style=\"display: flex ; flex-direction: column\">\r\n                    \r\n                    <h4 style=\"color: white; font-weight: bold\">");
#nullable restore
#line 47 "D:\Developing\Tuwaiq\unitTesting\Projects\mvc-unit-test\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\EzzRestaurant\Views\Products\Index.cshtml"
                                                           Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h5 style=\"color: white; font-weight: bold\">");
#nullable restore
#line 48 "D:\Developing\Tuwaiq\unitTesting\Projects\mvc-unit-test\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\EzzRestaurant\Views\Products\Index.cshtml"
                                                           Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</h5>\r\n                </div>\r\n            </div>\r\n            \r\n        </div>\r\n");
#nullable restore
#line 53 "D:\Developing\Tuwaiq\unitTesting\Projects\mvc-unit-test\Project01_ASP.NET_MVC\Project01_ASP.NET_MVC\EzzRestaurant\Views\Products\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
