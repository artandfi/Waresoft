#pragma checksum "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc57878f7d406da809d4aac29974ad8efed326d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Queries_Result), @"mvc.1.0.view", @"/Views/Queries/Result.cshtml")]
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
#line 1 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\_ViewImports.cshtml"
using Waresoft;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\_ViewImports.cshtml"
using Waresoft.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc57878f7d406da809d4aac29974ad8efed326d3", @"/Views/Queries/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c6c707eff6e2a68160ca41d7b3816702fda01c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Queries_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Query>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Queries", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
  
    ViewData["Title"] = "Результат";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Результат</h1>\r\n<hr />\r\n\r\n");
#nullable restore
#line 10 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
 if (string.IsNullOrEmpty(Model.Error))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
     if (Model.QueryId.Equals("S1"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"font-size:20px\">\r\n            <b>Середня ціна продуктів розробника ");
#nullable restore
#line 15 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                                            Write(Model.DevName);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</b> ");
#nullable restore
#line 15 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                                                                Write(decimal.Round(Model.AvgPrice, 2, MidpointRounding.AwayFromZero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n");
#nullable restore
#line 17 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
    }
    else if (Model.QueryId.Equals("S2"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"font-size:20px\">\r\n            <b>Покупці, що придбали хоча б один продукт розробника ");
#nullable restore
#line 21 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                                                              Write(Model.DevName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b>
        </p>
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        Ім'я
                    </th>
                    <th>
                        Прізвище
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 35 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                 for (int i = 0; i < Model.CustNames.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 39 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                       Write(Model.CustNames[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 42 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                       Write(Model.CustSurnames[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 45 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 48 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
    }
    else if (Model.QueryId.Equals("S3"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"font-size:20px\">\r\n            <b>Назви та ціни всіх програмних продуктів усіх розробників із країни ");
#nullable restore
#line 52 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                                                                             Write(Model.CountryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b>
        </p>
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        Назва
                    </th>
                    <th>
                        Ціна
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 66 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                 for (int i = 0; i < Model.ProdNames.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 70 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                       Write(Model.ProdNames[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 73 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                       Write(decimal.Round(Model.ProdPrices[i], 2, MidpointRounding.AwayFromZero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 76 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 79 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
    }
    else if (Model.QueryId.Equals("S4"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"font-size:20px\">\r\n            <b>Імена розробників усіх програмних продуктів, придбаних покупцем з ім\'ям ");
#nullable restore
#line 83 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                                                                                  Write(Model.CustName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", прізвищем ");
#nullable restore
#line 83 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                                                                                                             Write(Model.CustSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" та email-ом ");
#nullable restore
#line 83 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                                                                                                                                            Write(Model.CustEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n        </p>\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        Ім\'я/назва\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 94 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                 for (int i = 0; i < Model.DevNames.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 98 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                       Write(Model.DevNames[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 101 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 104 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
    }
    else if (Model.QueryId.Equals("S5"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"font-size:20px\">\r\n            <b>Імена розробників, які продають продукти ціною не ");
#nullable restore
#line 108 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                                                            Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" у.о.</b>\r\n        </p>\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        Ім\'я/назва\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 119 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                 for (int i = 0; i < Model.DevNames.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 123 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                       Write(Model.DevNames[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 126 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 129 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
    }
    else if (Model.QueryId.Equals("S6"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"font-size:20px\">\r\n            <b>Імена розробників, які не продають продукти з назвою ");
#nullable restore
#line 133 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                                                               Write(Model.ProdName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n        </p>\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        Ім\'я/назва\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 144 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                 for (int i = 0; i < Model.DevNames.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 148 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                       Write(Model.DevNames[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 151 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 154 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
    }
    else if (Model.QueryId.Equals("A1"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"font-size:20px\">\r\n            <b>Назви країн, розробники з яких продають програмні продукти принаймні за всіма тими цінами, що й розробник із кодом ");
#nullable restore
#line 158 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                                                                                                                             Write(Model.DevId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n        </p>\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        Назва\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 169 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                 for (int i = 0; i < Model.CountryNames.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 173 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                       Write(Model.CountryNames[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 176 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 179 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
    }
    else if (Model.QueryId.Equals("A2"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"font-size:20px\">\r\n            <b>Прізвища покупців, які придбали точно ті ж самі програмні продукти, що й покупець з email ");
#nullable restore
#line 183 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                                                                                                    Write(Model.CustEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n        </p>\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        Прізвище\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 194 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                 for (int i = 0; i < Model.CustSurnames.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 198 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                       Write(Model.CustSurnames[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 201 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 204 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
    }
    else if (Model.QueryId.Equals("A3"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"font-size:20px\">\r\n            <b>Прізвища та email-и покупців з іменем ");
#nullable restore
#line 208 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                                                Write(Model.CustName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@", які придбали всі наявні програмні продукти</b>
        </p>
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        Прізвище
                    </th>
                    <th>
                        Email
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 222 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                 for (int i = 0; i < Model.CustSurnames.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 226 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                       Write(Model.CustSurnames[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 229 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                       Write(Model.CustEmails[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 232 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 235 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
    }
    else if (Model.QueryId.Equals("T1"))
    {

    }
    else if (Model.QueryId.Equals("T2"))
    {

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 243 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"font-size:20px\">\r\n        Результат запиту порожній.\r\n        <br />\r\n        Будь ласка, спробуйте ще раз з іншим параметром.\r\n    </p>\r\n");
#nullable restore
#line 252 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <td>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc57878f7d406da809d4aac29974ad8efed326d324900", async() => {
                WriteLiteral("\r\n                <input type=\"submit\" class=\"btn btn-primary\" value=\"Назад до запитів\" />\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </td>\r\n        <td></td>\r\n        <td></td>\r\n        <td></td>\r\n        <td>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc57878f7d406da809d4aac29974ad8efed326d326954", async() => {
                WriteLiteral("\r\n                <input type=\"submit\" class=\"btn btn-primary\" value=\"На головну\" />\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </td>
    </tr>
</table>


<div class=""modal fade"" id=""error"" tabindex=""-1"" role=""alertdialog"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Повідомлення</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""errorText"">
                ");
#nullable restore
#line 283 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
           Write(Model.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-primary\" data-dismiss=\"modal\">ОК</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        window.addEventListener(\"load\", function () {\r\n            if (\'");
#nullable restore
#line 296 "D:\Женя\Студматериалы\2 КУРС\2 СЕМЕСТР\БД та ІС\Лаба 2\Waresoft\Waresoft\Views\Queries\Result.cshtml"
            Write(Model.ErrorFlag);

#line default
#line hidden
#nullable disable
                WriteLiteral("\' == 1) {\r\n                $(\"#error\").modal();\r\n            }\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Query> Html { get; private set; }
    }
}
#pragma warning restore 1591
