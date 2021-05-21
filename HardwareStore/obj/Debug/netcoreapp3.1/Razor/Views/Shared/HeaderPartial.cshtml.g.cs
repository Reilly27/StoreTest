#pragma checksum "C:\Users\Reilly\source\repos\HardwareStore\HardwareStore\Views\Shared\HeaderPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff4f16941b670514fcb5ac09b73afaf2821ee935"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_HeaderPartial), @"mvc.1.0.view", @"/Views/Shared/HeaderPartial.cshtml")]
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
#line 1 "C:\Users\Reilly\source\repos\HardwareStore\HardwareStore\Views\_ViewImports.cshtml"
using HardwareStore.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Reilly\source\repos\HardwareStore\HardwareStore\Views\_ViewImports.cshtml"
using HardwareStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Reilly\source\repos\HardwareStore\HardwareStore\Views\_ViewImports.cshtml"
using HardwareStore.Domain.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff4f16941b670514fcb5ac09b73afaf2821ee935", @"/Views/Shared/HeaderPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b3af2b8a99aa3c65f99ce9b79d74338895f6edf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_HeaderPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff4f16941b670514fcb5ac09b73afaf2821ee9353380", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">  
    <link href=""https://fonts.googleapis.com/css2?family=Cabin:wght@600&display=swap"" rel=""stylesheet"">
    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha38z4-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
");
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
            WriteLiteral(@"

    <nav class=""navbar navbar-expand-lg navbar-light bg-light"" id=""header-wrapper"">
        <div class=""container"">
            <nav class=""navbar navbar-light bg-light"">
                <a class=""navbar-brand"" href=""/"">
                    <img src=""/images/123.JPG"" width=""70"" height=""30"" class=""d-inline-block align-top""");
            BeginWriteAttribute("alt", " alt=\"", 949, "\"", 955, 0);
            EndWriteAttribute();
            WriteLiteral(@">                 
                </a>
            </nav>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>

            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <ul class=""navbar-nav mr-auto "">
                    <li class=""nav-item"">
                        <a class=""nav-link""  href=""/home/Contacts"">О компании</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/home/Info"">Информация</a>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle font-weight-bold"" href=""/Services/Index"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-");
            WriteLiteral(@"expanded=""false"">
                            Услуги
                        </a>
                        <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                            <a class=""dropdown-item"" href=""/Services/One"">Промышленные полы</a>
                            <a class=""dropdown-item"" href=""/Services/2"">Наливные полы</a>
                            <a class=""dropdown-item"" href=""/Services/3"">Полимерные/эпоксидные полы</a>
                            <a class=""dropdown-item"" href=""/Services/4"">Антистатические полы</a>
                            <a class=""dropdown-item"" href=""/Services/5"">Бетонные полы</a>
                            <a class=""dropdown-item"" href=""#"">Пылесосы</a>
                            <a class=""dropdown-item"" href=""#"">Тележки для топпинга</a>
                            <a class=""dropdown-item"" href=""#"">Топпинговые полы</a>
                            <a class=""dropdown-item"" href=""#"">Пады, Франкфурты</a>
                            <a class=""dr");
            WriteLiteral(@"opdown-item"" href=""#"">Затирочные диски</a>
                            <a class=""dropdown-item"" href=""#"">Краски колеруемые всех сегментов цены</a>
                            <a class=""dropdown-item"" href=""#"">Шлифовальные машины</a>
                            <a class=""dropdown-item"" href=""#"">Грунтовки всех видов для полов и для отделки</a>
                            <a class=""dropdown-item"" href=""#"">Растворители</a>
                            <a class=""dropdown-item"" href=""#"">Штукатурка</a>
                            <a class=""dropdown-item"" href=""#"">Шпаклёвка</a>
                            <a class=""dropdown-item"" href=""#"">Клей для плитки</a>
                            <a class=""dropdown-item"" href=""#"">Шланги</a>
                            <a class=""dropdown-item"" href=""#"">Стекловата</a>
                            <a class=""dropdown-item"" href=""#"">И многие инструменты для</a>
                            <a class=""dropdown-item"" href=""#"">Отделки помещений,валики шпатели и тд</a>           ");
            WriteLiteral(@"              
                            
                        </div>
                    <li class=""nav-item"">
                        <a class=""nav-link font-weight-normal"" href=""/home/News"" >Новости</a>
                    </li>


                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/home/Contacts"">Контакты</a>
                    </li>

                </ul>

                <a class=""navbar-brand"" href=""#"">
                    <img src=""/images/whats.png"" width=""20"" height=""20"" class=""d-inline-block align-top""");
            BeginWriteAttribute("alt", " alt=\"", 4607, "\"", 4613, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n                <a class=\"navbar-brand\" href=\"#\">\r\n                    <img src=\"/images/inst.png\" width=\"20\" height=\"20\" class=\"d-inline-block align-top\"");
            BeginWriteAttribute("alt", " alt=\"", 4793, "\"", 4799, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n                <a class=\"navbar-brand\" href=\"#\">\r\n                    <img src=\"/images/TG.png\" width=\"20\" height=\"20\" class=\"d-inline-block align-top\"");
            BeginWriteAttribute("alt", " alt=\"", 4977, "\"", 4983, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </a>

                <div class=""menu right d-flex justify-content-end"">

                    <div class=""menu-contact"" style=""margin-right:25px"">
                        <ul class=""navbar-nav mr-auto "">
                            <li class=""nav-item"">
                                <a class=""nav-link text-dark"" href=""#"" style=""font-family:Cabin;""> +996-555-000-000</a>
                            </li>
                        </ul>

                    </div>

                    <button class=""btn btn-outline-primary my-2 my-sm-0"" type=""submit"">Заказать звонок</button>

                </div>

            </div>
            </div>
        </div>
    </nav>



    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://cd");
            WriteLiteral(@"njs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>

</html>");
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
