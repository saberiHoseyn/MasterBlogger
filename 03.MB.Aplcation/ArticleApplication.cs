using _00.Framework.Infrastructure;
using _01.MB.Domin.ArticleAgg;
using _02.MB.Application.Contracts.ArticleAgg;
using System.Collections.Generic;

namespace _03.MB.Aplcation
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IArticleRepository articleRepository;

        public ArticleApplication(IArticleRepository articleRepository, IUnitOfWork unitOfWork)
        {
            this.articleRepository = articleRepository;
            this.unitOfWork = unitOfWork;
        }

        public List<ArticleViewModel> GetList()
        {
            return articleRepository.GetList();
        }

        public void Create(CreateArticle command)
        {
            unitOfWork.BeginTran();
            var article = new Article(command.Title, command.ShortDescription, command.Content, command.Img, command.ArticleCategoryId);
            articleRepository.Creat(article);
            unitOfWork.CommitTran();
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
            unitOfWork.BeginTran();
            var article = articleRepository.Get(command.Id);
            article.Edit(command.Title, command.ShortDescription, command.Content, command.Img, command.ArticleCategoryId);
            unitOfWork.CommitTran();
        }

        public void Remove(long id)
        {
            unitOfWork.BeginTran();
            var article = articleRepository.Get(id);
            article.Remove();
            unitOfWork.CommitTran();
        }

        public void Activate(long id)
        {
            unitOfWork.BeginTran();
            var article = articleRepository.Get(id);
            article.Activate();
            unitOfWork.CommitTran();
        }
    }
}
