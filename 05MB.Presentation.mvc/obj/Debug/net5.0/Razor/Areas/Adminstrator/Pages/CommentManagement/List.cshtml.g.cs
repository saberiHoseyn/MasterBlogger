#pragma checksum "D:\Hoseyn\Asp.NetCore5(atriya)\practices\09.Master Blogger\MasterBlogger\05MB.Presentation.mvc\Areas\Adminstrator\Pages\CommentManagement\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2a7812fb803001a242e86a048c7f6697bdc8209"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Onion.Presentation.Areas.Administrator.Pages.CommentManagement.Areas_Adminstrator_Pages_CommentManagement_List), @"mvc.1.0.razor-page", @"/Areas/Adminstrator/Pages/CommentManagement/List.cshtml")]
namespace Onion.Presentation.Areas.Administrator.Pages.CommentManagement
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
#line 2 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\09.Master Blogger\MasterBlogger\05MB.Presentation.mvc\Areas\Adminstrator\Pages\CommentManagement\List.cshtml"
using _01.MB.Domin.CommentAgg;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2a7812fb803001a242e86a048c7f6697bdc8209", @"/Areas/Adminstrator/Pages/CommentManagement/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f7f2c4f4cad8cacfbb77820af4a8d73fb7ada6f", @"/Areas/Adminstrator/Pages/_ViewImports.cshtml")]
    public class Areas_Adminstrator_Pages_CommentManagement_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Confirm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-left mr-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Cancel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header"">
        <h3 class=""float-left"">Comments List</h3>
    </div>
    <div class=""card-body"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Message</th>
                    <th>Article</th>
                    <th>Status</th>
                    <th>CreationDate</th>
                    <th>Operations</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 26 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\09.Master Blogger\MasterBlogger\05MB.Presentation.mvc\Areas\Adminstrator\Pages\CommentManagement\List.cshtml"
                 foreach (var comment in Model.Comments)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 29 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\09.Master Blogger\MasterBlogger\05MB.Presentation.mvc\Areas\Adminstrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\09.Master Blogger\MasterBlogger\05MB.Presentation.mvc\Areas\Adminstrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\09.Master Blogger\MasterBlogger\05MB.Presentation.mvc\Areas\Adminstrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\09.Master Blogger\MasterBlogger\05MB.Presentation.mvc\Areas\Adminstrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\09.Master Blogger\MasterBlogger\05MB.Presentation.mvc\Areas\Adminstrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.Article);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 35 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\09.Master Blogger\MasterBlogger\05MB.Presentation.mvc\Areas\Adminstrator\Pages\CommentManagement\List.cshtml"
                             if (comment.Status == Statuses.New)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa fa-eye fa-2x text-info\"></i>\r\n");
#nullable restore
#line 38 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\09.Master Blogger\MasterBlogger\05MB.Presentation.mvc\Areas\Adminstrator\Pages\CommentManagement\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\09.Master Blogger\MasterBlogger\05MB.Presentation.mvc\Areas\Adminstrator\Pages\CommentManagement\List.cshtml"
                             if (comment.Status == Statuses.Cancle)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa fa-close fa-2x text-danger\"></i>\r\n");
#nullable restore
#line 42 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\09.Master Blogger\MasterBlogger\05MB.Presentation.mvc\Areas\Adminstrator\Pages\CommentManagement\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\09.Master Blogger\MasterBlogger\05MB.Presentation.mvc\Areas\Adminstrator\Pages\CommentManagement\List.cshtml"
                             if (comment.Status == Statuses.Confirm)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa fa-check fa-2x text-success\"></i>\r\n");
#nullable restore
#line 46 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\09.Master Blogger\MasterBlogger\05MB.Presentation.mvc\Areas\Adminstrator\Pages\CommentManagement\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>");
#nullable restore
#line 48 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\09.Master Blogger\MasterBlogger\05MB.Presentation.mvc\Areas\Adminstrator\Pages\CommentManagement\List.cshtml"
                       Write(comment.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 50 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\09.Master Blogger\MasterBlogger\05MB.Presentation.mvc\Areas\Adminstrator\Pages\CommentManagement\List.cshtml"
                             if (comment.Status == Statuses.New)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <button type=""button"" class=""btn btn-success"" data-toggle=""modal"" data-target=""#ModalConfirm"">
                                    Confirm
                                </button>
                                <div class=""modal fade"" id=""ModalConfirm"" tabindex=""-1"" role=""dialog"" aria-labelledby=""ModalConfirmTitle"" aria-hidden=""true"">
                                    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                                        <div class=""modal-content"">
                                            <div class=""modal-header"">
                                                <h5 class=""modal-title"" id=""ModalConfirmTitle"">Confirm comment</h5>
                                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                    <span aria-hidden=""true"">&times;</span>
                                                </button>
           ");
            WriteLiteral(@"                                 </div>
                                            <div class=""modal-body"">
                                                After confirmation, this comment will be published and you can not delete it anymore!
                                                <br />
                                                Are you sure you want to confirm this comment?
                                            </div>
                                            <div class=""modal-footer"">
                                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2a7812fb803001a242e86a048c7f6697bdc820911849", async() => {
                WriteLiteral("\r\n                                                    <button type=\"submit\" class=\"btn btn-warning\">Confirm</button>\r\n                                                    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 3922, "\"", 3941, 1);
#nullable restore
#line 74 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\09.Master Blogger\MasterBlogger\05MB.Presentation.mvc\Areas\Adminstrator\Pages\CommentManagement\List.cshtml"
WriteAttributeValue("", 3930, comment.Id, 3930, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
            WriteLiteral(@"                                <button type=""button"" class=""btn btn-danger m-1"" data-toggle=""modal"" data-target=""#ModalCancel"">
                                    Cancel
                                </button>
                                <div class=""modal fade"" id=""ModalCancel"" tabindex=""-1"" role=""dialog"" aria-labelledby=""ModalCancelTitle"" aria-hidden=""true"">
                                    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                                        <div class=""modal-content"">
                                            <div class=""modal-header"">
                                                <h5 class=""modal-title"" id=""ModalCancelTitle"">Cancel comment</h5>
                                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                    <span aria-hidden=""true"">&times;</span>
                                                </button>
              ");
            WriteLiteral(@"                              </div>
                                            <div class=""modal-body"">
                                                After cancellation this comment, this will be cancelled and you can not publish it anymore!
                                                <br />
                                                Are you sure you want to cancel this comment?
                                            </div>
                                            <div class=""modal-footer"">
                                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2a7812fb803001a242e86a048c7f6697bdc820916115", async() => {
                WriteLiteral("\r\n                                                    <button type=\"submit\" class=\"btn btn-warning\">Save changes</button>\r\n                                                    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 6180, "\"", 6199, 1);
#nullable restore
#line 102 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\09.Master Blogger\MasterBlogger\05MB.Presentation.mvc\Areas\Adminstrator\Pages\CommentManagement\List.cshtml"
WriteAttributeValue("", 6188, comment.Id, 6188, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 108 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\09.Master Blogger\MasterBlogger\05MB.Presentation.mvc\Areas\Adminstrator\Pages\CommentManagement\List.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 111 "D:\Hoseyn\Asp.NetCore5(atriya)\practices\09.Master Blogger\MasterBlogger\05MB.Presentation.mvc\Areas\Adminstrator\Pages\CommentManagement\List.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MB.Presentation.MVCCore.Areas.Administrator.Pages.CommentManagement.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MB.Presentation.MVCCore.Areas.Administrator.Pages.CommentManagement.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MB.Presentation.MVCCore.Areas.Administrator.Pages.CommentManagement.ListModel>)PageContext?.ViewData;
        public MB.Presentation.MVCCore.Areas.Administrator.Pages.CommentManagement.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
