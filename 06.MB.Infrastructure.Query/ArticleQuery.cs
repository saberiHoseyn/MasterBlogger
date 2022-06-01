using _01.MB.Domin.CommentAgg;
using _04.MB_Infrastructrue.EFCore;
using MB.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _06.MB.Infrastructure.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly MasterBloggerContext context;
        private readonly IUserLikeManager userLikeManager;


        public ArticleQuery(MasterBloggerContext context, IUserLikeManager userLikeManager)
        {
            this.context = context;
            this.userLikeManager = userLikeManager;
        }

        public ArticleQueryView GetArticle(long id)
        {
            return context.Articles
                .Include(x => x.ArticleCategory)
                .Include(x => x.Comments)
                .Where(x => x.IsDeleted == false)
                .Select(x => new ArticleQueryView
                {
                    Id = x.Id,
                    Title = x.Title,
                    ShortDescription = x.ShortDescription,
                    Img = x.Img,
                    CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture),
                    ArticleCategory = x.ArticleCategory.Title,
                    Content = x.Content,
                    CommentsCount = x.Comments.Count(x => x.Status == Statuses.Confirm),
                    Comments = MapComments(x.Comments.Where(x => x.Status == Statuses.Confirm)),
                    Like = x.Like,
                    HasLike = userLikeManager.HasLikeUserAny(x.Id)
                }).FirstOrDefault(x => x.Id == id);
        }


        public List<ArticleQueryView> GetArticles()
        {
            return context.Articles.Include(x => x.ArticleCategory)
                .Include(x => x.Comments)
                .Where(x => x.IsDeleted == false)
                .Select(x => new ArticleQueryView
                {
                    Id = x.Id,
                    Title = x.Title,
                    ShortDescription = x.ShortDescription,
                    Img = x.Img,
                    CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture),
                    ArticleCategory = x.ArticleCategory.Title,
                    CommentsCount = x.Comments.Count(x => x.Status == Statuses.Confirm),
                    Like = x.Like,
                    HasLike = userLikeManager.HasLikeUserAny(x.Id)
                }).ToList();
        }

        private static List<CommentQueryView> MapComments(IEnumerable<Comment> comments)
        {
            return comments.Select(x => new CommentQueryView
            {
                Name = x.Name,
                Message = x.Message,
                CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture)
            }).ToList();
        }

    }
}
