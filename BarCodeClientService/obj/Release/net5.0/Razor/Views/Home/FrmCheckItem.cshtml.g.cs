#pragma checksum "D:\VB\BarCode-System\BarCodeClientService\Views\Home\FrmCheckItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b61b7dc3ea2dc95d4a216276c2e2c3efc74b9c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FrmCheckItem), @"mvc.1.0.view", @"/Views/Home/FrmCheckItem.cshtml")]
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
#nullable restore
#line 1 "D:\VB\BarCode-System\BarCodeClientService\Views\Home\FrmCheckItem.cshtml"
using BarCodeClientService.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b61b7dc3ea2dc95d4a216276c2e2c3efc74b9c6", @"/Views/Home/FrmCheckItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"231de61c7d9a254eb8b39190aacae46b82b7984c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FrmCheckItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/DataTable/jquery.dataTables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/DataTable/rowReorder.dataTables.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/DataTable/jquery-3.3.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/DataTable/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/DataTable/dataTables.rowReorder.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/DataTable/moment.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/DataTable/datetime-moment.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/DataTable/dataTables.buttons.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/DataTable/dataTables.select.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/DataTable/dataTables.dateTime.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/DataTable/dataTables.editor.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\VB\BarCode-System\BarCodeClientService\Views\Home\FrmCheckItem.cshtml"
  
    ViewData["Title"] = "Product Detail";
    var dt = DateTime.Now;
    ViewData["Date"] = dt.ToShortDateString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3b61b7dc3ea2dc95d4a216276c2e2c3efc74b9c68429", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3b61b7dc3ea2dc95d4a216276c2e2c3efc74b9c69543", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3b61b7dc3ea2dc95d4a216276c2e2c3efc74b9c610657", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b61b7dc3ea2dc95d4a216276c2e2c3efc74b9c611807", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b61b7dc3ea2dc95d4a216276c2e2c3efc74b9c612847", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b61b7dc3ea2dc95d4a216276c2e2c3efc74b9c613887", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b61b7dc3ea2dc95d4a216276c2e2c3efc74b9c614927", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b61b7dc3ea2dc95d4a216276c2e2c3efc74b9c615967", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b61b7dc3ea2dc95d4a216276c2e2c3efc74b9c617007", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b61b7dc3ea2dc95d4a216276c2e2c3efc74b9c618047", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b61b7dc3ea2dc95d4a216276c2e2c3efc74b9c619088", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b61b7dc3ea2dc95d4a216276c2e2c3efc74b9c620129", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
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
        height: 35px;
        margin-left: 15px;
        margin-top: 10px;
        padding: 0px !important;
        position: relative !important;
        /*background-color: none;*/
    }

    table tbody tr td {
        background-color: #ffffff;
        color: black;
    ");
            WriteLiteral(@"}

    table tbody tr.selected td {
        background: #94d8e1;
        color: red;
    }

        table tbody tr.selected td .clsinput {
            background: #94d8e1;
            color: red;
        }

    input[type=""radio""] {
        margin-top: -1px;
        vertical-align: middle;
        height: 28px;
        width: 28px;
    }

    .lbl_rdo {
        font-size: 18px;
        /*font-weight: bold;*/
    }

    .clsinput:focus {
        outline: none;
    }

    .textbox-01 {
        display: block;
        height: calc(1.5em + .75rem + 2px);
        padding: .375rem .75rem;
        font-size: 12px;
        font-weight: 400;
        line-height: 1.5;
        color: #495057;
        background-color: #fff;
        background-clip: padding-box;
        border: 1px solid #ced4da;
        border-radius: .25rem;
    }

    /* =================================================== */
    .cover-spin {
        position: fixed;
        width: 100%;
        left: 0;
");
            WriteLiteral("        right: 0;\r\n        top: 0;\r\n        bottom: 0;\r\n        background-color: rgba(255,255,255,0.7);\r\n        z-index: 9999;\r\n        display: none;\r\n    }\r\n\r\n    ");
            WriteLiteral("@-webkit-keyframes spin {\r\n        from {\r\n            -webkit-transform: rotate(0deg);\r\n        }\r\n\r\n        to {\r\n            -webkit-transform: rotate(360deg);\r\n        }\r\n    }\r\n\r\n    ");
            WriteLiteral(@"@keyframes spin {
        from {
            transform: rotate(0deg);
        }

        to {
            transform: rotate(360deg);
        }
    }

    .cover-spin::after {
        content: '';
        display: block;
        position: absolute;
        left: 48%;
        top: 40%;
        width: 40px;
        height: 40px;
        border-style: solid;
        border-color: black;
        border-top-color: transparent;
        border-width: 4px;
        border-radius: 50%;
        -webkit-animation: spin .8s linear infinite;
        animation: spin .8s linear infinite;
    }
    /* =================================================== */
    table thead{
        background-color:antiquewhite;
        font-weight:bold;
        color:black;
        text-align:center;
    }
    #TbDataItem {
        font-size: 14px;
        color: black;
    }
</style>

<div id=""#main"">

    <div id=""frmLoading"" class=""cover-spin"" style=""display:none""></div>

    <div class=""row"" style=");
            WriteLiteral(@"""color: #696969; margin-left: 5px; margin-top: 5px;"">
        <h5 style=""color: #696969; margin-top: 5px;"">
            <a><i class=""fas fa-home""></i> Dashboard</a>
            <span>
                <a><i class=""fa fa-caret-right align-right""></i>Check Item</a>
            </span>
        </h5>
    </div>
    <hr />

    <div style=""color: #696969; padding: 10px;"">
        <div class=""tab-content"" id=""myTabContent"">
            <div class=""tab-pane fade show active"" id=""cus"" role=""tabpanel"" aria-labelledby=""cus-tab"" style=""margin-top: 10px"">

                <div class=""row"">
                    <div class=""col-sm-6"">
                        <b>Scan QRCode</b><br>
                        <div class=""input-group"">
                            <input type=""text"" id=""txtSearchItem"" autocomplete=""off"" class=""textbox-01"" size=""25""");
            BeginWriteAttribute("value", " value=\"", 5380, "\"", 5388, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                            <button class=""btn btn-info"" id=""btnSearchItem"">
                                Search
                            </button>
                        </div>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col-sm-12""><br>
                        <div class=""table-responsive"">
                            <table id=""TbDataItem"" border=""1"" class=""table table-hover"" width=""100%"" cellspacing=""0"" style=""background:#f0eff1;color:#696969;"">
                                <tr>
                                    <td width=""25%"" style=""border-right: 1px solid black""><b>ItemCode</b></td>
                                    <td><div id=""lbItemCode""></div></td>
                                </tr>
                                <tr>
                                    <td style=""border-right: 1px solid black""><b>ItemName</b></td>
                                    <td><div id=""lbItemName""></div></td>
");
            WriteLiteral(@"                                </tr>
                                <tr style=""display:none;"">
                                    <td style=""border-right: 1px solid black""><b>Warehouse</b></td>
                                    <td><div id=""lbWarehouse""></div></td>
                                </tr>
                                <tr style=""display:none;"">
                                    <td style=""border-right: 1px solid black""><b>Bin Location</b></td>
                                    <td><div id=""lbBinLocation""></div></td>
                                </tr>
                                <tr>
                                    <td style=""border-right: 1px solid black""><b>Batch Number</b></td>
                                    <td><div id=""lbBatchNumber""></div></td>
                                </tr>
                                <tr>
                                    <td style=""border-right: 1px solid black""><b>Serial Number</b></td>
                             ");
            WriteLiteral(@"       <td><div id=""lbSerialNumber""></div></td>
                                </tr>
                                <tr>
                                    <td style=""border-right: 1px solid black""><b>FDA Number (อย.)</b></td>
                                    <td><div id=""lbFDA""></div></td>
                                </tr>
                                <tr>
                                    <td style=""border-right: 1px solid black""><b>Exp Date</b></td>
                                    <td><div id=""lbExpDate""></div></td>
                                </tr>
                            </table>

                            
                            <div id=""divBinLocationList"" style=""display:block;"">
                                <b>Bin Location List</b>
                                <table id=""TbBinLocationList"" border=""1"" class=""table table-hover"" width=""99%"" cellspacing=""0"" style=""background:#fff;color:#696969; font-size: 12px;"">
                                    <");
            WriteLiteral(@"thead>
                                        <tr>
                                            <th>Item Code</th>
                                            <th>Warehouse</th>
                                            <th>Bin Location</th>
                                            <th>QTY</th>
                                            <th>BarCode</th>
                                        </tr>
                                    </thead>
                                </table>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
</div>


<script type=""text/javascript"">
    //console.cler();
    $('#txtSearchItem').focus();

    $(""#txtSearchItem"").on(""keypress"", function (event) {
        var englishAlphabetAndWhiteSpace = /[A-Za-z ;&-_#]/g;
        var key = String.fromCharCode(event.which);

        if (event.keyCode == 8 || event.keyCode == 37 || event.keyC");
            WriteLiteral(@"ode == 39 || englishAlphabetAndWhiteSpace.test(key)) {
            return true;
        }
        return false;
    });

    //$('#txtSearchItem').on(""paste"", function (e) {
    //    e.preventDefault();
    //});

    var input01 = document.getElementById(""txtSearchItem"");
    input01.addEventListener(""keyup"", function (event) {
        if (event.keyCode === 13) {
            event.preventDefault();
            if (input01.value != '') {
                document.getElementById(""btnSearchItem"").click();
            }
            else {
                alert('สแกน บาร์โค๊ด หรือ คิวอาร์โค๊ด อีกครั้ง!');
            }
        }
    });

    $('#btnSearchItem').on('click', function () {
        document.getElementById(""frmLoading"").style.display = ""block"";
        console.log(""BarCode is "" + $('#txtSearchItem').val());

        var txtScanBarCode = $('#txtSearchItem').val();
        const strArr = txtScanBarCode.split("";"");
        var sItemCode = strArr[0];
        var sBatch = strA");
            WriteLiteral(@"rr[1];
        var sSerial = strArr[2];

        //=============================
        var sBatchSerial;
        if (sBatch != '') {
            sBatchSerial = sBatch;
        }
        else if (sSerial != '') {
            sBatchSerial = sSerial;
        }
        else {
            sBatchSerial = ""empty"";
        }
        //=============================

        //console.log(sItemCode + ';' + sBatch + ';' + sSerial);
        console.log(sBatchSerial);
        //Have Batch And Serial
        if (sBatchSerial != ""empty"") {
            $.ajax({
                url: '");
#nullable restore
#line 332 "D:\VB\BarCode-System\BarCodeClientService\Views\Home\FrmCheckItem.cshtml"
                 Write(Url.Action("GetItemByBarcode", "Inventory"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: { barCode: sBatchSerial, itemcode: sItemCode},
                type: ""GET"",
                dataType: ""JSON"",
                ""dataSrc"": 'data',
                success: function (data) {
                    if (data !== undefined) {
                        //console.warn(data[0].length);                        
                        var jqueryXml = $(data);
                        if (jqueryXml[0].data.length > 0) {
                            //
                            console.log('Success..');
                            //console.log(data);
                            
                            document.getElementById(""lbItemCode"").innerHTML = jqueryXml[0].data[0].itemCode;
                            document.getElementById(""lbItemName"").innerHTML = jqueryXml[0].data[0].itemName;
                            document.getElementById(""lbWarehouse"").innerHTML = jqueryXml[0].data[0].whsCode;
                            document.getElementById(""lbBinLocation"").");
            WriteLiteral(@"innerHTML = jqueryXml[0].data[0].binCode;
                            document.getElementById(""lbBatchNumber"").innerHTML = jqueryXml[0].data[0].batchNumber;
                            document.getElementById(""lbSerialNumber"").innerHTML = jqueryXml[0].data[0].serialNumber;
                            document.getElementById(""lbFDA"").innerHTML = jqueryXml[0].data[0].fda;
                            document.getElementById(""lbExpDate"").innerHTML = jqueryXml[0].data[0].expDate;
                            tbBinLocationList.clear().draw();
                            fncGetBinLocationList(sBatchSerial, sItemCode);


                        } else {
                            alert(""ไม่มี Item ของ Barcode นี้"");
                            fncExit();                            
                        }

                        
                    }
                    else {
                        fncErr();
                    }
                    

                },
                err");
            WriteLiteral(@"or: function (err) {
                    console.log(err.responseText);
                    document.getElementById(""frmLoading"").style.display = ""none"";
                }
            });
        }
        //No Batch And Serial
        else {
            $.ajax({
                url: '");
#nullable restore
#line 380 "D:\VB\BarCode-System\BarCodeClientService\Views\Home\FrmCheckItem.cshtml"
                 Write(Url.Action("GetItemNoBatchSerial", "Inventory"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: { itemcode: sItemCode },
                type: ""GET"",
                dataType: ""JSON"",
                ""dataSrc"": 'data',
                success: function (data2) {
                    if (data2 !== undefined) {
                        console.log('GetItemNoBatchSerial Success..');
                        //console.log(data2);
                        var jqueryXml = $(data2);
                        document.getElementById(""lbItemCode"").innerHTML = jqueryXml[0].data[0].itemCode;
                        document.getElementById(""lbItemName"").innerHTML = jqueryXml[0].data[0].itemName;
                        document.getElementById(""lbWarehouse"").innerHTML = '';
                        document.getElementById(""lbBinLocation"").innerHTML = '';
                        document.getElementById(""lbBatchNumber"").innerHTML = '';
                        document.getElementById(""lbSerialNumber"").innerHTML = '';
                        document.getElementById(""lbFDA"").innerHTML = ");
            WriteLiteral(@"jqueryXml[0].data[0].fda;
                        var vExpDate = jqueryXml[0].data[0].expDate;
                        var cExpDate = vExpDate.toString();
                        console.log(""ExpDate : "" + cExpDate);
                        if (cExpDate == ""1899-12-31T00:00:00"") {
                            cExpDate = """";
                        }
                        document.getElementById(""lbExpDate"").innerHTML = cExpDate;
                        tbBinLocationList.clear().draw();
                        fncGetBinLocationList(sBatchSerial, sItemCode);
                    } else {
                        fncErr();
                    }

                },
                error: function (err) {
                    console.log(err.responseText);
                    document.getElementById(""frmLoading"").style.display = ""none"";
                    $('#txtSearchItem').val('');
                }
            });
        }

    });

    var LItems = [];
    var tbBinLocationList = $('#");
            WriteLiteral(@"TbBinLocationList').DataTable({
        bLengthChange: false,
        binfo: false,
        data: LItems,
        language: {
            emptyTable: ""Empty""
        },
        columns: [
            { data: ""itemCode"", autoWidth: true },
            { data: ""whsCode"", autoWidth: true },
            { data: ""binCode"", autoWidth: true },
            { data: ""qty"", autoWidth: true },
            { data: ""barCode"", autoWidth: true }
        ],
        select: true,
        paging: true,
        ordering: false,
        info: false,
        searching: false
    });
    tbBinLocationList.columns([0, 1, 4]).visible(false, false);

    function fncGetBinLocationList(barcode, itemcode) {
        console.log('Bin-Location List Loading...');
        $.ajax({
            url: '");
#nullable restore
#line 447 "D:\VB\BarCode-System\BarCodeClientService\Views\Home\FrmCheckItem.cshtml"
             Write(Url.Action("GetBinLocationList", "Inventory"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            data: { barcode: barcode, itemcode: itemcode},
            type: ""GET"",
            dataType: ""JSON"",
            ""dataSrc"": 'data',
            success: function (value) {
                //START -> Check Error [Cannot read properties of undefined]
                if (value !== undefined) {
                    console.log('Get Bin-Location List Success..');
                    console.log(value);
                    LItems = [];
                    LItems = value.data;
                    tbBinLocationList.rows.add(LItems);
                    tbBinLocationList.search("""").draw();
                    document.getElementById(""frmLoading"").style.display = ""none"";
                    $('#txtSearchItem').val('');
                }
                else {
                    fncErr();
                }
                //END -> Check Error [Cannot read properties of undefined]
                
            },
            error: function (err) {
                console.log(err.re");
            WriteLiteral(@"sponseText);
                document.getElementById(""frmLoading"").style.display = ""none"";
                $('#txtSearchItem').val('');
                $('#txtSearchItem').focus();
            }
        });
    }

    function fncErr() {
        alert(""Server error responses\r\nเกิดข้อผิดพลาดของเซิร์ฟเวอร์"");
        document.getElementById(""frmLoading"").style.display = ""none"";
        $('#txtSearchItem').val('');
        $('#txtSearchItem').focus();
    }

    function fncExit() {
        document.getElementById(""frmLoading"").style.display = ""none"";
        $('#txtSearchItem').val('');
        $('#txtSearchItem').focus();
    }


</script>");
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