#pragma checksum "C:\Users\MERT\OneDrive\Masaüstü\ASP.Net Core 5.0 Proje Kampı\Core_Proje\Core_Proje\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14a72bc42593f1ed0751a62a54be28ce6a431140"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
#line 1 "C:\Users\MERT\OneDrive\Masaüstü\ASP.Net Core 5.0 Proje Kampı\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MERT\OneDrive\Masaüstü\ASP.Net Core 5.0 Proje Kampı\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\MERT\OneDrive\Masaüstü\ASP.Net Core 5.0 Proje Kampı\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14a72bc42593f1ed0751a62a54be28ce6a431140", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\MERT\OneDrive\Masaüstü\ASP.Net Core 5.0 Proje Kampı\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card-header border-0"">
    <h3 class=""mb-0"">Hizmet Listesi Tablosu</h3>
</div>
<!-- Light table -->
<div class=""table-responsive"">
    <table class=""table align-items-center table-flush"">
        <thead class=""thead"">
            <tr>
                <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Başlık</th>
                <th scope=""col"" class=""sort"" data-sort=""status"">Görsel</th>
                <th scope=""col"" class=""sort"">Sil</th>
                <th scope=""col"" class=""sort"" data-sort=""completion"">Düzenle</th>
            </tr>
        </thead>
        <tbody class=""list"">
");
#nullable restore
#line 25 "C:\Users\MERT\OneDrive\Masaüstü\ASP.Net Core 5.0 Proje Kampı\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 29 "C:\Users\MERT\OneDrive\Masaüstü\ASP.Net Core 5.0 Proje Kampı\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
                   Write(item.ServiceID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th class=\"budget\">\r\n                        ");
#nullable restore
#line 32 "C:\Users\MERT\OneDrive\Masaüstü\ASP.Net Core 5.0 Proje Kampı\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <td>\r\n                        <img style=\"background-color: #fff;\" alt=\"Image placeholder\"");
            BeginWriteAttribute("src", " src=\"", 1222, "\"", 1243, 1);
#nullable restore
#line 35 "C:\Users\MERT\OneDrive\Masaüstü\ASP.Net Core 5.0 Proje Kampı\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
WriteAttributeValue(" ", 1228, item.ImageUrl, 1229, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1300, "\"", 1345, 2);
            WriteAttributeValue("", 1307, "/Service/DeleteService/", 1307, 23, true);
#nullable restore
#line 37 "C:\Users\MERT\OneDrive\Masaüstü\ASP.Net Core 5.0 Proje Kampı\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
WriteAttributeValue("", 1330, item.ServiceID, 1330, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1418, "\"", 1463, 2);
            WriteAttributeValue("", 1425, "/Service/UpdateService/", 1425, 23, true);
#nullable restore
#line 38 "C:\Users\MERT\OneDrive\Masaüstü\ASP.Net Core 5.0 Proje Kampı\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
WriteAttributeValue("", 1448, item.ServiceID, 1448, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Güncelle</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 40 "C:\Users\MERT\OneDrive\Masaüstü\ASP.Net Core 5.0 Proje Kampı\Core_Proje\Core_Proje\Views\Service\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <br />\r\n    <a href=\"/Service/AddService/\" class=\"btn btn-success\">Yeni Hizmet Ekle</a>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591
