#pragma checksum "C:\Users\12063\Documents\Documents\CodingDojo\BeltPrep_CSharp\Wedding_Planner_Two\Views\Wedding\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8148f9c0112965d40241720684068b96f787462"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wedding_Detail), @"mvc.1.0.view", @"/Views/Wedding/Detail.cshtml")]
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
#line 1 "C:\Users\12063\Documents\Documents\CodingDojo\BeltPrep_CSharp\Wedding_Planner_Two\Views\_ViewImports.cshtml"
using Wedding_Planner_Two;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\12063\Documents\Documents\CodingDojo\BeltPrep_CSharp\Wedding_Planner_Two\Views\_ViewImports.cshtml"
using Wedding_Planner_Two.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\12063\Documents\Documents\CodingDojo\BeltPrep_CSharp\Wedding_Planner_Two\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8148f9c0112965d40241720684068b96f787462", @"/Views/Wedding/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fed41ee7588cea07dbe807ee5ff4ddcd9f68908", @"/Views/_ViewImports.cshtml")]
    public class Views_Wedding_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wedding>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1>\r\n    ");
#nullable restore
#line 5 "C:\Users\12063\Documents\Documents\CodingDojo\BeltPrep_CSharp\Wedding_Planner_Two\Views\Wedding\Detail.cshtml"
Write(Model.WedderOne);

#line default
#line hidden
#nullable disable
            WriteLiteral(" and ");
#nullable restore
#line 5 "C:\Users\12063\Documents\Documents\CodingDojo\BeltPrep_CSharp\Wedding_Planner_Two\Views\Wedding\Detail.cshtml"
                    Write(Model.WedderTwo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s Wedding\r\n    </h1>\r\n    <h2>");
#nullable restore
#line 7 "C:\Users\12063\Documents\Documents\CodingDojo\BeltPrep_CSharp\Wedding_Planner_Two\Views\Wedding\Detail.cshtml"
   Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h2>Guests:</h2>\r\n");
#nullable restore
#line 9 "C:\Users\12063\Documents\Documents\CodingDojo\BeltPrep_CSharp\Wedding_Planner_Two\Views\Wedding\Detail.cshtml"
     foreach (var guest in Model.Guests)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>\r\n        <ul>");
#nullable restore
#line 12 "C:\Users\12063\Documents\Documents\CodingDojo\BeltPrep_CSharp\Wedding_Planner_Two\Views\Wedding\Detail.cshtml"
       Write(guest.UsersAttending.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\12063\Documents\Documents\CodingDojo\BeltPrep_CSharp\Wedding_Planner_Two\Views\Wedding\Detail.cshtml"
                                       Write(guest.UsersAttending.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n    </h2>\r\n");
#nullable restore
#line 14 "C:\Users\12063\Documents\Documents\CodingDojo\BeltPrep_CSharp\Wedding_Planner_Two\Views\Wedding\Detail.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wedding> Html { get; private set; }
    }
}
#pragma warning restore 1591