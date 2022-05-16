using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MB.Domin.ArticleCategoryAgg
{
    public interface IArticleCategoryRepository
    {
        void SaveChanges();
        bool Exists(string title);
        List<ArticleCategory> GetAll();
        ArticleCategory Get(long id);
        void Add(ArticleCategory entity);
    }
}
