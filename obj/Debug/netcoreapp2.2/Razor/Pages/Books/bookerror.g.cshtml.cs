#pragma checksum "C:\Users\YH\source\repos\MyApp\Pages\Books\bookerror.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f955ab80b74111ef5077b8c96ed97c3c56e5b8de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Pages.Books.Pages_Books_bookerror), @"mvc.1.0.razor-page", @"/Pages/Books/bookerror.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Books/bookerror.cshtml", typeof(MyApp.Pages.Books.Pages_Books_bookerror), null)]
namespace MyApp.Pages.Books
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\YH\source\repos\MyApp\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\YH\source\repos\MyApp\Pages\_ViewImports.cshtml"
using MyApp;

#line default
#line hidden
#line 3 "C:\Users\YH\source\repos\MyApp\Pages\_ViewImports.cshtml"
using MyApp.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f955ab80b74111ef5077b8c96ed97c3c56e5b8de", @"/Pages/Books/bookerror.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e7a81e891cd65e1fe272e90273b30f2cb1706dc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Books_bookerror : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\YH\source\repos\MyApp\Pages\Books\bookerror.cshtml"
  
    ViewData["Title"] = "bookerror";

#line default
#line hidden
            BeginContext(93, 62, true);
            WriteLiteral("\r\n<h1>Error</h1>\r\n<h4>You can not update other\'s book</h4>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Pages.Books.bookerrorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Pages.Books.bookerrorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Pages.Books.bookerrorModel>)PageContext?.ViewData;
        public MyApp.Pages.Books.bookerrorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
