using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MB.Application.Contracts.ArticleCategoryAgg
{
    public interface IArticleCategoryApplication
    {
        RenameArticleCategory Get(long id);
        List<ArticleCategoryViewModel> List();
        void Create(CreateArticleCategory command);
        void Rename(RenameArticleCategory command);
        void Remove(long id);
        void Activate(long id);
    }
}
