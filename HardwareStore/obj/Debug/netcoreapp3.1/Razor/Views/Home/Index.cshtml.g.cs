#pragma checksum "C:\Users\Reilly\source\repos\HardwareStore\HardwareStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e661644836453dc72f8fafb36a6ce11e70255861"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e661644836453dc72f8fafb36a6ce11e70255861", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b3af2b8a99aa3c65f99ce9b79d74338895f6edf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TextField>
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
#nullable restore
#line 2 "C:\Users\Reilly\source\repos\HardwareStore\HardwareStore\Views\Home\Index.cshtml"
  
    ViewBag.Title = Model.MetaTitle;
    ViewBag.Description = Model.MetaDiscription;
    ViewBag.Keywords = Model.Meta;

#line default
#line hidden
#nullable disable
            WriteLiteral("<di<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e661644836453dc72f8fafb36a6ce11e702558613624", async() => {
                WriteLiteral(@"
<!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

<!-- Bootstrap CSS -->
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-BmbxuPwQa2lc/FVzBcNJ7UAyJxM6wuqIj61tLrc4wSX0szH/Ev+nYRRuWlolflfl"" crossorigin=""anonymous"">

    <title>Hello, world!</title>


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

    <div id=""myCarousel"" class=""carousel slide caronsel-item""  data-bs-ride=""carousel"">
        <div class=""carousel-indicators"">
            <button type=""button"" data-bs-target=""#myCarousel"" data-bs-slide-to=""0"" class=""active"" aria-current=""true"" aria-label=""Slide 1""></button>
            <button type=""button"" data-bs-target=""#myCarousel"" data-bs-slide-to=""1"" aria-label=""Slide 2""></button>
            <button type=""button"" data-bs-target=""#myCarousel"" data-bs-slide-to=""2"" aria-label=""Slide 3""></button>
        </div>
        <div class=""carousel-inner"">
            <div class=""carousel-item active"">
                <svg class=""bd-placeholder-img"" width=""0%"" height=""-1px"" xmlns=""http://www.w3.org/2000/svg"" aria-hidden=""true"" preserveAspectRatio=""xMidYMid slice"" focusable=""true"">
                    <img src=""/images/Ban1.1.jpg"" width=""100%"" height=""100%"" class=""img-fluid"" alt=""Responsive image"">
                </svg>
                <div class=""container"">
                    <div class=""car");
            WriteLiteral(@"ousel-caption text-start"">
                        <h1>Текст</h1>
                        <p>Бла бла</p>
                        <p>

                            <a class=""btn btn-lg btn-primary"" href=""#"">
                              fsdfsdfdsf
                            </a>
                        </p>
                    </div>
                </div>
            </div>
            <div class=""carousel-item"">
                <svg class=""bd-placeholder-img"" width=""0%"" height=""-1px"" "" xmlns=""http://www.w3.org/2000/svg"" aria-hidden=""true"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"">
                    <img src=""/images/Ban2.jpg"" width=""100%"" height=""100%""  class=""img-fluid"" alt=""Responsive image"">
                </svg>

                <div class=""container"">
                    <div class=""carousel-caption"">
                        <h1>Текст</h1>
                        <p>Бла бла</p>
                        <p><a class=""btn btn-lg btn-primary"" href=""#"">Learn more</a></p>");
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""carousel-item"">
                <svg class=""bd-placeholder-img"" width=""0%"" height=""-1px"" "" xmlns=""http://www.w3.org/2000/svg"" aria-hidden=""true"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"">
                    <img src=""/images/Ban3.jpg"" width=""100%"" height=""100%"" class=""img-fluid"" alt=""Responsive image"">
                </svg>

                <div class=""container"">
                    <div class=""carousel-caption text-end"">
                        <h1>Текст</h1>
                        <p>Бла бла</p>
                        <p><a class=""btn btn-lg btn-primary"" href=""#"">Browse gallery</a></p>
                    </div>
                </div>
            </div>
        </div>
        <a class=""carousel-control-prev"" type=""button"" data-bs-target=""#myCarousel"" data-bs-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""vis");
            WriteLiteral(@"ually-hidden"">Previous</span>
        </a>
        <a class=""carousel-control-next"" type=""button"" data-bs-target=""#myCarousel"" data-bs-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""visually-hidden"">Next</span>
        </a>
    </div>

    <div>
        <h1>Преимущество нашего магазина</h1>
        <div>
            <img src=""/images/Prem.jpg"" width=""100%"" height=""100%"" class=""img-fluid"" alt=""Responsive image"">
        </div>
     </div>

    <div>  Бренды </div>
    <div>
        ");
#nullable restore
#line 92 "C:\Users\Reilly\source\repos\HardwareStore\HardwareStore\Views\Home\Index.cshtml"
   Write(Html.Raw(Model.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <div> 2 свежие новости </div>


    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-b5kHyXgcpbZJO/tY9Ul7kGkf1S0CWuKcCD38l8YkeH8z8QjE0GmW1gYU5S9FOnJ0"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popperjs/core@2.6.0/dist/umd/popper.min.js"" integrity=""sha384-KsvD1yqQ1/1+IA7gi3P0tyJcT3vR+NdBTt13hSJ2lnve8agRGXTTyNaBYmCR/Nwi"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/js/bootstrap.min.js"" integrity=""sha384-nsg8ua9HAw1y0W1btsyWgBklPnCUAFLuTMS2G72MMONqmOymq585AcH49TLBQObG"" crossorigin=""anonymous""></script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TextField> Html { get; private set; }
    }
}
#pragma warning restore 1591
