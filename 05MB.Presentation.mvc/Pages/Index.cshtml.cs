using System.Collections.Generic;
using _06.MB.Infrastructure.Query;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _05MB.Presentation.mvc.Pages
{
    public class IndexModel : PageModel
    {
        public List<ArticleQueryView> Articles { get; set; }
        private readonly IArticleQuery articleQuery;

        public IndexModel(IArticleQuery articleQuery)
        {
            this.articleQuery = articleQuery;
        }

        public void OnGet()
        {
            Articles = articleQuery.GetArticles();
        }
    }
}