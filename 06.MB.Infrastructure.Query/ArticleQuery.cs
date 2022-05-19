using _04.MB_Infrastructrue.EFCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _06.MB.Infrastructure.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly MasterBloggerContext context;

        public ArticleQuery(MasterBloggerContext context)
        {
            this.context = context;
        }

        public ArticleQueryView GetArticle(long id)
        {
            return context.Articles.Include(x => x.ArticleCategory).Where(x => x.IsDeleted == true)
                .Select(x => new ArticleQueryView
                {
                    Id = x.Id,
                    Title = x.Title,
                    ShortDescription = x.ShortDescription,
                    Img = x.Img,
                    CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture),
                    ArticleCategory = x.ArticleCategory.Title,
                    Content = x.Content
                }).FirstOrDefault(x => x.Id == id);
        }

        public List<ArticleQueryView> GetArticles()
        {
            return context.Articles.Include(x => x.ArticleCategory).Where(x => x.IsDeleted == true)
                .Select(x => new ArticleQueryView
                {
                    Id = x.Id,
                    Title = x.Title,
                    ShortDescription = x.ShortDescription,
                    Img = x.Img,
                    CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture),
                    ArticleCategory = x.ArticleCategory.Title
                }).ToList();
        }
    }
}
