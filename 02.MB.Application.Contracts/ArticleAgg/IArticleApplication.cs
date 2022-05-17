using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MB.Application.Contracts.ArticleAgg
{
     public interface IArticleApplication
    {
        List<ArticleViewModel> GetList();
        void Create(CreateArticle command);
        EditArticle Get(long id);
        void Edit(EditArticle command);
        void Remove(long id);
        void Activate(long id);
    }
}
