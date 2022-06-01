using _00.Framework.Infrastructure;
using _01.MB.Domin.ArticleAgg;
using _02.MB.Application.Contracts.ArticleAgg;
using MB.Infrastructure.Context;
using System.Collections.Generic;

namespace _03.MB.Aplcation
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IArticleRepository articleRepository;
        private readonly IUserLikeManager userLikeManager;

        public ArticleApplication(IArticleRepository articleRepository, IUnitOfWork unitOfWork, IUserLikeManager userLikeManager)
        {
            this.articleRepository = articleRepository;
            this.unitOfWork = unitOfWork;
            this.userLikeManager = userLikeManager;
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

        public void ToggleLike(long id)
        {
            if (userLikeManager.AddLike(id))
            {
                AddLike(id);
            }
            else
            {
                RemoveLike(id);
            }
        }


        private void AddLike(long id)
        {
            unitOfWork.BeginTran();
            var article = articleRepository.Get(id);
            article.AddLike();
            unitOfWork.CommitTran();
        }

        private void RemoveLike(long id)
        {
            unitOfWork.BeginTran();
            var article = articleRepository.Get(id);
            article.RemoveLike();
            unitOfWork.CommitTran();
        }
    }
}
