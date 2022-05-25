using _00.Framework.Infrastructure;
using _02.MB.Application.Contracts.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MB.Domin.ArticleAgg
{
    public interface IArticleRepository : IBaseRepository<long, Article>
    {
        List<ArticleViewModel> GetList();
    }
}
