#pragma checksum "C:\Users\User\source\repos\Lab5\Lab5\Views\Employees\_ViewStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9945ba61a9c96e34d5859959cf008b1b54966fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees__ViewStart), @"mvc.1.0.view", @"/Views/Employees/_ViewStart.cshtml")]
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
#line 1 "C:\Users\User\source\repos\Lab5\Lab5\Views\_ViewImports.cshtml"
using Lab7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\Lab5\Lab5\Views\_ViewImports.cshtml"
using Lab7.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9945ba61a9c96e34d5859959cf008b1b54966fd", @"/Views/Employees/_ViewStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca9c45965cdb4328646c2d59bfb24b4086998780", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees__ViewStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\source\repos\Lab5\Lab5\Views\Employees\_ViewStart.cshtml"
  
    List<TopMenuItem> topMenu = new List<TopMenuItem>();
    topMenu.Add(new TopMenuItem { AspAction = "Index", AspController = "Students", DisplayText = "Students" });
    topMenu.Add(new TopMenuItem { AspAction = "Index", AspController = "Courses", DisplayText = "Courses" });
    topMenu.Add(new TopMenuItem { AspAction = "Index", AspController = "AcademicRecords", DisplayText = "Student Records" });

    ViewData["topMenu"] = topMenu;
    ViewData["Title"] = "Employees";
    Layout = "~/Views/Shared/_ACLayout.cshtml";

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
