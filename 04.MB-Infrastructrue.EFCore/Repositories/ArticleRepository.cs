using _00.Framework.Infrastructure;
using _01.MB.Domin.ArticleAgg;
using _02.MB.Application.Contracts.ArticleAgg;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _04.MB_Infrastructrue.EFCore.Repositories
{
    public class ArticleRepository : BaseRepository<long, Article>, IArticleRepository
    {
        private readonly MasterBloggerContext context;

        public ArticleRepository(MasterBloggerContext context) : base(context)
        {
            this.context = context;
        }


        public List<ArticleViewModel> GetList()
        {
            return context.Articles.Include(x => x.ArticleCategory).Select(x => new ArticleViewModel
            {
                Id = x.Id,
                LikeCout = x.Like,
                Title = x.Title,
                IsDeleted = x.IsDeleted,
                ArticleCategory = x.ArticleCategory.Title,
                CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture)
            }).OrderByDescending(x => x.Id).ToList();
        }
    }
}
