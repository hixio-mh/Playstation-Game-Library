#pragma checksum "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a641f277368a00555a77b08874168cea11b74d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_Details), @"mvc.1.0.view", @"/Views/Games/Details.cshtml")]
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
#line 1 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\_ViewImports.cshtml"
using VideoGameLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\_ViewImports.cshtml"
using VideoGameLibrary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a641f277368a00555a77b08874168cea11b74d8", @"/Views/Games/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12a2c432bacd9f2dd25c96536f8fcc9586e649a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VideoGameLibrary.Models.Game>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Game</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Platform));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.Platform));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NoOfPlayers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.NoOfPlayers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Publisher));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.Publisher));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("/10\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Progress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <progress id=\"progress\" max=\"100\"");
            BeginWriteAttribute("value", " value=", 2198, "", 2246, 1);
#nullable restore
#line 71 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
WriteAttributeValue("", 2205, Html.DisplayFor(model => model.Progress), 2205, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">0% </progress>\r\n            ");
#nullable restore
#line 72 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.Progress));

#line default
#line hidden
#nullable disable
            WriteLiteral("%\r\n\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 76 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BoxArt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <img");
            BeginWriteAttribute("src", " src=", 2487, "", 2531, 1);
#nullable restore
#line 79 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
WriteAttributeValue("", 2492, Html.DisplayFor(model => model.BoxArt), 2492, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Sample Image\" />\r\n");
            WriteLiteral("        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a641f277368a00555a77b08874168cea11b74d812067", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "D:\Playstation-Library\Playstation-Game-Library\VideoGameLibrary\Views\Games\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a641f277368a00555a77b08874168cea11b74d814222", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VideoGameLibrary.Models.Game> Html { get; private set; }
    }
}
#pragma warning restore 1591
