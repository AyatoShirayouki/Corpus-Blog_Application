#pragma checksum "D:\CorpusSM\CorpusSMDemo\CorpusSMDemo\Views\Users\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c9a530f819df843bba750a9607fa6d1c50e7ad0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Edit), @"mvc.1.0.view", @"/Views/Users/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c9a530f819df843bba750a9607fa6d1c50e7ad0", @"/Views/Users/Edit.cshtml")]
    public class Views_Users_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CorpusSMDemo.ViewModels.Users.EditVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/user_profile.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("45"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/back.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\CorpusSM\CorpusSMDemo\CorpusSMDemo\Views\Users\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/particlesjs/2.2.2/particles.min.js""></script>
<div class=""container"">
    <form action=""/Users/Edit"" method=""post"">
        <div class=""row"">
            <div class=""col-md-8 mx-auto"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col"">
                                <center>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2c9a530f819df843bba750a9607fa6d1c50e7ad04710", async() => {
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
                                </center>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col"">
                                <center>
                                    <h3>Edit</h3>
                                </center>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col"">
                                <center>
                                    <hr />
                                </center>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col"">
                                <center>
                                    <span class=""badge bg-info text-dark"">Personal Information</span>
                                </center>
                            </div>
                ");
            WriteLiteral(@"        </div>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <label>First Name:</label>
                                <div class=""form-group"">
                                    ");
#nullable restore
#line 46 "D:\CorpusSM\CorpusSMDemo\CorpusSMDemo\Views\Users\Edit.cshtml"
                               Write(Html.TextBoxFor(u => u.FirstName, null, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <label>Last Name:</label>
                                <div class=""form-group"">
                                    ");
#nullable restore
#line 53 "D:\CorpusSM\CorpusSMDemo\CorpusSMDemo\Views\Users\Edit.cshtml"
                               Write(Html.TextBoxFor(u => u.LastName, null, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <label>Username:</label>
                                <div class=""form-group"">
                                    ");
#nullable restore
#line 62 "D:\CorpusSM\CorpusSMDemo\CorpusSMDemo\Views\Users\Edit.cshtml"
                               Write(Html.TextBoxFor(u => u.Username, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <label>Email:</label>
                                <div class=""form-group"">
                                    ");
#nullable restore
#line 69 "D:\CorpusSM\CorpusSMDemo\CorpusSMDemo\Views\Users\Edit.cshtml"
                               Write(Html.TextBoxFor(u => u.Email, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <label>Password:</label>
                                <div class=""form-group"">
                                    ");
#nullable restore
#line 76 "D:\CorpusSM\CorpusSMDemo\CorpusSMDemo\Views\Users\Edit.cshtml"
                               Write(Html.TextBoxFor(u => u.Password, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                   
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col"">
                                <div class=""form-group"">
                                    <input class=""btn btn-primary btn-block btn-lg"" type=""submit"" name=""Edit"" value=""Edit"" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <a href=""/Users/Index"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2c9a530f819df843bba750a9607fa6d1c50e7ad010502", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </a>
                <br /><br />
            </div>
        </div>
    </form>
</div>
<script>
        window.
            onload
            = function () {
                Particles.
                    init
                    ({
                        selector:
                            '.background'
                    });
            };
        var particles = Particles.init({
            selector: '.background',
            color: ['#DA0463', '#404B69', '#DBEDF3'],
            connectParticles: true
        });
</script>
<canvas class=""background""></canvas>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CorpusSMDemo.ViewModels.Users.EditVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
