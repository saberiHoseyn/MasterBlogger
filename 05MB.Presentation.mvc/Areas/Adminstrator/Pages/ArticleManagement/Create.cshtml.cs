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
    public class CreateModel : PageModel
    {
        public List<SelectListItem> articleCategories { get; set; }
        private readonly IArticleCategoryApplication articleCategoryApplication;
        private readonly IArticleApplication articleApplication;

        public CreateModel(IArticleCategoryApplication articleCategoryApplication, IArticleApplication articleApplication)
        {
            this.articleCategoryApplication = articleCategoryApplication;
            this.articleApplication = articleApplication;
        }

        public void OnGet()
        {
            articleCategories = articleCategoryApplication.List()
                                   .Select(x => new SelectListItem(x.Title, x.Id.ToString())).ToList();
        }

        public RedirectToPageResult OnPost(CreateArticle createArticle)
        {
            articleApplication.Create(createArticle);
            return RedirectToPage("./List");
        }
    }
}
