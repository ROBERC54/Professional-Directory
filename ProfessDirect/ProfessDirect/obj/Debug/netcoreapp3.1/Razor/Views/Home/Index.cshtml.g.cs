#pragma checksum "C:\Users\trapa\source\repos\Professional-Directory\ProfessDirect\ProfessDirect\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "471cd59922a130b49db336e9754925cdf248e3e4"
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
#line 1 "C:\Users\trapa\source\repos\Professional-Directory\ProfessDirect\ProfessDirect\Views\_ViewImports.cshtml"
using ProfessDirect;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\trapa\source\repos\Professional-Directory\ProfessDirect\ProfessDirect\Views\_ViewImports.cshtml"
using ProfessDirect.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"471cd59922a130b49db336e9754925cdf248e3e4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfab4d1cf67944a312885333da8cd6e067ac89b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\trapa\source\repos\Professional-Directory\ProfessDirect\ProfessDirect\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
</div>

<div class=""jumbotron"">
    <h1>ProfessDirect</h1>
    <p class=""lead"">Take the Next Step | Connect.</p>
    <p><a href=""https://github.com/ROBERC54/Professional-Directory"" class=""btn btn-primary btn-lg"">Learn more &raquo;</a></p>
    <!--
        <div>
        <a class=""btn btn-default""
           ");
#nullable restore
#line 16 "C:\Users\trapa\source\repos\Professional-Directory\ProfessDirect\ProfessDirect\Views\Home\Index.cshtml"
      Write(Html.ActionLink("List of contacts", "Index", "Contacts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <a class=\"btn btn-default\"\r\n        ");
#nullable restore
#line 18 "C:\Users\trapa\source\repos\Professional-Directory\ProfessDirect\ProfessDirect\Views\Home\Index.cshtml"
   Write(Html.ActionLink("List of files", "Index", "Files"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    -->
</div>
<div class=""row"">
    <div class=""col-md-4"">
        <h2>Diving into ProfessDirect</h2>
        <p>
            ProfessDirect gives you a powerful, systematic approach to enable leaders to more expediently assess and target professional relationships that are conducive/detrimental in light of current market trends.
        </p>
        <p><a class=""btn btn-default"" href=""https://github.com/ROBERC54/Professional-Directory"">Learn more &raquo;</a></p>
    </div>
    <div class=""col-md-4"">
        <h2>Enhance your connections</h2>
        <p>ProfessDirect is relationship management tool that makes it easy to add, remove, and update professional connections.</p>
        <p><a class=""btn btn-default"" href=""https://github.com/ROBERC54/Professional-Directory"">Learn more &raquo;</a></p>
    </div>
    <div class=""col-md-4"">
        <h2>Don't Go Alone</h2>
        <p>You can easily reach out to contacts; offer your hand in jolly cooperation via built in links to major s");
            WriteLiteral("ocial media platforms.</p>\r\n        <p><a class=\"btn btn-default\" href=\"https://github.com/ROBERC54/Professional-Directory\">Learn more &raquo;</a></p>\r\n    </div>\r\n</div>");
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
