using System.Collections.Generic;
using _02.MB.Application.Contracts.ArticleAgg;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _05MB.Presentation.mvc.Areas.Adminstrator.Pages.ArticleManagment
{
    public class ListModel : PageModel
    {
        public List<ArticleViewModel> articles { get; set; }
        private readonly IArticleApplication articleApplication;

        public ListModel(IArticleApplication articleApplication)
        {
            this.articleApplication = articleApplication;
        }

        public void OnGet()
        {
            articles = articleApplication.GetList();
        }

        public RedirectToPageResult OnPostActivate(long id)
        {
            articleApplication.Activate(id);
            return RedirectToPage("./List");
        }

        public RedirectToPageResult OnPostRemove(long id)
        {
            articleApplication.Remove(id);
            return RedirectToPage("./List");
        }
    }
}
