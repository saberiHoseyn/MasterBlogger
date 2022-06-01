using System.Collections.Generic;
using System.Linq;
using _02.MB.Application.Contracts.ArticleAgg;
using _06.MB.Infrastructure.Query;
using _07.MB.Infrastructure.Context.Web;
using MB.Infrastructure.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _05MB.Presentation.mvc.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IArticleQuery articleQuery;
        private readonly IArticleApplication articleApplication;
        public List<ArticleQueryView> Articles { get; set; }


        public IndexModel(IArticleQuery articleQuery, IArticleApplication articleApplication)
        {
            this.articleQuery = articleQuery;
            this.articleApplication = articleApplication;
        }

        public void OnGet()
        {
            Articles = articleQuery.GetArticles();
        }

        public RedirectToPageResult OnGetLike(long id)
        {
            articleApplication.ToggleLike(id);
            return RedirectToPage("./Index");
        }
    }
}