#pragma checksum "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69f9fabbe54a9f45101a96fbd169dc680a03b817"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyGrades_Index), @"mvc.1.0.view", @"/Views/MyGrades/Index.cshtml")]
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
#line 1 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\_ViewImports.cshtml"
using CarWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\_ViewImports.cshtml"
using CarWorld.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69f9fabbe54a9f45101a96fbd169dc680a03b817", @"/Views/MyGrades/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadc35c08ac6a95bdbce36f63d4c09f65aa51392", @"/Views/_ViewImports.cshtml")]
    public class Views_MyGrades_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarWorld.Models.Rating>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>My Grades</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Name\r\n            </th>\r\n            <th>\r\n                Image\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Car.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 31 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
                 if (item.Car.ImageName == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "69f9fabbe54a9f45101a96fbd169dc680a03b8175471", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
                   WriteLiteral("~/images/placeholder.jpg");

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 33 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 34 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "69f9fabbe54a9f45101a96fbd169dc680a03b8177943", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
                   WriteLiteral("~/images/"+item.Car.ImageName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n");
#nullable restore
#line 41 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
                  
                    var chk = "checked";
                    var checked1 = item.Score >= 1 ? chk : null;
                    var checked2 = item.Score >= 2 ? chk : null;
                    var checked3 = item.Score >= 3 ? chk : null;
                    var checked4 = item.Score >= 4 ? chk : null;
                    var checked5 = item.Score >= 5 ? chk : null;
                    var checked6 = item.Score >= 6 ? chk : null;
                    var checked7 = item.Score >= 7 ? chk : null;
                    var checked8 = item.Score >= 8 ? chk : null;
                    var checked9 = item.Score >= 9 ? chk : null;
                    var checked10 = item.Score == 10 ? chk : null;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span");
            BeginWriteAttribute("class", " class=\"", 1791, "\"", 1819, 3);
            WriteAttributeValue("", 1799, "fa", 1799, 2, true);
            WriteAttributeValue(" ", 1801, "fa-star", 1802, 8, true);
#nullable restore
#line 54 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
WriteAttributeValue(" ", 1809, checked1, 1810, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                <span");
            BeginWriteAttribute("class", " class=\"", 1851, "\"", 1879, 3);
            WriteAttributeValue("", 1859, "fa", 1859, 2, true);
            WriteAttributeValue(" ", 1861, "fa-star", 1862, 8, true);
#nullable restore
#line 55 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
WriteAttributeValue(" ", 1869, checked2, 1870, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                <span");
            BeginWriteAttribute("class", " class=\"", 1911, "\"", 1939, 3);
            WriteAttributeValue("", 1919, "fa", 1919, 2, true);
            WriteAttributeValue(" ", 1921, "fa-star", 1922, 8, true);
#nullable restore
#line 56 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
WriteAttributeValue(" ", 1929, checked3, 1930, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                <span");
            BeginWriteAttribute("class", " class=\"", 1971, "\"", 1999, 3);
            WriteAttributeValue("", 1979, "fa", 1979, 2, true);
            WriteAttributeValue(" ", 1981, "fa-star", 1982, 8, true);
#nullable restore
#line 57 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
WriteAttributeValue(" ", 1989, checked4, 1990, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                <span");
            BeginWriteAttribute("class", " class=\"", 2031, "\"", 2059, 3);
            WriteAttributeValue("", 2039, "fa", 2039, 2, true);
            WriteAttributeValue(" ", 2041, "fa-star", 2042, 8, true);
#nullable restore
#line 58 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
WriteAttributeValue(" ", 2049, checked5, 2050, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                <span");
            BeginWriteAttribute("class", " class=\"", 2091, "\"", 2119, 3);
            WriteAttributeValue("", 2099, "fa", 2099, 2, true);
            WriteAttributeValue(" ", 2101, "fa-star", 2102, 8, true);
#nullable restore
#line 59 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
WriteAttributeValue(" ", 2109, checked6, 2110, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                <span");
            BeginWriteAttribute("class", " class=\"", 2151, "\"", 2179, 3);
            WriteAttributeValue("", 2159, "fa", 2159, 2, true);
            WriteAttributeValue(" ", 2161, "fa-star", 2162, 8, true);
#nullable restore
#line 60 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
WriteAttributeValue(" ", 2169, checked7, 2170, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                <span");
            BeginWriteAttribute("class", " class=\"", 2211, "\"", 2239, 3);
            WriteAttributeValue("", 2219, "fa", 2219, 2, true);
            WriteAttributeValue(" ", 2221, "fa-star", 2222, 8, true);
#nullable restore
#line 61 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
WriteAttributeValue(" ", 2229, checked8, 2230, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                <span");
            BeginWriteAttribute("class", " class=\"", 2271, "\"", 2299, 3);
            WriteAttributeValue("", 2279, "fa", 2279, 2, true);
            WriteAttributeValue(" ", 2281, "fa-star", 2282, 8, true);
#nullable restore
#line 62 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
WriteAttributeValue(" ", 2289, checked9, 2290, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                <span");
            BeginWriteAttribute("class", " class=\"", 2331, "\"", 2360, 3);
            WriteAttributeValue("", 2339, "fa", 2339, 2, true);
            WriteAttributeValue(" ", 2341, "fa-star", 2342, 8, true);
#nullable restore
#line 63 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
WriteAttributeValue(" ", 2349, checked10, 2350, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 66 "C:\Users\Shadowmare\source\repos\CarWorld\CarWorld\Views\MyGrades\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarWorld.Models.Rating>> Html { get; private set; }
    }
}
#pragma warning restore 1591
