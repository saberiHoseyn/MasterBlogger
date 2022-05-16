using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _02.MB.Application.Contracts.ArticleCategoryAgg;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _05MB.Presentation.mvc.Areas.Adminstrator.Pages.ArticleCategoryManagment
{
    public class ListModel : PageModel
    {
        public List<ArticleCategoryViewModel> ArticleCategories { get; set; }
        private readonly IArticleCategoryApplication articleCategoryApplication;

        public ListModel(IArticleCategoryApplication articleCategoryApplication)
        {
            this.articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet()
        {
            ArticleCategories = articleCategoryApplication.List();
        }

        public RedirectToPageResult OnPostRemove(long id)
        {
            articleCategoryApplication.Remove(id);
            return RedirectToPage("./List");
        }

        public RedirectToPageResult OnPostActivate(long id)
        {
            articleCategoryApplication.Activate(id);
            return RedirectToPage("./List");
        }
    }
}
