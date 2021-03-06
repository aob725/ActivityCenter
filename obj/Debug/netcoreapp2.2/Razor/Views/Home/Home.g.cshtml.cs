#pragma checksum "C:\Users\Adam\Documents\CodingDojo\C#\ExamPrep\ActivityCenter\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d5e88930656b844c0ae9dba1379782f7bb3a72f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(AspNetCore.Views_Home_Home))]
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
#line 1 "C:\Users\Adam\Documents\CodingDojo\C#\ExamPrep\ActivityCenter\Views\_ViewImports.cshtml"
using ActivityCenter;

#line default
#line hidden
#line 2 "C:\Users\Adam\Documents\CodingDojo\C#\ExamPrep\ActivityCenter\Views\_ViewImports.cshtml"
using ActivityCenter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d5e88930656b844c0ae9dba1379782f7bb3a72f", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e339c4346f16b3c5483ad512c481a4e17eb8f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PlayActivity>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ToggleActivity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-status", "leave", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-status", "join", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Adam\Documents\CodingDojo\C#\ExamPrep\ActivityCenter\Views\Home\Home.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
            BeginContext(67, 44, true);
            WriteLiteral("\r\n<h1>Dojo Activity Center</h1>\r\n<p>Welcome ");
            EndContext();
            BeginContext(112, 22, false);
#line 7 "C:\Users\Adam\Documents\CodingDojo\C#\ExamPrep\ActivityCenter\Views\Home\Home.cshtml"
      Write(ViewBag.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(134, 378, true);
            WriteLiteral(@"</p>
<a href=""/logout""><button class=""btn btn-danger"">Logout</button></a>
<table class=""table"">
    <thead>
        <tr>
            <th>Activity</th>
            <th>Date and Time</th>
            <th>Duration</th>
            <th>Event Coordinator</th>
            <th>No. of Participants</th>
            <th>Actions</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 21 "C:\Users\Adam\Documents\CodingDojo\C#\ExamPrep\ActivityCenter\Views\Home\Home.cshtml"
         foreach(PlayActivity p in Model)
        {

#line default
#line hidden
            BeginContext(566, 32, true);
            WriteLiteral("        <tr>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 598, "\"", 632, 2);
            WriteAttributeValue("", 605, "/activity/", 605, 10, true);
#line 24 "C:\Users\Adam\Documents\CodingDojo\C#\ExamPrep\ActivityCenter\Views\Home\Home.cshtml"
WriteAttributeValue("", 615, p.PlayActivityId, 615, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(633, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(635, 7, false);
#line 24 "C:\Users\Adam\Documents\CodingDojo\C#\ExamPrep\ActivityCenter\Views\Home\Home.cshtml"
                                                 Write(p.Title);

#line default
#line hidden
            EndContext();
            BeginContext(642, 27, true);
            WriteLiteral("</a></td>\r\n            <td>");
            EndContext();
            BeginContext(670, 25, false);
#line 25 "C:\Users\Adam\Documents\CodingDojo\C#\ExamPrep\ActivityCenter\Views\Home\Home.cshtml"
           Write(p.Time.ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(695, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(697, 2, true);
            WriteLiteral("@ ");
            EndContext();
            BeginContext(700, 26, false);
#line 25 "C:\Users\Adam\Documents\CodingDojo\C#\ExamPrep\ActivityCenter\Views\Home\Home.cshtml"
                                         Write(p.Time.ToShortTimeString());

#line default
#line hidden
            EndContext();
            BeginContext(726, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(750, 21, false);
#line 26 "C:\Users\Adam\Documents\CodingDojo\C#\ExamPrep\ActivityCenter\Views\Home\Home.cshtml"
           Write(p.Organizer.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(771, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(795, 15, false);
#line 27 "C:\Users\Adam\Documents\CodingDojo\C#\ExamPrep\ActivityCenter\Views\Home\Home.cshtml"
           Write(p.Friends.Count);

#line default
#line hidden
            EndContext();
            BeginContext(810, 25, true);
            WriteLiteral("</td>\r\n            <td>\r\n");
            EndContext();
#line 29 "C:\Users\Adam\Documents\CodingDojo\C#\ExamPrep\ActivityCenter\Views\Home\Home.cshtml"
                 if(ViewBag.User.UserId == p.Organizer.UserId)
                {

#line default
#line hidden
            BeginContext(918, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 940, "\"", 981, 3);
            WriteAttributeValue("", 947, "/activity/", 947, 10, true);
#line 31 "C:\Users\Adam\Documents\CodingDojo\C#\ExamPrep\ActivityCenter\Views\Home\Home.cshtml"
WriteAttributeValue("", 957, p.PlayActivityId, 957, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 974, "/delete", 974, 7, true);
            EndWriteAttribute();
            BeginContext(982, 37, true);
            WriteLiteral(" class=\"btn btn-warning\">Delete</a>\r\n");
            EndContext();
#line 32 "C:\Users\Adam\Documents\CodingDojo\C#\ExamPrep\ActivityCenter\Views\Home\Home.cshtml"
                }
                else
                {
                    //Query to see if they are watching the movie
                    if(p.Friends.Any(x => x.UserId == ViewBag.User.UserId))
                    {

#line default
#line hidden
            BeginContext(1246, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1270, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d5e88930656b844c0ae9dba1379782f7bb3a72f9562", async() => {
                BeginContext(1401, 5, true);
                WriteLiteral("Leave");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-playActivityId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "C:\Users\Adam\Documents\CodingDojo\C#\ExamPrep\ActivityCenter\Views\Home\Home.cshtml"
                                                                                                  WriteLiteral(p.PlayActivityId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["playActivityId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-playActivityId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["playActivityId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-status", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["status"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1410, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 39 "C:\Users\Adam\Documents\CodingDojo\C#\ExamPrep\ActivityCenter\Views\Home\Home.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1484, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1508, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d5e88930656b844c0ae9dba1379782f7bb3a72f12937", async() => {
                BeginContext(1639, 4, true);
                WriteLiteral("Join");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-playActivityId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "C:\Users\Adam\Documents\CodingDojo\C#\ExamPrep\ActivityCenter\Views\Home\Home.cshtml"
                                                                                                  WriteLiteral(p.PlayActivityId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["playActivityId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-playActivityId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["playActivityId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-status", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["status"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1647, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 43 "C:\Users\Adam\Documents\CodingDojo\C#\ExamPrep\ActivityCenter\Views\Home\Home.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(1691, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 47 "C:\Users\Adam\Documents\CodingDojo\C#\ExamPrep\ActivityCenter\Views\Home\Home.cshtml"
        }

#line default
#line hidden
            BeginContext(1736, 100, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<a href=\"/new\"><button class=\"btn btn-primary\">Add New Activity</button></a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PlayActivity>> Html { get; private set; }
    }
}
#pragma warning restore 1591
