#pragma checksum "D:\C++\5 semester\h\Lab1\Views\CalcService\AccessServiceDirectly.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ba95ce8a391b1991a7b4e749c8937f05b388cd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CalcService_AccessServiceDirectly), @"mvc.1.0.view", @"/Views/CalcService/AccessServiceDirectly.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ba95ce8a391b1991a7b4e749c8937f05b388cd5", @"/Views/CalcService/AccessServiceDirectly.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CalcService_AccessServiceDirectly : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\C++\5 semester\h\Lab1\Views\CalcService\AccessServiceDirectly.cshtml"
  
    ViewBag.Title = "AccessServiceDirectly - Backend1";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>AccessServiceDirectly</h1>\r\n\r\n<b>Rand value first:</b> ");
#nullable restore
#line 6 "D:\C++\5 semester\h\Lab1\Views\CalcService\AccessServiceDirectly.cshtml"
                    Write(Model.X);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n<b>Rand value second:</b> ");
#nullable restore
#line 7 "D:\C++\5 semester\h\Lab1\Views\CalcService\AccessServiceDirectly.cshtml"
                     Write(Model.Y);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\r\n\r\n<b>Add:</b><br />\r\n");
#nullable restore
#line 10 "D:\C++\5 semester\h\Lab1\Views\CalcService\AccessServiceDirectly.cshtml"
Write(Model.Sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n<b>Dif:</b><br />\r\n");
#nullable restore
#line 13 "D:\C++\5 semester\h\Lab1\Views\CalcService\AccessServiceDirectly.cshtml"
Write(Model.Dif);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n<b>Mult:</b><br/>\r\n");
#nullable restore
#line 16 "D:\C++\5 semester\h\Lab1\Views\CalcService\AccessServiceDirectly.cshtml"
Write(Model.Mult);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n<b>Div:</b><br/>\r\n");
#nullable restore
#line 19 "D:\C++\5 semester\h\Lab1\Views\CalcService\AccessServiceDirectly.cshtml"
Write(Model.Div);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
