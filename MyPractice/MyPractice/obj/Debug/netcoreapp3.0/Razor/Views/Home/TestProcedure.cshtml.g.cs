#pragma checksum "D:\Programming\Other\Practice for ASP.NET CORE 3.0\MyPractice\MyPractice\Views\Home\TestProcedure.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76954a2cb8e5786f61fa3befe3c705c6afa98f97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TestProcedure), @"mvc.1.0.view", @"/Views/Home/TestProcedure.cshtml")]
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
#line 1 "D:\Programming\Other\Practice for ASP.NET CORE 3.0\MyPractice\MyPractice\Views\_ViewImports.cshtml"
using MyPractice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\Other\Practice for ASP.NET CORE 3.0\MyPractice\MyPractice\Views\_ViewImports.cshtml"
using MyPractice.DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Programming\Other\Practice for ASP.NET CORE 3.0\MyPractice\MyPractice\Views\_ViewImports.cshtml"
using MyPractice.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Programming\Other\Practice for ASP.NET CORE 3.0\MyPractice\MyPractice\Views\_ViewImports.cshtml"
using MyPractice.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Programming\Other\Practice for ASP.NET CORE 3.0\MyPractice\MyPractice\Views\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76954a2cb8e5786f61fa3befe3c705c6afa98f97", @"/Views/Home/TestProcedure.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f91514b89df7d466201a348cf12db77f4aa1807d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TestProcedure : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Table1>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Programming\Other\Practice for ASP.NET CORE 3.0\MyPractice\MyPractice\Views\Home\TestProcedure.cshtml"
  
    ViewData["Title"] = "TestProcedure";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Programming\Other\Practice for ASP.NET CORE 3.0\MyPractice\MyPractice\Views\Home\TestProcedure.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 9 "D:\Programming\Other\Practice for ASP.NET CORE 3.0\MyPractice\MyPractice\Views\Home\TestProcedure.cshtml"
  Write(Convert.ToBase64String(item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 10 "D:\Programming\Other\Practice for ASP.NET CORE 3.0\MyPractice\MyPractice\Views\Home\TestProcedure.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Table1>> Html { get; private set; }
    }
}
#pragma warning restore 1591
