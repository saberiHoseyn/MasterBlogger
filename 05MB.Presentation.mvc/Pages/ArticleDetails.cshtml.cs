using _02.MB.Application.Contracts.CommentAgg;
using _06.MB.Infrastructure.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _05MB.Presentation.mvc.Pages
{
    public class ArticleDetailsModel : PageModel
    {
        public ArticleQueryView Article { get; set; }
        private readonly IArticleQuery articleQuery;
        private readonly ICommentApplication commentApplication;

        public ArticleDetailsModel(IArticleQuery articleQuery, ICommentApplication commentApplication)
        {
            this.articleQuery = articleQuery;
            this.commentApplication = commentApplication;
        }

        public void OnGet(long id)
        {
            Article = articleQuery.GetArticle(id);
        }

        public RedirectToPageResult OnPost(AddComment comment)
        {
            commentApplication.Add(comment);
            return RedirectToPage("./ArticleDetails", new { id = comment.ArticleId });
        }
    }
}