using _01.MB.Domin.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MB_Infrastructrue.EFCore.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly MasterBloggerContext context;

        public ArticleRepository(MasterBloggerContext context)
        {
            this.context = context;
        }
    }
}
