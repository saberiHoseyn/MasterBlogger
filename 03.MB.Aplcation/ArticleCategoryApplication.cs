using _01.MB.Domin.ArticleCategoryAgg;
using _01.MB.Domin.ArticleCategoryAgg.Servives;
using _02.MB.Application.Contracts.ArticleCategoryAgg;
using System.Collections.Generic;
using System.Globalization;

namespace _03.MB.Aplcation
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IArticleCategoryRepository articleCategoryRepository;
        private readonly IArticleCategoryValidatorService articleCategoryValidatorService;

        public ArticleCategoryApplication(IArticleCategoryValidatorService articleCategoryValidatorService)
        {
            this.articleCategoryValidatorService = articleCategoryValidatorService;
        }

        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository)
        {
            this.articleCategoryRepository = articleCategoryRepository;
        }

        public List<ArticleCategoryViewModel> List()
        {
            var articleCategoris = articleCategoryRepository.GetAll();
            var result = new List<ArticleCategoryViewModel>();
            foreach (var article in articleCategoris)
            {
                result.Add(new ArticleCategoryViewModel
                {
                    Id = article.Id,
                    Title = article.Title,
                    IsDeleted = article.IsDeleted,
                    CreationDate = article.CreationDate.ToString(CultureInfo.InvariantCulture)
                });
            }
            return result;
        }

        public void Create(CreateArticleCategory command)
        {
            var articleCategory = new ArticleCategory(command.Title, articleCategoryValidatorService);

            articleCategoryRepository.Add(articleCategory);
            articleCategoryRepository.SaveChanges();
        }

        public void Rename(RenameArticleCategory command)
        {
            var articleCategory = articleCategoryRepository.Get(command.Id);
            articleCategory.Rename(command.Title);
            articleCategoryRepository.SaveChanges();
        }

        public RenameArticleCategory Get(long id)
        {
            var articleCategory = articleCategoryRepository.Get(id);
            return new RenameArticleCategory
            {
                Id = articleCategory.Id,
                Title = articleCategory.Title
            };
        }

        public void Remove(long id)
        {
            var articleCategory = articleCategoryRepository.Get(id);
            articleCategory.Remove();
            articleCategoryRepository.SaveChanges();
        }

        public void Activate(long id)
        {
            var articleCategory = articleCategoryRepository.Get(id);
            articleCategory.Activate();
            articleCategoryRepository.SaveChanges();
        }
    }
}
