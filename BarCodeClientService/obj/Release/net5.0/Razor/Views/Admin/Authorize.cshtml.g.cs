#pragma checksum "D:\VB\BarCode-System\BarCodeClientService\Views\Admin\Authorize.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d74136694debafb7525c5703429225321cd47bce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Authorize), @"mvc.1.0.view", @"/Views/Admin/Authorize.cshtml")]
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
#line 1 "D:\VB\BarCode-System\BarCodeClientService\Views\_ViewImports.cshtml"
using BarCodeClientService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VB\BarCode-System\BarCodeClientService\Views\_ViewImports.cshtml"
using BarCodeClientService.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d74136694debafb7525c5703429225321cd47bce", @"/Views/Admin/Authorize.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"231de61c7d9a254eb8b39190aacae46b82b7984c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Authorize : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/DataTable/jquery.dataTables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Array.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/DataTable/jquery-3.3.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/DataTable/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\VB\BarCode-System\BarCodeClientService\Views\Admin\Authorize.cshtml"
  
    ViewData["Title"] = "User Setup";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d74136694debafb7525c5703429225321cd47bce5213", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<style>
    tr.selected {
        background: red;
        color: red;
    }

    #main {
        position: absolute;
    }

    .color_tap {
        background-color: #5f95c3;
        color: #ffffff;
        font-weight: 600;
        margin-right: 1px;
        min-width: 60px;
    }

    .nav-tabs .nav-link {
        border: 1px solid rgb(193, 193, 193);
        border-radius: 0px 12px 0px 0px;
        height: 40px;
        line-height: 20px;
    }

    .modal {
        z-index: 200000;
    }

    .modal-header {
        background: #5f95c3;
        color: #ffffff;
        height: 40px;
    }

        .modal-header b {
            margin-top: -10px;
        }

    #TbAR table tr td {
        background-color: none;
        height: 35px;
        margin-left: 15px;
        margin-top: 10px;
        padding: 0px !important;
        position: relative !important;
    }

    table tbody tr td {
        background-color: #ffffff;
        color: black;
    }
");
            WriteLiteral(@"
    table tbody tr.selected td {
        background: #ffce99; /*#94d8e1*/
        color: red;
    }

        table tbody tr.selected td .clsinput {
            background: #ffce99;
            color: red;
        }

    .clsinput:focus {
        outline: none;
    }

    input.form-check-input {
        height: 20px;
        width: 20px;
    }
</style>
<div id=""#main"">
    <div class=""row"" style=""color: #696969; margin-left: 5px; margin-top: 5px;"">
        <h5 style=""color: #696969; margin-top: 5px;""></h5>
    </div>
    <ul class=""nav nav-tabs Tap-PA"" id=""mytab"" role=""tablist"">
        <li class=""nav-item"">
");
            WriteLiteral("        </li>\r\n");
            WriteLiteral(@"    </ul>
    <div class=""tab-content"" id=""myTabContent"">
        <div class=""tab-pane fade show active"" id=""create"" role=""tabpanel"" aria-labelledby=""create-tab"">
            <div class=""row"">
                <strong>User  :</strong><select style=""width:150px;margin-left:15px;"" size=""1"" class=""c6 styleOption""> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d74136694debafb7525c5703429225321cd47bce8454", async() => {
                WriteLiteral("User 1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d74136694debafb7525c5703429225321cd47bce9377", async() => {
                WriteLiteral("User 2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</select>
            </div>
            <div class=""row"">
                <div class=""col"">
                    <div class=""container-fluid"" style=""border-inline-style: initial;color: midnightblue;margin-top:10px;"">
                        <div class=""card"" style=""border:initial;width:300px;height:200px"">
                            <div class=""card-header"">
                                <strong>SALES A/R </strong><input type=""checkbox"" class=""input-group-text"" style=""float:right"" />
                            </div>
                            <div class=""card-body"">
                                <label>Delivery</label><input type=""checkbox"" style=""float:right"" /><br />
                                <label>Return</label><input type=""checkbox"" style=""float:right"" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""container-fluid"" style=""border-inline-st");
            WriteLiteral(@"yle: initial;color: midnightblue;margin-top:10px;"">
                        <div class=""card"" style=""border:initial;width:300px;height:200px"">
                            <div class=""card-header"">
                                <strong>Purchase A/P </strong><input type=""checkbox"" class=""input-group-text"" style=""float:right"" />
                            </div>
                            <div class=""card-body"">
                                <label>Goods Receipt PO</label><input type=""checkbox"" style=""float:right"" />
                                <label>Goods Return</label><input type=""checkbox"" style=""float:right"" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""container-fluid"" style=""border-inline-style: initial;color: midnightblue;margin-top:10px;"">
                        <div class=""card"" style=""border:initial;width:300px;height:200px"">
             ");
            WriteLiteral(@"               <div class=""card-header"">
                                <strong>Inventory</strong><input type=""checkbox"" class=""input-group-text"" style=""float:right"" />
                            </div>
                            <div class=""card-body"">
                                <label>Inventory Transfer</label><input type=""checkbox"" style=""float:right"" />
                                <label>Inventory Transfer Return</label><input type=""checkbox"" style=""float:right"" />
                                <label>Inventory Counting</label><input type=""checkbox"" style=""float:right"" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""container-fluid"" style=""border-inline-style: initial;color: midnightblue;margin-top:10px;"">
                        <div class=""card"" style=""border:initial;width:300px;height:200px"">
                            <div class=""card-hea");
            WriteLiteral(@"der"">
                                <strong>User</strong><input type=""checkbox"" class=""input-group-text"" style=""float:right"" />
                            </div>
                            <div class=""card-body"">
                                <label>Create User</label><input type=""checkbox"" style=""float:right"" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <br />
            <button class=""btn btn-success"" id=""Save"" style=""margin-left: 5px;margin-top:5px;float:left"">Save</button>
        </div>
    </div>
    <div class=""d-none"" id=""body1"">
        <div class=""row"">
            <div class=""col-12"" style=""text-align: center"">
                <h1>
                    <label>Print Item Lable</label>
                </h1>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-2"">
                <div class=""col-6"">
                    <button oncl");
            WriteLiteral("ick=\"window.history.back();\" class=\"button\">Back</button>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-10\">\r\n                <p align=\"right\">\r\n");
            WriteLiteral("                    <button class=\"button\" onclick=\"PrintPDF();\">PDF</button>\r\n                </p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d74136694debafb7525c5703429225321cd47bce15079", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d74136694debafb7525c5703429225321cd47bce16123", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d74136694debafb7525c5703429225321cd47bce17167", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <script>
        function ShowPassword() {
            const password = document.getElementById('password');
            const icon = document.getElementById('togglePassword');
            if (password.getAttribute('Type') === 'password') {
                password.setAttribute('type', 'text');
                icon.setAttribute('class', 'fa-eye');
            } else {
                password.setAttribute('type', 'password');
                icon.setAttribute('class', 'fa-eye-slash');
            }
        }


        function Load() {
            $.ajax({
                url: '");
#nullable restore
#line 195 "D:\VB\BarCode-System\BarCodeClientService\Views\Admin\Authorize.cshtml"
                 Write(Url.Action("GetUserLogin", "Admin"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: 'GET',
                dataType: 'JSON',
                success: function(data) {
                    LsUser = [];
                    console.log(data);
                    LsUser = data.data;
                    tbUser.clear();
                    tbUser.rows.add(LsUser);
                    tbUser.draw();
                }
            });
        }
    </script>
</div>");
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
