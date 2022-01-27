#pragma checksum "C:\Users\adam_\source\repos\AdamCastleCV\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7c109eeb7d994a2d40f5fba2606d6a7486ec947"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AdamCastleCV.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace AdamCastleCV.Pages
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
#line 1 "C:\Users\adam_\source\repos\AdamCastleCV\Pages\_ViewImports.cshtml"
using AdamCastleCV;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7c109eeb7d994a2d40f5fba2606d6a7486ec947", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ee17220654f2a5a62084a42cb330e00267ac568", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/booksPhoto.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/TeacherHat3.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\adam_\source\repos\AdamCastleCV\Pages\Index.cshtml"
  
    ViewData["Title"] = "Adam Castle Projects";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"" style=""color:white"">
    <h1 class=""display-4 font-weight-bold"">Adam Castle</h1>  
    <h3>Projects</h3>
</div>
<div class=""container"">
    <div class=""row gutters-sm mt-4"">
        <div class=""col-md-6 mb-3"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""d-flex flex-column align-items-center text-center"">                        
                            <h4><a href=""http://castlelibrary.somee.com/"">CastleLibrary</a></h4>
                        <p><em>AKA ""BookCatalog""</em></p>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b7c109eeb7d994a2d40f5fba2606d6a7486ec9474407", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"     
                        <br />                       
                        <br />
                        <div class=""text-left"">
                            <h6>Function</h6>
                            <br />
                            <ul>
                                <li>WebApp designed to help a librarian manage book loans</li>
                                <li>Books are taken out, returned, and fines generated</li>
                                <li>Users blocked for not returning books</li>
                                <li>All records of loans, users, books, and authors support CRUD operations</li>
                            </ul>
                            <br />
                            <h6>Languages & Frameworks</h6>
                            <br />
                            <ul>
                                <li>Data access with Entity Framework Core (Code-First)</li>
                                <li>LINQ queries</li>
                              ");
            WriteLiteral(@"  <li>Using Model-View-Controller Structure</li>
                                <li>Connected to a MySQL database and hosted <a href=""http://castlelibrary.somee.com/"">here</a></li>
                                <li>Designed using CSS Bootstrap</li>
                            </ul>
                        </div>                        
                        <p><a href=""https://github.com/AdamGCastle/BookCatalogMVC"">See Project on GitHub</a></p>                       
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-6 mb-3"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""d-flex flex-column align-items-center text-center"">
                        <h4>TeacherAdmin</h4>
                        <br />
                        <br />
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b7c109eeb7d994a2d40f5fba2606d6a7486ec9477405", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <br />
                        <br />
                        <div class=""text-left"">
                            <h6>Function</h6>
                            <br />
                            <ul>
                                <li>WebApp designed to help a teacher keep track of lesson schedules, student details, and student performance</li>
                                <li>Teacher user can create and alter details of each individual student and create and alter lesson plans</li>
                            </ul>
                            <br />
                            <h6>Languages & Frameworks</h6>
                            <br />
                            <ul>
                                <li>Data access with Entity Framework Core (Code-First)</li>
                                <li>LINQ queries</li>
                                <li>Razor Pages folder structure</li>
                                <li>Designed using CSS Bootstrap</li>

   ");
            WriteLiteral(@"                         </ul>
                        </div>
                        <br />
                        <br />   
                        <p><a href=""https://github.com/AdamGCastle/TeacherAdmin"">See Project on GitHub</a></p>                        
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
