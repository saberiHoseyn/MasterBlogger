using _01.MB.Domin.ArticleAgg;
using _02.MB.Application.Contracts.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MB.Aplcation
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IArticleRepository articleRepository;

        public ArticleApplication(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }

        public List<ArticleViewModel> GetList()
        {
            return articleRepository.GetList();
        }
    }
}
