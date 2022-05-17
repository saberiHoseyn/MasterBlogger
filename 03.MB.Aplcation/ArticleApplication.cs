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

        public void Create(CreateArticle command)
        {
            var article = new Article(command.Title, command.ShortDescription, command.Content, command.Img, command.ArticleCategoryId);
            articleRepository.CreateAndSave(article);
        }

        public EditArticle Get(long id)
        {
            var article = articleRepository.Get(id);
            return new EditArticle
            {
                Id = article.Id,
                Title = article.Title,
                Img = article.Img,
                ShortDescription = article.ShortDescription,
                Content = article.Content,
                ArticleCategoryId = article.ArticleCategoryId
            };
        }

        public void Edit(EditArticle command)
        {
            var article = articleRepository.Get(command.Id);
            article.Edit(command.Title, command.ShortDescription, command.Content, command.Img, command.ArticleCategoryId);
            articleRepository.Save();
        }

        public void Remove(long id)
        {
            var article = articleRepository.Get(id);
            article.Remove();
            articleRepository.Save();
        }

        public void Activate(long id)
        {
            var article = articleRepository.Get(id);
            article.Activate();
            articleRepository.Save();
        }
    }
}
