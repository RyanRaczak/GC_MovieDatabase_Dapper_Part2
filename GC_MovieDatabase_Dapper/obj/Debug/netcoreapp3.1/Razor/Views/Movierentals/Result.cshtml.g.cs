#pragma checksum "C:\Users\RRaczak\source\repos\DevBuild\GC_MovieDatabase_Dapper\GC_MovieDatabase_Dapper\Views\Movierentals\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f8b280997ca8a738c19af1d0093b9964085ac3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movierentals_Result), @"mvc.1.0.view", @"/Views/Movierentals/Result.cshtml")]
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
#line 1 "C:\Users\RRaczak\source\repos\DevBuild\GC_MovieDatabase_Dapper\GC_MovieDatabase_Dapper\Views\_ViewImports.cshtml"
using GC_MovieDatabase_Dapper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RRaczak\source\repos\DevBuild\GC_MovieDatabase_Dapper\GC_MovieDatabase_Dapper\Views\_ViewImports.cshtml"
using GC_MovieDatabase_Dapper.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f8b280997ca8a738c19af1d0093b9964085ac3f", @"/Views/Movierentals/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e13221d37b520f70dd83cb5479fba6c629a4560a", @"/Views/_ViewImports.cshtml")]
    public class Views_Movierentals_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<h2>Success!</h2>\r\n<h4>");
#nullable restore
#line 4 "C:\Users\RRaczak\source\repos\DevBuild\GC_MovieDatabase_Dapper\GC_MovieDatabase_Dapper\Views\Movierentals\Result.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has been added</h4>\r\n<div>\r\n    <p>\r\n        Title: ");
#nullable restore
#line 7 "C:\Users\RRaczak\source\repos\DevBuild\GC_MovieDatabase_Dapper\GC_MovieDatabase_Dapper\Views\Movierentals\Result.cshtml"
          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        Year: ");
#nullable restore
#line 8 "C:\Users\RRaczak\source\repos\DevBuild\GC_MovieDatabase_Dapper\GC_MovieDatabase_Dapper\Views\Movierentals\Result.cshtml"
         Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        Genre: ");
#nullable restore
#line 9 "C:\Users\RRaczak\source\repos\DevBuild\GC_MovieDatabase_Dapper\GC_MovieDatabase_Dapper\Views\Movierentals\Result.cshtml"
          Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        Runtime: ");
#nullable restore
#line 10 "C:\Users\RRaczak\source\repos\DevBuild\GC_MovieDatabase_Dapper\GC_MovieDatabase_Dapper\Views\Movierentals\Result.cshtml"
            Write(Model.Runtime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" min<br />\r\n    </p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591