#pragma checksum "C:\Users\RRaczak\source\repos\DevBuild\GC_MovieDatabase_Dapper\GC_MovieDatabase_Dapper\Views\Movierentals\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e4e1f2d181a2568c97b68ce92a064b69b8b3713"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movierentals_Details), @"mvc.1.0.view", @"/Views/Movierentals/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e4e1f2d181a2568c97b68ce92a064b69b8b3713", @"/Views/Movierentals/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e13221d37b520f70dd83cb5479fba6c629a4560a", @"/Views/_ViewImports.cshtml")]
    public class Views_Movierentals_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListMovies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movierentals", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div>\r\n    <p>\r\n        Title: ");
#nullable restore
#line 6 "C:\Users\RRaczak\source\repos\DevBuild\GC_MovieDatabase_Dapper\GC_MovieDatabase_Dapper\Views\Movierentals\Details.cshtml"
          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        Year: ");
#nullable restore
#line 7 "C:\Users\RRaczak\source\repos\DevBuild\GC_MovieDatabase_Dapper\GC_MovieDatabase_Dapper\Views\Movierentals\Details.cshtml"
         Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        Genre: ");
#nullable restore
#line 8 "C:\Users\RRaczak\source\repos\DevBuild\GC_MovieDatabase_Dapper\GC_MovieDatabase_Dapper\Views\Movierentals\Details.cshtml"
          Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        Runtime: ");
#nullable restore
#line 9 "C:\Users\RRaczak\source\repos\DevBuild\GC_MovieDatabase_Dapper\GC_MovieDatabase_Dapper\Views\Movierentals\Details.cshtml"
            Write(Model.Runtime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" min<br />\r\n    </p>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e4e1f2d181a2568c97b68ce92a064b69b8b37135099", async() => {
                WriteLiteral("<button>Back</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
