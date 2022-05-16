using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _02.MB.Application.Contracts.ArticleCategoryAgg;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _05MB.Presentation.mvc.Areas.Adminstrator.Pages.ArticleCategoryManagment
{
    public class CreateModel : PageModel
    {
        private readonly IArticleCategoryApplication articleCategoryApplication;

        public CreateModel(IArticleCategoryApplication articleCategoryApplication)
        {
            this.articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet()
        {
        }

        public RedirectToPageResult OnPost(CreateArticleCategory command)
        {
            articleCategoryApplication.Create(command);
            return RedirectToPage("./List");
        }
    }
}
