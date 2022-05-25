using _00.Framework.Infrastructure;
using _01.MB.Domin.ArticleCategoryAgg;

namespace _04.MB_Infrastructrue.EFCore.Repositories
{
    public class ArticleCategoryRepository : BaseRepository<long, ArticleCategory>, IArticleCategoryRepository
    {
        private readonly MasterBloggerContext _context;

        public ArticleCategoryRepository(MasterBloggerContext context) : base(context)
        {
            _context = context;
        }

    }
}
