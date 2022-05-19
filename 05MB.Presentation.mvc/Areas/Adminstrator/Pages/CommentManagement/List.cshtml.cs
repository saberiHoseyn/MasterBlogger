using System.Collections.Generic;
using _01.MB.Domin.CommentAgg;
using _02.MB.Application.Contracts.CommentAgg;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Areas.Administrator.Pages.CommentManagement
{
    public class ListModel : PageModel
    {
        public List<CommentViewModel> Comments { get; set; }
        private readonly ICommentApplication _commentApplication;
        public ListModel(ICommentApplication commentApplication)
        {
            _commentApplication = commentApplication;
        }
        public void OnGet()
        {
            Comments = _commentApplication.GetList();
        }

        //public RedirectToPageResult OnPostConfirm(long id)
        //{
        //    _commentApplication.Confirm(id);
        //    return RedirectToPage("./List");
        //}

        //public RedirectToPageResult OnPostCancel(long id)
        //{
        //    _commentApplication.Cancel(id);
        //    return RedirectToPage("./List");
        //}
    }
}