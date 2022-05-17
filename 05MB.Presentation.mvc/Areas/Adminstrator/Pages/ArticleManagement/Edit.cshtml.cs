using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _02.MB.Application.Contracts.ArticleAgg;
using _02.MB.Application.Contracts.ArticleCategoryAgg;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace _05MB.Presentation.mvc.Areas.Adminstrator.Pages.ArticleManagement
{
    public class EditModel : PageModel
    {
        [BindProperty] public EditArticle Article { get; set; }
        public List<SelectListItem> articlrCategories { get; set; }
        private readonly IArticleApplication articleApplication;
        private readonly IArticleCategoryApplication articleCategoryApplication;

        public EditModel(IArticleApplication articleApplication, IArticleCategoryApplication articleCategoryApplication)
        {
            this.articleApplication = articleApplication;
            this.articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet(long id)
        {
            Article = articleApplication.Get(id);
            articlrCategories = articleCategoryApplication.List()
                 .Select(x => new SelectListItem(x.Title, x.Id.ToString())).ToList();
        }

        public RedirectToPageResult OnPost()
        {
            articleApplication.Edit(Article);
            return RedirectToPage("./List");
        }
    }
}
