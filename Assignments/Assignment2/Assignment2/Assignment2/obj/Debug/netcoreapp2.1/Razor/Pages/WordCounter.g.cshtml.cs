#pragma checksum "C:\Info6250\Assignments\Assignment2\Assignment2\Assignment2\Pages\WordCounter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c1a72ce6f52199f31c1d5aae9c2cadbe1ba23a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Assignment2.Pages.Pages_WordCounter), @"mvc.1.0.razor-page", @"/Pages/WordCounter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/WordCounter.cshtml", typeof(Assignment2.Pages.Pages_WordCounter), null)]
namespace Assignment2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Info6250\Assignments\Assignment2\Assignment2\Assignment2\Pages\_ViewImports.cshtml"
using Assignment2;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c1a72ce6f52199f31c1d5aae9c2cadbe1ba23a0", @"/Pages/WordCounter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91771f1eebd9d7f06a7f96c184e0efa222d6330c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_WordCounter : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/counting-image.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Counting Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("310"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Info6250\Assignments\Assignment2\Assignment2\Assignment2\Pages\WordCounter.cshtml"
  
    ViewData["Title"] = "WordCounter";

#line default
#line hidden
            BeginContext(97, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(105, 1711, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5181d9e2367499e8113cf0a3640f803", async() => {
                BeginContext(111, 1698, true);
                WriteLiteral(@"
    <style>
        body {
            font-family: Verdana, Arial, sans-serif;
            background-color: #303F9F;
        }

        #wrapper {
            background-color: #C5CAE9;
            color: #212121;
            width: 90%;
            margin: auto;
            min-width: 940px;
        }

        #textlabel {
            color: #757575;
        }

        .hr {
            color: #BDBDBD;
        }

        .center {
            display: block;
            margin-left: auto;
            margin-right: auto;
            width: 50%;
        }

        img {
            padding: 1px;
            border: 1px solid #021a40;
        }

        ul {
            list-style-type: square;
        }

        .white {
            color: white;
        }
    </style>
    <script src=""http://code.jquery.com/jquery-3.3.1.js""
            integrity=""sha256-2Kok7MbOyxpgUVvAk/HJ2jigOSYS2auK4Pfzbm7uH60=""
            crossorigin=""anonymous""></script>
    <script src=""");
                WriteLiteral(@"http://code.jquery.com/ui/1.12.1/jquery-ui.js""
            integrity=""sha256-T0Vest3yCU7pafRw9r+settMBX6JkKN06dqBnpQ8d30=""
            crossorigin=""anonymous""></script>
    <script>
        $(document).ready(function () {
            $(""h1"").click(function () {
                $(this).toggleClass(""white"");
            });
        });
    </script>
    <script>
        $(document).ready(function () {
            $(""#myBtn"").click(function () {
                $(""h3"").append("" <b><i>Word Counter App Running......Now Loading Output!!!</i></b>"");
                $(""h4"").append("" <b>The word count is:</b>."");
            });
        });

    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1816, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1818, 929, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "082f1a0cbda74f53914e6ec1aed1a79d", async() => {
                BeginContext(1824, 144, true);
                WriteLiteral("\r\n    <div id=\"wrapper\">\r\n        <h1><strong><i>Welcome to the Word Counter App!</i></strong></h1>\r\n        <h3></h3>\r\n        <br />\r\n        ");
                EndContext();
                BeginContext(1968, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b4a65f6071d14d42a8757bc207f064e9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2070, 34, true);
                WriteLiteral("\r\n        <br /><br />\r\n\r\n        ");
                EndContext();
                BeginContext(2104, 255, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b3e1c0db2534c27b409537ca86a8669", async() => {
                    BeginContext(2124, 228, true);
                    WriteLiteral("\r\n            <label for=\"wordCounter\" id=\"textlabel\">Enter something cool: </label>\r\n            <input type=\"text\" id=\"wordCounter\" placeholder=\"\" name=\"wordCounter\" />\r\n            <input type=\"submit\" id=\"myBtn\" />\r\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2359, 46, true);
                WriteLiteral("\r\n\r\n        <hr />\r\n\r\n        <h3>Your text = ");
                EndContext();
                BeginContext(2406, 17, false);
#line 89 "C:\Info6250\Assignments\Assignment2\Assignment2\Assignment2\Pages\WordCounter.cshtml"
                   Write(Model.WordCounter);

#line default
#line hidden
                EndContext();
                BeginContext(2423, 43, true);
                WriteLiteral(" </h3>\r\n        <h4></h4>\r\n\r\n        <ul>\r\n");
                EndContext();
#line 93 "C:\Info6250\Assignments\Assignment2\Assignment2\Assignment2\Pages\WordCounter.cshtml"
             if (Model.WordDict != null)
            {
                

#line default
#line hidden
#line 95 "C:\Info6250\Assignments\Assignment2\Assignment2\Assignment2\Pages\WordCounter.cshtml"
                 foreach (KeyValuePair<string, int> pair in Model.WordDict)
                {

#line default
#line hidden
                BeginContext(2619, 24, true);
                WriteLiteral("                    <li>");
                EndContext();
                BeginContext(2644, 8, false);
#line 97 "C:\Info6250\Assignments\Assignment2\Assignment2\Assignment2\Pages\WordCounter.cshtml"
                   Write(pair.Key);

#line default
#line hidden
                EndContext();
                BeginContext(2652, 3, true);
                WriteLiteral(" : ");
                EndContext();
                BeginContext(2656, 10, false);
#line 97 "C:\Info6250\Assignments\Assignment2\Assignment2\Assignment2\Pages\WordCounter.cshtml"
                               Write(pair.Value);

#line default
#line hidden
                EndContext();
                BeginContext(2666, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 98 "C:\Info6250\Assignments\Assignment2\Assignment2\Assignment2\Pages\WordCounter.cshtml"
                }

#line default
#line hidden
#line 98 "C:\Info6250\Assignments\Assignment2\Assignment2\Assignment2\Pages\WordCounter.cshtml"
                 
            }

#line default
#line hidden
                BeginContext(2707, 33, true);
                WriteLiteral("        </ul>\r\n    </div>\r\n    \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2747, 19, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assignment2.Pages.WordCounterModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Assignment2.Pages.WordCounterModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Assignment2.Pages.WordCounterModel>)PageContext?.ViewData;
        public Assignment2.Pages.WordCounterModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
