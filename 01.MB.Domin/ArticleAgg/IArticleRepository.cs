using _02.MB.Application.Contracts.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MB.Domin.ArticleAgg
{
    public interface IArticleRepository
    {
        List<ArticleViewModel> GetList();
        void CreateAndSave(Article entity);
        Article Get(long id);
        void Save();
    }
}
